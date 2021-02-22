<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditPasswordPage.aspx.cs" Inherits="Register_Sys_practice.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Lab_Editpassword_Title" runat="server" Text="請輸入修改資料"></asp:Label>
            <br />
            <asp:Label ID="Lab_Warning" runat="server" ForeColor="#CC0000"></asp:Label>
        </div>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 密碼：<asp:TextBox ID="Tb_Editpassword_Password" runat="server" TextMode="Password"></asp:TextBox>
        </p>
        <p>
            確認密碼：<asp:TextBox ID="Tb_Editpassword_Confirm" runat="server" TextMode="Password"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Btn_Editpassword_OK" runat="server" OnClick="Btn_Editpassword_OK_Click" Text="確定" Width="225px" />
        </p>
    </form>
</body>
</html>
