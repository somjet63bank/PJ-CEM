using Microsoft.AspNetCore.Mvc;
using Nestle_service_api.Context;
using Nestle_service_api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nestle_service_api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class GetSetting : Controller
    {
        private readonly Nestle_Connect _Nestle_Connect;

        public GetSetting(Nestle_Connect Nestle_Connect)
        {
            _Nestle_Connect = Nestle_Connect;
        }

        [HttpGet]
        public ActionResult<tb_title> gettitle()
        {
            var data = _Nestle_Connect.tb_title.ToList();
            if (data.Count !=0)
            {
                return Ok(data);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpGet]
        public ActionResult<tb_sex> getsex()
        {
            var data = _Nestle_Connect.tb_sexs.ToList();
            if (data.Count != 0)
            {
                return Ok(data);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpGet]
        public ActionResult<tb_age_range> get_age_range()
        {
            var data = _Nestle_Connect.tb_age_range.ToList();
            if (data.Count != 0)
            {
                return Ok(data);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpGet]
        public ActionResult<tb_members> get_members()
        {
            var data = _Nestle_Connect.tb_members.ToList();
            if (data.Count != 0)
            {
                return Ok(data);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpGet]
        public ActionResult<tb_animal_type> get_animal_type()
        {
            var data = _Nestle_Connect.tb_animal_type.ToList();
            if (data.Count != 0)
            {
                return Ok(data);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
