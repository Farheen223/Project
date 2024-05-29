<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            border-style: inset;
            border-width: 2px;
            padding: 1px 2px;
            height: 1px;
            width: 1px;
        }
        .auto-style2 {
            border-style: inset;
            padding: 1px 2px;
            height: 1px;
            width: 2px;
            margin-top: 0px;
        }
        .auto-style4 {
            border-style: none;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p class="auto-style1">
            &nbsp;</p>
        <div>
        </div>
        <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 12px; top: 38px; position: absolute" Text="Staff ID" width="95px"></asp:Label>
        <p class="auto-style2">
            <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 114px; top: 68px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblNumber" runat="server" style="z-index: 1; left: 8px; top: 125px; position: absolute" Text="PhoneNumber" width="95px"></asp:Label>
        </p>
            <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 113px; top: 36px; position: absolute"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 12px; top: 97px; position: absolute; height: 18px" Text="Email" width="95px"></asp:Label>
            <asp:Label ID="lblHours0" runat="server" style="z-index: 1; left: 12px; top: 154px; position: absolute" Text="HoursWorked" width="95px"></asp:Label>
        </p>
        <asp:Label ID="lblStaffName" runat="server" style="z-index: 1; left: 12px; top: 69px; position: absolute; height: 19px" Text="Name" width="95px"></asp:Label>
        <asp:CheckBox ID="chkFulltime" runat="server" style="z-index: 1; left: 94px; top: 216px; position: absolute" Text="FullTime" OnCheckedChanged="chkFulltime_CheckedChanged" />
        <asp:TextBox ID="txtDateAdded" runat="server" OnTextChanged="txtDateCreated_TextChanged" style="z-index: 1; left: 114px; top: 186px; position: absolute"></asp:TextBox>
        <p class="auto-style4">
            <asp:Label ID="lblAccount" runat="server" style="z-index: 1; left: 12px; top: 189px; position: absolute; width: 95px; margin-bottom: 0px" Text="Date Created"></asp:Label>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Find"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" Width="68px" />
        </p>
        <p style="height: 58px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 96px; top: 315px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="BtnMainMenu" runat="server" OnClick="BtnMainMenu_Click" Text="Return to main menu" style="margin-bottom: 14px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
            <asp:TextBox ID="txtHoursWorked" runat="server" style="z-index: 1; left: 114px; top: 152px; position: absolute"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 40px; top: 314px; position: absolute; height: 26px;" Text="Ok" />
        </p>
        <p>
            <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 114px; top: 95px; position: absolute"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
        <p class="auto-style1">
            <asp:TextBox ID="txtPhoneNumber" runat="server" style="z-index: 1; left: 114px; top: 121px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 17px; top: 268px; position: absolute; height: 7px;"></asp:Label>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    </form>
</body>
</html>
