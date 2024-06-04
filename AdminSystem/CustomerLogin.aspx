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
        Customer Login Page<asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 282px; top: 127px; position: absolute"></asp:Label>
        </p>
        <asp:Label ID="lblUserName" runat="server" Text="UserName" style="z-index: 1; left: 10px; top: 91px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="margin-left: 2px; z-index: 1; left: 106px; top: 90px; position: absolute;"></asp:TextBox>
        <p>
            <asp:Label ID="lblPassword" runat="server" Text="Password" style="z-index: 1; left: 10px; top: 129px; position: absolute"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" style="margin-left: 1px; z-index: 1; left: 107px; top: 125px; position: absolute;" TextMode="Password" Width="128px" height="22px"></asp:TextBox>
        <asp:Button ID="btnCancel" runat="server" Height="25px" style="margin-left: 0px; z-index: 1; left: 82px; top: 168px; position: absolute;" Text="Cancel" Width="56px" OnClick="btnCancel_Click" />
        </p>
        <asp:Button ID="btnLogin" runat="server" Height="25px" OnClick="btnLogin_Click" style="margin-left: 2px; z-index: 1; left: 10px; top: 167px; position: absolute;" Text="Login" Width="52px" />
    </form>
    </body>
</html>
