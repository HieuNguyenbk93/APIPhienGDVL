using AutoMapper;
using Common.Constants;
using Interfaces.Base;
using Interfaces.Models.PgdXacNhanDn;
using Model;
using Repositories.Commons;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Implements
{
    public class PgdDnDataAccess
    {
        private readonly IMapper _mapper;
        private SV_DBContext db;
        public PgdDnDataAccess(IMapper mapper)
        {
            _mapper = mapper;
        }
        public PgdDnGetByIdResponse PgdDnGetByIdPhien (PgdDnGetByIdRequest request)
        {
            using (var db = new SV_DBContext())
            {
                try
                {
                    List<PgdXacNhanDN> dataDangKy = db.PgdXacNhanDN.Where(x => x.PhienGiaoDichId == request.Id && x.Type == true).ToList();
                    List<PgdXacNhanDN> dataDuocMoi = db.PgdXacNhanDN.Where(x => x.PhienGiaoDichId == request.Id && x.Type == false).ToList();
                    return new PgdDnGetByIdResponse
                    {
                        Status = ResponseStatus.Susscess,
                        PgdDnDangKy = dataDangKy,
                        PgdDnDuocMoi = dataDuocMoi,
                    };
                }
                catch (Exception ex)
                {
                    return new PgdDnGetByIdResponse
                    {
                        Status = ResponseStatus.Fail,
                        Message = ex.Message,
                    };
                }
            }
        }
        public BaseResponse<ResponseStatus> PgdDnDuocMoiCreate (PgdDnCreateRequest request)
        {
            db = new SV_DBContext();
            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    request.listNhaTuyenDungInvite.ForEach((element) =>
                    {
                        var model = _mapper.Map<PgdXacNhanDN>(element);
                        model.NguoiTao = request.AccountId;
                        model.NgayTao = DateTime.Now;
                        var result = db.PgdXacNhanDN.Add(model);
                        //LogHelper.InsertSystemLogging(request.UserId, LogAction.Add, IPCommons.GetLocalIPAddress(), IPCommons.GetMacAddress(), $"Create DnDuocMoi {element.NTDId} tham gia phien giao dich {element.PhienGiaoDichId}", null, "DetailPHieGiaoDich/DoanhNghiepDuocMoi", true);
                        var his = new HisDnDuocMoi();
                        his.Id = 0;
                        his.ObjectId = element.NTDId.Value;
                        his.Contents = "Doanh nghiệp được mời tham gia";
                        his.CreatedBy = request.AccountId;
                        his.CreatedDate = DateTime.Now;
                        var result1 = db.HisDnDuocMoi.Add(his);
                        //LogHelper.InsertSystemLogging(request.UserId, LogAction.Add, IPCommons.GetLocalIPAddress(), IPCommons.GetMacAddress(), $"Create HisDnDuocMoi DoanhNghiepId:{element.NTDId}", null, "DetailPhienGiaoDich/DoanhNghiepDuocMoi", true);
                    });
                    db.SaveChanges();
                    tran.Commit();
                    return new BaseResponse<ResponseStatus>
                    {
                        Status = ResponseStatus.Susscess,
                        Message = "Tạo mới thành công",
                    };
                }
                catch (Exception ex)
                {
                    //LogHelper.InsertSystemLogging(request.UserId, LogAction.Add, IPCommons.GetLocalIPAddress(), IPCommons.GetMacAddress(), $"Create DnDangKy in DetailPhienGiaoDich", ex, "DetailPhienGiaoDich/DoanhNghiepDangKy", false);
                    tran.Rollback();
                    return new BaseResponse<ResponseStatus>
                    {
                        Status = ResponseStatus.Fail,
                        Message = ex.Message,
                    };
                }
            }
        }

        public BaseResponse<ResponseStatus> PgdDnDangKyUpdate (PgdDnCreateRequest request)
        {
            db = new SV_DBContext();
            try
            {
                var model = _mapper.Map<PgdXacNhanDN>(request.listNhaTuyenDungInvite[0]);
                var result = db.PgdXacNhanDN.Update(model);
                //LogHelper.InsertSystemLogging(request.UserId, LogAction.Add, IPCommons.GetLocalIPAddress(), IPCommons.GetMacAddress(), $"Update DnDangKy {model.NTDId} tham gia phien giao dich {model.PhienGiaoDichId}", null, "DetailPhieGiaoDich/DoanhNghiepDangKy", true);
                var his = new HisDnDangKy();
                his.Id = 0;
                his.ObjectId = model.NTDId.Value;
                if (model.ThamGiaPhien.Value)
                {
                    his.Contents = "Xác nhận tham gia";
                    his.Status = 2;
                }
                else
                {
                    his.Contents = "Từ chối tham gia";
                    his.Status = 3;
                }
                his.CreatedBy = request.AccountId;
                his.CreatedDate = DateTime.Now;
                var result1 = db.HisDnDangKy.Add(his);
                //LogHelper.InsertSystemLogging(request.UserId, LogAction.Add, IPCommons.GetLocalIPAddress(), IPCommons.GetMacAddress(), $"Create HisDnDangKy DoanhNghiepId:{model.NTDId}", null, "DetailPhienGiaoDich/DoanhDangKy", true);
                db.SaveChanges();
                return new BaseResponse<ResponseStatus>
                {
                    Status = ResponseStatus.Susscess,
                    Message = "Cập nhật thành công",
                };
            }
            catch (Exception ex)
            {
                //LogHelper.InsertSystemLogging(request.UserId, LogAction.Add, IPCommons.GetLocalIPAddress(), IPCommons.GetMacAddress(), $"Update DnDangKy in DetailPhienGiaoDich", ex, "DetailPhienGiaoDich/DoanhNghiepDangKy", false);
                return new BaseResponse<ResponseStatus>
                {
                    Status = ResponseStatus.Fail,
                    Message = ex.Message,
                };
            }
        }

        public HisDnDuocMoiByDnIdResponse HisDnDuocMoiGetByIdDn (long DoanhNghiepId)
        {
            db = new SV_DBContext();
            try
            {
                var result = db.HisDnDuocMoi.Where(x => x.ObjectId == DoanhNghiepId).OrderByDescending(x => x.CreatedDate).ToList();
                return new HisDnDuocMoiByDnIdResponse
                {
                    Status = ResponseStatus.Susscess,
                    ListHisDnDuocMoi = result,
                };
            }
            catch (Exception ex)
            {
                return new HisDnDuocMoiByDnIdResponse
                {
                    Status = ResponseStatus.Fail,
                    Message = ex.Message,
                };
            }
        }

        public HisDnDangKyByDnIdResponse HisDnDangKyGetByIdDn (long DoanhNghiepId)
        {
            db = new SV_DBContext();
            try
            {
                var result = db.HisDnDangKy.Where(x => x.ObjectId == DoanhNghiepId).OrderByDescending(x => x.CreatedDate).ToList();
                return new HisDnDangKyByDnIdResponse
                {
                    Status = ResponseStatus.Susscess,
                    ListHisDnDangKy = result,
                };
            }
            catch (Exception ex)
            {
                return new HisDnDangKyByDnIdResponse
                {
                    Status = ResponseStatus.Fail,
                    Message = ex.Message,
                };
            }
        }

        //public Pgd_XacNhanDnGetListResponse PgdDnSearch(PgdDnSearchDnRequest request)
        //{
        //    db = new SV_DBContext();
        //    //var list = db.PgdXacNhanDN
        //    //            .Where(x => x.PhienGiaoDichId == request.PhienGiaoDichd && x.Type == request.Type)
        //    var table = db.PgdXacNhanDN.Where(x => x.PhienGiaoDichId == request.PhienGiaoDichd && x.Type == request.Type);
        //    var data = (from xndn in table
        //                join qlntd in db.QlNhaTuyenDung on xndn.NTDId equals qlntd.Id
        //                where !qlntd.IsDeleted
        //                && (string.IsNullOrEmpty(request.Name) || qlntd.Ten.Contains(request.Name))
        //                select new PgdDnView
        //                {
        //                    Id = xndn.Id,
        //                    PhienGiaoDichId = xndn.PhienGiaoDichId,
        //                    BusinessId = xndn.BusinessId,
        //                    NTDId = xndn.NTDId,
        //                    Type = xndn.Type,

        //                }).ToList();
        //}
    }
}
