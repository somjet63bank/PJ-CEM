using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nestle_service_api.Model
{
    public class tb_zip_code
    {
        public int id { get; set; }

        public int sub_district_id { get; set; }
        public string sub_district_name { get; set; }
        public string zip_code { get; set; }
    }
}
