<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditPage.aspx.cs" Inherits="Register_Sys_practice.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Lab_Edit_Title" runat="server" Text="請輸入修改資料"></asp:Label>
            <br />
            <asp:Label ID="Lab_Warning" runat="server" ForeColor="#CC0000"></asp:Label>
            <br />
        <p>
            姓名：<asp:TextBox ID="Tb_Edit_Realname" runat="server"></asp:TextBox>
        </p>
        <p>
            生日：<asp:TextBox ID="Tb_Edit_Birthday" runat="server"></asp:TextBox>
        </p>
        <p>
            信箱：<asp:TextBox ID="Tb_Edit_Email" runat="server"></asp:TextBox>
        </p>
            <p>
                <asp:Button ID="Btn_Edit_OK" runat="server" OnClick="Btn_Edit_OK_Click" Text="確定" Width="195px" />
        </p>
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
