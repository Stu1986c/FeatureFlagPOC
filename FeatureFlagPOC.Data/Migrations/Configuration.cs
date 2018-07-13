namespace FeatureFlagPOC.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FeatureFlagPOC.Data.Contexts.FeatureContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "FeatureFlagPOC.Data.Contexts.FeatureContext";
        }

        protected override void Seed(FeatureFlagPOC.Data.Contexts.FeatureContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
