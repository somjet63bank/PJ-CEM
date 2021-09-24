using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nestle_service_api.Model
{
    public class tb_title
    {
        [Key]
        public Int32 id { get; set; }
        public string sex_title { get; set; }
    }
}
