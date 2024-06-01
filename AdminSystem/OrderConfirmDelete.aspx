<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Are you sure you want to delete this record?<p>
            <asp:Button ID="btnYesDelete" runat="server" OnClick="btnYesDelete_Click" style="margin-left: 50px" Text="Yes" Width="80px" />
            <asp:Button ID="btnNoDelete" runat="server" OnClick="btnNoDelete_Click" style="margin-left: 100px" Text="No" Width="80px" />
        </p>
    </form>
</body>
</html>
