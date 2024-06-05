<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 594px;
        }
    </style>
</head>
<body style="height: 594px">
    <form id="form1" runat="server">
        <asp:TextBox ID="txtOrderId" runat="server" style="z-index: 1; left: 141px; top: 253px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 16px; top: 258px; position: absolute; width: 66px;" Text="Order ID"></asp:Label>
        <asp:TextBox ID="txtTotalAmount" runat="server" style="z-index: 1; left: 139px; top: 205px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblTotalAmount" runat="server" style="z-index: 1; left: 23px; top: 204px; position: absolute; width: 93px;" Text="Total Amount"></asp:Label>
        <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 27px; top: 132px; position: absolute; width: 83px;" Text="Staff ID"></asp:Label>
        <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 135px; top: 128px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblQuantity" runat="server" Text="Quantity"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server" style="margin-left: 73px; margin-bottom: 0px" Width="120px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 135px; top: 166px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblDate" runat="server" style="z-index: 1; left: 25px; top: 303px; position: absolute; width: 44px" Text="Date"></asp:Label>
        <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 141px; top: 301px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkPaymentSuccessful" runat="server" style="z-index: 1; left: 61px; top: 374px; position: absolute" Text="Payment Successful" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 120px; top: 439px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:TextBox ID="txtStockId" runat="server" style="z-index: 1; left: 137px; top: 71px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 17px; top: 405px; position: absolute"></asp:Label>
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 23px; top: 170px; position: absolute; width: 88px;" Text="Customer ID"></asp:Label>
        <asp:Label ID="lblStockId" runat="server" Text="Stock ID" style="z-index: 1; left: 20px; top: 76px; position: absolute"></asp:Label>
        <asp:Button ID="btnReturnMainMenu" runat="server" Style="z-index: 1; left: 334px; top: 422px; position: absolute; width: 172px; height: 31px" Text="Return to Main Menu" OnClick="btnReturnMainMenu_Click" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click1" style="z-index: 1; left: 18px; top: 439px; position: absolute; height: 25px; width: 40px" Text="OK" />
    </form>
</body>
</html>
