using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Expensed
{
    public class BS_NguoiSdLaoDongObject
    {
        public long Id { get; set; }
        public string Ma { get; set; }
        public long? NhaTuyenDungId { get; set; }
        public string Ten { get; set; }
        public bool ChuTheTuyenDung { get; set; }
        public string Cmnd { get; set; }
        public int LoaiDoanhNghiep { get; set; }
        public string Kcn { get; set; }
        public string DiaChi { get; set; }
        public int HuyenId { get; set; }
        public int XaId { get; set; }
        public int TinhId { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public int NganhKinhDoanh { get; set; }
        public string SanPham { get; set; }
        public byte QuyMoLd { get; set; }
        public bool? CapNhatCv { get; set; }
        public string DaiDien { get; set; }
        public string SdtLh { get; set; }
        public string EmailLh { get; set; }
        public int? ChucVu { get; set; }
        public string TenCongViec { get; set; }
        public int? SoLuongTuyen { get; set; }
        public string NhiemVu { get; set; }
        public string TrachNhiem { get; set; }
        public string QuyenHan { get; set; }
        public string YeuCauKhac { get; set; }
        public int? MaNghe { get; set; }
        public int? ChucDanh { get; set; }
        public byte? NoiLamViec { get; set; }
        public string NoiLamViecKhac { get; set; }
        public string NuocNgoai { get; set; }
        public byte? TrinhDoHocVan { get; set; }
        public byte? TrinhDoCmkt { get; set; }
        public string ChuyenNganh { get; set; }
        public byte? TrinhDoNgoaiNgu { get; set; }
        public byte? KyNangCntt { get; set; }
        public byte? MangXaHoi { get; set; }
        public byte? TheThao { get; set; }
        public byte? VanNghe { get; set; }
        public byte? XaHoi { get; set; }
        public byte? TrinhDoTinHoc { get; set; }
        public int? YeuCauKinhNghiem { get; set; }
        public byte? LoaiHopDong { get; set; }
        public string LoaiHopDongKhac { get; set; }
        public byte? YeuCauThem { get; set; }
        public string YeuCauThoiGianKhac { get; set; }
        public byte? TinhChatCongViec { get; set; }
        public string TinhChatCongViecKhac { get; set; }
        public byte? MucLuong { get; set; }
        public decimal? LuongNgay { get; set; }
        public decimal? LuongGio { get; set; }
        public byte? HoTroAn { get; set; }
        public byte? ThangTien { get; set; }
        public string ThangTienKhac { get; set; }
        public byte? TangLuong { get; set; }
        public byte? LamThem { get; set; }
        public byte? NoiLamViecKn { get; set; }
        public byte? TrongLuongNang { get; set; }
        public byte? ThinhLuc { get; set; }
        public byte? ThiLuc { get; set; }
        public byte? ThaoTacTay { get; set; }
        public byte TrangThai { get; set; }
        public bool? TrungLap { get; set; }
        public bool Xoa { get; set; }
        public bool? Online { get; set; }
        public bool? CopyThongTin { get; set; }
        public int? NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public int? NguoiCapNhat { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public int? NguoiTiepNhan { get; set; }
        public DateTime? NgayTiepNhan { get; set; }
        public short? SoLuongCungUng { get; set; }
        public short? SoLanDaCungUng { get; set; }
        public DateTime? NgayHieuLuc { get; set; }
        public bool? DaCungUngTrongDot { get; set; }
        public int? DiemSanId { get; set; }
    }
}
