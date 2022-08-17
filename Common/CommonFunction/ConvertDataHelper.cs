using System;
using System.Collections.Generic;
using System.Text;

namespace Common.CommonFunction
{
    public class ConvertDataHelper
    {
        public static string ConvertToEnglish(string data)
        {
            if (string.IsNullOrWhiteSpace(data)) return default;
            data = data.Replace("ấ", "a");
            data = data.Replace("ầ", "a");
            data = data.Replace("ẩ", "a");
            data = data.Replace("ẫ", "a");
            data = data.Replace("ậ", "a");
            //---------------------------------A^
            data = data.Replace("Ấ", "A");
            data = data.Replace("Ầ", "A");
            data = data.Replace("Ẩ", "A");
            data = data.Replace("Ẫ", "A");
            data = data.Replace("Ậ", "A");
            //---------------------------------a(
            data = data.Replace("ắ", "a");
            data = data.Replace("ằ", "a");
            data = data.Replace("ẳ", "a");
            data = data.Replace("ẵ", "a");
            data = data.Replace("ặ", "a");
            //---------------------------------A(
            data = data.Replace("Ắ", "A");
            data = data.Replace("Ằ", "A");
            data = data.Replace("Ẳ", "A");
            data = data.Replace("Ẵ", "A");
            data = data.Replace("Ặ", "A");
            //---------------------------------a
            data = data.Replace("á", "a");
            data = data.Replace("à", "a");
            data = data.Replace("ả", "a");
            data = data.Replace("ã", "a");
            data = data.Replace("ạ", "a");
            data = data.Replace("â", "a");
            data = data.Replace("ă", "a");
            //---------------------------------A
            data = data.Replace("Á", "A");
            data = data.Replace("À", "A");
            data = data.Replace("Ả", "A");
            data = data.Replace("Ã", "A");
            data = data.Replace("Ạ", "A");
            data = data.Replace("Â", "A");
            data = data.Replace("Ă", "A");
            //---------------------------------e^
            data = data.Replace("ế", "e");
            data = data.Replace("ề", "e");
            data = data.Replace("ể", "e");
            data = data.Replace("ễ", "e");
            data = data.Replace("ệ", "e");
            //---------------------------------E^
            data = data.Replace("Ế", "E");
            data = data.Replace("Ề", "E");
            data = data.Replace("Ể", "E");
            data = data.Replace("Ễ", "E");
            data = data.Replace("Ệ", "E");
            //---------------------------------e
            data = data.Replace("é", "e");
            data = data.Replace("è", "e");
            data = data.Replace("ẻ", "e");
            data = data.Replace("ẽ", "e");
            data = data.Replace("ẹ", "e");
            data = data.Replace("ê", "e");
            //---------------------------------E
            data = data.Replace("É", "E");
            data = data.Replace("È", "E");
            data = data.Replace("Ẻ", "E");
            data = data.Replace("Ẽ", "E");
            data = data.Replace("Ẹ", "E");
            data = data.Replace("Ê", "E");
            //---------------------------------i
            data = data.Replace("í", "i");
            data = data.Replace("ì", "i");
            data = data.Replace("ỉ", "i");
            data = data.Replace("ĩ", "i");
            data = data.Replace("ị", "i");
            //---------------------------------I
            data = data.Replace("Í", "I");
            data = data.Replace("Ì", "I");
            data = data.Replace("Ỉ", "I");
            data = data.Replace("Ĩ", "I");
            data = data.Replace("Ị", "I");
            //---------------------------------o^
            data = data.Replace("ố", "o");
            data = data.Replace("ồ", "o");
            data = data.Replace("ổ", "o");
            data = data.Replace("ỗ", "o");
            data = data.Replace("ộ", "o");
            //---------------------------------O^
            data = data.Replace("Ố", "O");
            data = data.Replace("Ồ", "O");
            data = data.Replace("Ổ", "O");
            data = data.Replace("Ô", "O");
            data = data.Replace("Ộ", "O");
            //---------------------------------o*
            data = data.Replace("ớ", "o");
            data = data.Replace("ờ", "o");
            data = data.Replace("ở", "o");
            data = data.Replace("ỡ", "o");
            data = data.Replace("ợ", "o");
            //---------------------------------O*
            data = data.Replace("Ớ", "O");
            data = data.Replace("Ờ", "O");
            data = data.Replace("Ở", "O");
            data = data.Replace("Ỡ", "O");
            data = data.Replace("Ợ", "O");
            //---------------------------------u*
            data = data.Replace("ứ", "u");
            data = data.Replace("ừ", "u");
            data = data.Replace("ử", "u");
            data = data.Replace("ữ", "u");
            data = data.Replace("ự", "u");
            //---------------------------------U*
            data = data.Replace("Ứ", "U");
            data = data.Replace("Ừ", "U");
            data = data.Replace("Ử", "U");
            data = data.Replace("Ữ", "U");
            data = data.Replace("Ự", "U");
            //---------------------------------y
            data = data.Replace("ý", "y");
            data = data.Replace("ỳ", "y");
            data = data.Replace("ỷ", "y");
            data = data.Replace("ỹ", "y");
            data = data.Replace("ỵ", "y");
            //---------------------------------Y
            data = data.Replace("Ý", "Y");
            data = data.Replace("Ỳ", "Y");
            data = data.Replace("Ỷ", "Y");
            data = data.Replace("Ỹ", "Y");
            data = data.Replace("Ỵ", "Y");
            //---------------------------------DD
            data = data.Replace("Đ", "D");
            data = data.Replace("Đ", "D");
            data = data.Replace("đ", "d");
            //---------------------------------o
            data = data.Replace("ó", "o");
            data = data.Replace("ò", "o");
            data = data.Replace("ỏ", "o");
            data = data.Replace("õ", "o");
            data = data.Replace("ọ", "o");
            data = data.Replace("ô", "o");
            data = data.Replace("ơ", "o");
            //---------------------------------O
            data = data.Replace("Ó", "O");
            data = data.Replace("Ò", "O");
            data = data.Replace("Ỏ", "O");
            data = data.Replace("Õ", "O");
            data = data.Replace("Ọ", "O");
            data = data.Replace("Ô", "O");
            data = data.Replace("Ơ", "O");
            //---------------------------------u
            data = data.Replace("ú", "u");
            data = data.Replace("ù", "u");
            data = data.Replace("ủ", "u");
            data = data.Replace("ũ", "u");
            data = data.Replace("ụ", "u");
            data = data.Replace("ư", "u");
            //---------------------------------U
            data = data.Replace("Ú", "U");
            data = data.Replace("Ù", "U");
            data = data.Replace("Ủ", "U");
            data = data.Replace("Ũ", "U");
            data = data.Replace("Ụ", "U");
            data = data.Replace("Ư", "U");
            //--------------------------------- 
            data = data.Trim();
            return data;
        }
    }
}
