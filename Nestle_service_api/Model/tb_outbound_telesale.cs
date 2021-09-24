using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nestle_service_api.Model
{
    public class tb_outbound_telesale
    {
        public DateTime ob_date { get; set; }
        public string ob_time { get; set; }
        public string contact_status { get; set; }
        public string consurmer_name { get; set; }
        public string consurmer_surmer { get; set; }
        public string owner_mobile_number { get; set; }
        public string consurmer_group { get; set; }
        public string discountcode_exp_date { get; set; }
        public string discountcode_sending_status { get; set; }
    }
}
