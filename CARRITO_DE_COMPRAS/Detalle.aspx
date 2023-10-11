<%@ Page Title="" Language="C#" MasterPageFile="~/Mi_Master.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="CARRITO_DE_COMPRAS.Detalle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Detalle</h1>
    
              <div class="col">
                <div class="card">
                  <img src="<%:articulo.UrlImagen %>" class="card-img-top" alt="...">
                  <div class="card-body">
                    <h5 class="card-title"><%:articulo.Nombre %></h5>
                    <p class="card-text"><%:articulo.Precio %></p>
                            
                  </div>
                </div>
              </div>


    <a href="Default.aspx">regresar</a>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="CardsContainer" runat="server">
</asp:Content>
