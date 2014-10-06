using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class LoginHandler : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["user"] != null && Request["pass"] != null)
        {
            string user = Request.QueryString["user"];
            string pass = Request.QueryString["pass"];
            bool isok = BLL.UserInfoManager.Login(user, pass);
            if (isok)
                Response.Write( "{result:'success'}");
            else
                Response.Write( "{result:'failed'}");
            


            //BLL.UserInfoManager.GetUserInfoById

        }
    }
}
