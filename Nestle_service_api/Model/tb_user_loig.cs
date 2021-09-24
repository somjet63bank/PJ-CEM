using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nestle_service_api.Model
{
    public class tb_user_login
    {
        [key]
        public int id { get; set; }
        public string user_ { get; set; }
        public string password_ { get; set; }
        public string project_id { get; set; }
        public string status { get; set; }

    }
}
