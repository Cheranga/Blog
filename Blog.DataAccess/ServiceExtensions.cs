using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace Blog.DataAccess
{
    public static class ServiceExtensions
    {
        public static void UseDataAccess(this IServiceCollection services)
        {
            //
            // TODO: Register project spefici dependencies in here
            //
            new ConfigurationBuilder().

        }
    }
}