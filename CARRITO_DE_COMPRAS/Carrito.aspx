<%@ Page Title="" Language="C#" MasterPageFile="~/Mi_Master.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="CARRITO_DE_COMPRAS.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>MI CARRITO</h1>

    <div>
        <%

            foreach (dominio.Articulo articulo in listaCarrito)
             {
            %>
                  <div class="col">
                    <div class="card">
                      <img style="max-width:120px;" src="<%:articulo.UrlImagen %>" class="card-img-top" alt="...">
                      <div class="card-body">
                        <h5 class="card-title"><%:articulo.Nombre %></h5>
                        <p class="card-text"><%:articulo.Precio %></p>
                         
                      </div>
                    </div>
                  </div>

         <% } %>

   </div>

    <a href="Default.aspx">Regresar</a>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CardsContainer" runat="server">

</asp:Content>
