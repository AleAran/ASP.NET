<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ajax.aspx.cs" Inherits="WebCurso.Ajax" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        
    <br />
    
    <br />
    <div style="text-align: center">
    <br />
    <h2>EJEMPLO DE AJAX</h2>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <br />
            <asp:Label ID="lblDentrodelPanel" runat="server" Text="" style="font-size: x-large"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnPanel" runat="server" Text="Actualiza Panel de AJAX" OnClick="btnPanel_Click" />
            <asp:Timer ID="Timer1" runat="server" Interval="10000" OnTick="Timer1_Tick"></asp:Timer> 
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="btnExterno" EventName="Click" />
        </Triggers>
    </asp:UpdatePanel>

    <p>
        </p>
        <asp:UpdateProgress ID="UpdateProgress1" runat="server">
            <ProgressTemplate>
                Procesando...espere un momento por favor...
                <img src="Imagenes/progress_spinner.gif" />
            </ProgressTemplate>
        </asp:UpdateProgress>
    <asp:Label ID="lblFueraDelPanel" runat="server" Text="" style="font-size: x-large"></asp:Label>
    <br />
    <br />
    <asp:Button ID="btnFueraPanel" runat="server" Text="Actualiza Toda La pagina" OnClick="btnFueraPanel_Click" />
        <br />
        <asp:Label ID="lblPagina" runat="server" Text="Label" style="font-size: x-large"></asp:Label>

        <br />
        <asp:Button ID="btnExterno" runat="server" Text="Boton Externo" Width="187px" OnClick="btnExterno_Click" />

    </div>

</asp:Content>
