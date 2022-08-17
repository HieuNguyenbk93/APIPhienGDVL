using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Constants
{
    public enum OrderAction
    {
        Add = 1,
        Edit = 2,
        Delete = 3,
        Approved = 4, // trưởng phòng(tp) duyệt
        Deny = 5, // tp từ chối
        WaitApproveTP = 6, // đợi tp duyệt
        WaitApproveBGD = 9, // đợi bgd từ chối
    }
}
