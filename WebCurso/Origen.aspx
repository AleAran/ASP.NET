<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Origen.aspx.cs" Inherits="WebCurso.Origen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <br />
    <h2>PASANDO DATOS CON QUERYSTRING</h2>
    <div>
        <br />
        <strong>
        <asp:Label ID="lblDato" runat="server" Text="Ingrese dato a enviar " style="font-size: large"></asp:Label>
        <br />
        </strong>
        <br />
        <asp:TextBox ID="txtDato" runat="server" Width="196px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnEnviar" runat="server" Text="ENVIAR" OnClick="btnEnviar_Click" />
    </div>

</asp:Content>
