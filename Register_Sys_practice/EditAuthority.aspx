<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditAuthority.aspx.cs" Inherits="Register_Sys_practice.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Lab_Authroity_Username" runat="server" Text="帳號："></asp:Label>
            <br />
            <asp:Label ID="Lab_Warning" runat="server" ForeColor="#CC0000"></asp:Label>
            <br />
            <br />
            權限：<asp:RadioButtonList ID="rbl_Edit_Authority" runat="server" OnSelectedIndexChanged="rbl_Edit_Authority_SelectedIndexChanged" RepeatDirection="Horizontal">
                <asp:ListItem Value="1">一般會員</asp:ListItem>
                <asp:ListItem Value="2">VIP會員</asp:ListItem>
                <asp:ListItem Value="3">管理者</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <p>
            <asp:Button ID="Btn_Edit_Authority_OK" runat="server" Height="38px" OnClick="Btn_Edit_OK_Click" Text="確定" Width="239px" />
        </p>
    </form>
</body>
</html>
