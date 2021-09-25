
using Nestle_service_api.Model;
using Nestle_service_api.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nestle_service_api.BL.Outbound
{
    public interface IFristCallDetail : IBaseBLL
    {
        Task<bool> AddOrUpdate(FristCallModel fristCall);
        Task<bool> AddOrUpdate(SecondCallModel secondCall);
        Task<bool> AddLog(tb_logs_outbound logsOutbound);
        Task<bool> Delete(int id);
        Task<FristCallModel> GetFristCall(int id);
        Task<SecondCallModel> GetSecondCall(int id);
        Task<ResponseViewModel<FristCallModel>> GetFristCallAll( string key, int skip, int take);
        Task<ResponseViewModel<SecondCallModel>> GetSecondCallAll(string key, int skip, int take);
        Task<ResponseViewModel<OutboundCallViewModel>> GetOutboundCallDetailAsync(string KeywordSearch ,int PageNumber);
        Task<int> ExecuteConsumerSegment(string id);

    }
}
