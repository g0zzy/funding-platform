using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalInvest.FundingPlatform.DataAccess.Entitities
{
    public class Funding : BaseEntity
    {
        public string Name { get; set; }

        public double Target { get; set; }

        public double Investment { get; set; }

        public DateTime ExpirationDate { get; set; }

        public ICollection<UserFunding> UserFundings { get; set; }

    }
}
