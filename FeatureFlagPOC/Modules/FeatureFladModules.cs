using FeatureFlagPOC.Core.Repositories;
using FeatureFlagPOC.Core.Services;
using FeatureFlagPOC.Data.Repositories;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FeatureFlagPOC.Modules
{
    public class FeatureFlagModule : NinjectModule
    {
        public override void Load()
        {
            //Repository bindings
            Bind<IFeatureRepository>().To<FeatureRepository>().InSingletonScope(); 

            //Service bindings
            Bind<IFeatureService>().To<FeatureService>();
        }
    }
}