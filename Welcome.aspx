<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Welcome.aspx.cs" Inherits="Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <header>Welcome!</header>
        <table>
            <tr>
                <td>

                    <asp:LinkButton ID="lkbtnDonation" runat="server" PostBackUrl="Donations.aspx">Make Donation</asp:LinkButton>

                </td>

                <td>


                    <asp:LinkButton ID="lkbtnGrant" runat="server" PostBackUrl="Grants.aspx">Apply for Grant</asp:LinkButton>


                </td>
             </tr>

        </table>
    </div>
    </form>
</body>
</html>
