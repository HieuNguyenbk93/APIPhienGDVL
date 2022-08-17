using System;
using System.Collections.Generic;
using System.Text;

namespace Common.StaticExtensions
{
    public static class ReplaceSpecialChar
    {
        public static string ReplaceString(string oldString)
        {
            string newString = "";

            if (!String.IsNullOrEmpty(oldString))
            {
                newString = oldString.Replace("_", "[_]");
                newString = newString.Replace("%", "[%]");
            }
            return newString;
        }
    }
}
