
using Microsoft.EntityFrameworkCore;
using Nestle_service_api.Context;
using Nestle_service_api.Model;
using Nestle_service_api.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nestle_service_api.BL.Outbound
{
    public class FirstOrSecondCallDetail : BaseBLL, IFirstOrSecondCallDetail
    {
        private readonly IEfRepository<tb_outbound_first_call> fristcallRepository;
        private readonly IEfRepository<tb_outbound_second_call> secondcallRepository;
        private readonly IEfRepository<tb_logs_outbound> outboundlogsRepository;
        private readonly Nestle_Connect nestle_Connect;
        private readonly SPContext context;
        public FirstOrSecondCallDetail(IEfRepository<tb_outbound_first_call> _fristcallRepository,
                         IEfRepository<tb_outbound_second_call> _secondcallRepository,
                         IEfRepository<tb_logs_outbound> _outboundlogsRepository,
                         Nestle_Connect _nestle_Connect,
                         SPContext _context)
        {
            fristcallRepository = _fristcallRepository;
            secondcallRepository = _secondcallRepository;
            outboundlogsRepository = _outboundlogsRepository;
            nestle_Connect = _nestle_Connect;
            context = _context;
        }

        public async Task<bool> AddOrUpdate(FirstCallModel fristCallModel)
        {

            var fristcall = fristcallRepository.Table.Where(x => x.IsActive && x.case_id == fristCallModel.case_id).FirstOrDefault();

            if (fristCallModel.contact_status == "Available")
            {
                fristCallModel.status_of_case = "Reachable";
                fristCallModel.contact_status = "Completed Information";
            }
            if (fristCallModel.contact_status == "Not Available" ||
                fristCallModel.contact_status == "Busy" ||
                fristCallModel.contact_status == "Missed call" ||
                fristCallModel.contact_status == "On behalf of owner" ||
                fristCallModel.contact_status == "Busy")
            {
                fristCallModel.status_of_case = "Unreachable";
            }
            if (fristCallModel.contact_status == "Wrong number")
            {
                fristCallModel.status_of_case = "Not Called";
            }

            DateTime? nullDateTime = null;
            if (fristcall != null)
            {
                fristcall.ob_date = fristCallModel.ob_date;
                fristcall.ob_time = fristCallModel.ob_time;
                fristcall.case_status = fristCallModel.status_of_case;
                fristcall.contact_status = fristCallModel.contact_status;
                fristcall.consurmer_name = fristCallModel.consurmer_name;
                fristcall.consurmer_surmer = fristCallModel.consurmer_surmer;
                fristcall.owner_mobile_number = fristCallModel.owner_mobile_number;
                fristcall.callback_customer_date = fristCallModel.callback_customer_date == null ? nullDateTime : fristCallModel.callback_customer_date.Value;
                fristcall.use_discount_code = fristCallModel.use_discount_code;
                fristcall.discount_code_for = fristCallModel.discount_code_for;
                fristcall.discount_code_exp_date = fristCallModel.discount_code_exp_date;
                fristcall.interested_brand_ambassador = fristCallModel.interested_brand_ambassador;
                fristcall.tellscore_registration_status = fristCallModel.tellscore_registration_status;
                fristcall.convenient_to_chat = fristCallModel.convenient_to_chat;
                fristcall.case_id = fristCallModel.case_id;
                fristcall.UpdatedBy = fristCallModel.UserName;
                fristcall.UpdatedDate = DateTime.Now;
                await fristcallRepository.UpdateAsync(fristcall);
            }
            else
            {

                if (fristCallModel.contact_status == "Available")
                {
                    fristCallModel.status_of_case = "Reachable";
                    fristCallModel.contact_status = "Completed Information";
                }
                if (fristCallModel.contact_status == "Not Available" ||
                    fristCallModel.contact_status == "Busy" ||
                    fristCallModel.contact_status == "Missed call" ||
                    fristCallModel.contact_status == "On behalf of owner" ||
                    fristCallModel.contact_status == "Busy")
                {
                    fristCallModel.status_of_case = "Unreachable";
                }
                if (fristCallModel.contact_status == "Wrong number")
                {
                    fristCallModel.status_of_case = "Not Called";
                }

                var _fristcall = new tb_outbound_first_call
                {
                    ob_date = DateTime.Now,
                    ob_time = DateTime.Now.ToString("HH:mm:ss tt"),
                    case_status = fristCallModel.status_of_case,
                    contact_status = fristCallModel.contact_status,
                    consurmer_name = fristCallModel.consurmer_name,
                    consurmer_surmer = fristCallModel.consurmer_surmer,
                    owner_mobile_number = fristCallModel.owner_mobile_number,
                    callback_customer_date = fristCallModel.callback_customer_date == null ? nullDateTime : fristCallModel.callback_customer_date.Value,
                    use_discount_code = fristCallModel.use_discount_code,
                    discount_code_for = fristCallModel.discount_code_for,
                    discount_code_exp_date = fristCallModel.discount_code_exp_date,
                    interested_brand_ambassador = fristCallModel.interested_brand_ambassador,
                    tellscore_registration_status = fristCallModel.tellscore_registration_status,
                    convenient_to_chat = fristCallModel.convenient_to_chat,
                    case_id = fristCallModel.case_id,
                    UpdatedBy = fristCallModel.UserName,
                    UpdatedDate = DateTime.Now,
                    CreatedBy = fristCallModel.UserName,
                    CreatedDate = DateTime.Now
                };

                await fristcallRepository.AddAsync(_fristcall);
            }

            var inbound = new tb_logs_outbound
            {
                case_id = fristCallModel.case_id,
                aqent_name = fristCallModel.UserName,
                create_date = DateTime.Now,
                status_of_case = fristCallModel.status_of_case,
                status_of_contact = fristCallModel.contact_status,
                step = 1,
                CreatedBy = fristCallModel.UserName,
                CreatedDate = DateTime.Now,
                UpdatedBy = fristCallModel.UserName,
                UpdatedDate = DateTime.Now,
            };

            await AddLogFirst(inbound);
            return true;
        }

        public async Task<bool> AddOrUpdate(SecondCallModel secondCallModel)
        {

            var secondcall = secondcallRepository.Table.Where(x => x.IsActive && x.case_id == secondCallModel.case_id).FirstOrDefault();
            DateTime? nullDateTime = null;
            if (secondCallModel.contact_status == "Available")
            {
                secondCallModel.status_of_case = "Reachable";
                secondCallModel.contact_status = "Completed Information";
            }
            if (secondCallModel.contact_status == "Not Available" ||
                secondCallModel.contact_status == "Busy" ||
                secondCallModel.contact_status == "Missed call" ||
                secondCallModel.contact_status == "On behalf of owner" ||
                secondCallModel.contact_status == "Busy")
            {
                secondCallModel.status_of_case = "Unreachable";
            }
            if (secondCallModel.contact_status == "Wrong number")
            {
                secondCallModel.status_of_case = "Not Called";
            }

            if (secondcall != null)
            {
                secondcall.ob_date = secondCallModel.ob_date;
                secondcall.ob_time = secondCallModel.ob_time;
                secondcall.case_status = secondCallModel.status_of_case;
                secondcall.contact_status = secondCallModel.contact_status;
                secondcall.consurmer_name = secondCallModel.consurmer_name;
                secondcall.consurmer_surmer = secondCallModel.consurmer_surmer;
                secondcall.owner_mobile_number = secondCallModel.owner_mobile_number;
                secondcall.callback_customer_date = secondCallModel.callback_customer_date == null ? nullDateTime : secondCallModel.callback_customer_date.Value;
                secondcall.regietered_yet = secondCallModel.regietered_yet;
                secondcall.interested_brand_ambassador = secondCallModel.interested_brand_ambassador;
                secondcall.tellscore_registration_status = secondCallModel.tellscore_registration_status;
                secondcall.reasons_register = secondCallModel.reasons_register;
                secondcall.convenient_to_chat = secondCallModel.convenient_to_chat;
                secondcall.case_id = secondCallModel.case_id;
                secondcall.UpdatedBy = secondCallModel.UserName;
                secondcall.UpdatedDate = DateTime.Now;
                await secondcallRepository.UpdateAsync(secondcall);
            }
            else
            {
                if (secondCallModel.contact_status == "Available")
                {
                    secondCallModel.status_of_case = "Reachable";
                    secondCallModel.contact_status = "Completed Information";
                }
                if (secondCallModel.contact_status == "Not Available" ||
                    secondCallModel.contact_status == "Busy" ||
                    secondCallModel.contact_status == "Missed call" ||
                    secondCallModel.contact_status == "On behalf of owner" ||
                    secondCallModel.contact_status == "Busy")
                {
                    secondCallModel.status_of_case = "Unreachable";
                }
                if (secondCallModel.contact_status == "Wrong number")
                {
                    secondCallModel.status_of_case = "Not Called";
                }
                var _secondcall = new tb_outbound_second_call
                {
                    ob_date = DateTime.Now,
                    ob_time = DateTime.Now.ToString("HH:mm:ss tt"),
                    contact_status = secondCallModel.contact_status,
                    case_status = secondCallModel.status_of_case,
                    consurmer_name = secondCallModel.consurmer_name,
                    consurmer_surmer = secondCallModel.consurmer_surmer,
                    owner_mobile_number = secondCallModel.owner_mobile_number,
                    callback_customer_date = secondCallModel.callback_customer_date == null ? nullDateTime : secondCallModel.callback_customer_date.Value,
                    regietered_yet = secondCallModel.regietered_yet,
                    interested_brand_ambassador = secondCallModel.interested_brand_ambassador,
                    tellscore_registration_status = secondCallModel.tellscore_registration_status,
                    reasons_register = secondCallModel.reasons_register,
                    convenient_to_chat = secondCallModel.convenient_to_chat,
                    case_id = secondCallModel.case_id,
                    UpdatedBy = secondCallModel.UserName,
                    UpdatedDate = DateTime.Now,
                    CreatedBy = secondCallModel.UserName,
                    CreatedDate = DateTime.Now
                };

                await secondcallRepository.AddAsync(_secondcall);
            }

            var inbound = new tb_logs_outbound
            {
                case_id = secondCallModel.case_id,
                aqent_name = secondCallModel.UserName,
                create_date = DateTime.Now,
                status_of_case = secondCallModel.status_of_case,
                status_of_contact = secondCallModel.contact_status,
                step = 2,
                CreatedBy = secondCallModel.UserName,
                CreatedDate = DateTime.Now,
                UpdatedBy = secondCallModel.UserName,
                UpdatedDate = DateTime.Now,
            };

            await AddLogSecond(inbound);

            return true;
        }
        public async Task<bool> Delete(int id)
        {
            var inboundCase = await fristcallRepository.FindByIdAsync(id);
            if (inboundCase == null)
                throw new Exception("Not found inbound Case");

            inboundCase.IsActive = false;
            inboundCase.UpdatedDate = DateTime.Now;
            inboundCase.UpdatedBy = UserName;
            return await fristcallRepository.UpdateAsync(inboundCase);

        }
        public async Task<FirstCallModel> GetFirstCall(int id)
        {
            var fristcall = await fristcallRepository.Table.Where(x => x.Id == id)
                                          .Select(s => new FirstCallModel
                                          {
                                              Id = s.Id,
                                              ob_date = s.ob_date,
                                              ob_time = s.ob_time,
                                              contact_status = s.contact_status,
                                              consurmer_name = s.consurmer_name,
                                              consurmer_surmer = s.consurmer_surmer,
                                              owner_mobile_number = s.owner_mobile_number,
                                              use_discount_code = s.use_discount_code,
                                              discount_code_for = s.discount_code_for,
                                              discount_code_exp_date = s.discount_code_exp_date,
                                              interested_brand_ambassador = s.interested_brand_ambassador,
                                              tellscore_registration_status = s.tellscore_registration_status
                                          }).FirstOrDefaultAsync();
            if (fristcall == null)
                throw new Exception("Not found frist call");

            return fristcall;
        }
        public async Task<SecondCallModel> GetSecondCall(int id)
        {
            var secondcall = await secondcallRepository.Table.Where(x => x.Id == id)
                                          .Select(s => new SecondCallModel
                                          {
                                              Id = s.Id,
                                              ob_date = s.ob_date,
                                              ob_time = s.ob_time,
                                              contact_status = s.contact_status,
                                              consurmer_name = s.consurmer_name,
                                              consurmer_surmer = s.consurmer_surmer,
                                              owner_mobile_number = s.owner_mobile_number,
                                              regietered_yet = s.regietered_yet,
                                              interested_brand_ambassador = s.interested_brand_ambassador,
                                              reasons_register = s.reasons_register,
                                              tellscore_registration_status = s.tellscore_registration_status
                                          }).FirstOrDefaultAsync();
            if (secondcall == null)
                throw new Exception("Not found second call");

            return secondcall;
        }
        public async Task<ResponseViewModel<FirstCallModel>> GetFirstCallAll(string key, int skip, int take)
        {
            var query = fristcallRepository.Table.Where(x => x.IsActive);

            if (!string.IsNullOrEmpty(key))
                query = query.Where(x => x.consurmer_name.Contains(key) || x.consurmer_surmer.Contains(key));

            int total = 0;
            var fristcall = query.OrderBy(x => x.CreatedDate).Get(out total, skip, take)
                                .Select(s => new FirstCallModel
                                {
                                    Id = s.Id,
                                    ob_date = s.ob_date,
                                    ob_time = s.ob_time,
                                    contact_status = s.contact_status,
                                    consurmer_name = s.consurmer_name,
                                    consurmer_surmer = s.consurmer_surmer,
                                    owner_mobile_number = s.owner_mobile_number,
                                    use_discount_code = s.use_discount_code,
                                    discount_code_for = s.discount_code_for,
                                    discount_code_exp_date = s.discount_code_exp_date,
                                    interested_brand_ambassador = s.interested_brand_ambassador,
                                    tellscore_registration_status = s.tellscore_registration_status
                                });

            return new ResponseViewModel<FirstCallModel> { data = fristcall.ToList(), totalCount = total };
        }

        public async Task<ResponseViewModel<SecondCallModel>> GetSecondCallAll(string key, int skip, int take)
        {
            var query = secondcallRepository.Table.Where(x => x.IsActive);

            if (!string.IsNullOrEmpty(key))
                query = query.Where(x => x.consurmer_name.Contains(key) || x.consurmer_surmer.Contains(key));

            int total = 0;
            var secondcall = query.OrderBy(x => x.CreatedDate).Get(out total, skip, take)
                                .Select(s => new SecondCallModel
                                {
                                    Id = s.Id,
                                    ob_date = s.ob_date,
                                    ob_time = s.ob_time,
                                    contact_status = s.contact_status,
                                    consurmer_name = s.consurmer_name,
                                    consurmer_surmer = s.consurmer_surmer,
                                    owner_mobile_number = s.owner_mobile_number,
                                    regietered_yet = s.regietered_yet,
                                    interested_brand_ambassador = s.interested_brand_ambassador,
                                    reasons_register = s.reasons_register,
                                    tellscore_registration_status = s.tellscore_registration_status
                                });

            return new ResponseViewModel<SecondCallModel> { data = secondcall.ToList(), totalCount = total };
        }

        public async Task<bool> AddLogFirst(tb_logs_outbound logsInbound)
        {
            var registerHeading = nestle_Connect.tb_RegisterHeading.Where(x => x.id_master == logsInbound.case_id).FirstOrDefault();

            if (registerHeading != null)
            {
                registerHeading.number_of_calls += 1;
                nestle_Connect.tb_RegisterHeading.Update(registerHeading);
                nestle_Connect.SaveChanges();
            }

            var outboundlogs = outboundlogsRepository.Table.Where(x => x.case_id == logsInbound.case_id && x.step == 1).OrderByDescending(x => x.number_of_repeat).FirstOrDefault();

            var inbound = new tb_logs_outbound
            {
                case_id = logsInbound.case_id,
                aqent_name = logsInbound.aqent_name,
                create_date = DateTime.Now,
                number_of_repeat = outboundlogs == null ? 1 : outboundlogs.number_of_repeat + 1,
                status_of_case = logsInbound.status_of_case,
                status_of_contact = logsInbound.status_of_contact,
                step = logsInbound.step,
                CreatedBy = logsInbound.CreatedBy,
                CreatedDate = DateTime.Now,
                UpdatedBy = logsInbound.UpdatedBy,
                UpdatedDate = DateTime.Now
            };

            await outboundlogsRepository.AddAsync(inbound);

            return true;
        }

        public async Task<bool> AddLogSecond(tb_logs_outbound logsInbound)
        {
            var registerHeading = nestle_Connect.tb_RegisterHeading.Where(x => x.id_master == logsInbound.case_id).FirstOrDefault();

            if (registerHeading != null)
            {
                registerHeading.number_of_calls += 1;
                nestle_Connect.tb_RegisterHeading.Update(registerHeading);
                nestle_Connect.SaveChanges();
            }

            var outboundlogs = outboundlogsRepository.Table.Where(x => x.case_id == logsInbound.case_id && x.step == 2).OrderByDescending(x => x.number_of_repeat).FirstOrDefault();

            var inbound = new tb_logs_outbound
            {
                case_id = logsInbound.case_id,
                aqent_name = logsInbound.aqent_name,
                create_date = DateTime.Now,
                number_of_repeat = outboundlogs == null ? 1 : outboundlogs.number_of_repeat + 1,
                status_of_case = logsInbound.status_of_case,
                status_of_contact = logsInbound.status_of_contact,
                step = logsInbound.step,
                CreatedBy = logsInbound.CreatedBy,
                CreatedDate = DateTime.Now,
                UpdatedBy = logsInbound.UpdatedBy,
                UpdatedDate = DateTime.Now
            };

            await outboundlogsRepository.AddAsync(inbound);

            return true;
        }

        public async Task<ResponseViewModel<OutboundCallViewModel>> GetOutboundFirstCallAsync(string KeywordSearch, int PageNumber)
        {
            try
            {
                int total = 0;
                var Results = context.Set<OutboundCallViewModel>().FromSqlRaw("EXEC dbo.sp_GetAllOutboundCall @KeywordSearch={0}, @PageNumber={1}", KeywordSearch, PageNumber).ToList();

                return new ResponseViewModel<OutboundCallViewModel> { data = Results.ToList(), totalCount = total }; ;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<ResponseViewModel<OutboundCallViewModel>> GetOutboundSecondCallAsync(string KeywordSearch, int PageNumber)
        {
            try
            {
                int total = 0;
                var Results = context.Set<OutboundCallViewModel>().FromSqlRaw("EXEC dbo.sp_GetAllOutboundSecondCall @KeywordSearch={0}, @PageNumber={1}", KeywordSearch, PageNumber).ToList();

                return new ResponseViewModel<OutboundCallViewModel> { data = Results.ToList(), totalCount = total }; ;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<ResponseViewModel<OutboundCallViewModel>> GetAllOutboundCallAsync(int PageNumber)
        {
            try
            {
                int total = 0;
                var Results = context.Set<OutboundCallViewModel>().FromSqlRaw("EXEC dbo.sp_GetOutboundCallAll @PageNumber={0}", PageNumber).ToList();

                List<OutboundCallViewModel> list = new List<OutboundCallViewModel>();
                foreach (var item in Results)
                {
                    if (item.first_contact_status != "Wrong number")
                    {
                        if (item.second_contact_status != "Completed Information")
                            list.Add(item);
                    }
                }

                return new ResponseViewModel<OutboundCallViewModel> { data = list, totalCount = total };
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<OutboundCallViewModel> GetOutboundByIdmaster(string Idmaster)
        {
            try
            {
                var Result = context.Set<OutboundCallViewModel>().FromSqlRaw("EXEC dbo.GetOutboundByIdmaster @id_master={0}", Idmaster).ToList();

                return Result.FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<int> ExecuteConsumerSegment(string id_master)
        {
            try
            {
                var Result = await context.Database.ExecuteSqlRawAsync("EXEC dbo.sp_i_consumer_segment @id_master={0}", id_master);

                return Result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
