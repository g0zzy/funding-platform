using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DigitalInvest.FundingPlatform.DataAccess.Entitities
{
    public class Funding : BaseEntity
    {
        public string Name { get; set; }

        public double Target { get; set; }

        [Range(100,10000)]
        public double Investment { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ExpirationDate { get; set; }

    }
}
