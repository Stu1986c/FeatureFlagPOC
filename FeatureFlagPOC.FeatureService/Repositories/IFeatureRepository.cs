using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureFlagPOC.Core.Repositories
{
    public interface IFeatureRepository
    {
        bool IsFeatureEnabled(string flagName);

        bool IsUserFlaggedOn(int userId);
    }
}
