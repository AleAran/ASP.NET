<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AltaAutor.aspx.cs" Inherits="WebCurso.AltaAutor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <br />
    <br />
    <br />
    <div>
        <h3>INGRESO DE NUEVO AUTOR</h3>
        <table style="border-style: solid; border-width: 2px; width: 100%; height: 162px;">
            <tr>
                <td style="width: 267px; border-style: solid; border-width: 2px" class="text-right">
                    <strong>
                    <asp:Label ID="lblApellido" runat="server" Text="Apellido(*) :"></asp:Label>
                    </strong>
                </td>
                <td style="border-style: solid; border-width: 2px; width: 314px;">
                    <asp:TextBox ID="txtApellido" runat="server" Width="300px" MaxLength="50"></asp:TextBox>
                </td>
                <td style="border-style: solid; border-width: 2px">
                    <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ControlToValidate="txtApellido" ErrorMessage="(1) El Apellido es Obligatorio!!!" Font-Bold="True" ForeColor="#FF3300">(1) Dato Obligatorio!</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 267px; border-style: solid; border-width: 2px" class="text-right">
                    <strong>
                    <asp:Label ID="lblNombre" runat="server" Text="Nombre(*) :"></asp:Label>
                    </strong>
                </td>
                <td style="border-style: solid; border-width: 2px; width: 314px;">
                    <asp:TextBox ID="txtNombre" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td style="border-style: solid; border-width: 2px">
                    <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ErrorMessage="(2) Nombre Obligatorio!!!" ControlToValidate="txtNombre" Font-Bold="True" ForeColor="#FF3300">(2) Dato Obligatorio!</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 267px; border-style: solid; border-width: 2px" class="text-right">
                    <strong>
                    <asp:Label ID="lblFechaNacimiento" runat="server" Text="Fecha de Nacimiento :"></asp:Label>
                    </strong>
                </td>
                <td style="border-style: solid; border-width: 2px; width: 314px;">
                    <asp:TextBox ID="txtFechaNacimiento" runat="server"></asp:TextBox>
                    <ajaxToolkit:CalendarExtender ID="txtFechaNacimiento_CalendarExtender" runat="server" BehaviorID="txtFechaNacimiento_CalendarExtender" TargetControlID="txtFechaNacimiento" />
                </td>
                <td style="border-style: solid; border-width: 2px">
                    <asp:CompareValidator ID="cvFechaNacimiento" runat="server" ControlToValidate="txtFechaNacimiento" Display="Dynamic" ErrorMessage="(3) Formato de fecha Incorrectoi!!!" Font-Bold="True" ForeColor="#FF3300" Operator="DataTypeCheck" Type="Date">(3) Formato Incorrecto!</asp:CompareValidator>
                    
                    <asp:RequiredFieldValidator ID="rfvFechaNac" runat="server" ControlToValidate="txtFechaNacimiento" Display="Dynamic" ErrorMessage="(4) La fecha de nacimiento es obligatoria!!!" Font-Bold="True" ForeColor="#FF3300">(4) Dato obligatorio!</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 267px; border-style: solid; border-width: 2px" class="text-right">
                    <strong>
                    <asp:Label ID="lblNacionalidad" runat="server" Text="Nacionalidad :"></asp:Label>
                    </strong>
                </td>
                <td style="border-style: solid; border-width: 2px; width: 314px;">
                    <asp:DropDownList ID="ddlNacionalidad" runat="server" Width="300px">
                    </asp:DropDownList>
                </td>
                <td style="border-style: solid; border-width: 2px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 267px; border-style: solid; border-width: 2px" class="text-right">
                    <asp:Button ID="btnEnviar" CssClass="btn-primary" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
                </td>
                <td style="border-style: solid; border-width: 2px; width: 314px;"><strong>
                    <asp:Label ID="lblMensaje" runat="server" style="color: #FF3300" Text=""></asp:Label>
                    </strong></td>
                <td style="border-style: solid; border-width: 2px">
                    <asp:Button ID="btnAyuda" CssClass="alert-danger" runat="server" Text="Ayuda en linea" CausesValidation="False" OnClick="btnAyuda_Click" />
                </td>
            </tr>
        </table>
        (*) Datos obligatorios
        <div>
            <strong>
            <asp:ValidationSummary ID="vsAutor" runat="server" Height="64px" style="background-color: #FFFFCC" ShowMessageBox="True" ShowSummary="False" />
            </strong>
        </div>
    </div>

</asp:Content>
