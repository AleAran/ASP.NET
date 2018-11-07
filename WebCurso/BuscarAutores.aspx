<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BuscarAutores.aspx.cs" Inherits="WebCurso.BuscarAutores" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <br />
    <br />
    <br />
<div class="text-left">
    <h2>Buscar Autor</h2>
    <p>
        <asp:TextBox ID="txtBuscar" runat="server" style="font-size: large" Width="422px"></asp:TextBox>
    <asp:AutoCompleteExtender 
        ID="txtBuscar_AutoCompleteExtender" 
        runat="server" 
        Enabled="true"
        TargetControlID="txtBuscar"
        MinimumPrefixLength="1"
        ServiceMethod="ObtenerAutores"
        ServicePath="Busquedas.asmx"
        EnableCaching="true"
        UseContextKey="true"
        CompletionSetCount="10"
        CompletionInterval="0">
    </asp:AutoCompleteExtender>

 </div>
</asp:Content>
