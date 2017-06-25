using Fiver.Mvc.DependencyInjection.Models.Home;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Fiver.Mvc.DependencyInjection
{
    public class Startup
    {
        public Startup(
            IHostingEnvironment env,
            ILoggerFactory loggerFactory)
        {
        }

        public void ConfigureServices(
            IServiceCollection services)
        {
            services.AddScoped<ILookupService, LookupService>();
            services.AddMvc();
        }

        public void Configure(
            IApplicationBuilder app,
            IHostingEnvironment env,
            ILoggerFactory loggerFactory)
        {
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
