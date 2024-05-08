<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblSupplierName" runat="server" style="z-index: 1; left: 11px; top: 36px; position: absolute; right: 936px" Text="Supplier's name" width="170px"></asp:Label>
        <asp:TextBox ID="txtSupplierName" runat="server" style="z-index: 1; left: 112px; top: 34px; position: absolute; width: 128px"></asp:TextBox>
        <p>
            <asp:Label ID="lblSupplier" runat="server" style="z-index: 1; left: 9px; top: 62px; position: absolute; right: 938px" Text="Supplier's city" width="170px"></asp:Label>
            <asp:TextBox ID="txtSupplierCity" runat="server" style="z-index: 1; left: 110px; top: 63px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblSupplierEmail" runat="server" style="z-index: 1; left: 10px; top: 91px; position: absolute" Text="Supplier's email" width="170px"></asp:Label>
            <asp:TextBox ID="txtSupplierEmail" runat="server" style="z-index: 1; left: 112px; top: 91px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblSupplierTelephoneNumber" runat="server" style="z-index: 1; left: 10px; top: 116px; position: absolute" Text="Supplier's telephone number"></asp:Label>
            <asp:TextBox ID="txtSupplierTelephoneNumber" runat="server" style="z-index: 1; left: 192px; top: 116px; position: absolute"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:CheckBox ID="lblSupplierAvailability" runat="server" style="z-index: 1; left: 107px; top: 161px; position: absolute" Text="Is the supplier available?" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 204px; position: absolute"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 10px; top: 243px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 54px; top: 243px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
