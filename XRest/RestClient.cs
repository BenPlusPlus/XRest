using System;
using System.Net.Http;

namespace XRest
{
    public class RestClient
    {
        private string _baseUrl;
        private HttpClient _httpClient;

        public RestClient(string BaseUrl)
        {
            Init(BaseUrl, new HttpClient());
        }

        public RestClient(string BaseUrl, HttpClient HttpClient)
        {
            Init(BaseUrl, HttpClient);
        }

        private void Init(string BaseUrl, HttpClient HttpClient)
        {
            _baseUrl = BaseUrl;
            _httpClient = HttpClient;
        }
    }
}

