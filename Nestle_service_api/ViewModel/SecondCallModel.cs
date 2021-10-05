﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nestle_service_api.ViewModel
{
    public class SecondCallModel
    {
        public Int32 Id { get; set; }
        public DateTime ob_date { get; set; }
        public string ob_time { get; set; }
        public string contact_status { get; set; }
        public string consurmer_name { get; set; }
        public string consurmer_surmer { get; set; }
        public string owner_mobile_number { get; set; }
        public string convenient_to_chat { get; set; }
        public DateTime? callback_customer_date { get; set; }
        public string regietered_yet { get; set; }
        public string interested_brand_ambassador { get; set; }
        public string reasons_register { get; set; }
        public string tellscore_registration_status { get; set; }
        public string case_id { get; set; }
        public string status_of_case { get; set; }
        public string UserName { get; set; }
    }
}
