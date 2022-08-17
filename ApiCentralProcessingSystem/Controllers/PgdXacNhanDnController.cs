using Common.Constants;
using Interfaces;
using Interfaces.Base;
using Interfaces.Models.PgdXacNhanDn;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCentralProcessingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PgdXacNhanDnController : ControllerBase
    {
        private readonly IPgdXacNhanDnBusinessLogic _business;
        public PgdXacNhanDnController(IPgdXacNhanDnBusinessLogic business)
        {
            _business = business;
        }

        [HttpPost]
        [Route("GetByIdPhien")]
        public PgdDnGetByIdResponse GetByIdPhien(PgdDnGetByIdRequest request)
        {
            return _business.GetByIdPhien(request);
        }

        [HttpPost]
        [Route("CreateDuocMoi")]
        [Authorize]
        public BaseResponse<ResponseStatus> PgdDnCreate(PgdDnCreateRequest request)
        {
            return _business.PgdDnDuocMoiCreate(request);
        }

        [HttpPost]
        [Route("UpdateDangKy")]
        [Authorize]
        public BaseResponse<ResponseStatus> PgdDnDangKyUpdate(PgdDnCreateRequest request)
        {
            return _business.PgdDnDangKyUpdate(request);
        }

        [HttpGet]
        [Route("HisDnDuocMoiGetByIdDn")]
        public HisDnDuocMoiByDnIdResponse HisDnDuocMoiGetByIdDn(long DoanhNghiepId)
        {
            return _business.HisDnDuocMoiGetByIdDn(DoanhNghiepId);
        }

        [HttpGet]
        [Route("HisDnDangKyGetByIdDn")]
        public HisDnDangKyByDnIdResponse HisDnDangKyGetByIdDn(long DoanhNghiepId)
        {
            return _business.HisDnDangKyGetByIdDn(DoanhNghiepId);
        }
    }
}
