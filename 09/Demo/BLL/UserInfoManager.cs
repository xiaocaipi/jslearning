//============================================================
// Producnt name:		BLL Extender
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2010-5-13 9:09:08
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Models;

namespace BLL
{

    public static partial class UserInfoManager
    {
        public static bool Login(string user, string pass)
        {
            UserInfo userinfo = DAL.UserInfoService.GetUserInfoByLoginId(user);
            if (userinfo != null)
            {
                return userinfo.PassWord == pass;
            }
            else
                return false;

        }
    }
}
