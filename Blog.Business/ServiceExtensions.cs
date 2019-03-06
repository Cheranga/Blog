using Blog.DataAccess;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.Business
{
    public static class ServiceExtensions
    {
        public static void UseBusiness(this IServiceCollection services)
        {
            //
            // TODO:
            // Register project specific dependencies in here
            //

            services.UseDataAccess();
        }
    }
}