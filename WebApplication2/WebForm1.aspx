<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Zinseszins-Rechner</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Zinseszins-Rechner"></asp:Label>
            <br />
            <asp:Table ID="Table1" runat="server" Height="124px" Width="339px">
                <asp:TableRow >
                    <asp:TableCell>
                        <asp:Label ID="Label2" runat="server" Text="Betrag in Euro:"></asp:Label>
                    </asp:TableCell>

                    <asp:TableCell>
                        <asp:TextBox ID="BetragTxt" runat="server" OnTextChanged="BetragTxt_TextChanged"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label7" runat="server" Text="Startjahr:"></asp:Label>
                    </asp:TableCell>

                    <asp:TableCell>
                        <asp:TextBox ID="StartjahrTxt" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label4" runat="server" Text="Laufzeit (in Jahren):"></asp:Label>
                    </asp:TableCell>

                    <asp:TableCell>
                        <asp:TextBox ID="LaufzeitTxt" runat="server" OnTextChanged="LaufzeitTxt_TextChanged"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label5" runat="server" Text="Zinssatz:"></asp:Label>
                    </asp:TableCell>

                    <asp:TableCell>
                        <asp:TextBox ID="ZinssatzTxt" runat="server" OnTextChanged="ZinssatzTxt_TextChanged"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Button ID="Button1" runat="server" Text="Berechnen" OnClick="Button1_Click" />
                    </asp:TableCell>

                    <asp:TableCell>
                        <asp:Label ID="ErgebnisLbl" runat="server" Text="Ergebnis"></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell ColumnSpan="2">
                        <asp:Button Visible="false" ID="BtnDetails" runat="server" Text="mehr details.." Width="100%" OnClick="BtnDetails_Click"></asp:Button>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
