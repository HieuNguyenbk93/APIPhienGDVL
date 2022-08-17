using DocumentFormat.OpenXml.Packaging;
using System;
using System.Linq;
using DocumentFormat.OpenXml.Drawing;

namespace Common.StaticExtensions
{
    public static class FileUtils
    {
        public static string ReadFileExtension(string path)
        {
            using (var doc = WordprocessingDocument.Open(path, false))
            {
                var content = doc.MainDocumentPart.Document.Body.InnerText;
                return content;
            }
        }
    }
}
