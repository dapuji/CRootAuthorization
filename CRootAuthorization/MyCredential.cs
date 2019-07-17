using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRootAuthorization
{
    public class MyCredential
    {
        public MyCredential()
        {
            AuthorizeApi = "/oauth2/authorize?";
            TokenApi = "/oauth2/token";
        }

        public string ClientId { get; set; }

        public string ClientSecret { get; set; }

        public string authURL { get; set; }

        /// <summary>
        /// /adfs/oauth2/authorize
        /// </summary>
        public string AuthorizeApi { get; set; }

        /// <summary>
        /// /adfs/oauth2/token
        /// </summary>
        public string TokenApi { get; set; }

        /// <summary>
        /// 重定向Uri
        /// urn:ietf:wg:oauth:2.0:oob
        /// http://localhost
        /// </summary>
        public string RedirectUri { get; set; }

        public string Resource { get; set; }
    }
}
