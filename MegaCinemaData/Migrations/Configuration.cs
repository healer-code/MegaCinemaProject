namespace MegaCinemaData.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MegaCinemaData.SampleData;
    using MegaCinemaModel.Models;
    using MegaCinemaCommon.StatusCommon;
    internal sealed class Configuration : DbMigrationsConfiguration<MegaCinemaData.MegaCinemaDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MegaCinemaData.MegaCinemaDBContext context)
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

            SampleData.GenerateAdsBanner(context);
            //SampleData.GenerateData(context);
            //SampleData.GenerateRegency(context);
            //SampleData.GenerateStaff(context);
            //context.Staffs.Add(new Staff
            //{
            //    StaffPrefix = CommonConstrants.STAFF_PREFIX,
            //    StaffRegencyID = 1,
            //    StaffStatus = "AC",
            //});
        }
    }
}
