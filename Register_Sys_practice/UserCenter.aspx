<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserCenter.aspx.cs" Inherits="Register_Sys_practice.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Lab_Center_Title" runat="server"></asp:Label>
        </div>
        <p>
            <asp:Label ID="Lab_Center_Username" runat="server" Text="帳號："></asp:Label>
        </p>
        <asp:Label ID="Lab_Center_Realname" runat="server" Text="姓名："></asp:Label>
        <p>
            <asp:Label ID="Lab_Center_Birthday" runat="server" Text="生日："></asp:Label>
        </p>
        <asp:Label ID="Lab_Center_Email" runat="server" Text="信箱："></asp:Label>
        <p>
            <asp:Label ID="Lab_Center_Buildday" runat="server" Text="建立時間："></asp:Label>
        </p>
        <asp:Label ID="Lab_Center_Authority" runat="server" Text="帳號權限："></asp:Label>
        <p>
            <asp:Button ID="Btn_Center_Logout" runat="server" OnClick="Btn_Center_Logout_Click" Text="登出" />
            <asp:Button ID="Btn_Center_Editpassword" runat="server" OnClick="Btn_Center_Editpassword_Click" Text="修改密碼" />
            <asp:Button ID="Btn_Center_Edit" runat="server" OnClick="Btn_Center_Edit_Click" Text="編輯" />
        </p>
        <p>
            <asp:Button ID="btn_Center_Authoritytable" runat="server" OnClick="btn_Center_Authoritytable_Click" Text="帳號權限列表" Width="157px" />
        </p>
    </form>
</body>
</html>
