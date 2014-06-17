<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TYDonation.aspx.cs" Inherits="TYDonation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2>Thank you for your Donation!</h2>
        <asp:LinkButton ID="lkbtnReturn" runat="server" PostBackUrl="~/Welcome.aspx">Return to Main</asp:LinkButton>
    </div>

    </form>
</body>
</html>
