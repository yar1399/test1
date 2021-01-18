using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using PTemplate.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.FileProviders;
using PTemplate.Models;

using System.IO;

using Microsoft.AspNetCore.Http;
using PTemplate.Data.DataBase;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using PTemplate.Models.Interface;
using PTemplate.Models.JobTime;

namespace PTemplate
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            //services.AddCronJob<MyCronJob1>(c =>
            //{
            //    c.TimeZoneInfo = TimeZoneInfo.Local;
            //    c.CronExpression = @"*/5 * * * *";
            //});


            //services.AddCronJob<MyCronJob2>(c =>
            //{
            //    c.TimeZoneInfo = TimeZoneInfo.Local;
            //    c.CronExpression = @"* * * * *";
            //});

            services.AddCronJob<MyCronJob3>(c =>
            {
                c.TimeZoneInfo = TimeZoneInfo.Local;
                c.CronExpression = @"10 17 * * *";
            });


            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            // If using Kestrel:
            //services.Configure<KestrelServerOptions>(options =>
            //{
            //    options.AllowSynchronousIO = true;
            //});

            // If using IIS:
            services.Configure<IISServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });


            services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        Configuration.GetConnectionString("BaseCon")));

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedEmail = true)
                 .AddRoles<IdentityRole>()
                 .AddEntityFrameworkStores<PTsecContext>();




            services.Configure<IdentityOptions>(options =>
            {
                // Password settings.
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;


                options.SignIn.RequireConfirmedAccount = true;

                // Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

                // User settings.
                options.User.AllowedUserNameCharacters =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = true;



            });


            services.ConfigureApplicationCookie(options =>
            {

                // Cookie settings
                options.Cookie.HttpOnly = true;

                options.ExpireTimeSpan = TimeSpan.FromMinutes(20);

                options.LoginPath = "/Identity/Account/Login";
                options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                options.SlidingExpiration = true;

            });


            //email
            services.Configure<EmailSettings>(Configuration.GetSection("EmailSettings"));
            services.AddSingleton<IEmailSender, EmailSender>();





            //Upload
            services.AddSingleton<IFileProvider>(
            new PhysicalFileProvider(
                Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads")));

            //   services.AddControllersWithViews();


            services.AddMvc()
       .AddSessionStateTempDataProvider();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(20);//We set Time here 
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });


            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/error");
                app.UseHsts();
            }






            app.UseSession();



            app.UseStatusCodePagesWithRedirects("/error/Index/{0}");


            // app.UseHttpsRedirection();




            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseCookiePolicy();
            app.UseMiddleware(typeof(ApplcationVarlable));
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "mvcAreaRoute",
                   pattern: "{area:exists}/{controller=Admin}/{action=Index}");

                endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=sjtejarat}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                name: "admin",
                pattern: "{area:exists}/{controller=admin}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                name: "Users",
                pattern: "{area:exists}/{controller=Users}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
               name: "Ads",
               pattern: "{area:exists}/{controller=Ads}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
               name: "Products",
               pattern: "{area:exists}/{controller=Products}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                name: "Posts",
                pattern: "{area:exists}/{controller=Posts}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                name: "Addresssystems",
                pattern: "{area:exists}/{controller=Addresssystems}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                   name: "Factor1",
                   pattern: "{area:exists}/{controller=Factor1}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                   name: "Factorsubs",
                   pattern: "{area:exists}/{controller=Factorsubs}/{action=Index}/{id?}");


                endpoints.MapControllerRoute(
        name: "imageprofiles",
        pattern: "{area:exists}/{controller=imageprofiles}/{action=Index}/{id?}");

          
                endpoints.MapRazorPages();
            });
        }
    }
}
