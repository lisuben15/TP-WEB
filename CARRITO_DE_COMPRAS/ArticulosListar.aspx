<%@ Page Title="" Language="C#" MasterPageFile="~/Mi_Master.Master" AutoEventWireup="true" CodeBehind="ArticulosListar.aspx.cs" Inherits="CARRITO_DE_COMPRAS.ArticulosListar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Lista de articulos</h1>
    <asp:GridView ID="dgvArticulos" runat="server" ccsClass="table" AutoGenerateColumns="false">
         <Columns>
          <asp:BoundField HeaderText="Código" DataField="Codigo" />
          <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
          <asp:BoundField HeaderText="Descripción" DataField="Descripcion" />
          <asp:BoundField HeaderText="Marca" DataField="Marca.Descripcion" />
          <asp:BoundField HeaderText="Categoria" DataField="Categoria.Descripcion" />
          <asp:BoundField HeaderText="Precio" DataField="Precio" />
          <asp:BoundField HeaderText="ImagenURL" DataField="UrlImagen" />
         </Columns>
    </asp:GridView>
</asp:Content>
