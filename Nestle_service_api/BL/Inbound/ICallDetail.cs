
using Nestle_service_api.Model;
using Nestle_service_api.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nestle_service_api.BL.Inbound
{
    public interface ICallDetail : IBaseBLL
    {
        Task<bool> AddOrUpdate(InboundCaseModel inboundCase);
        Task<bool> Delete(int id);
        Task<InboundCaseModel> Get(int id);
        Task<bool> AddLog(tb_logs_inbound logsInbound);
        Task<ResponseViewModel<InboundCaseModel>> Get(string key, int skip, int take);
    }
}
