using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nestle_service_api.Model
{
    public class tb_Service_Type
    {
        [key]
        public int id { get; set; }
        public int id_service_group { get; set; }
        public string service_group { get; set; }
        public string Service_Type { get; set; }
    }
}
