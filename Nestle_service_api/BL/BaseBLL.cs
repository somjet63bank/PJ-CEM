
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Nestle_service_api.BL
{
    public class BaseBLL : IBaseBLL
    {
        public string UserName { get; set; }
        public BaseBLL()
        {

            //if (Utils.AppSetting.IsDevelopment)
            //    UserName = Utils.AppSetting.UserName;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}
