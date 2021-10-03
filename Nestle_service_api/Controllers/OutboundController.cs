using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nestle_service_api.BL.Outbound;
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
    public class OutboundController : ControllerBase
    {
        private readonly IFirstOrSecondCallDetail fristCallDetail;
        private readonly ILogger<OutboundController> logger;
        public OutboundController(IFirstOrSecondCallDetail _fristCallDetail, ILogger<OutboundController> _logger)
        {
            fristCallDetail = _fristCallDetail;
            logger = _logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetOutboundFistCallAll(string KeywordSearch, int PageNumber)
        {
            try
            {
                return Ok(await fristCallDetail.GetOutboundFirstCallAsync(KeywordSearch, PageNumber));
            }
            catch (Exception ex)
            {
                logger.LogError(ex.GetFullErrorText().Message);
                return BadRequest(ex.GetFullErrorText().Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetOutboundSecondCallAll(string KeywordSearch, int PageNumber)
        {
            try
            {
                return Ok(await fristCallDetail.GetOutboundSecondCallAsync(KeywordSearch, PageNumber));
            }
            catch (Exception ex)
            {
                logger.LogError(ex.GetFullErrorText().Message);
                return BadRequest(ex.GetFullErrorText().Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetOutboundByIdmaster(string Idmaster)
        {
            try
            {
                return Ok(await fristCallDetail.GetOutboundByIdmaster(Idmaster));
            }
            catch (Exception ex)
            {
                logger.LogError(ex.GetFullErrorText().Message);
                return BadRequest(ex.GetFullErrorText().Message);
            }
        }


        [HttpPost]
        public async Task<IActionResult> AddOrUpdateFristCall(FirstCallModel fristCall)
        {
            try
            {
                return Ok(await fristCallDetail.AddOrUpdate(fristCall));
            }
            catch (Exception ex)
            {
                logger.LogError(ex.GetFullErrorText().Message);
                return BadRequest(ex.GetFullErrorText().Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddLog(tb_logs_outbound logsOutbound)
        {
            try
            {
                return Ok(await fristCallDetail.AddLog(logsOutbound));
            }
            catch (Exception ex)
            {
                logger.LogError(ex.GetFullErrorText().Message);
                return BadRequest(ex.GetFullErrorText().Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddOrUpdateSecondCall(SecondCallModel secondCall)
        {
            try
            {
                return Ok(await fristCallDetail.AddOrUpdate(secondCall));
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
                return Ok(await fristCallDetail.Delete(id));
            }
            catch (Exception ex)
            {
                logger.LogError(ex.GetFullErrorText().Message);
                return BadRequest(ex.GetFullErrorText().Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetFirstCall(int id)
        {
            try
            {
                return Ok(await fristCallDetail.GetFirstCall(id));
            }
            catch (Exception ex)
            {
                logger.LogError(ex.GetFullErrorText().Message);
                return BadRequest(ex.GetFullErrorText().Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetSecondCall(int id)
        {
            try
            {
                return Ok(await fristCallDetail.GetSecondCall(id));
            }
            catch (Exception ex)
            {
                logger.LogError(ex.GetFullErrorText().Message);
                return BadRequest(ex.GetFullErrorText().Message);
            }
        }
        [HttpGet]
        public async Task<IActionResult> FilterFirstCall(string key, int skip, int take)
        {
            try
            {
                return Ok(await fristCallDetail.GetFirstCallAll(key, skip, take));
            }
            catch (Exception ex)
            {
                logger.LogError(ex.GetFullErrorText().Message);
                return BadRequest(ex.GetFullErrorText().Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> FilterSecondCall(string key, int skip, int take)
        {
            try
            {
                return Ok(await fristCallDetail.GetSecondCallAll(key, skip, take));
            }
            catch (Exception ex)
            {
                logger.LogError(ex.GetFullErrorText().Message);
                return BadRequest(ex.GetFullErrorText().Message);
            }
        }
        [HttpGet]
        public async Task<IActionResult> ExecuteConsumerSegment(string Idmaster)
        {
            try
            {
                return Ok(await fristCallDetail.ExecuteConsumerSegment(Idmaster));
            }
            catch (Exception ex)
            {
                logger.LogError(ex.GetFullErrorText().Message);
                return BadRequest(ex.GetFullErrorText().Message);
            }
        }

    }
}
