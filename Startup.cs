using Optimizely_Project.Extensions;
using EPiServer.Cms.Shell;
using EPiServer.Cms.UI.AspNetIdentity;
using EPiServer.Scheduler;
using EPiServer.ServiceLocation;
using EPiServer.Web.Routing;
using Stott.Optimizely.RobotsHandler.Configuration;
using Optimizely_Project.Middleware;
using EPiServer.Web;
using EPiServer.Forms;
using EPiServer.Framework.Web.Resources;

namespace Optimizely_Project;

public class Startup
{
    private readonly IWebHostEnvironment _webHostingEnvironment;

    public Startup(IWebHostEnvironment webHostingEnvironment)
    {
        _webHostingEnvironment = webHostingEnvironment;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        if (_webHostingEnvironment.IsDevelopment())
        {
            AppDomain.CurrentDomain.SetData("DataDire ctory", Path.Combine(_webHostingEnvironment.ContentRootPath, "App_Data"));

            services.Configure<SchedulerOptions>(options => options.Enabled = true);
        }

        services
            .AddCmsAspNetIdentity<ApplicationUser>()
            .AddCms()
            .AddAlloy()
            .AddAdminUserRegistration()
            .AddEmbeddedLocalization<Startup>();

        // Required by Wangkanai.Detection
        services.AddDetection();

        services.AddSession(options =>
        {
            options.IdleTimeout = TimeSpan.FromSeconds(10);
            options.Cookie.HttpOnly = true;
            options.Cookie.IsEssential = true;
        });
        //For robot.txt handler using Optimizely third party tools. Scotts Optimizely Robot Handlers
        services.AddRobotsHandler();
        //For controller base logic using in Error 500 Controller
        //services.AddControllersWithViews();

        services.Configure<DisplayOptions>(options =>
        {

            options.Add("full", "/displayoptions/full", Globals.ContentAreaTags.FullWidth, "", "epi-icon__layout--full")
               .Add("wide", "/displayoptions/wide", Globals.ContentAreaTags.TwoThirdsWidth, "", "epi-icon__layout--two-thirds")
               .Add("narrow", "/displayoptions/narrow", Globals.ContentAreaTags.OneThirdWidth, "", "epi-icon__layout--one-third");
        });
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        //For redirecting in case of 500 and 404 Error Page.
        //app.UsePageRedirectionMiddleware();
        //app.UseHttpsRedirection();
        app.UseDetection();
        app.UseSession();

        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthentication();
        app.UseAuthorization();

        //For controller base logic using in Error 500 Controller
        app.UseEndpoints(endpoints =>
        {
            //endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
            endpoints.MapContent();
        });

    }
}
