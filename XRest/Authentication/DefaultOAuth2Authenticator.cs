using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace XRest.Authentication
{
    //
    // A generic implementation of OAuth2 authentication. Might be ineffective
    // against APIs that require extra/non-standard data in the authentication
    // request.
    //
    public class DefaultOAuth2Authenticator : IOAuth2Authenticator
    {
        // This static member is used to share a common instance of
        // HttpClient when no HttpClient is injected in the constructor.
        private static HttpClient _sharedHttpClient;

        private OAuth2Options _options;
        private HttpClient _httpClient;

        private OAuth2Token _token;

        public DefaultOAuth2Authenticator(OAuth2Options Options)
        {
            Init(Options);
        }
        public DefaultOAuth2Authenticator(OAuth2Options Options, HttpClient HttpClient)
        {
            Init(Options, HttpClient);
        }
        public DefaultOAuth2Authenticator(Uri TokenUrl, string ClientId, string ClientSecret, string Resource)
        {
            Init(new OAuth2Options
            {
                TokenUrl = TokenUrl,
                ClientId = ClientId,
                ClientSecret = ClientSecret,
                Resource = Resource
            });
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

        public OAuth2Token Token { get { return _token; } }

        public async Task RefreshToken()
        {
            var requestContent = new Dictionary<string, string>
                {
                    {"grant_type", "client_credentials"},
                    {"client_id", _options.ClientId},
                    {"client_secret", _options.ClientSecret},
                    {"resource", _options.Resource }
                };
            // Ensure no caching
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("cache-control", "no-cache");

            using (var formData = new FormUrlEncodedContent(requestContent))
            {
                HttpResponseMessage tokenResponse = await _httpClient.PostAsync(_options.TokenUrl, formData).ConfigureAwait(false);

                if (tokenResponse.IsSuccessStatusCode)
                {
                    var responseBody = await tokenResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    _token = JsonConvert.DeserializeObject<OAuth2Token>(responseBody);
                }
                else
                {
                    _token = null;
                    throw new HttpRequestException($"Token refresh failed with HTTP status code {tokenResponse.StatusCode.ToString()}");
                }
            }
        }

    }
}

