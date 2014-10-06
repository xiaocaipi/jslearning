//============================================================
// Producnt name:		BLL
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

		
		//override
		public static UserInfo AddUserInfo(string LoginName,string PassWord,int Gender,string RealName)
		{
			Models.UserInfo userInfo = new Models.UserInfo();

			TransData_AddUserInfo(LoginName,PassWord,Gender,RealName,  userInfo );
		
			return UserInfoService.AddUserInfo(userInfo);
		}
        public static UserInfo AddUserInfo(UserInfo userInfo)
        {
            return UserInfoService.AddUserInfo(userInfo);
        }

        public static void DeleteUserInfo(UserInfo userInfo)
        {
            UserInfoService.DeleteUserInfo(userInfo);
        }

        public static void DeleteUserInfoById(int id)
        {
            UserInfoService.DeleteUserInfoById(id);
        }

		public static void ModifyUserInfo(UserInfo userInfo)
        {
            UserInfoService.ModifyUserInfo(userInfo);
        }
		//overload
		public static void ModifyUserInfo(int Id,string LoginName,string PassWord,int Gender,string RealName)
        {
			Models.UserInfo userInfo = new Models.UserInfo();
	        //PK
			userInfo.Id=Id;
			TransData_ModifyUserInfo(Id,LoginName,PassWord,Gender,RealName,userInfo);
		
			 UserInfoService.ModifyUserInfo(userInfo);
		}

        public static IList<UserInfo> GetAllUserInfos()
        {
            return UserInfoService.GetAllUserInfos();
        }

        public static UserInfo GetUserInfoById(int id)
        {
            return UserInfoService.GetUserInfoById(id);
        }

		#region private Method
		//Trans Add Method 
		private static void TransData_AddUserInfo(string LoginName,string PassWord,int Gender,string RealName, Models.UserInfo userInfo )
        {

			try{if (LoginName.ToString() == "0001-1-1 0:00:00") userInfo.LoginName = null; else userInfo.LoginName = LoginName;}catch{}
			try{if (PassWord.ToString() == "0001-1-1 0:00:00") userInfo.PassWord = null; else userInfo.PassWord = PassWord;}catch{}
			try{if (Gender.ToString() == "0001-1-1 0:00:00") userInfo.Gender = null; else userInfo.Gender = Gender;}catch{}
			try{if (RealName.ToString() == "0001-1-1 0:00:00") userInfo.RealName = null; else userInfo.RealName = RealName;}catch{}
        }
		//Trans Modify Method
		private static void TransData_ModifyUserInfo(int Id,string LoginName,string PassWord,int Gender,string RealName, Models.UserInfo userInfo)
		{

			try{if (LoginName.ToString() == "0001-1-1 0:00:00") userInfo.LoginName = null; else userInfo.LoginName = LoginName;}catch{}
			try{if (PassWord.ToString() == "0001-1-1 0:00:00") userInfo.PassWord = null; else userInfo.PassWord = PassWord;}catch{}
			try{if (Gender.ToString() == "0001-1-1 0:00:00") userInfo.Gender = null; else userInfo.Gender = Gender;}catch{}
			try{if (RealName.ToString() == "0001-1-1 0:00:00") userInfo.RealName = null; else userInfo.RealName = RealName;}catch{}
		}
		#endregion
    }
}


