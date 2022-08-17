using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
//using System.Web.UI;
//using System.Web.UI.HtmlControls;

namespace Repositories.Commons
{
    public class FileAttachHelper
    {
        /// <summary>
        /// ThangND - Tạo Files trên Server với các Files được upload lên hệ thống
        /// </summary>
        /// 

        //public static string createFile(string Paths, HttpPostedFileBase files)
        //{
        //    try
        //    {

        //        var fileName = Path.GetFileName(files.FileName);
        //        files.SaveAs(Path.Combine(Paths, fileName));
        //        return fileName;
        //    }
        //    catch (Exception)
        //    {
        //        return String.Empty;
        //    }
        //}

        /// <summary>
        /// ThangND - Upload nhiều files lên = .netCore
        /// </summary>
        /// 
        //public async Task<IActionResult> Post(List<IFormFile> files)
        public async Task<Boolean> Post(List<IFormFile> files)
        {
            long size = files.Sum(f => f.Length);

            // full path to file in temp location
            var filePath = Path.GetTempFileName();

            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }

            // process uploaded files
            // Don't rely on or trust the FileName property without validation.

            //return Ok(new { count = files.Count, size, filePath });
            return true;
        }

        /// <summary>
        /// ThangND - Xóa Files trong một thư mục trên Server
        /// </summary>
        /// param name="type" 1.xóa toàn bộ file theo đường dẫn thư mục , 2. xóa toàn bộ thư mục con thuộc đường dẫn , 3.file theo đường dẫn(đường dẫn bao gồm cả tên)
        public static bool deleteFile(string paths, int type)
        {
            try
            {
                System.IO.DirectoryInfo di = new DirectoryInfo(paths);
                switch (type)
                {
                    case 1:
                        foreach (FileInfo file in di.GetFiles())
                        {
                            file.Delete();
                        }
                        break;
                    case 2:
                        foreach (DirectoryInfo dir in di.GetDirectories())
                        {
                            dir.Delete(true);
                        }
                        break;
                    case 3:
                        File.Delete(paths);
                        break;
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        ///<summary>
        ///ThangND - Di chuyển File trên Server
        ///</summary>
        ///<param name="fromPaths" đường dẫn gốc></param>
        ///<param name="toPath" đường dẫn muốn di chuyển đến></param>
        ///<param name="type" kiểu di chuyển "1" chuyển File "2" chuyển thư mục></param>
        public static bool moveFile(string fromPaths, string toPath, int type)
        {
            try
            {
                switch (type)
                {
                    case 1:
                        File.Move(fromPaths, toPath);
                        break;
                    case 2:
                        Directory.Move(fromPaths, toPath);
                        break;
                }
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
