<%@ Page Language="C#" MasterPageFile="~/ATM.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TheATM.Default" %>

<asp:Content ContentPlaceHolderID="MainContent" ID="defaultpage" runat="server">
    <link href="CSS/LoginStyleSheet.css" rel="stylesheet" />
    <div>
        <div id="welcome">
            <h1>Welcome</h1>
        </div>
        <div id="login">
            <table style="align-content:center">
                <tr>
                    <td colspan="2" style="text-align: center; font-size: 150%">Log In</td>
                </tr>
                <tr>
                    <td style="text-align: right">Card </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" Width="150px">
                            <asp:ListItem Value="1">Card1</asp:ListItem>
                            <asp:ListItem Value="2">Card2</asp:ListItem>
                            <asp:ListItem Value="3">Card3</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: right">PIN</td>
                    <td>
                        <asp:TextBox ID="TextBoxPIN" runat="server" TextMode="Password" MaxLength="4" Width="150px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align: center">
                        <asp:Button ID="LoginButton" runat="server" Text="Log In" OnClick="LoginButton_Click"/>

                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align: center"></td>
                </tr>
            </table>
        </div>
        </div>
</asp:Content>
