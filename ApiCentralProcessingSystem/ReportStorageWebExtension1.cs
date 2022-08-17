using AutoMapper;
using Dapper;
using DevExpress.XtraReports.UI;
using WebApi.ExportGrid;
using Repositories.Bases;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Web;
using Newtonsoft.Json;

namespace WebApi
{
    public class ReportStorageWebExtension1 : DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension
    {
        //private readonly IMapper _mapper;
        public class ReportDetails
        {
            public byte[] Layout { get; set; }
            public string DisplayName { get; set; }
        }
        public EmbeddedResourceReportStorageService EmbeddedResourceReportStorage { get; private set; }
        public ConcurrentDictionary<string, ReportDetails> Reports { get; private set; }

        IEnumerable<string> reportUrlsFromAssemblies;
        IEnumerable<string> ReportsFromResources
        {
            get
            {
                if (reportUrlsFromAssemblies == null)
                {
                    reportUrlsFromAssemblies = EmbeddedResourceReportStorage.Assemblies.SelectMany(x => x.GetManifestResourceNames());
                }
                return reportUrlsFromAssemblies;
            }
        }

        public ReportStorageWebExtension1(IMapper mapper)
        {

            Reports = new ConcurrentDictionary<string, ReportDetails>();
            EmbeddedResourceReportStorage = new EmbeddedResourceReportStorageService { Assemblies = new Assembly[] { Assembly.GetExecutingAssembly() } };

        }

        public override bool CanSetData(string url)
        {
            // Determines whether or not it is possible to store a report by a given URL. 
            // For instance, make the CanSetData method return false for reports that should be read-only in your storage. 
            // This method is called only for valid URLs (i.e., if the IsValidUrl method returned true) before the SetData method is called.

            return true;
        }

        public override bool IsValidUrl(string url)
        {
            // Determines whether or not the URL passed to the current Report Storage is valid. 
            // For instance, implement your own logic to prohibit URLs that contain white spaces or some other special characters. 
            // This method is called before the CanSetData and GetData methods.

            return true;
        }

        public override byte[] GetData(string url)
        {
            // Returns report layout data stored in a Report Storage using the specified URL. 
            // This method is called only for valid URLs after the IsValidUrl method is called.
            string newUrl = "http://www.example.com/" + url;
            Uri myUri = new Uri(newUrl);
            var jss = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Local,
                DateParseHandling = DateParseHandling.DateTimeOffset
            };

            string reportname = myUri.AbsolutePath.ToString().Replace('/', ' ');
            var assembly = typeof(WebApi.ReportStorageWebExtension1).Assembly;
            string DepId = "", UserName = "";
            string UserId = HttpUtility.ParseQueryString(myUri.Query).Get("UserId");
            string objectReport = "";
            if (UserId != null)
            {
                using (IDbConnection db = new SqlConnection(ConnectionString.Connection))
                {
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@UserId", UserId);

                    UserName = db.Query<string>("HT_NguoiDung_getTenbyId", param, null, true, null, CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            else
            {
                try
                {
                    objectReport = url.Split('?')[1];

                }
                catch
                {

                }
            }
            Stream resource = null;
            XtraReport result = null;
            MemoryStream ms = new MemoryStream();
            string Dates = "Ngày " + DateTime.Now.Day + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year;
            using (IDbConnection db = new SqlConnection(ConnectionString.Connection))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@UserId", UserId);

                UserName = db.Query<string>("HT_NguoiDung_getTenbyId", param, null, true, null, CommandType.StoredProcedure).FirstOrDefault();
            }

            DynamicParameters parameters = new DynamicParameters();
            switch (reportname.Trim())
            {

                case "ExportSessionDetailLaborer":
                    var param = JsonConvert.DeserializeObject<ReportSessionDetailLaborer>(objectReport, jss);
                    resource = assembly.GetManifestResourceStream("ApiCentralProcessingSystem.ExportGrid.SessionDetailLaborerExport.repx");
                    result = XtraReport.FromStream(resource);
                    result.Parameters["PhienId"].Value = param.PhienId;
                    result.Parameters["Ten"].Value = param.Ten;
                    result.Parameters["SoDienThoai"].Value = param.SoDienThoai;
                    result.Parameters["HinhThuc"].Value = param.HinhThuc;
                    result.Parameters["DiaDiem"].Value = param.DiaDiem;
                    result.Parameters["ThamGiaPhien"].Value = param.ThamGiaPhien;
                    result.Parameters["Email"].Value = param.Email;
                    result.Parameters["NhuCauViecLam"].Value = param.NhuCauViecLam;
                    result.Parameters["TrangThai"].Value = param.TrangThai;
                    result.Parameters["Type"].Value = param.Type;
                    result.Parameters["TrangThai"].Value = param.TrangThai;
                    result.Parameters["Type"].Value = param.Type;
                    result.Parameters["PageIndex"].Value = param.PageIndex;
                    result.Parameters["PageSize1"].Value = param.PageSize;
                    result.Parameters["Title1"].Value = param.Title;
                    result.SaveLayoutToXml(ms);
                    if (ms != null)
                    {
                        return ms.ToArray();
                    }
                    break;

                case "ExportUser":
                    var paramExportUser = JsonConvert.DeserializeObject<ExportUser>(objectReport, jss);
                    resource = assembly.GetManifestResourceStream("ApiCentralProcessingSystem.ExportGrid.UserExport.repx");
                    result = XtraReport.FromStream(resource);
                    result.Parameters["HoTen"].Value = paramExportUser.HoTen;
                    result.Parameters["TenDangNhap"].Value = paramExportUser.TenDangNhap;
                    result.Parameters["DienThoai"].Value = paramExportUser.DienThoai;
                    result.Parameters["PhongBan"].Value = paramExportUser.PhongBan;
                    result.Parameters["DepId"].Value = paramExportUser.DepId ?? -1;
                    result.SaveLayoutToXml(ms);
                    if (ms != null)
                    {
                        return ms.ToArray();
                    }
                    break;

                case "ExportUserByDepartment":
                    var paramExportUserByDep = JsonConvert.DeserializeObject<ExportUserByDep>(objectReport, jss);
                    resource = assembly.GetManifestResourceStream("ApiCentralProcessingSystem.ExportGrid.UserByDepartmentExport.repx");
                    result = XtraReport.FromStream(resource);
                    result.Parameters["TenDangNhap"].Value = paramExportUserByDep.TenDangNhap;
                    result.Parameters["HoTen"].Value = paramExportUserByDep.HoTen;
                    result.Parameters["ChucVu"].Value = paramExportUserByDep.ChucVu;
                    result.Parameters["DienThoai"].Value = paramExportUserByDep.DienThoai;
                    result.Parameters["PhongBan"].Value = paramExportUserByDep.PhongBan;
                    result.Parameters["TrangThai"].Value = paramExportUserByDep.TrangThai ?? -1;
                    result.SaveLayoutToXml(ms);
                    if (ms != null)
                    {
                        return ms.ToArray();
                    }
                    break;

                case "EmployerOnline":
                    var paramEmployerOnline = JsonConvert.DeserializeObject<EmployerOnlineExport>(objectReport, jss);
                    resource = assembly.GetManifestResourceStream("ApiCentralProcessingSystem.ExportGrid.EmployerOnline.repx");
                    result = XtraReport.FromStream(resource);
                    result.Parameters["Ma"].Value = paramEmployerOnline.Ma;
                    result.Parameters["Ten"].Value = paramEmployerOnline.Ten;
                    result.Parameters["Cmnd"].Value = paramEmployerOnline.Cmnd;
                    result.Parameters["Sdt"].Value = paramEmployerOnline.Sdt;
                    result.Parameters["Email"].Value = paramEmployerOnline.Email;
                    result.Parameters["DiaChi"].Value = paramEmployerOnline.DiaChi;
                    result.Parameters["TenCongViec"].Value = paramEmployerOnline.TenCongViec;
                    result.Parameters["SoLuongTuyen"].Value = paramEmployerOnline.SoLuongTuyen;
                    result.Parameters["NguoiCapNhat"].Value = paramEmployerOnline.NguoiCapNhat == null ? -1 : paramEmployerOnline.NguoiCapNhat;
                    result.SaveLayoutToXml(ms);
                    if (ms != null)
                    {
                        return ms.ToArray();
                    }
                    break;

                case "LaborerOnline":
                    var paramLaborerOnline = JsonConvert.DeserializeObject<LaborerOnlineExport>(objectReport, jss);
                    resource = assembly.GetManifestResourceStream("ApiCentralProcessingSystem.ExportGrid.LaborerOnline.repx");
                    result = XtraReport.FromStream(resource);
                    result.Parameters["Ma"].Value = paramLaborerOnline.Ma;
                    result.Parameters["HoTen"].Value = paramLaborerOnline.HoTen;
                    result.Parameters["Sdt"].Value = paramLaborerOnline.Sdt;
                    result.Parameters["DiaChi"].Value = paramLaborerOnline.DiaChi;
                    result.Parameters["TenCongViec"].Value = paramLaborerOnline.TenCongViec;
                    result.Parameters["TrangThai"].Value = paramLaborerOnline.TrangThai == null ? -1 : paramLaborerOnline.TrangThai;
                    result.SaveLayoutToXml(ms);
                    if (ms != null)
                    {
                        return ms.ToArray();
                    }
                    break;
                case "NhaTuyenDung":
                    var paramNhaTuyenDung = JsonConvert.DeserializeObject<NhaTuyenDungExport>(objectReport, jss);
                    resource = assembly.GetManifestResourceStream("ApiCentralProcessingSystem.ExportGrid.NhaTuyenDung.repx");
                    result = XtraReport.FromStream(resource);
                    result.Parameters["Ten"].Value = paramNhaTuyenDung.Ten;
                    result.Parameters["CMND"].Value = paramNhaTuyenDung.CMND;
                    result.Parameters["KdChinh"].Value = paramNhaTuyenDung.KdChinh == null ? -1 : paramNhaTuyenDung.KdChinh;
                    result.Parameters["LoaiHinh"].Value = paramNhaTuyenDung.LoaiHinh == null ? -1 : paramNhaTuyenDung.LoaiHinh;
                    result.Parameters["DiaChi"].Value = paramNhaTuyenDung.DiaChi;
                    result.Parameters["NhuCau"].Value = paramNhaTuyenDung.NhuCau;
                    result.Parameters["TrangThai"].Value = paramNhaTuyenDung.TrangThai == null ? -1 : paramNhaTuyenDung.TrangThai;
                    result.SaveLayoutToXml(ms);
                    if (ms != null)
                    {
                        return ms.ToArray();
                    }
                    break;
                case "PhiengiaodichDN":
                    var paramPhiengiaodichDN = JsonConvert.DeserializeObject<TradingsessionDoanhNghiepExport>(objectReport, jss);
                    resource = assembly.GetManifestResourceStream("ApiCentralProcessingSystem.ExportGrid.PhiengiaodichDN.repx");
                    result = XtraReport.FromStream(resource);
                    result.Parameters["Id"].Value = paramPhiengiaodichDN.Id;
                    result.Parameters["tittle"].Value = paramPhiengiaodichDN.tittle == null ? "" : paramPhiengiaodichDN.tittle.ToUpper();  
                    result.SaveLayoutToXml(ms);
                    if (ms != null)
                    {
                        return ms.ToArray();
                    }
                    break;
                case "UngVien":
                    var paramUngVien = JsonConvert.DeserializeObject<UngVienExport>(objectReport, jss);
                    resource = assembly.GetManifestResourceStream("ApiCentralProcessingSystem.ExportGrid.UngVien.repx");
                    result = XtraReport.FromStream(resource);
                    result.Parameters["HoTen"].Value = paramUngVien.HoTen;
                    result.Parameters["CMND"].Value = paramUngVien.CMND;
                    result.Parameters["Sdt"].Value = paramUngVien.Sdt;
                    result.Parameters["Email"].Value = paramUngVien.Email;
                    result.Parameters["DiaChi"].Value = paramUngVien.DiaChi;
                    result.Parameters["NhuCau"].Value = paramUngVien.NhuCau;
                    result.Parameters["TrangThai"].Value = paramUngVien.TrangThai == null ? -1 : paramUngVien.TrangThai;
                    result.SaveLayoutToXml(ms);
                    if (ms != null)
                    {
                        return ms.ToArray();
                    }
                    break;
            }
            ReportDetails details = null;
            if (Reports.TryGetValue(url, out details))
            {
                return details.Layout;
            }

            throw new FaultException(new FaultReason(string.Format("Could not find report '{0}'.", url)), new FaultCode("Server"), "GetData");
        }

        public override Dictionary<string, string> GetUrls()
        {
            // Returns a dictionary of the existing report URLs and display names. 
            // This method is called when running the Report Designer, 
            // before the Open Report and Save Report dialogs are shown and after a new report is saved to a storage.

            var dictionary = Reports.ToDictionary(x => x.Key, y => y.Value.DisplayName);
            foreach (var resourceName in ReportsFromResources)
            {
                if (!dictionary.ContainsKey(resourceName))
                {
                    dictionary.Add(resourceName, resourceName);
                }
            }

            return dictionary;
        }

        public override void SetData(XtraReport report, string url)
        {
            // Stores the specified report to a Report Storage using the specified URL. 
            // This method is called only after the IsValidUrl and CanSetData methods are called.

            SetDataInternal(report, url, false);
        }

        public override string SetNewData(XtraReport report, string defaultUrl)
        {
            // Stores the specified report using a new URL. 
            // The IsValidUrl and CanSetData methods are never called before this method. 
            // You can validate and correct the specified URL directly in the SetNewData method implementation 
            // and return the resulting URL used to save a report in your storage.

            while (Reports.ContainsKey(defaultUrl))
            {
                defaultUrl += "_1";
            }
            SetDataInternal(report, defaultUrl, true);
            return defaultUrl;
        }

        void SetDataInternal(XtraReport report, string url, bool isNewOne)
        {
            if (!isNewOne && !Reports.ContainsKey(url))
            {
                throw new FaultException(new FaultReason(string.Format("Could not find report '{0}'.", url)), new FaultCode("Server"), "SetData");
            }
            using (var stream = new MemoryStream())
            {
                report.SaveLayoutToXml(stream);
                var reportLayout = stream.ToArray();
                var newReportDetails = new ReportDetails { DisplayName = url, Layout = reportLayout };
                Reports.AddOrUpdate(url, newReportDetails, (currentUrl, existingReport) => { existingReport.Layout = reportLayout; return existingReport; });
            }
        }
    }
}
