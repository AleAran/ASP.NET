<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CacheTiempoRel.aspx.cs" Inherits="WebCurso.CacheTiempoRel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="text-center">
    <br />
    <br />
    <br />
    <br />
        <h2>VISTA DE LIBROS ( CACHE CON TIEMPO RELATIVO ) </h2>
        <p>&nbsp;</p>
        <div class="text-left">
        <asp:GridView ID="gvLibros" runat="server" CellPadding="4" GridLines="None" Height="161px" HorizontalAlign="Center" Width="874px" AllowPaging="True" OnPageIndexChanging="gvLibros_PageIndexChanging" PageSize="8" ForeColor="#333333">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        </div>
        <br />
    </div>
</asp:Content>
