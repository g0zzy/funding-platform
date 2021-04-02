using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalInvest.FundingPlatform.DataAccess.Entitities
{
    public class Funding
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public double Target { get; set; }

        public double Investment { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime ExpirationDate { get; set; }
    }
}
