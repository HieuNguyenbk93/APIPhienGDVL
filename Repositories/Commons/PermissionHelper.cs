using Common.Constants;
using Dapper;
using Interfaces.Base;
using Repositories.Bases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Repositories.Commons
{
    public static class PermissionHelper
    {
        public static bool CheckPermissionForGetData(int accountId, int doiTuongId, CheckPermissionType checkPermissionType, bool? isSuperAdmin)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionString.Connection))
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("UserId", accountId);
                    parameters.Add("DoiTuongId", doiTuongId);
                    parameters.Add("Type", (int)checkPermissionType);
                    int count = connection.Query<int>("HT_NguoiDung_CheckPermission", parameters, null, true, null, CommandType.StoredProcedure).FirstOrDefault();
                    if (count == 0 && isSuperAdmin == false)
                    {
                        return false;
                    }
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
