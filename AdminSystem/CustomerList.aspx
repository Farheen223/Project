<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" Height="372px" Width="472px" OnSelectedIndexChanged="lstCustomerList_SelectedIndexChanged"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="54px" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" style="margin-left: 38px" width="54px" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="margin-left: 47px" Text="Delete" width="54px" />
        </p>
        <p>
            <asp:Label ID="lblEnterEmail" runat="server" Text="Enter Email"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" style="margin-left: 46px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApply_Click" Text="Apply Filter" Width="100px" />
            <asp:Button ID="btnClearFilter" runat="server" Height="27px" OnClick="btnClearFilter_Click" style="margin-left: 60px" Text="Clear Filter" Width="101px" />
            <asp:Button ID="btnReturnToMainMenu" runat="server" OnClick="btnReturnToMainMenu_Click" style="margin-left: 56px" Text="Return to Main Menu" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </form>
</body>
</html>
