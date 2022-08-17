using System;
using System.Collections.Generic;
using System.Text;

namespace Common.StaticExtensions
{
    public static class StringExtension
    {
        public static string TrimSpace(this string value)
        {
            value = value?.Trim();

            return value;
        }
    }
}
