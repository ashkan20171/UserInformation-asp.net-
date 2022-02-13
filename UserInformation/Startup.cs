using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using UserInformation.Generic;
using UserInformation.MyContext;
using UserInformation.Service;
using UserInformation.Service.Interface;

//Ahmad hadizadeh Asancode.Com
namespace UserInformation
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            #region ConnectionString

            services.AddDbContext<RegisterContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("RegisterConnection"));
            });

            #endregion ConnectionString

            #region Authentication

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(options =>
            {
                options.LoginPath = "/Login";
                options.LogoutPath = "/LogOut";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(43200);
            });

            #endregion Authentication

            #region IOC

            services.AddTransient<IRegisterService, RegisterService>();
            services.AddTransient<IViewRenderService, RenderViewToString>();

            #endregion IOC
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseStaticFiles();
                app.UseAuthentication();
                app.UseMvcWithDefaultRoute();
                app.UseDeveloperExceptionPage();
                app.UseMvc();
            }
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}