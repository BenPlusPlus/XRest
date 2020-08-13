using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace XRest
{
    public class RestClient
    {
        private Uri _baseUrl;
        private HttpClient _httpClient;

        public RestClient(string BaseUrl)
        {
            Init(new Uri(BaseUrl), new HttpClient());
        }
        public RestClient(Uri BaseUrl)
        {
            Init(BaseUrl, new HttpClient());
        }

        // Allow HttpClient to be injected to avoid issues with socket availability
        // (see: https://aspnetmonsters.com/2016/08/2016-08-27-httpclientwrong/)
        public RestClient(string BaseUrl, HttpClient HttpClient)
        {
            Init(new Uri(BaseUrl), HttpClient);
        }
        public RestClient(Uri BaseUrl, HttpClient HttpClient)
        {
            Init(BaseUrl, HttpClient);
        }

        private void Init(Uri BaseUrl, HttpClient HttpClient)
        {
            _baseUrl = BaseUrl;
            _httpClient = HttpClient;
        }

        public async Task Post<T>(string UrlPart, T Value)
        {
            _httpClient.BaseAddress = _baseUrl;
            using (var content = new StringContent(JsonConvert.SerializeObject(Value), Encoding.UTF8, "application/json"))
            {
                var result = await _httpClient.PostAsync(new Uri(UrlPart), content).ConfigureAwait(false);
                result.EnsureSuccessStatusCode();
            }
        }

        public async Task Put<T>(string UrlPart, T Value)
        {
            _httpClient.BaseAddress = _baseUrl;
            using (var content = new StringContent(JsonConvert.SerializeObject(Value), Encoding.UTF8, "application/json"))
            {
                var result = await _httpClient.PutAsync(new Uri(UrlPart), content).ConfigureAwait(false);
                result.EnsureSuccessStatusCode();
            }
        }

        public async Task<T> Get<T>(string url)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBasicUri);
                var result = await client.GetAsync(url);
                result.EnsureSuccessStatusCode();
                string resultContentString = await result.Content.ReadAsStringAsync();
                T resultContent = JsonConvert.DeserializeObject<T>(resultContentString);
                return resultContent;
            }
        }

        public async Task Delete(string UrlPart)
        {
            _httpClient.BaseAddress = _baseUrl;
            var result = await _httpClient.DeleteAsync(new Uri(UrlPart)).ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
        }
    }
}


