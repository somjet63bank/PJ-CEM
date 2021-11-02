using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nestle_service_api.ViewModel
{
    public class tdcx_report
    {
        public Int64 No { get; set; }
        public string Name { get; set; }
        public int ConutSMS { get; set; }
        public int CountlinkNonvoice { get; set; }
        public int ConfrimSMS { get; set; }
        public int ConfrimLink { get; set; }
    }
}
