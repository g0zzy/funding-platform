using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalInvest.FundingPlatform.DataAccess.Entitities
{
    public class User : BaseEntity
    {
        public ICollection<UserFunding> UserFundings { get; set; }
    }
}
