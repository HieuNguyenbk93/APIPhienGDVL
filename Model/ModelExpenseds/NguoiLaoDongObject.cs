using System;
using System.Collections.Generic;
using System.Text;

namespace Model.ModelExpenseds
{
    public class NguoiLaoDongObject
    {
        public long Id { get; set; }
        public string Ma { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Cmnd { get; set; }
        public bool GioiTinh { get; set; }
        public int? DanToc { get; set; }
        public string TonGiao { get; set; }
        public string DiaChiTt { get; set; }
        public string DiaChiTtCt { get; set; }
        public int? HuyenTtId { get; set; }
        public int? XaTtId { get; set; }
        public int? TinhTtId { get; set; }
        public string DiaChiHt { get; set; }
        public string DiaChiHtCt { get; set; }
        public int? HuyenHtId { get; set; }
        public int? XaHtId { get; set; }
        public int? TinhHtId { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public string LienHeKhac { get; set; }
        public int? DtUuTien { get; set; }
        public byte? TrinhDoHocVan { get; set; }
        public int? TrinhDoCmkt { get; set; }
        public string ChuyenNganh { get; set; }
        public string KyNangNghe { get; set; }
        public string BacKyNangNghe { get; set; }
        public string TrinhDoTinHoc { get; set; }
        public byte? KhaNangTinHoc { get; set; }
        public string LamViecNuocNgoai { get; set; }
        public byte? LoaiBh { get; set; }
        public int? LoaiDoanhNghiep { get; set; }
        public string TenCongViec { get; set; }
        public string MoTaCongViec { get; set; }
        public int? MaCongViec { get; set; }
        public int? ChucVu { get; set; }
        public int? KinhNghiem { get; set; }
        public int? NganhKtUuTien { get; set; }
        public byte? LoaiHopDong { get; set; }
        public byte? KhaNangDapUng { get; set; }
        public bool? HinhThucLamViec { get; set; }
        public byte? MucDich { get; set; }
        public byte? MucLuong { get; set; }
        public byte? HoTroAn { get; set; }
        public byte? NoiLamViec { get; set; }
        public byte? TrongLuong { get; set; }
        public byte? DungHoacDi { get; set; }
        public byte? NgheNoi { get; set; }
        public bool? ThiLuc { get; set; }
        public byte? ThaoTacTay { get; set; }
        public byte? DungHaiTay { get; set; }
        public bool? SanSangLamViec { get; set; }
        public int? LamViecSau { get; set; }
        public byte? HinhThucTuyenDung { get; set; }
        public byte? TrangThai { get; set; }
        public int? NguoiThuThap { get; set; }
        public DateTime? NgayThuThap { get; set; }
        public int? NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public int? NguoiCapNhat { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public decimal? LuongNgay { get; set; }
        public decimal? LuongGio { get; set; }
        public string AnhDaiDien { get; set; }
        public bool Xoa { get; set; }
        public int? UngVienId { get; set; }
        public bool? TrungLap { get; set; }
    }
}
