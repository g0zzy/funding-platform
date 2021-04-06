using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalInvest.FundingPlatform.DataAccess.Entitities
{
    public class UserFunding
    {
        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid FundingId { get; set; }
        public Funding Funding { get; set; }
    }
}
