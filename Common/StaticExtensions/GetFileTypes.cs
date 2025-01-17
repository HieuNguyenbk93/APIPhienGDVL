﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Common.StaticExtensions
{
    public static class GetFileTypes
    {
        public static byte GetFileType(string contentType)
        {
            if (!string.IsNullOrEmpty(contentType))
            {
                var dictionay = ContentType();
                return Convert.ToByte(dictionay[contentType]);
            }
            return 0;
        }
        public static int GetFileTypeInt(string contentType)
        {
            if (!string.IsNullOrEmpty(contentType))
            {
                var dictionay = ContentType();
                return dictionay[contentType];
            }
            return 0;
        }
        private static Dictionary<string, int> ContentType()
        {
            return new Dictionary<string, int>
            {
                { "application/msword", 1 },
                { "text/plain", 1 },
                { "application/vnd.openxmlformats-officedocument.wordprocessingml.document", 1 },
                { "application/vnd.openxmlformats-officedocument.wordprocessingml.template", 1 },
                { "application/vnd.ms-word.document.macroEnabled.12", 1 },
                { "application/vnd.ms-word.template.macroEnabled.12", 1 },
                { "application/vnd.ms-excel", 2 },
                { "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", 2 },
                { "application/vnd.openxmlformats-officedocument.spreadsheetml.template", 2 },
                { "application/vnd.ms-excel.sheet.macroEnabled.12", 2 },
                { "application/vnd.ms-excel.template.macroEnabled.12", 2 },
                { "application/vnd.ms-excel.addin.macroEnabled.12", 2 },
                { "application/vnd.ms-excel.sheet.binary.macroEnabled.12", 2 },
                { "application/octet-stream", 2 },
                { "application/pdf", 3 },
                { "image/png", 4 },
                { "image/jpeg", 4 },
                { "image/gif", 4 },
                { "application/x-rar-compressed", 5 },
                { "application/zip", 5 },
                { "application/x-7z-compressed", 5 },
                { "application/vnd.ms-powerpoint", 6 },
                { "application/vnd.openxmlformats-officedocument.presentationml.presentation", 6 },
                { "application/vnd.openxmlformats-officedocument.presentationml.template", 6 },
                { "application/vnd.openxmlformats-officedocument.presentationml.slideshow", 6 },
                { "application/vnd.ms-powerpoint.addin.macroEnabled.12", 6 },
                { "application/vnd.ms-powerpoint.presentation.macroEnabled.12", 6 },
                { "application/vnd.ms-powerpoint.template.macroEnabled.12", 6 },
                { "application/vnd.ms-powerpoint.slideshow.macroEnabled.12", 6 },
            };
        }
    }
}
