using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nestle_service_api.Model
{
    public class tb_Service_Group
    {
        [key]
        public int id { get; set; }
        public string Service_Group { get; set; }
    }
}
