using System.Threading.Tasks;

namespace AspNetFeed.Web.Clients.Contracts
{
    public interface IClient
    {
        Task<dynamic> PlayersAsync();
    }
}