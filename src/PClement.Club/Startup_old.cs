using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PClement.Club.Models;
using PClement.Club.Services;
using System.Diagnostics;

namespace PClement.Club
{
    public class Startup_old
    {
        public Startup_old(IHostingEnvironment env)
        {
            // Set up configuration sources.

            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            if (env.IsDevelopment())
            {
                // For more details on using the user secret store see http://go.microsoft.com/fwlink/?LinkID=532709
                builder.AddUserSecrets();

                // This will push telemetry data through Application Insights pipeline faster, allowing you to view results immediately.
                builder.AddApplicationInsightsSettings(developerMode: true);
            }

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();            
        }

        public IConfigurationRoot Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddApplicationInsightsTelemetry(Configuration);

            services.AddEntityFramework()
                .AddSqlServer()
                .AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(Configuration["Data:DefaultConnection:ConnectionString"]))
                .AddDbContext<ClubDbContext>(options =>
                    options.UseSqlServer(Configuration["Data:DefaultConnection:ConnectionString"]));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddMvc();

            // Add application services.
            services.AddTransient<IEmailSender, AuthMessageSender>();
            services.AddTransient<ISmsSender, AuthMessageSender>();
            services.Configure<Models.Config.FooConfig>(Configuration.GetSection("Foo"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            // log to the console
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            // log to the debug window
            loggerFactory.AddDebug(LogLevel.Debug);
            loggerFactory.MinimumLevel = LogLevel.Debug;
#if DNX451
            //https://docs.asp.net/en/latest/fundamentals/logging.html
            //loggerFactory.AddTraceSource(new SourceSwitch("LoggingSample") { Level = SourceLevels.Critical }, new ConsoleTraceListener(false));
            //loggerFactory.AddTraceSource(new SourceSwitch("LoggingSample") { Level = SourceLevels.Critical }, new EventLogTraceListener("Application"));
            //var sourceSwitch = new SourceSwitch("LoggingSample") { Level = SourceLevels.Information };
            //loggerFactory.AddTraceSource(sourceSwitch, new ConsoleTraceListener(false));
            //loggerFactory.AddTraceSource(sourceSwitch, new EventLogTraceListener("Application"));

#endif


            app.UseApplicationInsightsRequestTelemetry();

            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");

                // For more details on creating database during deployment see http://go.microsoft.com/fwlink/?LinkID=615859
                try
                {
                    using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>()
                        .CreateScope())
                    {
                        serviceScope.ServiceProvider.GetService<ApplicationDbContext>()
                             .Database.Migrate();
                    }
                }
                catch { }
            }

            app.UseIISPlatformHandler(options => options.AuthenticationDescriptions.Clear());

            app.UseApplicationInsightsExceptionTelemetry();

            app.UseStaticFiles();

            app.UseIdentity();

            // To configure external authentication please see http://go.microsoft.com/fwlink/?LinkID=532715

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });


            // Create a catch-all response
            app.Run(async (context) =>
            {
                //var logger = loggerFactory.CreateLogger("Catchall Endpoint");
                //logger.LogInformation("No endpoint found for request {path}", context.Request.Path);
                //await context.Response.WriteAsync("No endpoint found - try /api/todo.");


                //if (context.Request.Path.Value.Contains("boom"))
                //{
                    var executionTime = 1000;
                    var logger = loggerFactory.CreateLogger(typeof(Program).FullName);
                    logger.LogInformation($"Handled in {{{nameof(executionTime)}}} ms", executionTime);
                    //throw new Exception("boom!");
                //}
                await context.Response.WriteAsync("Hello World!");
            });
        }

        // Entry point for the application.
        //public static void Main(string[] args) => WebApplication.Run<Startup_old>(args);
    }
}
