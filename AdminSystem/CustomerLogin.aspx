<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerLogin.aspx.cs" Inherits="CustomerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Login Page </title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    <p>
        Customer Login Page</p>
        <asp:Label ID="lblUserName" runat="server" Text="UserName"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="margin-left: 36px"></asp:TextBox>
        <p>
            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" style="margin-left: 39px" TextMode="Password" Width="123px"></asp:TextBox>
            <asp:Label ID="lblError" runat="server" ForeColor="#FF3300"></asp:Label>
        </p>
        <asp:Button ID="btnLogin" runat="server" Height="25px" OnClick="btnLogin_Click" style="margin-left: 52px" Text="Login" Width="52px" />
        <asp:Button ID="btnCancel" runat="server" Height="25px" style="margin-left: 44px" Text="Cancel" Width="56px" OnClick="btnCancel_Click" />
    </form>
    </body>
</html>
