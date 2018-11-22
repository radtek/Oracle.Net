using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Oracle.Net.Data;

namespace Oracle.Net
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //services.AddAuthentication(x => {
            //    x.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            //    x.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            //    x.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            //}).AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, x =>
            //{
            //    //登录地址
            //    x.LoginPath = "/Auth/Login";
            //    //sid
            //    x.Cookie.Name = "mycookie";
            //    x.Cookie.Path = "/";
            //    x.Cookie.HttpOnly = true;
            //    x.Cookie.Expiration = new TimeSpan(0, 0, 30);
            //    x.ExpireTimeSpan = new TimeSpan(0, 0, 30);
            //});
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options =>
            {
                options.LoginPath = new PathString("/login");
                options.AccessDeniedPath = new PathString("/denied");
            });
            services.AddDbContextPool<OracleContext>(options => options.UseMySql("Server=localhost;Port=3306;Database=myoracle; User=root;Password=123456;"));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Auth}/{action=Login}/{id?}");
            });
        }
    }
}
