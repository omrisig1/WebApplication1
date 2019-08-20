using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OtoSpaMVC.Data;
using OtoSpaMVC.Models;
using OtoSpaMVC.Services;
using FluentScheduler;
using OtoSpaMVC.Models.OtherHelperModels;

namespace OtoSpaMVC
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            // Add application services.
            services.AddTransient<IEmailSender, EmailSender>();

            services.AddMvc(options => {
                options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
                //options.Filters.Add(new RequireHttpsAttribute());
            });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                    {
                        options.AccessDeniedPath = "/Shared/PleaseJoin";
                        options.LoginPath = "/Shared/PleaseJoin";
                        options.ForwardSignIn = "/Shared/PleaseJoin";
                    }
                );
            //  .addFacebook, addOAuth...

            services.AddAuthorization(options => {
                options.AddPolicy("MustBeAdmin", p => p.RequireAuthenticatedUser().RequireRole("admin"));
                options.AddPolicy("MustBeUser", p => p.RequireAuthenticatedUser().RequireRole("user","admin"));
            });

            var context = services.BuildServiceProvider().GetService<ApplicationDbContext>();
            JobManager.Initialize(new tAppRegistry(context));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseForwardedHeaders(new ForwardedHeadersOptions() {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });
            app.UseHsts();
            //app.UseHsts(options => options.MaxAge(days: 365).IncludeSubdomains());

            app.UseStaticFiles();

            //app.UseXXssProtection(options => options.EnabledWithBlockMode());

            //app.UseXContentTypeOptions();

            app.UseAuthentication();    // AUTH! / cookie

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
