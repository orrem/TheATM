<%@ Page Language="C#" MasterPageFile="~/ATM.Master" AutoEventWireup="true" CodeBehind="PrintHistory.aspx.cs" Inherits="TheATM.PrintHistory" %>

<asp:Content ContentPlaceHolderID="MainContent" ID="listBoxPrint" runat="server">
    <div>
        <asp:ListBox ID="ListBoxPrint" runat="server" Height="400px"></asp:ListBox>
    </div>
    </asp:Content>

