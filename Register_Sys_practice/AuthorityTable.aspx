<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AuthorityTable.aspx.cs" Inherits="Register_Sys_practice.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Lab_Edit_Title" runat="server" Text="帳號權限列表"></asp:Label>
            <br />
            <asp:Label ID="Lab_Warning" runat="server" ForeColor="#CC0000"></asp:Label>
            <br />
            <asp:Button ID="btn_Authority_Goback" runat="server" OnClick="btn_Authority_Goback_Click" Text="返回主選單" />
            <asp:Table ID="table_Authority_Table" runat="server" GridLines="Vertical">
                <asp:TableRow runat="server" Font-Bold="True">
                    <asp:TableCell runat="server">UserName</asp:TableCell>
                    <asp:TableCell runat="server">Authority</asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
