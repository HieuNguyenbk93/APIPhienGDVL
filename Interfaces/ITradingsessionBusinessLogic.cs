using Interfaces.Models.Tradingsession;
using Model.ModelExpenseds;

namespace Interfaces
{
    public interface ITradingsessionBusinessLogic
    {
        HinhThucPhienDropDownResponse getDropDownHinhThucPhien(int id);
        TradingsessionGetListResponse TradingsessionGetList(int Id, string tieuDe, int HinhThucId, string thoigian_bd, string thoigian_kt,
            string hangdangky_bd, string handangky_kt, int TrangThaiCongBoId, int PageIndex, int PageSize);
        int TradingsessionUpdateStatus(TradddingsessionPutRequest request);
        int TradingsessiononDelete(int Id);
        bool TradingsessionCreate(TradingsessionGetListRequest request);
        bool TradingsessionUpdate(TradingsessionGetListRequest request);
        TradingsessionGetListResponse TradingsessionGetById(int id);
        TradingsessionGetListDetailResponse TradingsessionGetChitietphien(int id);
        TradingsessionGetListDoanhNghiepResponse TradingsessionGetListDoanhNghiep(int id, int pageSize, int pageIndex, string tendoanhnghiep,
            string sodienthoai, string nhucautuyendung, string chitieutuyendung, int lichsugioithieu);
        TradingsessionGetListNguoilaodongResponse TradingsessionGetListNguoilaodong(int id, int pageSize, int pageIndex, string tennguoilaodong,
            string sodienthoai, string nhucautuyendung, string chitieutuyendung, int lichsugioithieu);
    }
}
