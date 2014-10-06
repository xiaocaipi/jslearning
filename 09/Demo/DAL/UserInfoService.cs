//============================================================
// Producnt name:		DAL Extender
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2010-5-13 9:09:08
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using Models;

namespace DAL
{
	public static partial class UserInfoService
	{
        public static UserInfo GetUserInfoByLoginId(string loginid)
        {
            string strsql = string.Format("select * from UserInfo where LoginName='{0}'", loginid);
            try
            {
                return GetUserInfosBySql(strsql)[0];
            }
            catch
            {
                return null;
            }
        }
	}

}
