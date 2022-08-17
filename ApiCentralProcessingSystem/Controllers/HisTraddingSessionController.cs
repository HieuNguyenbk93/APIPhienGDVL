using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Common.Constants;
using Interfaces;
using Interfaces.Base;
using Model.Expensed;
using System;
using System.Collections.Generic;
using Interfaces.Models.Business;
using Interfaces.Models.Commons;

namespace ApiCentralProcessingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class HisTraddingSessionController : Controller
    {
        private readonly IHisTraddingSessionBusinessLogic _business;
        public HisTraddingSessionController(IHisTraddingSessionBusinessLogic business)
        {
            _business = business;
        }
        [HttpPost]
        [Authorize]
        [Route("CreateHistoryTradingsession")]
        public BaseResponse<ResponseStatus> CreateHistoryTradingsession(UpdateStatusByIdBusinessRequest request)
        {
            return _business.Create(request);
        }
        [HttpGet]
        [Route("TradingsessionGetListHistory")]
        [Authorize]
        public BusinessHistoryByIdGetListResponse TradingsessionGetListHistory(int id, string fromdate,string todate, int pageindex, int pagesize)
        {
            return _business.GetListHistory(id, fromdate,todate,pageindex,pagesize);
        }
    }
}
