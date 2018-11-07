<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CacheDepArchivo.aspx.cs" Inherits="WebCurso.CacheDepArchivo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <div class="text-center">
    <br />
    <br />
    <br />
    <br />
        <h2>VISTA DE LIBROS ( CACHE CON DEPENDENCIA DE ARCHIVO ) </h2>
        <p>&nbsp;</p>
        <div class="text-left">
        <asp:GridView ID="gvLibros" runat="server" CellPadding="4" Height="161px" HorizontalAlign="Center" Width="874px" AllowPaging="True" OnPageIndexChanging="gvLibros_PageIndexChanging" PageSize="8" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px">
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#330099" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <SortedAscendingCellStyle BackColor="#FEFCEB" />
            <SortedAscendingHeaderStyle BackColor="#AF0101" />
            <SortedDescendingCellStyle BackColor="#F6F0C0" />
            <SortedDescendingHeaderStyle BackColor="#7E0000" />
        </asp:GridView>
        </div>
        <br />
    </div>

</asp:Content>
