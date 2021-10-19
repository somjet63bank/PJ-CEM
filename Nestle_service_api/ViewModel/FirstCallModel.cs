using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nestle_service_api.ViewModel
{
    public class FirstCallModel
    {
        public int Id { get; set; }
        public DateTime? ob_date { get; set; }
        public string ob_time { get; set; }
        public string contact_status { get; set; }
        public string consurmer_name { get; set; }
        public string consurmer_surmer { get; set; }
        public string owner_mobile_number { get; set; }
        public DateTime? callback_customer_date { get; set; }
        public string use_discount_code { get; set; }
        public string discount_code_for { get; set; }
        public string discount_code_exp_date { get; set; }
        public string interested_brand_ambassador { get; set; }
        public string tellscore_registration_status { get; set; }
        public string status_of_case { get; set; }
        public string case_id { get; set; }
        public string UserName { get; set; }
        public string convenient_to_chat { get; set; }
        public bool verify_phone_number { get; set; }
        public string new_phone_number { get; set; }
        public bool ask_more { get; set; }
        public string inquiry { get; set; }
        public string answer1 { get; set; }
        public string answer2 { get; set; }
        public string answer3 { get; set; }
        public string answer4 { get; set; }
    }
}
