<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Data Entry</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID" width="115px"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" OnTextChanged="TextBox1_TextChanged" style="margin-left: 0px"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="Button1_Click" Text="Find" />
        <br />
        <asp:Label ID="lblName" runat="server" Text="Name" width="115px"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" style="margin-left: 0px"></asp:TextBox>   
        <br />
        <asp:Label ID="lblDob" runat="server" Text="DOB" width="115px"></asp:Label>
        <asp:TextBox ID="txtDOB" runat="server" OnTextChanged="txtDOB_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="lblCustomerDetails" runat="server" Text="Customer Details" width="115px"></asp:Label>
        <asp:TextBox ID="txtCustomerDetails" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblAccountBalance" runat="server" Text="Account Balance" width="115px"></asp:Label>
        <asp:TextBox ID="txtAccountBalance" runat="server" OnTextChanged="TextBox5_TextChanged"></asp:TextBox>
        <br />
        <asp:CheckBox ID="lblPendingOrder" runat="server" Text="Pending Order" OnCheckedChanged="lblPendingOrder_CheckedChanged" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="Ok" Width="55px" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        <br />
        
        
    </form>
</body>
</html>
