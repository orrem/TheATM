<%@ Page Language="C#" MasterPageFile="~/ATM.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TheATM.Default" %>

<asp:Content ContentPlaceHolderID="MainContent" ID="defaultpage" runat="server">
    <link href="CSS/MasterPageStyleSheet.css" rel="stylesheet" />
    <div>
        <div id="main" class="center">
            <div>Log in
            <asp:TextBox ID="TextBoxCardNumber" runat="server" EnableTheming="True"></asp:TextBox>
            <asp:TextBox ID="TextBoxPIN" runat="server" TextMode="Password" MaxLength="4"></asp:TextBox>
            <asp:Button ID="LoginButton" runat="server" Text="Log In" OnClick="LoginButton_Click" /></div>
        </div>
            <%--<div id="welcome">
            <h1>Welcome</h1>
        </div>
        <div id="login">
            <table>
                <tr>
                    <td colspan="2" style="text-align: center; font-size: 150%">Log In</td>
                </tr>
                <tr>
                    <td style="text-align: right">Card Number</td>
                    <td>
                        <asp:TextBox ID="TextBoxCardNumber" runat="server" EnableTheming="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: right">PIN</td>
                    <td>
                        <asp:TextBox ID="TextBoxPIN" runat="server" TextMode="Password" MaxLength="4"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align: center">
                        <asp:Button ID="LoginButton" runat="server" Text="Log In" OnClick="LoginButton_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align: center"></td>
                </tr>
            </table>
        </div>--%>
    </div>
</asp:Content>
