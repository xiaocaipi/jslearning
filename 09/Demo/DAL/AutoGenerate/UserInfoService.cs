//============================================================
// Producnt name:		DAL
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
        public static UserInfo AddUserInfo(UserInfo userInfo)
		{
            string sql =
				"INSERT UserInfo (LoginName, PassWord, Gender, RealName)" +
				"VALUES (@LoginName, @PassWord, @Gender, @RealName)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@LoginName", DBHelper.GetValueByWhetherNull(userInfo.LoginName)),
					new SqlParameter("@PassWord", DBHelper.GetValueByWhetherNull(userInfo.PassWord)),
					new SqlParameter("@Gender", DBHelper.GetValueByWhetherNull(userInfo.Gender)),
					new SqlParameter("@RealName", DBHelper.GetValueByWhetherNull(userInfo.RealName))
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetUserInfoById(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                throw e;
            }
		}
		
        public static void DeleteUserInfo(UserInfo userInfo)
		{
			DeleteUserInfoById( userInfo.Id );
		}

        public static void DeleteUserInfoById(int id)
		{
            string sql = "DELETE UserInfo WHERE Id = @Id";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Id", id)
				};
			
                DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
				throw e;
            }
		}
		
        public static void ModifyUserInfo(UserInfo userInfo)
        {
            string sql =
                "UPDATE UserInfo " +
                "SET " +
	                "LoginName = @LoginName, " +
	                "PassWord = @PassWord, " +
	                "Gender = @Gender, " +
	                "RealName = @RealName " +
                "WHERE Id = @Id";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Id", userInfo.Id),
					new SqlParameter("@LoginName", DBHelper.GetValueByWhetherNull(userInfo.LoginName)),
					new SqlParameter("@PassWord", DBHelper.GetValueByWhetherNull(userInfo.PassWord)),
					new SqlParameter("@Gender", DBHelper.GetValueByWhetherNull(userInfo.Gender)),
					new SqlParameter("@RealName", DBHelper.GetValueByWhetherNull(userInfo.RealName))
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		

        public static IList<UserInfo> GetAllUserInfos()
        {
            string sqlAll = "SELECT * FROM UserInfo";
			return GetUserInfosBySql( sqlAll );
        }
		
        public static UserInfo GetUserInfoById(int id)
        {
            string sql = "SELECT * FROM UserInfo WHERE Id = @Id";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Id", id));
                if (reader.Read())
                {
					
                    UserInfo userInfo = new UserInfo();

					try{
					userInfo.Id = (int)reader["Id"];
					}catch
					{}
					try{
					userInfo.LoginName = (string)reader["LoginName"];
					}catch
					{}
					try{
					userInfo.PassWord = (string)reader["PassWord"];
					}catch
					{}
					try{
					userInfo.Gender = (int)reader["Gender"];
					}catch
					{}
					try{
					userInfo.RealName = (string)reader["RealName"];
					}catch
					{}

                    reader.Close();
					
                    return userInfo;
                }
                else
                {
                    reader.Close();
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
		
		
		
		
        private static IList<UserInfo> GetUserInfosBySql( string safeSql )
        {
            List<UserInfo> list = new List<UserInfo>();

			try
			{
				DataTable table = DBHelper.GetDataSet( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					UserInfo userInfo = new UserInfo();
					
					try{
					userInfo.Id = (int)row["Id"];
					}catch
					{}
					try{
					userInfo.LoginName = (string)row["LoginName"];
					}catch
					{}
					try{
					userInfo.PassWord = (string)row["PassWord"];
					}catch
					{}
					try{
					userInfo.Gender = (int)row["Gender"];
					}catch
					{}
					try{
					userInfo.RealName = (string)row["RealName"];
					}catch
					{}
	
					list.Add(userInfo);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }
		
        private static IList<UserInfo> GetUserInfosBySql( string sql, params SqlParameter[] values )
        {
            List<UserInfo> list = new List<UserInfo>();

			try
			{
				DataTable table = DBHelper.GetDataSet( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					UserInfo userInfo = new UserInfo();
					
					try{
					userInfo.Id = (int)row["Id"];
					}catch
					{}
					try{
					userInfo.LoginName = (string)row["LoginName"];
					}catch
					{}
					try{
					userInfo.PassWord = (string)row["PassWord"];
					}catch
					{}
					try{
					userInfo.Gender = (int)row["Gender"];
					}catch
					{}
					try{
					userInfo.RealName = (string)row["RealName"];
					}catch
					{}
	
					list.Add(userInfo);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
			
        }
		
	}
}
