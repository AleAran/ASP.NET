<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Sumar.aspx.cs" Inherits="WebCurso.Sumar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <br />
    <br />
    <div>
        <h3>Suma de 2 numeros con web services</h3>
        <p>&nbsp;</p>
        <asp:Label ID="lblNumero1" runat="server" Text="Numero 1 :" style="font-size: x-large"></asp:Label>
        <asp:TextBox ID="txtNumero1" runat="server" style="font-size: x-large"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblNumero2" runat="server" Text="Numero 2 :" style="font-size: x-large"></asp:Label>
        <asp:TextBox ID="txtNumero2" runat="server" style="font-size: x-large"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnSumar" runat="server" Text="SUMAR" style="font-size: x-large" OnClick="btnSumar_Click" />
        <asp:Label ID="lblSuma" runat="server" style="font-size: x-large"></asp:Label>
        <br />

    </div>
</asp:Content>
