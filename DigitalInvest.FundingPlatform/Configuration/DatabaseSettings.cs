using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalInvest.FundingPlatform.Data
{
    public class DatabaseSettings
    {
        public string ConnectionString { get; set; }

        public bool UseInMemory { get; set; }
    }
}
