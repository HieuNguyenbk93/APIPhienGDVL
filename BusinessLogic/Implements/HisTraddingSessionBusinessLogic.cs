using AutoMapper;
using Common.Constants;
using Interfaces;
using Interfaces.Base;
using Interfaces.Models.Business;
using Interfaces.Models.Tradingsession;
using Repositories.Implements;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Implements
{
    public class HisTraddingSessionBusinessLogic : IHisTraddingSessionBusinessLogic
    {
        private readonly HisTraddingSessionDataAccess _dataAccess;
        public HisTraddingSessionBusinessLogic(IMapper mapper)
        {
            _dataAccess = new HisTraddingSessionDataAccess(mapper);
        }
        public BaseResponse<ResponseStatus> Create(UpdateStatusByIdBusinessRequest request)
        {
            return _dataAccess.Create(request);
        }
        public BusinessHistoryByIdGetListResponse GetListHistory(int id, string fromdate, string todate, int pageindex, int pagesize)
        {
            return _dataAccess.GetListHistory(id, fromdate, todate, pageindex, pagesize);
        }
    }
}
