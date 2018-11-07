<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Sesion.aspx.cs" Inherits="WebCurso.Sesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <br />
    <br />
    <div>
        <h2>Ingrese su Nombre :
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <p>
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar Nombre" Height="40px" Width="278px" OnClick="btnGuardar_Click" />
            </p>
        <p>
                &nbsp;</p>
        <p>
                <asp:CheckBox ID="cbGuardar" Text="Mantener sesion" runat="server" />
            </p>
        </h2>
    </div>
</asp:Content>
