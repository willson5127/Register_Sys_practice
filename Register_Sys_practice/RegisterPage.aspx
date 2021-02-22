<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="Register_Sys_practice.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Lab_Warning" runat="server" ForeColor="#CC0000"></asp:Label>
            <br />
            帳號：<asp:TextBox ID="Tb_Register_Username" runat="server"></asp:TextBox>
        </div>
        <p>
            密碼：<asp:TextBox ID="Tb_Register_Password" runat="server" TextMode="Password"></asp:TextBox>
        </p>
        <p>
            姓名：<asp:TextBox ID="Tb_Register_Realname" runat="server"></asp:TextBox>
        </p>
        <p>
            生日：<asp:TextBox ID="Tb_Register_Birthday" runat="server"></asp:TextBox>
        </p>
        <p>
            信箱：<asp:TextBox ID="Tb_Register_Email" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Btn_Register_Accept" runat="server" OnClick="Btn_Register_Accept_Click" Text="確認" Width="200px" />
        </p>
    </form>
</body>
</html>
