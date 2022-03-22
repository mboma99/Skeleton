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
        <asp:GridView ID="GridView1" HeaderStyle-BackColor="LightGray" HeaderStyle-ForeColor="Black" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="OnSelectedIndexChanged">
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
        <asp:Button ID="btnAdd" runat="server" style="margin-right:10px; margin-top:10px;" Text="Add" OnClick="btnAdd_Click" CssClass="btn" />
        <asp:Button ID="btnEdit" runat="server" style="margin-right:10px;" OnClick="btnEdit_Click" Text="Edit" CssClass="btn" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" CssClass="btn" />
        <br/>
        <br/>
        <asp:Label ID="lblFilter" runat="server" Text="Filter by IsActive: "></asp:Label>
        <asp:CheckBox ID="chkActive" style="margin-bottom:10px;" runat="server" CssClass="btn" />
        <br/>
        <asp:Button ID="btnApply" runat="server" style="margin-top:5px;"  OnClick="btnApply_Click" Text="Apply" CssClass="btn" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="margin-left:10px;" Text="Clear" CssClass="btn" />
        <br/>
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
