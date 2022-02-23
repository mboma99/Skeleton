<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLineDataEntry.aspx.cs" Inherits="_Default" %>

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
            <br />
            <asp:Label ID="lblPetID" runat="server" Text="Pet ID" width="57px"></asp:Label>
            <asp:TextBox ID="txtPetID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblQuantity" runat="server" Text="Quantity" width="57px"></asp:Label>
            <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblPricePaid" runat="server" Text="Price Paid" width="57px"></asp:Label>
            <asp:TextBox ID="txtPricePaid" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblPetPrice" runat="server" Text="Pet Price" width="57px"></asp:Label>
            <asp:TextBox ID="txtPetPrice" runat="server"></asp:TextBox>
             <br />
            <asp:Label ID="lblOrderStatus" runat="server" Text="Order Status" width="57px"></asp:Label>
            <asp:TextBox ID="txtOrderStatus" runat="server"></asp:TextBox>

            <br />
            <br />
            <asp:CheckBox ID="chkActive" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Active" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />

        </div>
    </form>
</body>
</html>
