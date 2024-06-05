<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLogin.aspx.cs" Inherits="OrderLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="lblOrderLoginPage" runat="server" Text="Order Login Page"></asp:Label>
        </p>
        <asp:Label ID="lblUserName" runat="server" Text="UserName:"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="margin-left: 10px"></asp:TextBox>
        <p>
            <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" Height="16px" style="margin-left: 17px" TextMode="Password"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" ForeColor="#FF3300"></asp:Label>
        </p>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="margin-left: 82px" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="margin-left: 17px" Text="Cancel" />
    </form>
</body>
</html>
