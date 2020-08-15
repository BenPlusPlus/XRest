using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace XRest.Authentication
{
    public class OAuth2
    {
        // This static member is used to share a common instance of
        // HttpClient when no HttpClient is injected in the constructor.
        private static HttpClient _sharedHttpClient;

        private OAuth2Options _options;
        private HttpClient _httpClient;

        public OAuth2(OAuth2Options Options)
        {
            Init(Options);
        }
        public OAuth2(OAuth2Options Options, HttpClient HttpClient)
        {
            Init(Options, HttpClient);
        }

        private void Init(OAuth2Options Options)
        {
            if (_sharedHttpClient == null)
            {
                _sharedHttpClient = new HttpClient();
            }
            Init(Options, _sharedHttpClient);
        }
        private void Init(OAuth2Options Options, HttpClient HttpClient)
        {
            _options = Options;
            _httpClient = HttpClient;
        }

    }
}

