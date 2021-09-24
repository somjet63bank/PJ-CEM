using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nestle_service_api.Model
{
    public class tb_district
    {
        public int id { get; set; }
        public int province_id { get; set; }
        public string pvnc_name { get; set; }
        public string district_name { get; set; }
    }
}
