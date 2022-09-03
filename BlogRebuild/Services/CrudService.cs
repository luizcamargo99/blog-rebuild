using BlogRebuild.Constants;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;

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
        public async Task<HttpResponseMessage> Get(string endpoint, string query = "")
        {
            return await _httpClient.GetAsync(string.Concat(Urls.ApiBlogAdmin, endpoint, query));
        }

        public StringContent ConvertStringToStringContent(string jsonString)
        {
            return new StringContent(jsonString, System.Text.Encoding.UTF8, _mediaType);
        }
    }
}
