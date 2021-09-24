
using Microsoft.EntityFrameworkCore;
using Nestle_service_api.Context;
using Nestle_service_api.Model;
using Nestle_service_api.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nestle_service_api.BL.Inbound
{
    public class CallDetail : BaseBLL, ICallDetail
    {
        private readonly IEfRepository<tb_inbound_case> inboundCaseRepository;
        private readonly IEfRepository<tb_logs_inbound> inboundlogsRepository;
        public CallDetail(IEfRepository<tb_inbound_case> _inboundCaseRepository,
                         IEfRepository<tb_logs_inbound> _inboundlogsRepository)
        {
            inboundlogsRepository = _inboundlogsRepository;
            inboundlogsRepository = _inboundlogsRepository;
        }

        public async Task<bool> AddOrUpdate(InboundCaseModel inboundCase)
        {

            var inboundCasep = inboundCaseRepository.Table.Where(x => x.IsActive && x.Id == inboundCase.Id).FirstOrDefault();
            if (inboundCase != null)
            {
                inboundCasep.case_open_time = inboundCase.case_open_time;
                inboundCasep.contact_channel = inboundCase.contact_channel;
                inboundCasep.contact_number = inboundCase.contact_number;
                inboundCasep.case_id = inboundCase.case_id;
                inboundCasep.inbound_call_date = inboundCase.inbound_call_date;
                inboundCasep.name = inboundCase.name;
                inboundCasep.surname = inboundCase.surname;
                inboundCasep.service_group = inboundCase.service_group;
                inboundCasep.service_requst_verbatim = inboundCase.service_requst_verbatim;
                inboundCasep.service_type = inboundCase.service_type;
                inboundCasep.solution = inboundCase.solution;
                inboundCasep.sratus_case = inboundCase.sratus_case;
                inboundCasep.UpdatedBy = UserName;
                inboundCasep.UpdatedDate = DateTime.Now;
                await inboundCaseRepository.UpdateAsync(inboundCasep);
            }
            else
            {
                var inbound = new tb_inbound_case
                {
                    inbound_call_date = inboundCase.inbound_call_date,
                    case_open_time = inboundCase.case_open_time,
                    case_id = inboundCase.case_id,
                    contact_channel = inboundCase.contact_channel,
                    name = inboundCase.name,
                    surname = inboundCase.surname,
                    contact_number = inboundCase.contact_number,
                    service_group = inboundCase.service_group,
                    service_type = inboundCase.service_type,
                    service_requst_verbatim = inboundCase.service_requst_verbatim,
                    solution = inboundCase.solution,
                    sratus_case = inboundCase.sratus_case,
                    CreatedBy = UserName,
                    CreatedDate = DateTime.Now
                };
                await inboundCaseRepository.AddAsync(inbound);
            }


            return true;
        }
        public async Task<bool> Delete(int id)
        {
            var inboundCase = await inboundCaseRepository.FindByIdAsync(id);
            if (inboundCase == null)
                throw new Exception("Not found inbound Case");

            inboundCase.IsActive = false;
            inboundCase.UpdatedDate = DateTime.Now;
            inboundCase.UpdatedBy = UserName;
            return await inboundCaseRepository.UpdateAsync(inboundCase);

        }
        public async Task<InboundCaseModel> Get(int id)
        {
            var inboundCase = await inboundCaseRepository.Table.Where(x => x.Id == id)
                                          .Select(s => new InboundCaseModel
                                          {
                                              inbound_call_date = s.inbound_call_date,
                                              case_open_time = s.case_open_time,
                                              case_id = s.case_id,
                                              contact_channel = s.contact_channel,
                                              name = s.name,
                                              surname = s.surname,
                                              contact_number = s.contact_number,
                                              service_group = s.service_group,
                                              service_type = s.service_type,
                                              service_requst_verbatim = s.service_requst_verbatim,
                                              solution = s.solution,
                                              sratus_case = s.sratus_case
                                          }).FirstOrDefaultAsync();
            if (inboundCase == null)
                throw new Exception("Not found inbound Case");

            return inboundCase;
        }
        public async Task<ResponseViewModel<InboundCaseModel>> Get(string key, int skip, int take)
        {
            var query = inboundCaseRepository.Table.Where(x => x.IsActive);

            if (!string.IsNullOrEmpty(key))
                query = query.Where(x => x.name.Contains(key) || x.contact_number.Contains(key));

            int total = 0;
            var inboundCases = query.OrderBy(x => x.CreatedDate).Get(out total, skip, take)
                                .Select(s => new InboundCaseModel
                                {
                                    inbound_call_date = s.inbound_call_date,
                                    case_open_time = s.case_open_time,
                                    case_id = s.case_id,
                                    contact_channel = s.contact_channel,
                                    name = s.name,
                                    surname = s.surname,
                                    contact_number = s.contact_number,
                                    service_group = s.service_group,
                                    service_type = s.service_type,
                                    service_requst_verbatim = s.service_requst_verbatim,
                                    solution = s.solution,
                                    sratus_case = s.sratus_case
                                });

            return new ResponseViewModel<InboundCaseModel> { data = inboundCases.ToList(), totalCount = total };
        }

        public async Task<bool> AddLog(tb_logs_inbound logsInbound)
        {
            var inbound = new tb_logs_inbound
            {
                case_id = logsInbound.case_id,
                aqent_id = logsInbound.aqent_id,
                create_date = DateTime.Now,
                number = logsInbound.number,
                status_of_case = logsInbound.status_of_case,
                status_of_contact = logsInbound.status_of_contact,
                CreatedBy = UserName,
                CreatedDate = DateTime.Now
            };

            await inboundlogsRepository.AddAsync(inbound);

            return true;
        }
    }
}
