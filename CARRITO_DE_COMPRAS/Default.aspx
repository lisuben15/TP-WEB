<%@ Page Title="" Language="C#" MasterPageFile="~/Mi_Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CARRITO_DE_COMPRAS.Página1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Página 1</h2>

    <div class="row row-cols-1 row-cols-md-3 g-4">
        <% //dentro de estos comidines puedo escribir codigo c#
            foreach (dominio.Articulo articulo in ListaArticulo)
            {
        %>
              <div class="col">
                <div class="card">
                  <img src="<%:articulo.UrlImagen %>" class="card-img-top" alt="...">
                  <div class="card-body">
                    <h5 class="card-title"><%:articulo.Nombre %></h5>
                    <p class="card-text"><%:articulo.Descripcion %></p>
                  </div>
                </div>
              </div>
           <% } %>
  
    </div>

</asp:Content>
