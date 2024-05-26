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
        <asp:TextBox ID="txtOrderId" runat="server" style="z-index: 1; left: 135px; top: 33px; position: absolute" height="19px"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" Text="Find" Height="26px" style="margin-left: 295px" Width="71px" />
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 9px; top: 35px; position: absolute" Text="Order ID" width="119px"></asp:Label>
        </p>
        <asp:TextBox ID="txtTotalAmount" runat="server" style="z-index: 1; left: 135px; top: 62px; position: absolute" height="19px"></asp:TextBox>
        <asp:TextBox ID="txtPaymentSuccessful" runat="server" OnTextChanged="txtPaymentSuccessful_TextChanged" style="z-index: 1; left: 135px; top: 93px; position: absolute" height="19px"></asp:TextBox>
        <p>
            <asp:Label ID="lblTotalAmount" runat="server" style="z-index: 1; left: 6px; top: 64px; position: absolute" Text="Total Amount" width="119px" height="19px"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblPaymentSuccessful" runat="server" style="z-index: 1; left: 6px; top: 94px; position: absolute; right: 546px" Text="Payment Successful" height="19px" width="119px"></asp:Label>
        </p>
        <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 6px; top: 143px; position: absolute" Text="Staff ID" width="119px" height="19px"></asp:Label>
        <asp:Label ID="lblQuantity" runat="server" height="19px" Text="Quantity" width="119px"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server" height="19px" style="margin-left: 5px" Width="120px"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 135px; top: 128px; position: absolute" height="19px"></asp:TextBox>
            <asp:Label ID="lblStockId" runat="server" Text="Stock ID" width="119px"></asp:Label>
            <asp:TextBox ID="txtStockId" runat="server" height="19px" style="margin-left: 142px" Width="114px"></asp:TextBox>
        </p>
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 6px; top: 171px; position: absolute" Text="Customer ID" width="119px" height="19px"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 135px; top: 166px; position: absolute" height="19px"></asp:TextBox>
        <asp:Label ID="lblDate" runat="server" style="z-index: 1; left: 6px; top: 213px; position: absolute; width: 119px" Text="Date" height="19px"></asp:Label>
        <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 135px; top: 204px; position: absolute" height="19px"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 137px; top: 357px; position: absolute" Text="Active" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 25px; top: 423px; position: absolute" Text="OK" />
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 73px; top: 424px; position: absolute" Text="Cancel" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 17px; top: 383px; position: absolute"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
