using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Constants
{
    public static class Histories
    {
        public static int Create = 1;
        public static int Update = 2;
        public static int Forward = 3;
        public static int Approved = 4;
        public static int Deny = 5;
        public static int Finished = 6;
        public static int Deleted = 7;
    }
    public static class HistoriesStatus
    {
        public static int Forward = 1;
        public static int Approved = 2;
        public static int Deny = 3;
    }
}
