using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Repos;
using WebApiDemo.Model;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdDetailController : ControllerBase
    {
        private IAdDetail _obj = new AdDetailRepository();

        [HttpGet]
        [Route("ad-listings")]
        public List<AdInfo> getAdsList()
        {
            return _obj.getAllAds();
        }

        [HttpGet]
        [Route("v1/get-temp-ads")]
        public ActionResult gettempads()
        {
            return RedirectToActionPermanent("ad-information");
        }


        [Route("v2/ad-information")]
        [ActionName("ad-information")]
        public ActionResult<AdInfo> getAds(Int32 adid)
        {
            return _obj.getAdDetail(adid);
        }
    }
}
