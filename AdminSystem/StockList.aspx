<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 614px;
        }
    </style>
</head>
<body style="height: 261px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStockList" runat="server" Height="267px" Width="634px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 26px; top: 326px; position: absolute; height: 26px;" Text="Add" width="37px" />
        <asp:Button ID="btnAdd0" runat="server" style="z-index: 1; left: 26px; top: 326px; position: absolute; height: 26px;" Text="Add" width="37px" />
        <asp:Button ID="lblEdit" runat="server" OnClick="lblEdit_Click" style="z-index: 1; left: 84px; top: 326px; position: absolute" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 27px; top: 464px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 138px; top: 327px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 130px; top: 385px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblEnterItemName" runat="server" style="z-index: 1; left: 20px; top: 386px; position: absolute" Text="Enter item name"></asp:Label>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 25px; top: 420px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 145px; top: 420px; position: absolute" Text="Clear Filter" />
        <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="z-index: 1; left: 491px; top: 358px; position: absolute" Text="Return to main menu" />
    </form>
</body>
</html>
