<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Boleto.aspx.cs" Inherits="WEB_Desarrollo_8_10.Boleto.Boleto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <table class="auto-style1">
        <tr>
            <td class="auto-style4" colspan="2"><h1>Venta de boletos</h1></td>
        </tr>
        <tr>
            <td class="auto-style4" style="font-weight: bold">Cliente:</td>
            <td class="auto-style2">
                <asp:DropDownList ID="comboViewCliente" runat="server" CssClass="auto-style8">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style5" style="font-weight: bold">Evento:</td>
            <td>
                <asp:DropDownList ID="comboViewEvento" runat="server" CssClass="auto-style8">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style5" style="font-weight: bold">Tipo de Boleto:</td>
            <td>
                <asp:DropDownList ID="comboViewTipoEvento" runat="server" CssClass="auto-style8">
                </asp:DropDownList>
            
            </td>
        </tr>
        
        
        <tr>
            <td class="auto-style7" colspan="2">
                <asp:Button ID="btnGrabar" runat="server" BackColor="#3333FF" CssClass="auto-style9" ForeColor="White" OnClick="btnGrabar_Click" Text="Vender Boleto" Width="280px" />
            </td>
            <td class="auto-style7">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7" colspan="2">
                <asp:Button ID="btnConsultar" runat="server" BackColor="#3333FF" CssClass="auto-style9" ForeColor="White" Text="Consultar Cliente" Width="280px" OnClick="btnConsultar_Click" />
            </td>
            <td class="auto-style7">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblError" runat="server" CssClass="auto-style6" ForeColor="#CC0000"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="grdBoleto" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
