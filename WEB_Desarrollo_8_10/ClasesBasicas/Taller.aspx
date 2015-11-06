<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Taller.aspx.cs" Inherits="WEB_Desarrollo_8_10.ClasesBasicas.Taller" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2" colspan="2"><strong>REPARACIÓN MOTOS</strong></td>
        </tr>
        <tr>
            <td class="auto-style5">Costo repuestos:</td>
            <td style="width: 163px">
                <asp:TextBox ID="txtCostoRepuestos" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Costo Mano obra:</td>
            <td style="width: 163px">
                <asp:TextBox ID="txtCostoManoObra" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Porcentaje descuento:</td>
            <td style="width: 163px">
                <asp:TextBox ID="txtPorcentajeDescuento" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnCalcular" runat="server" BackColor="Blue" ForeColor="White" Height="42px" Text="CALCULAR" Width="219px" OnClick="btnCalcular_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style6" colspan="2">
                <asp:Label ID="lblError" runat="server" style="color: #FF3300; font-size: medium; font-style: italic"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Subtotal:</td>
            <td class="auto-style6" style="width: 163px">
                <asp:Label ID="lblSubtotal" runat="server" style="color: #000000; font-size: medium"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Valor descuento:</td>
            <td class="auto-style6" style="width: 163px">
                <asp:Label ID="lblValorDescuento" runat="server" style="color: #000000; font-size: medium"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Valor antes de IVA:</td>
            <td class="auto-style6" style="width: 163px">
                <asp:Label ID="lblValorAntesIVA" runat="server" style="color: #000000; font-size: medium"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Valor IVA:</td>
            <td class="auto-style6" style="width: 163px">
                <asp:Label ID="lblValorIVA" runat="server" style="color: #000000; font-size: medium"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Total a pagar:</td>
            <td class="auto-style6" style="width: 163px">
                <asp:Label ID="lblTotalPagar" runat="server" style="color: #000000; font-size: medium"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
