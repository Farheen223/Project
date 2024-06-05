<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 771px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblMainMenu" runat="server" Text="Order Main Menu"></asp:Label>
        </p>
        <asp:Button ID="btnOrders" runat="server" Text="Orders" style="z-index: 1; left: 11px; top: 89px; position: absolute" OnClick="btnOrders_Click" />
        <asp:Button ID="btnStocks" runat="server" style="z-index: 1; left: 100px; top: 90px; position: absolute" Text="Stocks" />
        <asp:Button ID="btnStaffs" runat="server" style="z-index: 1; left: 197px; top: 90px; position: absolute" Text="Staffs" />
        <asp:Button ID="btnSupplier" runat="server" Text="Supplier"  style="z-index: 1; left: 279px; top: 91px; position: absolute"/>
        <asp:Button ID="btnCustomers" runat="server" style="z-index: 1; left: 381px; top: 92px; position: absolute; width: 81px" Text="Customers" />
    </form>
</body>
</html>
