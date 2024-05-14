<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin-left: 43px; height: 369px; width: 901px;">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 43px; top: 140px; position: absolute; width: 109px; height: 18px; right: 465px; bottom: 475px" Text="Customer ID"></asp:Label>
        </div>
        <p>
            <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 194px; top: 137px; position: absolute; bottom: 407px; width: 126px"></asp:TextBox>
            <asp:Label ID="LblCustomerName" runat="server" style="z-index: 1; left: 43px; top: 167px; position: absolute; width: 130px;" Text="Customer Name"></asp:Label>
            <asp:TextBox ID="txtCustomerName" runat="server" OnTextChanged="txtAddressId_TextChanged" style="z-index: 1; left: 193px; top: 163px; position: absolute" width="126px"></asp:TextBox>
        </p>
        <asp:Label ID="LblDateOfBirth" runat="server" style="z-index: 1; left: 43px; top: 202px; position: absolute" Text="Date Of Birth" width="109px"></asp:Label>
        <asp:TextBox ID="txtHouseNo" runat="server" OnTextChanged="txtHouseNo_TextChanged" style="z-index: 1; left: 193px; top: 196px; position: absolute; margin-bottom: 14px" width="126px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:CheckBox ID="ChkActive" runat="server" style="z-index: 1; left: 193px; top: 275px; position: absolute" Text="Active" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 56px; top: 288px; position: absolute" width="59px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 59px; top: 331px; position: absolute" Text="OK" width="59px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 148px; top: 332px; position: absolute" Text="Cancel" width="59px" />
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 41px; top: 241px; position: absolute; height: 22px; width: 109px" Text="Email"></asp:Label>
        </p>
        <asp:TextBox ID="TxtEmail" runat="server" style="z-index: 1; left: 192px; top: 238px; position: absolute" width="126px"></asp:TextBox>
    </form>
</body>
</html>
