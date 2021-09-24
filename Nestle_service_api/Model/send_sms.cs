using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nestle_service_api.Model
{
    public class send_sms
    {
        public string phone_no { get; set; }
        public string msgs { get; set; }
        public string senders { get; set; }
        public string refID { get; set; }
        public string projectID { get; set; }

    }
}
