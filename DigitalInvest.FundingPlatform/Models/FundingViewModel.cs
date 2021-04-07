using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalInvest.FundingPlatform.Models
{
    public class FundingViewModel : BaseViewModel
    {
        public string Name { get; set; }

        public double Target { get; set; }

        [Range(100, 10000)]
        public double Investment { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ExpirationDate { get; set; }
    }
}
