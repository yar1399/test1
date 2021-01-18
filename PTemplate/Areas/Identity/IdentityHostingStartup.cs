using System;
using Microsoft.AspNetCore.Hosting;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PTemplate.Data;

[assembly: HostingStartup(typeof(PTemplate.Areas.Identity.IdentityHostingStartup))]
namespace PTemplate.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<PTsecContext>(options =>
                    options.UseSqlServer(
                       
                        context.Configuration.GetConnectionString("BaseCon")));

                //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                //    .AddEntityFrameworkStores<PTsecContext>();
            });
        }
    }
}