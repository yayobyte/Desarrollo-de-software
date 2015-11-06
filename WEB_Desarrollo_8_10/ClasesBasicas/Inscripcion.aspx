<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inscripcion.aspx.cs" Inherits="WEB_Desarrollo_8_10.ClasesBasicas.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%">
        <tr>
            <td class="text-center" colspan="2" style="font-size: x-large"><strong>INSCRIPCION EQUIPO</strong></td>
        </tr>
        <tr>
            <td style="width: 266px">Numero de Entrenadores</td>
            <td>
                <asp:TextBox ID="txtNroEntrena" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 266px">Categoria</td>
            <td>
                <asp:TextBox ID="txtCateGoria" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 266px">Numero de Partidos</td>
            <td>
                <asp:TextBox ID="txtNroParTidos" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" Width="412px" />
            </td>
        </tr>
        <tr>
            <td style="width: 266px">
                <asp:Label ID="lblError" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 266px">Total Inscripcion</td>
            <td>
                <asp:Label ID="lblTotal" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
