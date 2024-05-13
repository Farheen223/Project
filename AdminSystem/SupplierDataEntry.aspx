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
        <asp:Label ID="lblSupplierId" runat="server" height="19px" style="z-index: 1; left: 13px; top: 112px; position: absolute" Text="Supplier ID" width="186px"></asp:Label>
        <asp:TextBox ID="txtSupplierId" runat="server" style="z-index: 1; left: 218px; top: 111px; position: absolute" width="128px"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 400px; top: 112px; position: absolute" Text="Find" OnClick="btnFind_Click" />

        <asp:Label ID="lblSupplierName" runat="server" Style="z-index: 1; left: 13px; top: 149px; position: absolute; width: 186px;" Text="Supplier's name" height="19px"></asp:Label>
        <asp:TextBox ID="txtSupplierName" runat="server" Style="z-index: 1; left: 218px; top: 148px; position: absolute; width: 128px"></asp:TextBox>

        <asp:Label ID="lblSupplier" runat="server" Style="z-index: 1; left: 13px; top: 200px; position: absolute; " Text="Supplier's city" Width="186px" height="19px"></asp:Label>
        <asp:TextBox ID="txtSupplierCity" runat="server" Style="z-index: 1; left: 218px; top: 199px; position: absolute" Width="128px"></asp:TextBox>

        <asp:Label ID="lblSupplierEmail" runat="server" Style="z-index: 1; left: 13px; top: 243px; position: absolute" Text="Supplier's email" Width="186px" height="19px"></asp:Label>
        <asp:TextBox ID="txtSupplierEmail" runat="server" Style="z-index: 1; left: 218px; top: 242px; position: absolute" Width="128px"></asp:TextBox>

        <asp:Label ID="lblSupplierTelephoneNumber" runat="server" Style="z-index: 1; left: 13px; top: 282px; position: absolute; right: 1455px; width: 186px;" Text="Supplier's telephone number"></asp:Label>
        <asp:TextBox ID="txtSupplierTelephoneNumber" runat="server" Style="z-index: 1; left: 218px; top: 281px; position: absolute" width="128px"></asp:TextBox>

        <asp:CheckBox ID="chkSupplierAvailability" runat="server" Style="z-index: 1; left: 101px; top: 349px; position: absolute" Text="Is the supplier available?" />
        <asp:Label ID="lblError" runat="server" Style="z-index: 1; left: 16px; top: 406px; position: absolute"></asp:Label>

        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 69px; top: 506px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 225px; top: 507px; position: absolute" Text="Cancel" />

    </form>
</body>
</html>
