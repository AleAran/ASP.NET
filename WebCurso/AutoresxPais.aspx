<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AutoresxPais.aspx.cs" Inherits="WebCurso.AutoresxPais" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
    
    <div>
        <h4>Seleccione Pais :<asp:DropDownList ID="ddlPaises" runat="server" Height="38px" Width="381px" AutoPostBack="True" OnSelectedIndexChanged="ddlPaises_SelectedIndexChanged">
            </asp:DropDownList>
        </h4>
    </div>
    <div>
        <h5>Autores</h5>
        <asp:GridView ID="gvAutores" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="1075px" CellSpacing="2" EmptyDataText="NO SE ENCONTRARON AUTORES">
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        <br />

    </div>

</asp:Content>
