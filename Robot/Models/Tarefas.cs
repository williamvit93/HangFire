using Hangfire;
using Robot.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Robot.Models
{
    public class Tarefas
    {
        public Tarefas()
        {
            RecurringJob.AddOrUpdate<PessoasController>(pessoas => pessoas.Aniversario(), Cron.Minutely);
        }
    }
}