<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <script type="text/javascript" src="js/Http.js"></script>
    <script type="text/javascript">
      function send()
      {
         var fnLoading =function()
         {
            var oDiv = document.getElementById("divLoading");
            if (oDiv)
            {
               oDiv.style.display="block";
              // oDiv.innerHTML="<font color='red'>Loading...</font>";
            }
         }
         
         var fnCallBack = function(result)
         {
            var oDiv = document.getElementById("divLoading");
            oDiv.style.display="none";
            if (result=="success")
            {
               location.href="Main.aspx";
            }else
            {
                alert("帐号或密码有误，请重试!");
            }
         }
         var user = document.getElementById("txtUser").value;
         var password = document.getElementById("txtPass").value;
         var url = "LoginHandler.aspx?user="+user+"&password="+password+"&catch="+(new Date()).getTime()
         alert(url);
         Http.Get(url,fnLoading,fnCallBack);
       }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div id="divLoading" style="width:100px;height:20px;background-color:Green;color:White;text-align:center;position:absolute;left:0px;top:0px;padding-top:3px;display:none">Loading....</div>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="用户名"></asp:Label>
        <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="密码"></asp:Label>
        &nbsp; &nbsp;
        <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:Button ID="btnLogin" runat="server" Text="登陆" OnClientClick="send()" />
        <input id="Reset1" type="reset" value="重置" /></div>
    </form>
</body>
</html>
