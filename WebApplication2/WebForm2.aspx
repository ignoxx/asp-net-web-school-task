<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Zinseszins-Rechner - Details</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Zinseszins-Rechner - Details"></asp:Label>
            <br />
            <asp:Button Visible="false" ID="BtnRedirect" runat="server" Text="Zum Formular" OnClick="BtnRedirect_Click"></asp:Button>
            <asp:Table ID="Table1" runat="server" Width="100%">
            </asp:Table>
        </div>
    </form>
</body>
</html>
