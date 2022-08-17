using Dapper;
using Model.ModelExpenseds;
using Repositories.Bases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Text.RegularExpressions;

namespace WebApi.ExportGrid
{
    public class ExportUser
    {
        public string HoTen { get; set; }
        public string TenDangNhap { get; set; }
        public string DienThoai { get; set; }
        public string PhongBan { get; set; }
        public int? DepId { get; set; }
    }
    public class ExportUserByDep
    {
        public string TenDangNhap { get; set; }
        public string HoTen { get; set; }
        public string ChucVu { get; set; }
        public string DienThoai { get; set; }
        public string PhongBan { get; set; }
        public int? TrangThai { get; set; }
    }
    public class DataLayer
    {
        public static string MaKN { get; set; }
        public static int ThoiGian { get; set; }
        public static int UnitId { get; set; }
        public static int Department { get; set; }
        public static int UserId { get; set; }
        public static int IsTongHop { get; set; }
    }
    public class ReportNghiQuyet
    {
        public int? TrangThai { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? Nam { get; set; }
        public int? NhiemKy { get; set; }
        public DateTime? NgayIn { get; set; }
        public string UserName { get; set; }
    }
    public class ReportSessionDetailLaborer
    {
        public int? UserProcessId { get; set; }
        public int? UserProcessName { get; set; }
        public int PhienId { get; set; }
        public string Ten { get; set; }
        public string Title { get; set; }
        public string SoDienThoai { get; set; }
        public bool? HinhThuc { get; set; }
        public int? DiaDiem { get; set; }
        public bool? ThamGiaPhien { get; set; }
        public bool Type { get; set; }
        public string Email { get; set; }
        public string NhuCauViecLam { get; set; }
        public int? TrangThai { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    } 
    public class EmployerOnlineExport
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string Cmnd { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string TenCongViec { get; set; }
        public string SoLuongTuyen { get; set; }
        public int? NguoiCapNhat { get; set; }
        public int? DiemSanId { get; set; }
    } 
    public class LaborerOnlineExport
    {
        public string Ma { get; set; }
        public string HoTen { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }
        public string TenCongViec { get; set; }
        public int? TrangThai { get; set; }
    }
    public class NhaTuyenDungExport
    {
        public string Ten { get; set; }
        public string CMND { get; set; }
        public int? LoaiHinh { get; set; }
        public int? KdChinh { get; set; }
        public string DiaChi { get; set; }
        public string NhuCau { get; set; }
        public int? TrangThai { get; set; }
    }
    public class TradingsessionDoanhNghiepExport
    {
        public int Id { get; set; }
        public string tittle { get; set; }      
    }
    public class UngVienExport
    {
        public string HoTen { get; set; }
        public string CMND { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string NhuCau { get; set; }
        public int? TrangThai { get; set; }
    }
}
