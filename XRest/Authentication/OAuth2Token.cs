using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace XRest.Authentication
{
    //
    // A simple class for deserializing an OAuth2 token
    //
    public class OAuth2Token
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }
    }
}
