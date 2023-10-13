<%@ Page Title="" Language="C#" MasterPageFile="~/Mi_Master.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="CARRITO_DE_COMPRAS.Detalle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Detalle</h1>
    
              <div class="col">
                <div class="card">
                    
                  <img style="max-width:200px;" src="<%:articulo.UrlImagen %>" class="card-img-top" alt="...">
                  <div class="card-body">

                      <asp:Label ID="Label1" runat="server" Text="Nombre del producto "></asp:Label>
                      <p class="card-text"><%:articulo.Nombre %></p>
                      
                      <asp:Label ID="Label2" runat="server" Text="Codigo "></asp:Label>
                      <p class="card-text"><%:articulo.Codigo %></p>

                      <asp:Label ID="Label5" runat="server" Text="Marca"></asp:Label>
                      <p class="card-text"><%:articulo.Marca.Descripcion %></p>
                      
                      <asp:Label ID="Label3" runat="server" Text="Descripción"></asp:Label>
                      <p class="card-text"><%:articulo.Descripcion %></p>
                     
                      <asp:Label ID="Label4" runat="server" Text="Precio"></asp:Label>
                      <p class="card-text"><%:articulo.Precio %></p> 
                       
                      <asp:Label ID="Label6" runat="server" Text="Categoria"></asp:Label>
                      <p class="card-text"><%:articulo.Categoria.Descripcion %></p>
                      
                  </div>
                </div>
              </div>


    <a href="Default.aspx">regresar</a>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="CardsContainer" runat="server">
</asp:Content>
