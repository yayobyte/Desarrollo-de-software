<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TiendaDeportiva.aspx.cs" Inherits="WEB_Desarrollo_8_10.ReglasNeglocio.TiendaDeportiva" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%">
        <tr>
            <td colspan="2" style="text-align: center; color: #FF66FF; font-size: 25pt">Tienda Deportiva</td>
        </tr>
        <tr>
            <td style="width: 411px">Marca</td>
            <td>
                <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 411px">Valor Unitario</td>
            <td>
                <asp:TextBox ID="txtValorUnitario" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 411px">Cantidad</td>
            <td>
                <asp:TextBox ID="txtCantidad" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center">
                <asp:Button ID="btnCalcular" runat="server" OnClick="Button1_Click" Text="CALCULAR" Width="129px" />
            </td>
        </tr>
        <tr>
            <td style="width: 411px">
                <asp:Label ID="lblError" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 22px; width: 411px">valor antes de descuento</td>
            <td style="height: 22px">
                <asp:Label ID="lblValorAntesDescuento" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 411px">valor descuento</td>
            <td>
                <asp:Label ID="lblValorDescuento" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 411px">valor antes de iva</td>
            <td>
                <asp:Label ID="lblValorAntesIva" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 411px">valor iva</td>
            <td>
                <asp:Label ID="lblValorIva" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 411px">Valor a Pagar</td>
            <td>
                <asp:Label ID="lblValorPagar" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
