using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureFlagPOC.Core.Entities
{
    public class FlaggedUser
    {
        public int Id { get; set; }

        public int UserId { get; set; }
    }
}
