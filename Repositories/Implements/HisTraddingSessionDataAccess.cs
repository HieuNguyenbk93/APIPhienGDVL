using AutoMapper;
using Dapper;
using Interfaces.Models.Business;
using Repositories.Bases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Data;
using System.Linq;
using Common.Constants;
using Interfaces.Base;
using Repositories.Commons;
using Repositories.Entities;
using Org.BouncyCastle.Asn1.Crmf;
using Model;
using Model.Expensed;
using Interfaces.Models.Tradingsession;
namespace Repositories.Implements
{
   public class HisTraddingSessionDataAccess
    {
        private readonly IMapper _mapper;
        public HisTraddingSessionDataAccess(IMapper mapper)
        {
            _mapper = mapper;
        }
        public BaseResponse<ResponseStatus> Create(UpdateStatusByIdBusinessRequest request)
        {
            try
            {
                using (var context = new SV_DBContext())
                {
                    var data = new HIS_PhienGiaoDich();                                       
                    if(request.TrangThai == 1)
                    {
                        //them moi               
                        data.ObjectId = GetMaxTraddingSessionId();
                    }
                    else
                    {
                        data.ObjectId = request.Id;
                    }
                   
                    data.Contents = request.NoiDung;
                    data.Status = request.TrangThai;
                    data.Type = request.Loai;
                    data.CreatedBy = request.AccountId;
                    data.CreatedDate = DateTime.Now;
                    context.HIS_PhienGiaoDich.Add(data);
                    context.SaveChanges();

                }
                return new BaseResponse<ResponseStatus>
                {
                    Status = ResponseStatus.Susscess
                };
            }
            catch (Exception e)
            {
                return new BaseResponse<ResponseStatus>
                {
                    Status = ResponseStatus.Fail,
                    Message = e.Message + " - " + e.InnerException
                };
            }
        }
        public int GetMaxTraddingSessionId()
        {
            using (var connection = new SqlConnection(ConnectionString.Connection))
            {
                try
                {
                    var dynamic = new DynamicParameters();               
                    var kq = connection.Query<int>("PGD_PhienGiaoDich_GetMaxId", dynamic, null, true, null, CommandType.StoredProcedure).FirstOrDefault();
                    return kq;
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
        }
        public BusinessHistoryByIdGetListResponse GetListHistory(int id, string fromdate, string todate, int pageindex, int pagesize)
        {
            using (var connection = new SqlConnection(ConnectionString.Connection))
            {
                try
                {
                    var dynamic = new DynamicParameters();
                    dynamic.Add("@Id", id);
                    dynamic.Add("@fromdate", fromdate);
                    dynamic.Add("@todate", todate);
                    dynamic.Add("@pageSize", pagesize);
                    dynamic.Add("@pageIndex", pageindex);
                    var list = connection.Query<ListHistoryById>("HIS_PhienGiaoDich_GetListHistory", dynamic, null, true, null, CommandType.StoredProcedure).ToList();
                    return new BusinessHistoryByIdGetListResponse
                    {
                        Status = ResponseStatus.Susscess,
                        Message = ResponseStatus.Susscess.ToString(),
                        ListData = list,
                        TotalRecords = list.Count > 0 ? list[0].TotalRecords : 0,
                    };
                }
                catch (Exception ex)
                {
                    return new BusinessHistoryByIdGetListResponse
                    {
                        Status = ResponseStatus.Fail,
                        Message = ex.Message,
                    };
                }
            }
        }
    }
}
