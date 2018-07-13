using FeatureFlagPOC.Core.Repositories;
using FeatureFlagPOC.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureFlagPOC.Data.Repositories
{
    public class FeatureRepository : IFeatureRepository
    {
        private readonly FeatureContext _featureContext;

        public FeatureRepository()
        {
            _featureContext = new FeatureContext();
        }

        public bool IsFeatureEnabled(string flagName)
        {
            return _featureContext.FeatureFlags.Where(x => x.FeatureName == flagName).SingleOrDefault().Enabled;
        }

        public bool IsUserFlaggedOn(int userId)
        {
            return _featureContext.FlaggedUsers.Where(x => x.UserId == userId).Any();
        }
    }
}
