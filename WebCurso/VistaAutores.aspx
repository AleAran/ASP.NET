<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VistaAutores.aspx.cs" Inherits="WebCurso.VistaAutores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <br />

    <div>
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
        <h2>Autores</h2>
        <asp:GridView ID="gvAutores" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" Width="1075px" AllowPaging="True" OnPageIndexChanging="gvAutores_PageIndexChanging">
            <FooterStyle BackColor="White" ForeColor="#333333" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#487575" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#275353" />
        </asp:GridView>
        <br />
            <asp:Timer runat="server" ID="Timer1" Interval="1000" OnTick="Timer1_Tick"></asp:Timer>
            <strong>
            <asp:Label ID="lblTiempo" runat="server" Text="Estos datos se actualizaran en "></asp:Label>
            </strong>
          </ContentTemplate>
        
        </asp:UpdatePanel>
    </div>

</asp:Content>
