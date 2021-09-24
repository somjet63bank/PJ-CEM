using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nestle_service_api.Model
{
    public class tb_inbound_case : BaseEntity
    {
        public DateTime inbound_call_date { get; set; }
        public string case_open_time { get; set; }
        public Int32 case_id { get; set; }
        public string contact_channel { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string contact_number { get; set; }
        public string service_group { get; set; }
        public string service_type { get; set; }
        public string service_requst_verbatim { get; set; }
        public string solution { get; set; }
        public string sratus_case { get; set; }
    }
}
