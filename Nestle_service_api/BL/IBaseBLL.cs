using System;
using System.Collections.Generic;
using System.Text;

namespace Nestle_service_api.BL
{
    public interface IBaseBLL : IDisposable
    {
        string UserName { get; set; }
    }
}
