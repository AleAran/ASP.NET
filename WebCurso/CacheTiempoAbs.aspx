<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CacheTiempoAbs.aspx.cs" Inherits="WebCurso.CacheTiempoAbs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="text-center">
    <br />
    <br />
    <br />
    <br />
        <h2>VISTA DE LIBROS ( CACHE CON TIEMPO ABSOLUTO ) </h2>
        <p>&nbsp;</p>
        <div class="text-left">
        <asp:GridView ID="gvLibros" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" GridLines="Vertical" Height="161px" HorizontalAlign="Center" Width="874px" AllowPaging="True" OnPageIndexChanging="gvLibros_PageIndexChanging" PageSize="8" ForeColor="Black">
            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
        </asp:GridView>
        </div>
        <br />
    </div>


</asp:Content>
