using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.PlatformAbstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNet.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNet.Http;

namespace PClement.Club
{
    public class StartupDevelopment : Template.TemplatedStartup
    {
        public StartupDevelopment(IHostingEnvironment env, IApplicationEnvironment appEnv)
            : base(env, appEnv)
        {
        }

        protected override void SetupBuilderConfiguration(IConfigurationBuilder builder)
        {
            // For more details on using the user secret store see http://go.microsoft.com/fwlink/?LinkID=532709
            builder.AddUserSecrets();

            // This will push telemetry data through Application Insights pipeline faster, allowing you to view results immediately.
            builder.AddApplicationInsightsSettings(developerMode: true);
        }

        protected override LogLevel MinimumLogLevel { get { return LogLevel.Debug; } }
        protected override void SetupErrorPages(IApplicationBuilder app)
        {
            app.UseBrowserLink();
            app.UseDeveloperExceptionPage();
            app.UseDatabaseErrorPage();
        }

        protected override void AddEnvironmentSpecificMiddleware(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
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

    }
}
