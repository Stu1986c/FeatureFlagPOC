using FeatureFlagPOC.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureFlagPOC.Data.Contexts
{
    public class FeatureContext : DbContext
    {
        public DbSet<FeatureFlag> FeatureFlags { get; set; }

        public DbSet<FlaggedUser> FlaggedUsers { get; set; }
    }
}
