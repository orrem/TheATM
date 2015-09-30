<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ATMController.ascx.cs" Inherits="TheATM.ATMController" %>
<link href="CSS/ControllerStyleSheet.css" rel="stylesheet" />
<table style="width: 100%;">
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Label ID="KontoKvitto" runat="server" Text="Label"></asp:Label></td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Button ID="SaldoKonto" runat="server" Text="Button" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Button ID="VisaHistorik" runat="server" Text="Button" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Button ID="PrintKvitto" runat="server" Text="Button" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Button ID="UttagPrintKvitto" runat="server" Text="Button" OnClick="UttagPrintKvitto_Click" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Button ID="Uttag" runat="server" Text="Button" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="AvslutaNej" runat="server" Text="Button" /></td>
        <td>&nbsp;</td>
        <td>
            <asp:Button ID="OKJa" runat="server" Text="Button" /></td>
    </tr>
</table>

<asp:Label ID="LabelError" runat="server" Font-Bold="False" ForeColor="Red" Text="" />
<asp:Label ID="LabelInfo" runat="server" Font-Bold="False" ForeColor="Green" Text="" />


