using System.Net.Http;
using System.Threading.Tasks;

namespace AspNetFeed.Web.Clients
{
    public class HttpClientHelper
    {
        public static Task<T> GetAsync<T>(string uri)
        {
            return new HttpClient().GetAsync(uri).Result.Content.ReadAsAsync<T>();
        }
    }
}