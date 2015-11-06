<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Editorial.aspx.cs" Inherits="WEB_Desarrollo_8_10.ClasesBasicas.Editorial" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <style type="text/css">
        .auto-style1 {
            width: 75%;
        }
        .auto-style2 {
            height: 68px;
        }
        .auto-style4 {
            height: 68px;
            text-align: left;
            font-weight: bold;
            font-size: large;
        }
        .auto-style5 {
            text-align: left;
            font-size: large;
        }
            .auto-style8 {
                font-size: large;
                text-align: center;
            }
            .auto-style9 {
                text-align: left;
                font-weight: bold;
                font-size: medium;
            }
            .auto-style10 {
                text-align: left;
                font-weight: bold;
                font-size: large;
            }
            .auto-style11 {
                font-size: large;
            }
    </style>
    <table class="auto-style1">
        <tr>
            <td colspan="2" class="auto-style8"><strong>CÁLCULO DE IMPRESIÓN DE UN LIBRO</strong></td>
        </tr>
        <tr>
            <td class="auto-style9">TIPO DE IMPRESIÓN:</td>
            <td>
                <asp:TextBox ID="txtTipoImpresion" runat="server" CssClass="auto-style11"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">TIPO DE PASTA:</td>
            <td>
                <asp:TextBox ID="txtTipoPasta" runat="server" CssClass="auto-style11"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">NÚMERO DE HOJAS:</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtNroHojas" runat="server" CssClass="auto-style11"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">NÚMERO DE IMÁGENES:</td>
            <td class="text-left">
                <asp:TextBox ID="txtNroImagenes" runat="server" CssClass="auto-style11"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" class="text-center">
                <asp:Button ID="btnCalcular" runat="server" BackColor="#0066FF" ForeColor="White" Height="57px" OnClick="btnCalcular_Click" Text="CALCULAR COSTO" Width="225px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style5" colspan="2">
                <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="font-style: italic"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">VALOR IVA:</td>
            <td class="auto-style11">
                <asp:Label ID="lblValorIVA" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">VALOR A PAGAR:</td>
            <td class="auto-style11">
                <asp:Label ID="lblValorPagar" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
