<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 626px">
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 40px; top: 86px; position: absolute; margin-bottom: 3px" Text="Are you sure you wan to delete this record?"></asp:Label>
        </p>
        <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 96px; top: 133px; position: absolute" Text="Yes" OnClick="btnYes_Click" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 174px; top: 133px; position: absolute" Text="No" height="26px" OnClick="btnNo_Click" width="37px" />
    </form>
</body>
</html>
