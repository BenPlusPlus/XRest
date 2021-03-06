﻿using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using XRest.Authentication;

namespace XRest
{
    public class RestClient
    {
        // This static member is used to share a common instance of
        // HttpClient when no HttpClient is injected in the constructor.
        private static HttpClient _sharedHttpClient;

        private Uri _baseUrl;
        private HttpClient _httpClient;
        private IOAuth2Authenticator _auth;

        public RestClient(string BaseUrl)
        {
            Init(new Uri(BaseUrl));
        }
        public RestClient(Uri BaseUrl)
        {
            Init(BaseUrl);
        }

        // Allow HttpClient to be injected to avoid issues with socket availability
        // (see: https://aspnetmonsters.com/2016/08/2016-08-27-httpclientwrong/)
        public RestClient(string BaseUrl, HttpClient HttpClient)
        {
            Init(new Uri(BaseUrl), null, HttpClient);
        }
        public RestClient(Uri BaseUrl, HttpClient HttpClient)
        {
            Init(BaseUrl, null, HttpClient);
        }

        public RestClient(Uri BaseUrl, IOAuth2Authenticator Authenticator)
        {
            Init(BaseUrl, Authenticator);
        }

        public RestClient(Uri BaseUrl, IOAuth2Authenticator Authenticator, HttpClient HttpClient)
        {
            Init(BaseUrl, Authenticator, HttpClient);
        }

        private void Init(Uri BaseUrl)
        {
            Init(BaseUrl, null);
        }
        private void Init(Uri BaseUrl, IOAuth2Authenticator Authenticator)
        {
            if (_sharedHttpClient == null)
            {
                _sharedHttpClient = new HttpClient();
            }
            Init(BaseUrl, Authenticator, _sharedHttpClient);
        }
        private void Init(Uri BaseUrl, IOAuth2Authenticator Authenticator, HttpClient HttpClient)
        {
            if (BaseUrl.ToString().EndsWith('/') == false)
            {
                throw new Exception("BaseUrl parameter must end with /");
            }
            _baseUrl = BaseUrl;
            _httpClient = HttpClient;
            _auth = Authenticator;
        }

        public async Task<string> Get(string RelativePath)
        {
            var result = await _httpClient.GetAsync(new Uri(_baseUrl, RelativePath)).ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
            string resultContentString = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            return resultContentString;
        }

        public async Task<T> Get<T>(string RelativePath)
        {
            var result = await _httpClient.GetAsync(new Uri(_baseUrl, RelativePath)).ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
            string resultContentString = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            T resultContent = JsonConvert.DeserializeObject<T>(resultContentString);
            return resultContent;
        }

        public async Task<string> Post(string RelativePath, string Value)
        {
            using (var content = new StringContent(Value, Encoding.UTF8, "application/json"))
            {
                var result = await _httpClient.PostAsync(new Uri(_baseUrl, RelativePath), content).ConfigureAwait(false);
                result.EnsureSuccessStatusCode();
                string resultContentString = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
                return resultContentString;
            }
        }

        public async Task<T> Post<T>(string RelativePath, T Value)
        {
            using (var content = new StringContent(JsonConvert.SerializeObject(Value), Encoding.UTF8, "application/json"))
            {
                var result = await _httpClient.PostAsync(new Uri(_baseUrl, RelativePath), content).ConfigureAwait(false);
                result.EnsureSuccessStatusCode();
                string resultContentString = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
                T resultContent = JsonConvert.DeserializeObject<T>(resultContentString);
                return resultContent;
            }
        }

        public async Task<string> Put(string RelativePath, string Value)
        {
            using (var content = new StringContent(Value, Encoding.UTF8, "application/json"))
            {
                var result = await _httpClient.PutAsync(new Uri(_baseUrl, RelativePath), content).ConfigureAwait(false);
                result.EnsureSuccessStatusCode();
                string resultContentString = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
                return resultContentString;
            }
        }

        public async Task<T> Put<T>(string RelativePath, T Value)
        {
            using (var content = new StringContent(JsonConvert.SerializeObject(Value), Encoding.UTF8, "application/json"))
            {
                var result = await _httpClient.PutAsync(new Uri(_baseUrl, RelativePath), content).ConfigureAwait(false);
                result.EnsureSuccessStatusCode();
                string resultContentString = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
                T resultContent = JsonConvert.DeserializeObject<T>(resultContentString);
                return resultContent;
            }
        }

        public async Task<string> Delete(string RelativePath)
        {
            var result = await _httpClient.DeleteAsync(new Uri(_baseUrl, RelativePath)).ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
            string resultContentString = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            return resultContentString;
        }

        public async Task<T> Delete<T>(string RelativePath)
        {
            var result = await _httpClient.DeleteAsync(new Uri(_baseUrl, RelativePath)).ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
            string resultContentString = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            T resultContent = JsonConvert.DeserializeObject<T>(resultContentString);
            return resultContent;
        }

    }
}


