using AspNetFeed.Web.Clients.Contracts;
using System.Threading.Tasks;

namespace AspNetFeed.Web.Clients
{
    public class Client: IClient
    {
        public Task<dynamic> PlayersAsync()
        {
            string uri = string.Format(
                    "{0}/stats/commonallplayers?IsOnlyCurrentSeason=1&LeagueID=00&Season=2015-16",
                    "http://stats.nba.com");

            return HttpClientHelper.GetAsync<dynamic>(uri);

        }
    }
}