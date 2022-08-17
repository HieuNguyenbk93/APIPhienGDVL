using AutoMapper;
using Interfaces;
using Interfaces.Models.Tradingsession;
using Model.ModelExpenseds;
using Repositories.Implements;


namespace BusinessLogic.Implements
{
    public class TradingsessionBusinessLogic : ITradingsessionBusinessLogic
    {
        TradingsessionDataAccess _dataAccess;
        public TradingsessionBusinessLogic(IMapper mapper)
        {
            _dataAccess = new TradingsessionDataAccess(mapper);
        }
        public HinhThucPhienDropDownResponse getDropDownHinhThucPhien(int id)
        {
            return _dataAccess.getDropDownHinhThucPhien(id);
        }
        public TradingsessionGetListResponse TradingsessionGetList(int Id, string tieuDe, int HinhThucId, string thoigian_bd, string thoigian_kt,
            string hangdangky_bd, string handangky_kt, int TrangThaiCongBoId, int PageIndex, int PageSize)
        {
            return _dataAccess.TradingsessionGetList(Id, tieuDe, HinhThucId, thoigian_bd, thoigian_kt,
                hangdangky_bd, handangky_kt, TrangThaiCongBoId, PageIndex, PageSize);
        }
        public int TradingsessionUpdateStatus(TradddingsessionPutRequest request)
        {
            return _dataAccess.TradingsessionUpdateStatus(request);
        }
        public int TradingsessiononDelete(int Id)
        {
            return _dataAccess.TradingsessiononDelete(Id);
        }
        public bool TradingsessionCreate(TradingsessionGetListRequest request)
        {
            return _dataAccess.TradingsessionCreate(request);
        }
        public bool TradingsessionUpdate(TradingsessionGetListRequest request)
        {
            return _dataAccess.TradingsessionUpdate(request);
        }
        public TradingsessionGetListResponse TradingsessionGetById(int id)
        {
            return _dataAccess.TradingsessionGetById(id);
        }
        public TradingsessionGetListDetailResponse TradingsessionGetChitietphien(int id)
        {
            return _dataAccess.TradingsessionGetChitietphien(id);
        }
        public TradingsessionGetListDoanhNghiepResponse TradingsessionGetListDoanhNghiep(int id, int pageSize, int pageIndex, string tendoanhnghiep,
            string sodienthoai, string nhucautuyendung, string chitieutuyendung, int lichsugioithieu)
        {
            return _dataAccess.TradingsessionGetListDoanhNghiep(id, pageSize, pageIndex, tendoanhnghiep, sodienthoai, nhucautuyendung, chitieutuyendung, lichsugioithieu);
        }
        public TradingsessionGetListNguoilaodongResponse TradingsessionGetListNguoilaodong(int id, int pageSize, int pageIndex, string tennguoilaodong,
            string sodienthoai, string nhucautuyendung, string chitieutuyendung, int lichsugioithieu)
        {
            return _dataAccess.TradingsessionGetListNguoilaodong(id, pageSize, pageIndex, tennguoilaodong, sodienthoai, nhucautuyendung, chitieutuyendung, lichsugioithieu);
        }
    }
}
