using Common.Constants;
using Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Models.Business
{
    public class BusinessCungUngResponse : BaseResponse<ResponseStatus>
    {
        public int? Dot { get; set; }
        public int? IdNLD { get; set; }
    }

    public class BusinessCungUngGetByDotResponse
    {
        public List<GetDataSendMail> getDataSends { get; set; }
    }
    public class GetDataSendMail
    {
        public string TenNSDLD { get; set; }
        public string TenNLD { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public string Ten { get; set; }
        public string TenCongViec { get; set; }
        public string MucLuong { get; set; }
        public string DiaChi { get; set; }
        public string TrinhDoCMKT { get; set; }
        public string LyDo { get; set; }
        public DateTime? HanNop { get; set; }
        public DateTime? NgayDuyet { get; set; }
        public string TenCanBoGui { get; set; }
        public string DaiDien { get; set; }
        public string SdtLH { get; set; }
        public string EmailLH { get; set; }
    }
}
