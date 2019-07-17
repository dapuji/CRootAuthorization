using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRootAuthorization
{
    public class JsonWebTokenInfo
    {
        [JsonProperty("aud")]
        public string Audience { get; set; }

        [JsonProperty("iss")]
        public string Issuer { get; set; }

        [JsonProperty("iat")]
        public string IssuedAt { get; set; }

        [JsonProperty("exp")]
        public string ExpirationTime { get; set; }

        [JsonProperty("apptype")]
        public string AppType { get; set; }

        [JsonProperty("appid")]
        public string AppId { get; set; }

        [JsonProperty("authmethod")]
        public string AuthMethod { get; set; }

        [JsonProperty("auth_time")]
        public string AuthTime { get; set; }

        [JsonProperty("ver")]
        public string Version { get; set; }

        [JsonProperty("FirstName")]
        public string FirstName { get; set; }

        [JsonProperty("LastName")]
        public string LastName { get; set; }

        [JsonProperty("DisplayName")]
        public string DisplayName { get; set; }

        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("EmployeeType")]
        public string EmployeeType { get; set; }

        [JsonProperty("Role")]
        public string[] Role { get; set; }
    }
}
