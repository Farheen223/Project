<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin-left: 43px; height: 369px; width: 901px;">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 44px; top: 71px; position: absolute; width: 109px; height: 18px; right: 1276px; " Text="Customer Id"></asp:Label>
            <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 194px; top: 71px; position: absolute; width: 126px" height="22"></asp:TextBox>
            <asp:Label ID="LblCustomerName" runat="server" style="z-index: 1; left: 43px; top: 113px; position: absolute; width: 109px;" Text="Customer Name"></asp:Label>
            <asp:TextBox ID="txtCustomerName" runat="server" OnTextChanged="txtAddressId_TextChanged" style="z-index: 1; left: 194px; top: 113px; position: absolute; " width="126px" height="22"></asp:TextBox>
        <asp:Label ID="LblDateAdded" runat="server" style="z-index: 1; left: 41px; top: 160px; position: absolute" Text="DateAdded" width="109px"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server" OnTextChanged="txtDateOfBirth_TextChanged" style="z-index: 1; left: 190px; top: 168px; position: absolute; margin-bottom: 14px" width="126px"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 204px; top: 317px; position: absolute" Text="Active" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 47px; top: 338px; position: absolute" width="59px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 50px; top: 373px; position: absolute; right: 1053px;" Text="OK" width="59px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 124px; top: 374px; position: absolute" Text="Cancel" width="59px" height="26px" />
            <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 43px; top: 203px; position: absolute; height: 22px; width: 109px" Text="Email"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 188px; top: 211px; position: absolute" width="126px"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
 </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblCustomerSurname" runat="server" Text="CustomerSurname"></asp:Label>
        <asp:TextBox ID="TxtCustomerSurname" runat="server" width="134px"></asp:TextBox>
        <p>
            <asp:Label ID="lblContactNumber" runat="server" Text="ContactNumber"></asp:Label>
            <asp:TextBox ID="TxtContactNumber" runat="server" width="134px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
