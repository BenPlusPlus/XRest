using System;
using System.Collections.Generic;
using System.Text;

namespace XRest.Authentication
{
    public class OAuth2Options
    {
        public Uri TokenUrl { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}

