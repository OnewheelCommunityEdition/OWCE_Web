using Microsoft.AspNetCore.Rewrite;

namespace OWCE_Web;

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

            options.Conventions.AddPageRoute("/UnofficialAppUpdateFAQ", "faq/unofficial_app_update");
            options.Conventions.AddPageRoute("/UnofficialActivatingFAQ", "faq/unofficial_activating");
            options.Conventions.AddPageRoute("/PrivacyPolicy", "privacy-policy");

        });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();
#if !DEBUG
            var rewriteOptions = new RewriteOptions()
                .AddRedirect("(^$|^Index$)", "https://github.com/OnewheelCommunityEdition/OWCE_App", 307);
            app.UseRewriter(rewriteOptions);
#endif
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapRazorPages();
        });
    }
}
