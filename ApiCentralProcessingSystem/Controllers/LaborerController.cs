using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Interfaces;
using Interfaces.Model.Laborer;
using Newtonsoft.Json;
using Model;
using System.Collections.Generic;
using Interfaces.Base;
using Common.Constants;
using Interfaces.Models.Laborer;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LaborerController : ControllerBase
    {

        private readonly ILaborerBusinessLogic _business;
        public LaborerController(ILaborerBusinessLogic business)
        {
            _business = business;
        }

        [HttpPost]
        [Route("LaborerGetDataForCreate")]
        [Authorize]
        public LaborerGetDataForCreateResponse LaborerGetDataForCreate(LaborerGetDataForCreateRequest request)
        {
            return _business.LaborerGetDataForCreate(request);
        }

        [HttpPost]
        [Route("LaborerGetList")]
        [Authorize]
        public LaborerGetListResponse LaborerGetList(LaborerGetListRequest request)
        {
            return _business.LaborerGetList(request);
        }

        [HttpPost]
        [Route("LaborerGetById")]
        [Authorize]
        public LaborerGetByIdResponse LaborerGetById(LaborerGetByIdRequest request)
        {
            return _business.LaborerGetById(request);
        }

        [HttpPost]
        [Route("LaborerGetByIdView")]
        [Authorize]
        public LaborerGetByIdViewResponse LaborerGetByIdView(LaborerGetByIdRequest request)
        {
            return _business.LaborerGetByIdView(request);
        }
        [HttpPost]
        [Route("LaborerCreate")]
        [Authorize]
        public LaborerCreateResponse LaborerCreate()
        {
            var jss = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Local,
                DateParseHandling = DateParseHandling.DateTimeOffset
            };
            LaborerCreateRequest request = new LaborerCreateRequest();
            request.AccountId = JsonConvert.DeserializeObject<int>(Request.Form["AccountId"].ToString(), jss);
            request.UserId = JsonConvert.DeserializeObject<string>(Request.Form["UserId"].ToString(), jss);
            request.Data = JsonConvert.DeserializeObject<LbNguoiLaoDong>(Request.Form["Model"].ToString(), jss);
            request.lstLoaiBaoHiem = JsonConvert.DeserializeObject<List<LbLoaiBaoHiem>>(Request.Form["lstLoaiBaoHiem"].ToString(), jss);
            request.lstDoiTuongUuTien = JsonConvert.DeserializeObject<List<LbDoiTuongUuTien>>(Request.Form["lstDoiTuongUuTien"].ToString(), jss);
            request.lstTrinhDoNgoaiNgu = JsonConvert.DeserializeObject<List<LbTrinhDoNgoaiNgu>>(Request.Form["lstTrinhDoNgoaiNgu"].ToString(), jss);
            request.lstKyNangMemKhac = JsonConvert.DeserializeObject<List<LbKyNangMemKhac>>(Request.Form["lstNangMemKhac"].ToString(), jss);
            request.lstDangKyTuVan = JsonConvert.DeserializeObject<List<LbDangKyTuVan>>(Request.Form["lstDangKyTuVan"].ToString(), jss);
            request.lstDangKyCungUng = JsonConvert.DeserializeObject<List<LbDangKyCungUng>>(Request.Form["lstDangKyCungUng"].ToString(), jss);
            request.lstGioiThieuCungUng = JsonConvert.DeserializeObject<List<LbGioiThieuCungUng>>(Request.Form["lstGioiThieuCungUng"].ToString(), jss);
            request.lstHinhThucTuyenDung = JsonConvert.DeserializeObject<List<LbHinhThucTuyenDung>>(Request.Form["lstHinhThucTuyenDung"].ToString(), jss);
            request.lstKenhTiepNhanTT = JsonConvert.DeserializeObject<List<LbKenhTiepNhanTt>>(Request.Form["lstKenhTiepNhanTT"].ToString(), jss);
            request.lstKinhNghiem = JsonConvert.DeserializeObject<List<LbKinhNghiem>>(Request.Form["lstKinhNghiem"].ToString(), jss);
            request.lstCheDoPhucLoiKhac = JsonConvert.DeserializeObject<List<LbCheDoPhucLoiKhac>>(Request.Form["lstCheDoPhucLoiKhac"].ToString(), jss);                                  
            request.lstKhaNangDapUngAdd = JsonConvert.DeserializeObject<List<LbKhaNangDapUng>>(Request.Form["lstKhaNangDapUngAdd"].ToString(), jss);
            request.lstTrinhDoCmktkhac = JsonConvert.DeserializeObject<List<LbTrinhDoCmktkhac>>(Request.Form["lstTrinhDoCmktkhac"].ToString(), jss);
            return _business.LaborerCreate(request);
        }
        [HttpPost]
        [Route("LaborerUpdate")]
        [Authorize]
        public LaborerCreateResponse LaborerUpdate()
        {
            var jss = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Local,
                DateParseHandling = DateParseHandling.DateTimeOffset
            };
            LaborerCreateRequest request = new LaborerCreateRequest();
            request.AccountId = JsonConvert.DeserializeObject<int>(Request.Form["AccountId"].ToString(), jss);
            request.UserId = JsonConvert.DeserializeObject<string>(Request.Form["UserId"].ToString(), jss);
            request.Data = JsonConvert.DeserializeObject<LbNguoiLaoDong>(Request.Form["Model"].ToString(), jss);
            request.lstLoaiBaoHiem = JsonConvert.DeserializeObject<List<LbLoaiBaoHiem>>(Request.Form["lstLoaiBaoHiem"].ToString(), jss);
            request.lstDoiTuongUuTien = JsonConvert.DeserializeObject<List<LbDoiTuongUuTien>>(Request.Form["lstDoiTuongUuTien"].ToString(), jss);
            request.lstTrinhDoNgoaiNgu = JsonConvert.DeserializeObject<List<LbTrinhDoNgoaiNgu>>(Request.Form["lstTrinhDoNgoaiNgu"].ToString(), jss);
            request.lstKyNangMemKhac = JsonConvert.DeserializeObject<List<LbKyNangMemKhac>>(Request.Form["lstNangMemKhac"].ToString(), jss);
            request.lstDangKyTuVan = JsonConvert.DeserializeObject<List<LbDangKyTuVan>>(Request.Form["lstDangKyTuVan"].ToString(), jss);
            request.lstDangKyCungUng = JsonConvert.DeserializeObject<List<LbDangKyCungUng>>(Request.Form["lstDangKyCungUng"].ToString(), jss);
            request.lstGioiThieuCungUng = JsonConvert.DeserializeObject<List<LbGioiThieuCungUng>>(Request.Form["lstGioiThieuCungUng"].ToString(), jss);
            request.lstHinhThucTuyenDung = JsonConvert.DeserializeObject<List<LbHinhThucTuyenDung>>(Request.Form["lstHinhThucTuyenDung"].ToString(), jss);
            request.lstKenhTiepNhanTT = JsonConvert.DeserializeObject<List<LbKenhTiepNhanTt>>(Request.Form["lstKenhTiepNhanTT"].ToString(), jss);
            request.lstKinhNghiem = JsonConvert.DeserializeObject<List<LbKinhNghiem>>(Request.Form["lstKinhNghiem"].ToString(), jss);
            request.lstCheDoPhucLoiKhac = JsonConvert.DeserializeObject<List<LbCheDoPhucLoiKhac>>(Request.Form["lstCheDoPhucLoiKhac"].ToString(), jss);
            request.lstKhaNangDapUngAdd = JsonConvert.DeserializeObject<List<LbKhaNangDapUng>>(Request.Form["lstKhaNangDapUngAdd"].ToString(), jss);
            request.lstTrinhDoCmktkhac = JsonConvert.DeserializeObject<List<LbTrinhDoCmktkhac>>(Request.Form["lstTrinhDoCmktkhac"].ToString(), jss);
            return _business.LaborerUpdate(request);
        }

        [HttpPost]
        [Authorize]
        [Route("LaborerDelete")]
        public BaseResponse<ResponseStatus> DeleteLaborer(DeleteLaborer request)
        {
            return _business.DeleteLaborer(request);
        }
        [HttpPost]
        [Route("LbTrinhDoCmktkhac_Delete")]
        [Authorize]
        public BaseResponse<ResponseStatus> LbTrinhDoCmktkhac_Delete(LaborerGetByIdRequest request)
        {
            return _business.LbTrinhDoCmktkhac_Delete(request);
        }

        [HttpPost]
        [Route("LbTrinhDoNgoaiNgu_Delete")]
        [Authorize]
        public BaseResponse<ResponseStatus> LbTrinhDoNgoaiNgu_Delete(LaborerGetByIdRequest request)
        {
            return _business.LbTrinhDoNgoaiNgu_Delete(request);
        }

        [HttpPost]
        [Route("LbTrinhDoTinHocKhac_Delete")]
        [Authorize]
        public BaseResponse<ResponseStatus> LbTrinhDoTinHocKhac_Delete(LaborerGetByIdRequest request)
        {
            return _business.LbTrinhDoTinHocKhac_Delete(request);
        }

        [HttpPost]
        [Route("LbTrinhDoKhac_Delete")]
        [Authorize]
        public BaseResponse<ResponseStatus> LbTrinhDoKhac_Delete(LaborerGetByIdRequest request)
        {
            return _business.LbTrinhDoKhac_Delete(request);
        }

        [HttpPost]
        [Route("LbKinhNghiem_Delete")]
        [Authorize]
        public BaseResponse<ResponseStatus> LbKinhNghiem_Delete(LaborerGetByIdRequest request)
        {
            return _business.LbKinhNghiem_Delete(request);
        }

        [HttpPost]
        [Route("LbNoiLamViecUuTien_Delete")]
        [Authorize]
        public BaseResponse<ResponseStatus> LbNoiLamViecUuTien_Delete(LaborerGetByIdRequest request)
        {
            return _business.LbNoiLamViecUuTien_Delete(request);
        }
        [HttpPost]
        [Route("LaborerUpdateOnly")]
        public LaborerCreateResponse LaborerUpdateOnly(LaborerCreateRequest request)
        {
            return _business.LaborerUpdateOnly(request);
        }


        [HttpPost]
        [Route("LaborerUpdateLoaiBaoHiem")]
        public BaseResponse<ResponseStatus> LbBaoHiemUpdate(LbBaoHiemRequest request)
        {
            return _business.LbBaoHiemUpdate(request);
        }

        [HttpPost]
        [Route("LaborerUpdateDangKyCungUng")]
        public BaseResponse<ResponseStatus> LbDangKyCungUngUpdate(LbDangKyCungUngRequest request)
        {
            return _business.LbDangKyCungUngUpdate(request);
        }

        [HttpPost]
        [Route("LaborerUpdateDangKyTuVan")]
        public BaseResponse<ResponseStatus> LbDangKyTuVanUpdate(LbDangKyTuVanRequest request)
        {
            return _business.LbDangKyTuVanUpdate(request);
        }

        [HttpPost]
        [Route("LaborerUpdateGioiThieuCungUng")]
        public BaseResponse<ResponseStatus> LbGioiThieuCungUngUpdate(LbGioiThieuCungUngRequest request)
        {
            return _business.LbGioiThieuCungUngUpdate(request);
        }

        [HttpPost]
        [Route("LaborerUpdateHinhThucTuyenDung")]
        public BaseResponse<ResponseStatus> LbHinhThucTuyenDungUpdate(LbHinhThucTuyenDungRequest request)
        {
            return _business.LbHinhThucTuyenDungUpdate(request);
        }

        [HttpPost]
        [Route("LaborerUpdateKenhTiepNhanTT")]
        public BaseResponse<ResponseStatus> LbKenhTiepNhanThongTinUpdate(LbKenhTiepNhanThongTinRequest request)
        {
            return _business.LbKenhTiepNhanThongTinUpdate(request);
        }

        [HttpPost]
        [Route("LaborerUpdateDoiTuongUuTien")]
        public BaseResponse<ResponseStatus> LbDoiTuongUuTienUpdate(LbDoiTuongUuTienRequest request)
        {
            return _business.LbDoiTuongUuTienUpdate(request);
        }

        [HttpPost]
        [Route("LaborerUpdateKyNangMem")]
        public BaseResponse<ResponseStatus> LbKyNangMemUpdate(LbKyNangMemRequest request)
        {
            return _business.LbKyNangMemUpdate(request);
        }
        [HttpGet]
        [Route("GetListNguoiKiemDuyetOnline")]
        [Authorize]
        public NguoiLaoDongKiemDuyetOnlineResponse GetListNguoiKiemDuyetOnline()
        {
            return _business.GetListNguoiKiemDuyetOnline();
        }
        [HttpPost]
        [Route("GetListDangKySessionDetailLaborer")]
        [Authorize]
        public LaborerGetListDangKySessionDetailResponse GetListDangKySessionDetailLaborer(LaborerGetListDangKySessionDetailRequest request)
        {
            return _business.GetListDangKySessionDetailLaborer(request);
        }
        [HttpGet]
        [Route("GetDropDiemSan")]
        public DiemSanDropDownReponse GetDropDiemSan()
        {
            return _business.GetDropDiemSan();
        }
        [HttpPost]
        [Route("SessionDetailLaborerXacNhan")]
        public SessionDetailLaborerXacNhanReponse SessionDetailLaborerXacNhan(SessionDetailLaborerXacNhanRequest request)
        {
            return _business.SessionDetailLaborerXacNhan(request);
        }
        [HttpPost]
        [Route("SessionDetailLaborerCreate")]
        public SessionDetailLaborerXacNhanReponse SessionDetailLaborerCreate(SessionDetailLaborerCreateRequest request)
        {
            return _business.SessionDetailLaborerCreate(request);
        }
    }
}