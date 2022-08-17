using Common.Constants;
using Interfaces.Base;
using Interfaces.Models.PgdXacNhanDn;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IPgdXacNhanDnBusinessLogic
    {
        PgdDnGetByIdResponse GetByIdPhien(PgdDnGetByIdRequest request);
        BaseResponse<ResponseStatus> PgdDnDuocMoiCreate(PgdDnCreateRequest request);
        BaseResponse<ResponseStatus> PgdDnDangKyUpdate(PgdDnCreateRequest request);
        HisDnDuocMoiByDnIdResponse HisDnDuocMoiGetByIdDn(long DoanhNghiepId);
        HisDnDangKyByDnIdResponse HisDnDangKyGetByIdDn(long DoanhNghiepId);
    }
}
