<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Maestros.aspx.cs" Inherits="WEB_Desarrollo_8_10.Boleto.Maestros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Maestros</h1>
    <h2>Clientes</h2>
     <asp:Label ID="lblError" runat="server" CssClass="auto-style6" ForeColor="#CC0000"></asp:Label>
    <asp:GridView ID="gridViewCliente" runat="server" ForeColor="#333333" GridLines="None" CssClass="table table-condensed table-bordered table-striped table-hover"></asp:GridView>

</asp:Content>
