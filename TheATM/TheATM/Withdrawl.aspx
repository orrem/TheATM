<%@ Page Language="C#"  MasterPageFile="~/ATM.Master" AutoEventWireup="true" CodeBehind="Withdrawl.aspx.cs" Inherits="TheATM.Withdrawl" %>


<asp:Content ContentPlaceHolderID="MainContent" ID="withdrawl" runat="server">
    <table style="width: 100%;">
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Label ID="KontoKvitto" runat="server" Text="Label"></asp:Label></td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="withdrawl_100" runat="server" Text="100" Width="75px" OnClick="withdrawal_button_Click" />
        </td>
        <td>
            &nbsp;</td>
        <td>
            <asp:Button ID="withdrawl_1000" runat="server" Text="1000" Width="75px" OnClick="withdrawal_button_Click" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="withdrawl_300" runat="server" Text="300" Width="75px" OnClick="withdrawal_button_Click" />
        </td>
        <td>
            &nbsp;</td>
        <td>
            <asp:Button ID="withdrawl_2500" runat="server" Text="2500" Width="75px" OnClick="withdrawal_button_Click" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="withdrawl_500" runat="server" Text="500" Width="75px" OnClick="withdrawal_button_Click" />
        </td>
        <td>
            &nbsp;</td>
        <td>
            <asp:Button ID="withdrawl_5000" runat="server" Text="5000" Width="75px" OnClick="withdrawal_button_Click" />
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Label ID="LabelFreeAmount" runat="server" Text="Skriv in ett eget belopp"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:TextBox ID="textBoxWithdrawal" runat="server" Width="200px"></asp:TextBox>
            <asp:Button ID="Accept" runat="server" Text="OK" Width="75px" OnClick="Accept_Click" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="Exit" runat="server" Text="Avbryt" Width="75px" OnClick="Exit_Click" /></td>
        <td>&nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>
</asp:Content>
