<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblorderID" runat="server" Text="Order ID"></asp:Label>
            <asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
             <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            <br />
            <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID" style="margin-bottom:10px;" Width="96px"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblApproval" runat="server" Text="Approval" style="margin-bottom:10px;" Width="96px"></asp:Label>
            <asp:TextBox ID="txtApproval" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblSaleApplied" runat="server" Text="Sale Applied" style="margin-bottom:10px;" Width="96px"></asp:Label>
            <asp:TextBox ID="txtSaleApplied" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblOrderStatus" runat="server" Text="Order Status" style="margin-bottom:10px;" Width="96px"></asp:Label>
            <asp:TextBox ID="txtOrderStatus" runat="server"></asp:TextBox>

            
            <br />
            <br />
            <asp:Label ID="lblError" ForeColor="Red" style="margin-bottom:10px;" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
