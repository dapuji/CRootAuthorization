using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CRootAuthorization
{
    public class Authenticator
    {
        HttpClient client;

        public MyCredential Credential { get; set; }

        System.Windows.Forms.WebBrowser wb = new System.Windows.Forms.WebBrowser();

        public Authenticator()
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.AllowAutoRedirect = false;
            handler.UseDefaultCredentials = true;
            //handler.Credentials = CredentialCache.DefaultCredentials;
            client = new HttpClient(handler);
            //client.DefaultRequestHeaders.Host = "adfs-srv.croot.com";
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("*/*"));
            //client.DefaultRequestHeaders.AcceptLanguage.Add(new StringWithQualityHeaderValue("zh-CN"));
            //client.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue("gzip"));
            //client.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue("deflate"));
            //var p = new ProductHeaderValue("Mozilla", "4.0 (compatible; MSIE 7.0; Windows NT 6.1; WOW64; Trident/7.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; InfoPath.2; .NET4.0C; .NET4.0E)");
            //client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; WOW64; Trident/7.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; InfoPath.2; .NET4.0C; .NET4.0E)");
            wb.DocumentText = "<HTML></HTML>";
            object window = wb.Document.Window.DomWindow;
            object navigator = window.GetType().InvokeMember("navigator", System.Reflection.BindingFlags.GetProperty, null, window, null);
            object userAgent = navigator.GetType().InvokeMember("userAgent", System.Reflection.BindingFlags.GetProperty, null, navigator, null);
            client.DefaultRequestHeaders.Add("User-Agent", userAgent.ToString());
            //client.DefaultRequestHeaders.Add("User-Agent", "(compatible; MSIE 7.0; Windows NT 6.1; WOW64; Trident/7.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; InfoPath.2; .NET4.0C; .NET4.0E)");
        }

        public async Task<string> GetAccessToken(string accessCode)
        {
            HttpResponseMessage response = await GetAccessTokenResponse(Credential, accessCode);
            string result = await response.Content.ReadAsStringAsync();
            return result;
            //return JsonConvert.DeserializeObject<AccessTokenInfo>(result);
        }

        private async Task<HttpResponseMessage> GetAccessTokenResponse(MyCredential credential, string accessCode)
        {
            string reqUrl = credential.authURL + credential.TokenApi;

            Dictionary<string, string> paramMapping = new Dictionary<string, string>();
            paramMapping["client_id"] = credential.ClientId;
            paramMapping["redirect_uri"] = credential.RedirectUri;
            paramMapping["resource"] = credential.Resource;
            paramMapping["grant_type"] = "authorization_code";
            paramMapping["code"] = accessCode;
            HttpClient client = new HttpClient();
            HttpRequestMessage reqMsg = new HttpRequestMessage(HttpMethod.Post, reqUrl);
            reqMsg.Content = new FormUrlEncodedContent(paramMapping);

            HttpResponseMessage response = await client.SendAsync(reqMsg);
            return response;
        }

        public async Task<string> GetAccessCode()
        {
            string result = string.Empty;
            HttpResponseMessage response = await GetAuthorizeResponse(Credential);
            string code = await GetAccessCodeInternal(response);
            if (!string.IsNullOrEmpty(code))
                return code;
            string content = await response.Content.ReadAsStringAsync();
            wb.Navigated += Wb_Navigated;
            wb.Navigate(response.RequestMessage.RequestUri);
            using (System.Windows.Forms.Form form = new System.Windows.Forms.Form())
            {
                form.Controls.Add(wb);
                wb.Dock = System.Windows.Forms.DockStyle.Fill;
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    return form.Text;
            }
            return string.Empty;
        }

        private async Task<string> GetAccessCodeInternal(HttpResponseMessage response)
        {
            switch (response.StatusCode)
            {
                case HttpStatusCode.Found:
                    {
                        IEnumerable<string> values;
                        if (response.Headers.TryGetValues("Location", out values))
                        {
                            string location = values.FirstOrDefault();
                            if (!string.IsNullOrEmpty(location))
                            {
                                Uri uri = new Uri(location);
                                string accessCode = GetCodeFormUri(uri);
                                if (!string.IsNullOrEmpty(accessCode))
                                    return accessCode;
                                HttpResponseMessage response1 = await client.GetAsync(location);
                                return await GetAccessCodeInternal(response1);
                            }
                        }
                    }
                    break;
            }
            return string.Empty;
        }

        private void Wb_Navigated(object sender, System.Windows.Forms.WebBrowserNavigatedEventArgs e)
        {
            string accessCode = GetCodeFormUri(e.Url);
            if(!string.IsNullOrEmpty(accessCode))
            {
                System.Windows.Forms.Form form = ((System.Windows.Forms.WebBrowser)sender).FindForm();
                form.Text = accessCode;
                form.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else if (e.Url.Fragment.Contains("access_token="))
            {

            }
        }

        private string GetCodeFormUri(Uri uri)
        {
            string query = uri.Query;
            string codeTitle = "?code=";
            if (query.Contains(codeTitle))
                return query.Substring(query.IndexOf(codeTitle) + codeTitle.Length);
            return string.Empty;
        }

        private async Task<HttpResponseMessage> GetAuthorizeResponse(MyCredential credential)
        {
            string reqUrl = GetRequestUrl(credential, "code");
            return await client.GetAsync(reqUrl);
        }

        public static string GetRequestUrl(MyCredential credential, string responseType)
        {
            Dictionary<string, string> paramMapping = new Dictionary<string, string>();
            paramMapping.Add("response_type", responseType);
            paramMapping.Add("client_id", credential.ClientId);
            if (!string.IsNullOrEmpty(credential.Resource))
                paramMapping.Add("resource", credential.Resource);
            paramMapping.Add("redirect_uri", credential.RedirectUri);
            StringBuilder builder = new StringBuilder(credential.authURL + credential.AuthorizeApi);
            List<string> paraList = new List<string>();
            foreach (var pair in paramMapping)
            {
                paraList.Add(string.Format("{0}={1}", pair.Key, pair.Value));
            }
            builder.Append(string.Join("&", paraList));
            string reqUrl = builder.ToString();
            return reqUrl;
        }
    }
}
