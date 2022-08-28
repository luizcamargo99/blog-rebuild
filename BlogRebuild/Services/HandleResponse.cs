using Data.Models.Entities;
using Newtonsoft.Json;

namespace BlogRebuild.Services
{
    public class HandleResponse
    {
        public async Task<Response> Convert(HttpResponseMessage request)
        {
            return JsonConvert.DeserializeObject<Response>(await request.Content.ReadAsStringAsync());
        }
    }
}
