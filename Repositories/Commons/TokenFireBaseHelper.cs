using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using Repositories.Bases;
using Dapper;

namespace Repositories.Commons
{
    public static class TokenFireBaseHelper
    {
        public static List<string> GetTokens(IEnumerable<int> userIds)
        {
            using (IDbConnection db = new SqlConnection(ConnectionString.Connection))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ListUserId", String.Join(',', userIds));
                var result = db.Query<string>("HT_TokenNotification_GetToken", parameters, null, true, null, CommandType.StoredProcedure).ToList();
                return result;
            }
        }
        public static List<string> GetTokens(int userId)
        {
            using (IDbConnection db = new SqlConnection(ConnectionString.Connection))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ListUserId", userId.ToString());
                var result = db.Query<string>("HT_TokenNotification_GetToken", parameters, null, true, null, CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public static List<List<string>> GetListSubTokens(List<string> tokens, int limit = 1000)
        {
            List<List<string>> SubTokens = new List<List<string>>();
            if (tokens.Count <= limit)
            {
                SubTokens.Add(tokens);
            }
            else
            {
                int countToken = tokens.Count;
                int countSub = 0;
                while (countToken > limit)
                {
                    var tokenSubs = tokens.Skip(countSub * limit).Take((countSub + 1) * limit).ToList();
                    SubTokens.Add(tokenSubs);
                    countSub++;
                    countToken -= limit;
                }
                var tokenSubLasts = tokens.Skip(tokens.Count - countToken).Take(countToken).ToList();
                SubTokens.Add(tokenSubLasts);
            }
            return SubTokens;
        }
    }
}
