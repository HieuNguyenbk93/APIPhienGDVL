using Interfaces.Base;
using Common.Constants;
using Model.Expensed;

namespace Interfaces.Model.Unit
{
    public class CUDUnitReponse : BaseResponse<ResponseStatus>
    {
       public int Id { get; set; }
    }
}
