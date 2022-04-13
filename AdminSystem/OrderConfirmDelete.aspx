<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDelete" runat="server" style="margin-bottom:10px;" Text="Are you sure ?"></asp:Label>
        <br/>
        <asp:Button ID="btnYes" runat="server" style="margin-top:10px;" OnClick="btnYes_Click" Text="Yes" CssClass="btn" />
        <asp:Button ID="btnNo" runat="server" style="margin-left:10px;" Text="No" OnClick="btnNo_Click" CssClass="btn" />
        <style>
            .btn
            {
                cursor: pointer;
            }
        </style>
    </form>
    </form>
</body>
</html>
