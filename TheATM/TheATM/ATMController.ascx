<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ATMController.ascx.cs" Inherits="TheATM.ATMController" %>

<div> <asp:Label ID="KontoKvitto" runat="server" Text="Label"></asp:Label></div>
<div>
<asp:Button ID="SaldoKonto" runat="server" Text="Button" />
</div>
<div>
<asp:Button ID="VisaHistorik" runat="server" Text="Button" />
</div>
<div>
<asp:Button ID="PrintKvitto" runat="server" Text="Button" />
</div>
<div>
<asp:Button ID="UttagPrintKvitto" runat="server" Text="Button" />
</div>
<div>
<asp:Button ID="Uttag" runat="server" Text="Button" />
</div>
<div>
<asp:Button ID="Avsluta" runat="server" Text="Button" />
</div>
<div>
<asp:Button ID="OK" runat="server" Text="Button" />
</div>

<asp:Label ID="LabelError" runat="server" Font-Bold="False" ForeColor="Red" Text="" />
<asp:Label ID="LabelInfo" runat="server" Font-Bold="False" ForeColor="Green" Text="" />


