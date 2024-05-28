<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtOrderId" runat="server" style="z-index: 1; left: 135px; top: 33px; position: absolute"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 9px; top: 32px; position: absolute" Text="Order ID" width="119px"></asp:Label>
        </p>
        <asp:TextBox ID="txtTotalAmount" runat="server" style="z-index: 1; left: 135px; top: 62px; position: absolute"></asp:TextBox>
        <p>
            <asp:Label ID="lblTotalAmount" runat="server" style="z-index: 1; left: 6px; top: 64px; position: absolute" Text="Total Amount" width="119px"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 6px; top: 129px; position: absolute" Text="Staff ID" width="119px"></asp:Label>
        <p>
            <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 135px; top: 128px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblQuantity" runat="server" Text="Quantity"></asp:Label>
            <asp:TextBox ID="txtQuantity" runat="server" style="margin-left: 73px; margin-bottom: 0px" Width="120px"></asp:TextBox>
        </p>
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 6px; top: 167px; position: absolute" Text="Customer ID" width="119px"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 135px; top: 166px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblDate" runat="server" style="z-index: 1; left: 6px; top: 205px; position: absolute; width: 119px" Text="Date"></asp:Label>
        <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 135px; top: 204px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkPaymentSuccessful" runat="server" style="z-index: 1; left: 61px; top: 374px; position: absolute" Text="Payment Successful" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 73px; top: 439px; position: absolute" Text="OK" />
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 120px; top: 439px; position: absolute" Text="Cancel" />
            <asp:Label ID="lblStockId" runat="server" Text="Stock ID"></asp:Label>
            <asp:TextBox ID="txtStockId" runat="server" style="margin-left: 71px" Width="115px"></asp:TextBox>
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 17px; top: 405px; position: absolute"></asp:Label>
    </form>
</body>
</html>
