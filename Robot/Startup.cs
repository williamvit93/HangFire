using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin;
using Owin;
using Robot.App_Start;
using Robot.Controllers;

[assembly: OwinStartup(typeof(Robot.Startup))]
namespace Robot
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            new HangfireConfig(app);
        }
    }
}