using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nestle_service_api.BL.Inbound;
using Nestle_service_api.Common;
using Nestle_service_api.Model;
using Nestle_service_api.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Nestle_service_api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InboundController : ControllerBase
    {
        private readonly ICallDetail callDetail;
        private readonly ILogger<InboundController> logger;
        public InboundController(ICallDetail _callDetail, ILogger<InboundController> _logger)
        {
            callDetail = _callDetail;
            logger = _logger;
        }

        [HttpPost]
        public async Task<IActionResult> AddOrUpdate(InboundCaseModel inboundCase)
        {
            try
            {
                return Ok(await callDetail.AddOrUpdate(inboundCase));
            }
            catch (Exception ex)
            {
                logger.LogError(ex.GetFullErrorText().Message);
                return BadRequest(ex.GetFullErrorText().Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                return Ok(await callDetail.Delete(id));
            }
            catch (Exception ex)
            {
                logger.LogError(ex.GetFullErrorText().Message);
                return BadRequest(ex.GetFullErrorText().Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                return Ok(await callDetail.Get(id));
            }
            catch (Exception ex)
            {
                logger.LogError(ex.GetFullErrorText().Message);
                return BadRequest(ex.GetFullErrorText().Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Filter(string KeywordSearch, int skip)
        {
            try
            {
                return Ok(await callDetail.Get(KeywordSearch, skip));
            }
            catch (Exception ex)
            {
                logger.LogError(ex.GetFullErrorText().Message);
                return BadRequest(ex.GetFullErrorText().Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddLog(tb_logs_inbound logsInbound)
        {
            try
            {
                return Ok(await callDetail.AddLog(logsInbound));
            }
            catch (Exception ex)
            {
                logger.LogError(ex.GetFullErrorText().Message);
                return BadRequest(ex.GetFullErrorText().Message);
            }
        }
    }
}
