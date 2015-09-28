<%@ Page Language="C#"  MasterPageFile="~/ATM.Master" AutoEventWireup="true" CodeBehind="MainATM.aspx.cs" Inherits="TheATM.MainATM" %>

<%@ Reference Control="~/ATMController.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="mainmenu" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="PanelForm" runat="server"></asp:Panel>
    <asp:Label ID="LabelError" runat="server" Text="" ForeColor="Red"></asp:Label>
</asp:Content>
