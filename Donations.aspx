<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Donations.aspx.cs" Inherits="Donations" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head2" runat="server">
    <title></title>
</head>
<body>
    <header>Thanks for your Donations!</header>
    <form id="form2" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="True">
        </asp:GridView>
       
        <asp:Label ID="lblDonate" runat="server" Text="Enter Donation Amount"></asp:Label>
        <asp:TextBox ID="txtDonate" runat="server" ></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Donate" OnClick="btnDonateMore_Click" />
    </div>

    </form>
</body>
</html>