<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockLogin.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 614px;
        }
    </style>
</head>
<body style="height: 261px">
    <form id="form1" runat="server">
    <asp:Label ID="lblLoginPage" runat="server" style="z-index: 1; top: 43px; position: absolute; left: 194px;" Text="Stock Login Page"></asp:Label>
    <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 94px; top: 140px; position: absolute" Text="UserName"></asp:Label>
    <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 94px; top: 180px; position: absolute" Text="Password"></asp:Label>
    <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 193px; top: 136px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 192px; top: 176px; position: absolute; right: 1142px;" TextMode="Password"></asp:TextBox>
    <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 436px; top: 155px; position: absolute"></asp:Label>
    <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 164px; top: 239px; position: absolute" Text="Login" />
    <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 251px; top: 240px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
</form>
</body>
</html>
