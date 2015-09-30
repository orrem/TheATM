<%@ Page Language="C#"  MasterPageFile="~/ATM.Master" AutoEventWireup="true" CodeBehind="Saldo.aspx.cs" Inherits="TheATM.Saldo" %>


<asp:Content ContentPlaceHolderID="MainContent" ID="saldo" runat="server">
    <table style="width: 100%;">
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">
            &nbsp;</td>
        <td>
            <asp:Label ID="spacerLabel" runat="server" Text="    "></asp:Label>
            <asp:Label ID="saldoTest" runat="server" Text="Saldo"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">
            &nbsp;</td>
        <td>
            <asp:Label ID="valueSaldoLabel" runat="server"></asp:Label>
            <asp:Label ID="sekLabel" runat="server" Text="SEK"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4"></td>
        <td class="auto-style5">
            Historik</td>
        <td class="auto-style5">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            &nbsp;</td>
        <td class="auto-style3">
            <asp:ListBox ID="ListBoxHistory" runat="server" Height="110px" ></asp:ListBox>
        </td>
        <td class="auto-style3">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>
            <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>
            <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>
            <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>
            <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>
            &nbsp;</td>
        <td>Skriv ut senaste 25</td>
    </tr>
            <tr>
        <td class="auto-style1">
            <asp:Button ID="Button1" runat="server" Text="Avbryt" OnClick="Button1_Click"/>
                </td>
        <td>
            <asp:Button ID="ButtonSaldoToUttag" runat="server" OnClick="ButtonSaldoToUttag_Click" Text="Uttag" />
                </td>
        <td>
            <asp:Button ID="OKJa" runat="server" Text="Skriv ut" Width="75px" OnClick="OKJa_Click" /></td>
    </tr>
</table>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style1 {
            width: 248px;
        }
        .auto-style2 {
            width: 248px;
            height: 33px;
        }
        .auto-style3 {
            height: 33px;
        }
        .auto-style4 {
            width: 248px;
            height: 26px;
        }
        .auto-style5 {
            height: 26px;
        }
    </style>
</asp:Content>

