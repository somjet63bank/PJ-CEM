using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nestle_service_api.Model
{
    public class tb_members
    {
        [key]
        public int id { get; set; }
        public int member { get; set; }
    }
}
