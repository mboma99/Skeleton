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
        <asp:Label ID="lblStaffID" runat="server" style="margin-bottom:10px;" Text="Staff ID" Width="100px"></asp:Label>
        <asp:TextBox ID="txtStaffID" runat="server" Width="60px"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" style="margin-left:5px;" OnClick="btnFind_Click" Text="Find" CssClass="btn" />
        <br />
        <asp:Label ID="lblName" runat="server" style="margin-bottom:10px;" Text="Name" Width="100px"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" Width="250px"></asp:TextBox>
        <br />
        <asp:Label ID="lblDOB" runat="server" style="margin-bottom:10px;" Text="DOB" Width="100px"></asp:Label>
        <asp:TextBox ID="txtDOB" runat="server" Width="125px"></asp:TextBox>
        <br />
        <asp:Label ID="lblAddress" runat="server" style="margin-bottom:10px;" Text="Address" Width="100px"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" Width="250px" Height="60px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:Label ID="Salary" runat="server" style="margin-bottom:10px;" Text="Salary" Width="100px"></asp:Label>
        <asp:TextBox ID="txtSalary" runat="server" Width="125px"></asp:TextBox>
        <br />
        <asp:Label ID="lblActive" runat="server" style="margin-bottom:10px;" Text="Active" Width="96px"></asp:Label>
        <asp:CheckBox ID="chkActive" runat="server" CssClass="btn" />
        <br />
        <asp:Label ID="lblError" ForeColor="Red" style="margin-bottom:10px;" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" Text="OK" style="margin-right:10px;" OnClick="btnOK_Click" CssClass="btn" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" CssClass="btn" />
        <br />
        <style>
            .btn
            {
                cursor: pointer;
            }
        </style>
    </form>
</body>
</html>
