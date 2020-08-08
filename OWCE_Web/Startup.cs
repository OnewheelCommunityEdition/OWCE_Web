using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OWCE_Web
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
           services.AddRazorPages(options =>
           {
               var hwfwPages = new string[]
               {
                   "hw",
                   "fw",
                   "hwfw",
                   "fwhw",
                   "firmware",
                   "hardware",
                   "hardwarefirmware",
                   "firmwarehardware",
               };
               foreach (var hwfwPage in hwfwPages)
               {
                   options.Conventions.AddPageRoute("/KnownHardwareFirmware", hwfwPage);
               }

               //options.Conventions.AddRoute
           });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStaticFiles();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
#if !DEBUG
            var rewriteOptions = new RewriteOptions()
                .AddRedirect("(^$|^Index$)", "https://www.facebook.com/owceapp", 302);
            app.UseRewriter(rewriteOptions);
#endif
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
