using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureFlagPOC.Core.Entities
{
    public class FeatureFlag
    {
        public int Id { get; set; }

        public bool Enabled { get; set; }

        public string FeatureName { get; set; }
    }
}
