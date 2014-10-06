//============================================================
// Producnt name:		Models
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2010-5-13 9:09:07
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
namespace Models
{
	
	[Serializable()]
	public partial class UserInfo
	{
	    #region private field
		
			private int id;
			private string loginName;
			private string passWord;
			private Nullable<int> gender;
			private string realName;

        #endregion

        #region constructor

			public UserInfo() {
			}

        #endregion

        #region public property

			public int Id {
				get { return id; }
				set { id = value; }
			}
			
			public string LoginName {
				get { return loginName; }
				set { loginName = value; }
			}
			
			public string PassWord {
				get { return passWord; }
				set { passWord = value; }
			}
			
			public Nullable<int> Gender {
				get { return gender; }
				set { gender = value; }
			}
			
			public string RealName {
				get { return realName; }
				set { realName = value; }
			}
			
			
        #endregion

	}
}


