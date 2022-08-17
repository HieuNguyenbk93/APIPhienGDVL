using Common.Constants;
using Interfaces.Base;
using Interfaces.Models.Business;
using Interfaces.Models.Tradingsession;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IHisTraddingSessionBusinessLogic
    {
        BaseResponse<ResponseStatus> Create(UpdateStatusByIdBusinessRequest request);
        BusinessHistoryByIdGetListResponse GetListHistory(int id, string fromdate, string todate, int pageindex, int pagesize);
    }
}
