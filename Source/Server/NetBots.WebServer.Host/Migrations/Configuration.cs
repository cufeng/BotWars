using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace NetBots.WebServer.Host.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<NetBots.WebServer.Host.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "NetBots.WebServer.Host.Models.ApplicationDbContext";
        }

        protected override void Seed(NetBots.WebServer.Host.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
