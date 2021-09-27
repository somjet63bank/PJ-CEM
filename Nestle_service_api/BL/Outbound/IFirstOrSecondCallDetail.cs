
using Nestle_service_api.Model;
using Nestle_service_api.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nestle_service_api.BL.Outbound
{
    public interface IFirstOrSecondCallDetail : IBaseBLL
    {
        Task<bool> AddOrUpdate(FirstCallModel fristCall);
        Task<bool> AddOrUpdate(SecondCallModel secondCall);
        Task<bool> AddLog(tb_logs_outbound logsOutbound);
        Task<bool> Delete(int id);
        Task<FirstCallModel> GetFirstCall(int id);
        Task<SecondCallModel> GetSecondCall(int id);
        Task<ResponseViewModel<FirstCallModel>> GetFirstCallAll( string key, int skip, int take);
        Task<ResponseViewModel<SecondCallModel>> GetSecondCallAll(string key, int skip, int take);
        Task<ResponseViewModel<OutboundCallViewModel>> GetOutboundFirstCallAsync(string KeywordSearch ,int PageNumber);
        Task<ResponseViewModel<OutboundCallViewModel>> GetOutboundSecondCallAsync(string KeywordSearch, int PageNumber);
        Task<int> ExecuteConsumerSegment(string id);

    }
}
