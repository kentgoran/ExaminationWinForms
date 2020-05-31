namespace BusinessLogic2.Migrations
{
    using BusinessLogic;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BusinessLogic.FestivalContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BusinessLogic.FestivalContext context)
        {   
        }
    }
}
