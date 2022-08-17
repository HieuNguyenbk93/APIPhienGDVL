using AutoMapper;
using Common.Constants;
using Dapper;
using Interfaces.Models.Tradingsession;
using Model;
using Model.Expensed;
using Model.ModelExpenseds;
using Repositories.Bases;
using Repositories.Commons;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Repositories.Implements
{
    public class TradingsessionDataAccess
    {
        private readonly IMapper _mapper;
        public TradingsessionDataAccess(IMapper mapper)
        {
            _mapper = mapper;
        }

        public HinhThucPhienDropDownResponse getDropDownHinhThucPhien(int id)
        {
            using (IDbConnection db = new SqlConnection(ConnectionString.Connection))
            {
                try
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@Id", id);
                    var list = db.Query<DropDownObject>("DM_HinhThucPhien_getDropDownHinhThucPhien", parameters, null, true, null, CommandType.StoredProcedure).AsList();

                    return new HinhThucPhienDropDownResponse
                    {
                        Status = ResponseStatus.Susscess,
                        ListHinhThucPhien = list
                    };
                }
                catch (Exception ex)
                {

                    return new HinhThucPhienDropDownResponse
                    {
                        Status = ResponseStatus.Fail,
                        Message = ex.Message
                    };
                }
            }
        }

        public TradingsessionGetListResponse TradingsessionGetList(int Id, string tieuDe, int HinhThucId, string thoigian_bd, string thoigian_kt,
            string hangdangky_bd, string handangky_kt, int TrangThaiCongBoId, int PageIndex, int PageSize)
        {
            using (var connection = new SqlConnection(ConnectionString.Connection))
            {
                try
                {
                    var dynamic = new DynamicParameters();
                    dynamic.Add("HinhThucId", HinhThucId);
                    dynamic.Add("TieuDe", tieuDe);
                    dynamic.Add("thoigian_bd", thoigian_bd);
                    dynamic.Add("thoigian_kt", thoigian_kt);
                    dynamic.Add("hangdangky_bd", hangdangky_bd);
                    dynamic.Add("handangky_kt", handangky_kt);
                    dynamic.Add("TrangThaiCongBoId", TrangThaiCongBoId);                           
                    dynamic.Add("PageSize", PageSize);
                    dynamic.Add("PageIndex", PageIndex);
                    var list = connection.Query<TradingsessonGetList>("PGD_PhienGiaoDich_GetList", dynamic, null, true, null, CommandType.StoredProcedure).ToList();
                    return new TradingsessionGetListResponse
                    {
                        Status = ResponseStatus.Susscess,
                        Message = ResponseStatus.Susscess.ToString(),
                        ListTradingsesson = list,
                        TotalRecords = list.Count > 0 ? list[0].TotalRecords : 0,
                    };
                }
                catch (Exception ex)
                {
                    return new TradingsessionGetListResponse
                    {
                        Status = ResponseStatus.Fail,
                        Message = ex.Message,
                    };
                }
            }
        }
        public int TradingsessionUpdateStatus(TradddingsessionPutRequest request)
        {
            using (var connection = new SqlConnection(ConnectionString.Connection))
            {
                try
                {
                    var dynamic = new DynamicParameters();
                    dynamic.Add("Id", request.Id);          
                    connection.Query("PGD_PhienGiaoDich_UpdateStatus", dynamic, null, true, null, CommandType.StoredProcedure);
                    return 1;
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
        }
        public int TradingsessiononDelete(int Id)
        {
            using (var connection = new SqlConnection(ConnectionString.Connection))
            {
                try
                {
                    var dynamic = new DynamicParameters();
                    dynamic.Add("Id", Id);
                    connection.Query("PGD_PhienGiaoDich_onDelete", dynamic, null, true, null, CommandType.StoredProcedure);
                    return 1;
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
        }
        public bool TradingsessionCreate(TradingsessionGetListRequest request)
        {
            string thoigian_bd_str_full = request.thoigian_bd + " " + request.gio_bd_str + ":00";//10/08/2022 09:02:00
            string thoigian_bd_str_full_1 = thoigian_bd_str_full.Substring(3, 2) + "/" + //08/10/2022
            thoigian_bd_str_full.Substring(0, 2) + "/" +
            thoigian_bd_str_full.Substring(6, 4) + " " +
            thoigian_bd_str_full.Substring(11, 8);

            //DateTime thoigian_bd_date_full = Convert.ToDateTime(thoigian_bd_str_full);
            DateTime thoigian_bd_date_full = DateTime.Parse(thoigian_bd_str_full_1);

            string thoigian_kt_str_full = request.thoigian_kt + " " + request.gio_kt_str + ":00";
            string thoigian_kt_str_full_1 = thoigian_kt_str_full.Substring(3, 2) + "/" +
            thoigian_kt_str_full.Substring(0, 2) + "/" +
            thoigian_kt_str_full.Substring(6, 4) + " " +
            thoigian_kt_str_full.Substring(11, 8);

            //DateTime thoigian_kt_date_full = Convert.ToDateTime(thoigian_kt_str_full);
            DateTime thoigian_kt_date_full = DateTime.Parse(thoigian_kt_str_full_1);

            string hangdangky_str_full = request.hangdangky + " " + request.gio_handk_str + ":00";
            string hangdangky_str_full_1  = hangdangky_str_full.Substring(3, 2) + "/" +
            hangdangky_str_full.Substring(0, 2) + "/" +
            hangdangky_str_full.Substring(6, 4) + " " +
            hangdangky_str_full.Substring(11, 8);

            // DateTime hangdangky_date_full = Convert.ToDateTime(hangdangky_str_full);
            DateTime hangdangky_date_full = DateTime.Parse(hangdangky_str_full_1);


            using (var connection = new SqlConnection(ConnectionString.Connection))
            {
                try
                {
                    var dynamic = new DynamicParameters();
                    dynamic.Add("tieuDe", request.tieuDe);
                    dynamic.Add("hinhThucId", request.hinhThucId);
                    dynamic.Add("moTa", request.moTa);
                    dynamic.Add("thoigian_bd", thoigian_bd_date_full);
                    dynamic.Add("thoigian_kt", thoigian_kt_date_full);
                    dynamic.Add("hangdangky", hangdangky_date_full);
                    connection.Query("PGD_PhienGiaoDich_Create", dynamic, null, true, null, CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

        }
        public bool TradingsessionUpdate(TradingsessionGetListRequest request)
        {
            string thoigian_bd_str_full = request.thoigian_bd + " " + request.gio_bd_str + ":00";//10/08/2022 09:02:00
            string thoigian_bd_str_full_1 = thoigian_bd_str_full.Substring(3, 2) + "/" + //08/10/2022
            thoigian_bd_str_full.Substring(0, 2) + "/" +
            thoigian_bd_str_full.Substring(6, 4) + " " +
            thoigian_bd_str_full.Substring(11, 8);

            //DateTime thoigian_bd_date_full = Convert.ToDateTime(thoigian_bd_str_full);
            DateTime thoigian_bd_date_full = DateTime.Parse(thoigian_bd_str_full_1);

            string thoigian_kt_str_full = request.thoigian_kt + " " + request.gio_kt_str + ":00";
            string thoigian_kt_str_full_1 = thoigian_kt_str_full.Substring(3, 2) + "/" +
            thoigian_kt_str_full.Substring(0, 2) + "/" +
            thoigian_kt_str_full.Substring(6, 4) + " " +
            thoigian_kt_str_full.Substring(11, 8);

            //DateTime thoigian_kt_date_full = Convert.ToDateTime(thoigian_kt_str_full);
            DateTime thoigian_kt_date_full = DateTime.Parse(thoigian_kt_str_full_1);

            string hangdangky_str_full = request.hangdangky + " " + request.gio_handk_str + ":00";
            string hangdangky_str_full_1 = hangdangky_str_full.Substring(3, 2) + "/" +
            hangdangky_str_full.Substring(0, 2) + "/" +
            hangdangky_str_full.Substring(6, 4) + " " +
            hangdangky_str_full.Substring(11, 8);

            // DateTime hangdangky_date_full = Convert.ToDateTime(hangdangky_str_full);
            DateTime hangdangky_date_full = DateTime.Parse(hangdangky_str_full_1);


            using (var connection = new SqlConnection(ConnectionString.Connection))
            {
                try
                {
                    var dynamic = new DynamicParameters();
                    dynamic.Add("id", request.id);
                    dynamic.Add("tieuDe", request.tieuDe);
                    dynamic.Add("hinhThucId", request.hinhThucId);
                    dynamic.Add("moTa", request.moTa);
                    dynamic.Add("thoigian_bd", thoigian_bd_date_full);
                    dynamic.Add("thoigian_kt", thoigian_kt_date_full);
                    dynamic.Add("hangdangky", hangdangky_date_full);
                    connection.Query("PGD_PhienGiaoDich_Update", dynamic, null, true, null, CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

        }

        public TradingsessionGetListResponse TradingsessionGetById(int id)
        {            

            using (var connection = new SqlConnection(ConnectionString.Connection))
            {
                try
                {
                    var dynamic = new DynamicParameters();
                    dynamic.Add("Id", id);                   
                    var list = connection.Query<TradingsessonGetList>("PGD_PhienGiaoDich_GetById", dynamic, null, true, null, CommandType.StoredProcedure).ToList();
                    return new TradingsessionGetListResponse
                    {
                        Status = ResponseStatus.Susscess,
                        Message = ResponseStatus.Susscess.ToString(),
                        ListTradingsesson = list,
                        TotalRecords = list.Count > 0 ? list[0].TotalRecords : 0,
                    };
                }
                catch (Exception ex)
                {
                    return new TradingsessionGetListResponse
                    {
                        Status = ResponseStatus.Fail,
                        Message = ex.Message,
                    };
                }
            }
        }
        public TradingsessionGetListDetailResponse TradingsessionGetChitietphien(int id)
        {

            using (var connection = new SqlConnection(ConnectionString.Connection))
            {
                try
                {
                    var dynamic = new DynamicParameters();
                    dynamic.Add("Id", id);
                    var list = connection.Query<DetailTradingSession>("PGD_PhienGiaoDich_GetChitietphien", dynamic, null, true, null, CommandType.StoredProcedure).ToList();
                    return new TradingsessionGetListDetailResponse
                    {
                        Status = ResponseStatus.Susscess,
                        Message = ResponseStatus.Susscess.ToString(),
                        ListDetailTradingSession = list,                  
                    };
                }
                catch (Exception ex)
                {
                    return new TradingsessionGetListDetailResponse
                    {
                        Status = ResponseStatus.Fail,
                        Message = ex.Message,
                    };
                }
            }
        }
        public TradingsessionGetListDoanhNghiepResponse TradingsessionGetListDoanhNghiep(int id,int pageSize,int pageIndex, string tendoanhnghiep,
            string sodienthoai, string nhucautuyendung, string chitieutuyendung, int lichsugioithieu)
        {

            using (var connection = new SqlConnection(ConnectionString.Connection))
            {
                try
                {
                    var dynamic = new DynamicParameters();
                    dynamic.Add("Id", id);
                    dynamic.Add("PageSize", pageSize);
                    dynamic.Add("PageIndex", pageIndex);
                    dynamic.Add("tendoanhnghiep", tendoanhnghiep);
                    dynamic.Add("sodienthoai", sodienthoai);
                    dynamic.Add("nhucautuyendung", nhucautuyendung);
                    dynamic.Add("chitieutuyendung", chitieutuyendung);
                    dynamic.Add("lichsugioithieu", lichsugioithieu);
                    var list = connection.Query<TradingsessionDoanhNghiep>("PGD_PhienGiaoDich_GetListDoanhNghiep", dynamic, null, true, null, CommandType.StoredProcedure).ToList();
                    return new TradingsessionGetListDoanhNghiepResponse
                    {
                        Status = ResponseStatus.Susscess,
                        Message = ResponseStatus.Susscess.ToString(),
                        ListTradingsessionDoanhNghiep = list,
                        TotalRecords1 = list.Count > 0 ? list[0].TotalRecords1 : 0,
                    };
                }
                catch (Exception ex)
                {
                    return new TradingsessionGetListDoanhNghiepResponse
                    {
                        Status = ResponseStatus.Fail,
                        Message = ex.Message,
                    };
                }
            }
        }

        public TradingsessionGetListNguoilaodongResponse TradingsessionGetListNguoilaodong(int id, int pageSize, int pageIndex, string tennguoilaodong,
            string sodienthoai, string nhucautuyendung, string chitieutuyendung, int lichsugioithieu)
        {
            using (var connection = new SqlConnection(ConnectionString.Connection))
            {
                try
                {
                    var dynamic = new DynamicParameters();
                    dynamic.Add("Id", id);
                    dynamic.Add("PageSize", pageSize);
                    dynamic.Add("PageIndex", pageIndex);
                    dynamic.Add("tennguoilaodong", tennguoilaodong);
                    dynamic.Add("sodienthoai", sodienthoai);
                    dynamic.Add("nhucautuyendung", nhucautuyendung);
                    dynamic.Add("chitieutuyendung", chitieutuyendung);
                    dynamic.Add("lichsugioithieu", lichsugioithieu);
                    var list = connection.Query<TradingsessionNguoilaodong>("PGD_PhienGiaoDich_GetListNguoilaodong", dynamic, null, true, null, CommandType.StoredProcedure).ToList();
                    return new TradingsessionGetListNguoilaodongResponse
                    {
                        Status = ResponseStatus.Susscess,
                        Message = ResponseStatus.Susscess.ToString(),
                        ListTradingsessionNguoilaodong = list,
                        TotalRecords2 = list.Count > 0 ? list[0].TotalRecords2 : 0,
                    };
                }
                catch (Exception ex)
                {
                    return new TradingsessionGetListNguoilaodongResponse
                    {
                        Status = ResponseStatus.Fail,
                        Message = ex.Message,
                    };
                }
            }
        }

    }

}
