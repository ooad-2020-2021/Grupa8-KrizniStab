using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(CovidX.Areas.Identity.IdentityHostingStartup))]
namespace CovidX.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}