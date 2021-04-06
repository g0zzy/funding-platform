using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalInvest.FundingPlatform.Models
{
    public class FundingViewModel : BaseViewModel
    {
        public string Name { get; set; }

        public double Target { get; set; }

        public double Investment { get; set; }

        public DateTime ExpirationDate { get; set; }

        public ICollection<string> UserIds { get; set; } = new List<string>();
    }
}
