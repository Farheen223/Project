<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupllierConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

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
            <asp:Label ID="lblConfirm" runat="server" style="z-index: 1; left: 175px; top: 205px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnYes" runat="server" height="26px" OnClick="btnYes_Click" style="z-index: 1; left: 208px; top: 248px; position: absolute; right: 265px" Text="Yes" width="56px" />
        <asp:Button ID="btnNo" runat="server" height="26px" OnClick="btnNo_Click" style="z-index: 1; top: 248px; position: absolute; left: 338px" Text="No" width="56px" />
    </form>
</body>
</html>
