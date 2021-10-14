using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nestle_service_api.ViewModel
{
    public class OutboundCallViewModel
    {
        public string id_master { get; set; }
        public string title { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string sex { get; set; }
        public string age { get; set; }
        public string phone { get; set; }
        public string facebook { get; set; }
        public string email { get; set; }
        public string house_number { get; set; }
        public string employee { get; set; }
        public string tellscorelink { get; set; }
        public string village { get; set; }
        public string swine { get; set; }
        public string road { get; set; }
        public string sub_district_name { get; set; }
        public string district_name { get; set; }
        public string province_name { get; set; }
        public string zip_code { get; set; }
        public int number_of_calls { get; set; }
        public string first_contact_status { get; set; }
        public string second_contact_status { get; set; }       
        public string convenient_to_chat { get; set; }     
        public string interested_brand_ambassador { get; set; }
        public string tellscore_registration_status { get; set; }
        public DateTime? first_callback_customer_date { get; set; }
        public DateTime? second_callback_customer_date { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
