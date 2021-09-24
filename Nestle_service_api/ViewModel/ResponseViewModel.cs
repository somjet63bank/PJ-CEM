using System;
using System.Collections.Generic;
using System.Text;

namespace Nestle_service_api.ViewModel
{
    public class ResponseViewModel<T>
    {
        public List<T> data { get; set; }

        public int totalCount { get; set; }
    }
}
