using CRootAuthorization.Properties;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRootAuthorization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Init();
        }

        /// <summary>
        /// https://adfs.contoso.com/adfs
        /// </summary>
        string Authority
        {
            get { return txtAuthority.Text; }
            set { txtAuthority.Text = value; }
        }

        /// <summary>
        /// https://adfs-srv.croot.com/WebApi/
        /// </summary>
        string ResourceUri
        {
            get { return txtResourceUri.Text; }
            set { txtResourceUri.Text = value; }
        }

        /// <summary>
        /// 5071e284-f5b5-45e6-995f-53ee33cd3e27
        /// </summary>
        string ClientId
        {
            get { return txtClientId.Text; }
            set { txtClientId.Text = value; }
        }

        /// <summary>
        /// http://adfs-srv.croot.com/
        /// </summary>
        string RedirectUri
        {
            get { return txtRedirectUri.Text; }
            set { txtRedirectUri.Text = value; }
        }

        string ResponseStr
        {
            get { return this.rtbJsonResp.Text; }
            set { this.rtbJsonResp.Text = value; }
        }

        string JsonWebTokenStr
        {
            get { return this.rtbJwt.Text; }
            set { this.rtbJwt.Text = value; }
        }

        private void Init()
        {
            Authority = Settings.Default.Authority;
            ResourceUri = Settings.Default.ResourceUri;
            ClientId = Settings.Default.ClientId;
            RedirectUri = Settings.Default.RedirectUri;
        }

        private void btnAuthorize_Click(object sender, EventArgs e)
        {
            ByOAuth2();
        }

        private async void ByOAuth2()
        {
            MyCredential myCredential = new MyCredential()
            {
                authURL = Authority,
                ClientId = ClientId,
                RedirectUri = RedirectUri,
                Resource = ResourceUri
            };

            Authenticator authenticator = new Authenticator() { Credential = myCredential };
            string accessCode = await authenticator.GetAccessCode();
            if (!string.IsNullOrEmpty(accessCode))
            {
                string json = await authenticator.GetAccessToken(accessCode);
                AccessTokenInfo info = JsonConvert.DeserializeObject<AccessTokenInfo>(json);
                ResponseStr = json.Replace(",\"", ",\r\n\"");
                string[] jwt = info.AccessToken.Split('.');
                string payload = jwt.Length == 3 ? jwt[1] : "";
                if (!string.IsNullOrEmpty(payload))
                {
                    JwtPayload jwtPayload = JwtPayload.Base64UrlDeserialize(payload);
                    this.JsonWebTokenStr = jwtPayload.SerializeToJson().Replace(",\"", ",\r\n\"");
                    SetControl(jwtPayload);
                }
            }
        }

        private void SetControl(JwtPayload payload)
        {
            object fn, ln, dn, em, et, ro;
            if (payload.TryGetValue("FirstName", out fn))
                this.tbFirstName.Text = fn.ToString();
            if (payload.TryGetValue("LastName", out ln))
                this.tbLastName.Text = ln.ToString();
            if (payload.TryGetValue("DisplayName", out dn))
                this.tbDisplayName.Text = dn.ToString();
            if (payload.TryGetValue("Email", out em))
                this.tbEmail.Text = em.ToString();
            if (payload.TryGetValue("EmployeeType", out et))
                this.tbEmployeeType.Text = et.ToString();
            if (payload.TryGetValue("Role", out ro))
            {
                if (ro is JArray)
                {
                    JArray jArray = ro as JArray;
                    foreach (JToken o in jArray)
                    {
                        this.listBoxRoles.Items.Add(o);
                    }
                }
            }
        }
    }
}
