<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 15px; top: 440px; position: absolute" Text="Add" />
        <asp:ListBox ID="lstSupplierList" runat="server" style="z-index: 1; left: 15px; top: 54px; position: absolute; height: 360px; width: 402px"></asp:ListBox>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 70px; top: 440px; position: absolute; " Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 139px; top: 440px; position: absolute" Text="Delete" />
        <p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 12px; top: 622px; position: absolute"></asp:Label>
        </p>
        <asp:Label ID="lblCity" runat="server" style="z-index: 1; left: 18px; top: 513px; position: absolute" Text="Enter a city name"></asp:Label>
        <asp:TextBox ID="txtCity" runat="server" style="z-index: 1; left: 142px; top: 513px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 35px; top: 564px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 167px; top: 565px; position: absolute" Text="Clear Filter" />
    </form>
</body>
</html>
