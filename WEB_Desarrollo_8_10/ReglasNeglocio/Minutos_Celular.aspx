<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Minutos_Celular.aspx.cs" Inherits="WEB_Desarrollo_8_10.ReglasNeglocio.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        text-align: center;
    }
    .auto-style3 {
        text-align: right;
    }
    .auto-style4 {
        text-align: left;
    }
</style>
       <table class="auto-style1">
    <tr>
        <td class="auto-style2" colspan="2">RECARGA DE CELULAR</td>
    </tr>
    <tr>
        <td class="auto-style4">VALOR RECARGA:</td>
        <td class="auto-style2">
            <asp:TextBox ID="txtValorRecarga" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style4">NÚMERO DE CELULAR:</td>
        <td class="auto-style2">
            <asp:TextBox ID="txtCelular" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Button ID="btnRecargar" runat="server" BackColor="#0066FF" ForeColor="White" Height="68px" OnClick="btnRecargar_Click" Text="RECARGAR CELULAR" Width="425px" />
        </td>
    </tr>
    <tr>
        <td class="auto-style4" colspan="2">
            <asp:Label ID="lblError" runat="server" ForeColor="#CC3300" style="font-style: italic"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style4">MINUTOS RECARGADOS:</td>
        <td class="auto-style3">
            <asp:Label ID="lblMinutosRecargados" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style4">MINUTOS ADICIONALES:</td>
        <td class="auto-style3">
            <asp:Label ID="lblMinutosAdicionales" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style4">TOTAL MINUTOS:</td>
        <td class="auto-style3">
            <asp:Label ID="lblMinutosTotales" runat="server"></asp:Label>
        </td>
    </tr>
</table>
</asp:Content>
