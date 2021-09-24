using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nestle_service_api.Model
{
    public class tb_master_link
    {
        [key]
        public int id { get; set; }
        public string sender { get; set; }
        public string customer { get; set; }
        public string create_send { get; set; }
        public DateTime create_link_date { get; set; }
        public string Url { get; set; }
        public string status { get; set; }
        public string random_numbe { get; set; }
    }
}
