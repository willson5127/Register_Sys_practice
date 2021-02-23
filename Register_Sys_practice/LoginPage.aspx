<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Register_Sys_practice.LoginPage" %><%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

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
        </div>
        <asp:Label ID="Lab_Login_Username" runat="server" Text="帳號："></asp:Label>
        <asp:TextBox ID="Tb_Login_Username" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Lab_Login_Password" runat="server" Text="密碼："></asp:Label>
            <asp:TextBox ID="Tb_Login_Password" runat="server" TextMode="Password"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Btn_Login" runat="server" Height="40px" Text="確定" Width="200px" OnClick="Btn_Login_Click" style="margin-top: 0px" />
        </p>
        <p>
            <asp:Button ID="Btn_Register" runat="server" Height="20px" OnClick="Btn_Register_Click" Text="註冊" Width="200px" />
        </p>
    </form>
</body>
</html>
