using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.AspNet.Builder;
using Microsoft.Extensions.Logging;

namespace PClement.Club
{
    public class Startup : Template.TemplatedStartup
    {
        public Startup(IHostingEnvironment env, IApplicationEnvironment appEnv) 
            : base(env, appEnv)
        {

        }

        protected override void SetupBuilderConfiguration(IConfigurationBuilder builder)
        {
            // do nothing more
        }

        protected override void AddEnvironmentSpecificMiddleware(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            // no specific middleware for Production
        }

    }
}
