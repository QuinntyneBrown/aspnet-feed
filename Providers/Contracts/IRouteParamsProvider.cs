using System.Collections.Generic;

namespace AspNetFeed.Web.Providers.Contracts
{
    public interface IRouteParamsProvider
    {
        IDictionary<string, object> Get();

        void Set(string key, object value);
    }
}
