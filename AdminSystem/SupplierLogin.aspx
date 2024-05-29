<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierLogin.aspx.cs" Inherits="SupplierLogin" %>

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
            <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 24px; top: 56px; position: absolute" Text="Supplier login page"></asp:Label>
        </p>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 45px; top: 135px; position: absolute" Text="UserName:"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 129px; top: 134px; position: absolute"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 129px; top: 171px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 45px; top: 172px; position: absolute" Text="Password:"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 54px; top: 228px; position: absolute; right: 1151px;" Text="Login" height="26px" width="60px" />
        <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 323px; top: 189px; position: absolute"></asp:Label>
        <p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 212px; top: 229px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        </p>
    </form>
</body>
</html>
