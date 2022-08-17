using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Interfaces;
using Model.ModelExpenseds;
using Interfaces.Models.Tradingsession;
using Interfaces.Base;
using Common.Constants;
namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TradingsessionController : ControllerBase
    {
        private readonly ITradingsessionBusinessLogic _business;
        public TradingsessionController(ITradingsessionBusinessLogic businessLogic)
        {
            _business = businessLogic;
        }

        [HttpGet]
        [Route("GetDropHinhThucPhien")]
        public HinhThucPhienDropDownResponse GetDropHinhThucPhien(int id)
        {
            return _business.getDropDownHinhThucPhien(id);
        }
        [HttpGet]
        [Route("TradingsessionGetList")]
        public TradingsessionGetListResponse TradingsessionGetList(int Id,string tieuDe,int HinhThucId, string thoigian_bd,string thoigian_kt,
            string hangdangky_bd,string handangky_kt, int TrangThaiCongBoId, int PageIndex,int PageSize)
        {
            return _business.TradingsessionGetList(Id, tieuDe,HinhThucId, thoigian_bd,thoigian_kt,
                hangdangky_bd,handangky_kt,TrangThaiCongBoId,PageIndex,PageSize);
        }
        [HttpPut]
        [Route("TradingsessionUpdateStatus")]
        public int TradingsessionUpdateStatus(TradddingsessionPutRequest request)
        {
            return _business.TradingsessionUpdateStatus(request);
        }
        [HttpDelete]
        [Route("TradingsessiononDelete")]
        public int TradingsessiononDelete(int Id)
        {
            return _business.TradingsessiononDelete(Id);
        }
        [HttpPost]
        [Route("TradingsessionCreate")]
        public bool TradingsessionCreate([FromBody] TradingsessionGetListRequest request)
        {
            return _business.TradingsessionCreate(request);
        }
        [HttpPut]
        [Route("TradingsessionUpdate")]
        public bool TradingsessionUpdate(TradingsessionGetListRequest request)
        {
            return _business.TradingsessionUpdate(request);
        }
        [HttpGet]
        [Route("TradingsessionGetById")]
        public TradingsessionGetListResponse TradingsessionGetById(int id)
        {
            return _business.TradingsessionGetById(id);
        }
        [HttpGet]
        [Route("TradingsessionGetChitietphien")]
        public TradingsessionGetListDetailResponse TradingsessionGetChitietphien(int id)
        {
            return _business.TradingsessionGetChitietphien(id);
        }
        [HttpGet]
        [Route("TradingsessionGetListDoanhNghiep")]
        public TradingsessionGetListDoanhNghiepResponse TradingsessionGetListDoanhNghiep(int id, int pageSize, int pageIndex, string tendoanhnghiep,
            string sodienthoai, string nhucautuyendung, string chitieutuyendung, int lichsugioithieu)
        {
            return _business.TradingsessionGetListDoanhNghiep(id, pageSize, pageIndex, tendoanhnghiep, sodienthoai, nhucautuyendung, chitieutuyendung, lichsugioithieu);
        }
        [HttpGet]
        [Route("TradingsessionGetListNguoilaodong")]
        public TradingsessionGetListNguoilaodongResponse TradingsessionGetListNguoilaodong(int id, int pageSize, int pageIndex, string tennguoilaodong,
            string sodienthoai, string nhucautuyendung, string chitieutuyendung, int lichsugioithieu)
        {
            return _business.TradingsessionGetListNguoilaodong(id, pageSize, pageIndex, tennguoilaodong, sodienthoai, nhucautuyendung, chitieutuyendung, lichsugioithieu);
        }
    }

}

