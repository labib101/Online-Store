using MobileStore.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MobileStore.Controllers
{
    [RoutePrefix("api/Analytics")]
    public class AnalyticsController : ApiController
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        [HttpGet]
        [ActionName("getTop3Products")]
        public IHttpActionResult getTop3Products()
        {

            return Ok();
        }


    }
}
