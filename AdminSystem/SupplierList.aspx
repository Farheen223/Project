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
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 15px; top: 439px; position: absolute" Text="Add" />
        <asp:ListBox ID="lstSupplierList" runat="server" style="z-index: 1; left: 15px; top: 54px; position: absolute; height: 360px; width: 402px"></asp:ListBox>
    </form>
</body>
</html>
