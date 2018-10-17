using Hangfire;
using Owin;
using Robot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Robot.App_Start
{
    public class HangfireConfig
    {
        public HangfireConfig(IAppBuilder app)
        {
            GlobalConfiguration.Configuration
                .UseSqlServerStorage("DefaultConnection");

            app.UseHangfireDashboard();
            app.UseHangfireServer();
            new Tarefas();
        }
    }
}