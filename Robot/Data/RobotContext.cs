using Robot.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Robot.Data
{
    public class RobotContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        public RobotContext() : base("DefaultConnection")
        {

        }
    }
}