<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 12px; top: 38px; position: absolute" Text="Staff ID" width="95px"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 12px; top: 97px; position: absolute; height: 18px" Text="Email" width="95px"></asp:Label>
            <asp:Label ID="lblHours0" runat="server" style="z-index: 1; left: 12px; top: 154px; position: absolute" Text="HoursWorked" width="95px"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 114px; top: 36px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblStaffName" runat="server" style="z-index: 1; left: 12px; top: 69px; position: absolute; height: 19px" Text="Name" width="95px"></asp:Label>
        <asp:Label ID="lblNumber" runat="server" style="z-index: 1; left: 12px; top: 125px; position: absolute" Text="PhoneNumber" width="95px"></asp:Label>
        <asp:CheckBox ID="chkFulltime" runat="server" style="z-index: 1; left: 93px; top: 220px; position: absolute" Text="FullTime" OnCheckedChanged="chkFulltime_CheckedChanged" />
        <asp:TextBox ID="txtDateCreated" runat="server" OnTextChanged="txtDateCreated_TextChanged" style="z-index: 1; left: 114px; top: 186px; position: absolute"></asp:TextBox>
        <p>
            <asp:Label ID="lblAccount" runat="server" style="z-index: 1; left: 12px; top: 189px; position: absolute; right: 627px; width: 95px; margin-bottom: 0px" Text="Date Created"></asp:Label>
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 118px; top: 313px; position: absolute" Text="Ok" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 114px; top: 68px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 25px; top: 312px; position: absolute" Text="Cancel" />
        </p>
        <p>
            <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 115px; top: 95px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtPhoneNumber" runat="server" style="z-index: 1; left: 116px; top: 121px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 19px; top: 249px; position: absolute"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtHoursWorked" runat="server" style="z-index: 1; left: 114px; top: 152px; position: absolute"></asp:TextBox>
        </p>
    </form>
</body>
</html>
