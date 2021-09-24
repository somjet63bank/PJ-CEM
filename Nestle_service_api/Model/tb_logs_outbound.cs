using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nestle_service_api.Model
{
    public class tb_logs_outbound
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 Id { get; set; }
        public Int32 case_id { get; set; }
        public Int32 aqent_id { get; set; }
        public DateTime create_date { get; set; }
        public Int32 number { get; set; }
        public string status_of_case { get; set; }
        public string status_of_contact { get; set; }
    }
}
