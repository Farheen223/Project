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
        <asp:TextBox ID="txtPaymentSuccessful" runat="server" OnTextChanged="txtPaymentSuccessful_TextChanged" style="z-index: 1; left: 135px; top: 93px; position: absolute"></asp:TextBox>
        <p>
            <asp:Label ID="lblTotalAmount" runat="server" style="z-index: 1; left: 6px; top: 64px; position: absolute" Text="Total Amount" width="119px"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblPaymentSuccessful" runat="server" style="z-index: 1; left: 6px; top: 94px; position: absolute; right: 546px" Text="Payment Successful"></asp:Label>
        </p>
        <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 6px; top: 129px; position: absolute" Text="Staff ID" width="119px"></asp:Label>
        <p>
            <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 135px; top: 128px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 6px; top: 167px; position: absolute" Text="Customer ID" width="119px"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 135px; top: 166px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblDate" runat="server" style="z-index: 1; left: 6px; top: 205px; position: absolute; width: 119px" Text="Date"></asp:Label>
        <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 135px; top: 204px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 61px; top: 245px; position: absolute" Text="Active" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 73px; top: 319px; position: absolute" Text="OK" />
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 120px; top: 319px; position: absolute" Text="Cancel" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 14px; top: 302px; position: absolute"></asp:Label>
    </form>
</body>
</html>
