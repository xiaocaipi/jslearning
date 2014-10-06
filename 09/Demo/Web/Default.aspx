<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <script type="text/javascript" src="js/Ajax.js"></script>
    <script type="text/javascript">
        function Login()
        {
           var fnLoading = function()
           {
               var oDiv = document.getElementById("divLoading");
               if (oDiv)
               {
                  oDiv.innerHTML = "<font color='red'>系统验证中...</font>";
               }
           }
           
           var fnCallBack = function(oResult)
           {
              var oDiv = document.getElementById("divLoading");
               if (oDiv)
               {
                  oDiv.innerHTML = "";
               }
              var res = eval("("+oResult+")");
              if (res.result == "success")
                 alert("ok");
              else
                 alert("帐号或密码错误，请重试!");
  
           }
           
           var user = document.getElementById("txtUser");
           var pass = document.getElementById("txtPass");
           var url = "LoginHandler.aspx?user="+user.value+"&pass="+pass.value+"&catch="+(new Date()).getTime();
           //alert(url);
           Http.Get(url,fnCallBack,fnLoading);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="帐号"></asp:Label>
        <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="密码"></asp:Label>
        <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
        <br />
        <div id="divLoading"></div>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp;
        <input type="button" value="登录" id="btnLogin" onclick="Login()" />
        <asp:Button ID="Button2" runat="server" Text="退出" /></div>
    </form>
</body>
</html>
