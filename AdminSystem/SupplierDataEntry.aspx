<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Add a new supplier</h2>
        </div>

<%--
        <asp:Label ID="lblSupplierName" runat="server" Style="z-index: 1; left: 10px; top: 36px; width: 186px;" Text="Supplier's name"></asp:Label>
        <asp:TextBox ID="txtSupplierName" runat="server" Style="z-index: 1; left: 192px; top: 34px; width: 128px"></asp:TextBox>
        <br />

        <asp:Label ID="lblSupplier" runat="server" Style="z-index: 1; left: 10px; top: 62px;" Text="Supplier's city" Width="186px"></asp:Label>
        <asp:TextBox ID="txtSupplierCity" runat="server" Style="z-index: 1; left: 192px; top: 63px;" Width="128px"></asp:TextBox>
        <br />

        <asp:Label ID="lblSupplierEmail" runat="server" Style="z-index: 1; left: 10px; top: 91px;" Text="Supplier's email" Width="186px"></asp:Label>
        <asp:TextBox ID="txtSupplierEmail" runat="server" Style="z-index: 1; left: 192px; top: 91px;" Width="128px"></asp:TextBox>
        <br />

        <asp:Label ID="lblSupplierTelephoneNumber" runat="server" Style="z-index: 1; left: 10px; top: 116px; right: 1330px;" Text="Supplier's telephone number" width="186px"></asp:Label>
        <asp:TextBox ID="txtSupplierTelephoneNumber" runat="server" Style="z-index: 1; left: 192px; top: 116px" width="128px"></asp:TextBox>
        <br />

        <asp:CheckBox ID="chkSupplierAvailability" runat="server" Style="z-index: 1; left: 107px; top: 161px;" Text="Is the supplier available?" />
        <asp:Label ID="lblError" runat="server" Style="z-index: 1; left: 13px; top: 204px"></asp:Label>
        <br />

        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Style="z-index: 1; left: 10px; top: 243px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Style="z-index: 1; left: 54px; top: 243px" Text="Cancel" />
        <br />
    --%>
        <asp:Label ID="lblSupplierName" runat="server" Style="z-index: 1; left: 9px; top: 73px; position: absolute; width: 186px;" Text="Supplier's name" height="19px"></asp:Label>
        <asp:TextBox ID="txtSupplierName" runat="server" Style="z-index: 1; left: 206px; top: 72px; position: absolute; width: 128px"></asp:TextBox>

        <asp:Label ID="lblSupplier" runat="server" Style="z-index: 1; left: 9px; top: 119px; position: absolute; " Text="Supplier's city" Width="186px" height="19px"></asp:Label>
        <asp:TextBox ID="txtSupplierCity" runat="server" Style="z-index: 1; left: 206px; top: 118px; position: absolute" Width="128px"></asp:TextBox>

        <asp:Label ID="lblSupplierEmail" runat="server" Style="z-index: 1; left: 9px; top: 161px; position: absolute" Text="Supplier's email" Width="186px" height="19px"></asp:Label>
        <asp:TextBox ID="txtSupplierEmail" runat="server" Style="z-index: 1; left: 206px; top: 160px; position: absolute" Width="128px"></asp:TextBox>

        <asp:Label ID="lblSupplierTelephoneNumber" runat="server" Style="z-index: 1; left: 9px; top: 198px; position: absolute; right: 1396px; width: 186px;" Text="Supplier's telephone number"></asp:Label>
        <asp:TextBox ID="txtSupplierTelephoneNumber" runat="server" Style="z-index: 1; left: 206px; top: 197px; position: absolute" width="128px"></asp:TextBox>

        <asp:CheckBox ID="chkSupplierAvailability" runat="server" Style="z-index: 1; left: 88px; top: 265px; position: absolute" Text="Is the supplier available?" />
        <asp:Label ID="lblError" runat="server" Style="z-index: 1; left: 17px; top: 315px; position: absolute"></asp:Label>

        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 74px; top: 373px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 231px; top: 373px; position: absolute" Text="Cancel" />

    </form>
</body>
</html>
