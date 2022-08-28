using BlogRebuild.Constants;

namespace BlogRebuild.Services
{
    public class CrudService
    {
        private readonly HttpClient _httpClient;
        private const string _mediaType = "application/json";

        public CrudService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> Post(string endpoint, string jsonString)
        {
            return await _httpClient.PostAsync(string.Concat(Urls.ApiBlogAdmin, endpoint), ConvertStringToStringContent(jsonString));
        }
        public async Task<HttpResponseMessage> Get(string endpoint, string query = "")
        {
            
            return await _httpClient.GetAsync(string.Concat(Urls.ApiBlogAdmin, endpoint, query));
        }
        public async Task<HttpResponseMessage> Put(string endpoint, string jsonString)
        {
            return await _httpClient.PutAsync(string.Concat(Urls.ApiBlogAdmin, endpoint), ConvertStringToStringContent(jsonString));
        }
        public async Task<HttpResponseMessage> Delete(string query)
        {
            return await _httpClient.DeleteAsync(query);
        }

        private StringContent ConvertStringToStringContent(string jsonString)
        {
            return new StringContent(jsonString, System.Text.Encoding.UTF8, _mediaType);
        }
    }
}
