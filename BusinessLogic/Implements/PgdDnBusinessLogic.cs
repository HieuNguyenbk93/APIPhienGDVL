using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Common.Constants;
using Interfaces;
using Interfaces.Base;
using Interfaces.Models.PgdXacNhanDn;
using Repositories.Implements;

namespace BusinessLogic.Implements
{
    public class PgdDnBusinessLogic : IPgdXacNhanDnBusinessLogic
    {
        private readonly PgdDnDataAccess _dataAccess;
        public PgdDnBusinessLogic(IMapper mapper)
        {
            _dataAccess = new PgdDnDataAccess(mapper);
        }
        public PgdDnGetByIdResponse GetByIdPhien(PgdDnGetByIdRequest request)
        {
            return _dataAccess.PgdDnGetByIdPhien(request);
        }

        public HisDnDangKyByDnIdResponse HisDnDangKyGetByIdDn(long DoanhNghiepId)
        {
            return _dataAccess.HisDnDangKyGetByIdDn(DoanhNghiepId);
        }

        public HisDnDuocMoiByDnIdResponse HisDnDuocMoiGetByIdDn(long DoanhNghiepId)
        {
            return _dataAccess.HisDnDuocMoiGetByIdDn(DoanhNghiepId);
        }

        public BaseResponse<ResponseStatus> PgdDnDuocMoiCreate(PgdDnCreateRequest request)
        {
            return _dataAccess.PgdDnDuocMoiCreate(request);
        }

        public BaseResponse<ResponseStatus> PgdDnDangKyUpdate(PgdDnCreateRequest request)
        {
            return _dataAccess.PgdDnDangKyUpdate(request);
        }
    }
}
