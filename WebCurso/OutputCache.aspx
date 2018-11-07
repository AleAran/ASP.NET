<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OutputCache.aspx.cs" Inherits="WebCurso.OutputCache" %>
<%@ OutputCache Duration="30" VaryByParam="none"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <br />
    <div class="text-center">
        <br />
        <br />
        <br />
        <br />
            <asp:Label ID="lblfecha" runat="server" style="font-size: xx-large" />
        <br />
        <br />    
        <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" />
   </div>

</asp:Content>
