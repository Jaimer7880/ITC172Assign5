<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Grants.aspx.cs" Inherits="Grants" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <header>Apply for a Grant</header>
        <table>
           <tr>
               <td>
                   <asp:Label ID="lblHello" runat="server" Text="Label"></asp:Label>
               </td>

           </tr>
            <tr>
            <td>Grant Amount</td>
            <td>
                <asp:TextBox ID="txtGrantAmount" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
            <td>Reason for Needing Grant</td>
            <td>
                <asp:TextBox ID="txtGrantReason" runat="server"></asp:TextBox></td>
            </tr>
              <tr>
            <td>Submit Information</td>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /> </td>
            </tr>
        </table>

    </div>
    </form>
</body>
</html>
