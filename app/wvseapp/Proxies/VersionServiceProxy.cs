using System;
using System.Threading.Tasks;
using System.Net.Http;

namespace wvse.Proxies
{
    public class VersionServiceProxy
    {
        private HttpClient _httpClient;
        private string _versionServiceBaseUrl = "http://service/api/";
    
        public VersionServiceProxy()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(_versionServiceBaseUrl)
            };
        }
        
        public async Task<int> GetVersion()
        {
            //try {
                var response = await _httpClient.GetAsync("Version");
                var version = await response.Content.ReadAsAsync<int>();
            
                return version;
            //} catch(Exception ex) {
            //    return 0;
            //}
        }
    }
}
