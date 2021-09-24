using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nestle_service_api.Model
{
    public class tb_animal_type
    {
        [key]
        public Int32 id { get; set; }
        public string pet_type { get; set; }
    }
}
