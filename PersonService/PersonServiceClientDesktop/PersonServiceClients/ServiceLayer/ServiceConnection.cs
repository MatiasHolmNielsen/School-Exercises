using System.Net.Http;
using System.Threading.Tasks;

namespace PersonServiceClientDesktop.Servicelayer
{
    public abstract class ServiceConnection
    {
        private readonly HttpClient _httpEnabler;

        public ServiceConnection(string inBaseUrl)
        {
            _httpEnabler = new HttpClient();
            BaseUrl = inBaseUrl;
            UseUrl = BaseUrl;
        }

        public string? BaseUrl { get; init; }
        public string? UseUrl { get; set; }

        public async Task<HttpResponseMessage?> CallServiceGet()
        {
            if (UseUrl != null)
                return await _httpEnabler.GetAsync(UseUrl);
            return null;
        }

        public async Task<HttpResponseMessage?> CallServicePost(StringContent postJson)
        {
            if (UseUrl != null)
                return await _httpEnabler.PostAsync(UseUrl, postJson);
            return null;
        }

        // Put and Delete left unimplemented for now
    }
}
