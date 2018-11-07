<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Restar.aspx.cs" Inherits="WebCurso.Restar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <br />
    <br />
    <br />
    <br />
    <div style="background-color: #CCFFCC">
        <h3>Restar de 2 numeros con web services</h3>
        <p>&nbsp;</p>
        <asp:Label ID="lblNumero1" runat="server" Text="Numero 1 :" style="font-size: x-large"></asp:Label>
        <asp:TextBox ID="txtNumero1" runat="server" style="font-size: x-large"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblNumero2" runat="server" Text="Numero 2 :" style="font-size: x-large"></asp:Label>
        <asp:TextBox ID="txtNumero2" runat="server" style="font-size: x-large"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnResta" runat="server" Text="RESTAR" style="font-size: x-large" OnClick="btnSumar_Click" />
        <asp:Label ID="lblResta" runat="server" style="font-size: x-large"></asp:Label>
        <br />

    </div>

</asp:Content>
