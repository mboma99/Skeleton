<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblFilter" runat="server" Text="Filter by IsActive: "></asp:Label>
        <asp:CheckBox ID="chkActive" style="margin-bottom:10px;" runat="server" CssClass="btn" />
        <br/>
        <asp:Button ID="btnApply" runat="server" style="margin-top:5px;"  OnClick="btnApply_Click" Text="Apply" CssClass="btn" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="margin-left:10px; margin-bottom:10px;" Text="Clear" CssClass="btn" />
        <br/>
        <asp:GridView ID="grvStaffList" HeaderStyle-BackColor="LightGray" CellPadding="5" CellSpacing="15" HeaderStyle-ForeColor="Black" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="grvStaffList_OnSelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="StaffID" HeaderText="StaffID" />
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="DOB" HeaderText="DOB" />
                <asp:BoundField DataField="Address" HeaderText="Address" />
                <asp:BoundField DataField="Salary" HeaderText="Salary" />
                <asp:BoundField DataField="IsActive" HeaderText="IsActive" />
                <asp:ButtonField Text="Select" CommandName="Select" />
            </Columns>
        </asp:GridView>
        <asp:Button ID="btnAdd" runat="server" Font-Bold="true" Height="30" Width="60" style="margin-right:5px; margin-top:10px;" Text="Add" OnClick="btnAdd_Click" CssClass="btn" />
        <asp:Button ID="btnEdit" runat="server" Font-Bold="true" Height="30" Width="60" style="margin-right:5px;" OnClick="btnEdit_Click" Text="Edit" CssClass="btn" />
        <asp:Button ID="btnDelete" runat="server" Font-Bold="true" Height="30" Width="60" style="margin-bottom:10px;" OnClick="btnDelete_Click" Text="Delete" CssClass="btn" />
        <br/>
        <asp:Label ID="lblError" ForeColor="Red" runat="server"></asp:Label>
        <style>
            .btn
            {
                cursor: pointer;
            }
        </style>
    </form>
</body>
</html>
