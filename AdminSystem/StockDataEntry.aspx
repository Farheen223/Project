<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 337px">
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtitemID" runat="server" style="z-index: 1; left: 124px; top: 33px; position: absolute"></asp:TextBox>
        </div>
        <asp:Label ID="lblItemID" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="ItemID" width="100px"></asp:Label>
        <p>
            <asp:Label ID="lblSupplierID" runat="server" style="z-index: 1; left: 9px; top: 64px; position: absolute" Text="Supplier ID" width="100px"></asp:Label>
        </p>
        <asp:TextBox ID="txtSupplierID" runat="server" OnTextChanged="txtSupplierID_TextChanged" style="z-index: 1; left: 124px; top: 61px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblItemName" runat="server" style="z-index: 1; left: 10px; top: 97px; position: absolute" Text="Item Name" width="100px"></asp:Label>
        <asp:TextBox ID="txtItemDescription" runat="server" style="z-index: 1; left: 124px; top: 129px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtItemName" runat="server" style="z-index: 1; left: 124px; top: 94px; position: absolute"></asp:TextBox>
        <p>
            <asp:Label ID="lblItemDescription" runat="server" style="z-index: 1; left: 10px; top: 129px; position: absolute" Text="Item Description"></asp:Label>
        </p>
        <asp:Label ID="lblSupplyDate" runat="server" style="z-index: 1; left: 11px; top: 167px; position: absolute; height: 1px" Text="Supply Date" width="100px"></asp:Label>
        <asp:TextBox ID="txtSupplyDate" runat="server" OnTextChanged="txtSupplyDate_TextChanged" style="z-index: 1; left: 124px; top: 165px; position: absolute; width: 119px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:CheckBox ID="chkInStock" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" style="z-index: 1; left: 125px; top: 199px; position: absolute" Text="In Stock?" />
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 75px; top: 276px; position: absolute" Text="Cancel" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 243px; position: absolute; height: 34px" Text="Label"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 19px; top: 276px; position: absolute" Text="OK" />
    </form>
</body>
</html>
