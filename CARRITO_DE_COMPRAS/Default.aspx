<%@ Page Title="" Language="C#" MasterPageFile="~/Mi_Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CARRITO_DE_COMPRAS.Página1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row row-cols-1 row-cols-md-4 g-3">
       <%-- <% //dentro de estos comodines puedo escribir codigo c#
            foreach (dominio.Articulo articulo in ListaArticulo)
            {
        %>
              <div class="col">
                <div class="card">
                  <img style="max-width:120px;" src="<%:articulo.UrlImagen %>" class="card-img-top" alt="...">
                  <div class="card-body">
                    <h5 class="card-title"><%:articulo.Nombre %></h5>
                    <p class="card-text"><%:articulo.Precio %></p>
                      <div>
                          <a href="Detalle.aspx?Codigo=<%:articulo.Codigo %>">Ver detalle</a>
                      </div>
                      <br />
                      <div> <asp:Button style="background-color:black ; color:white" ID="btnAgregar" runat="server" Text="Agregar al carrito" OnClick="btnAgregar_Click"/></div>
                  </div>
                </div>
              </div>
                

           <% } %>--%>


        <asp:Repeater ID="Repetidor1" runat="server">
            <ItemTemplate>
                    <div class="col">
                      <div class="card">
                        <img style="max-width:120px;" src="<%#Eval("UrlImagen") %>" class="card-img-top" alt="...">
                        <div class="card-body">
                          <h5 class="card-title"><%#Eval("Nombre") %></h5>
                          <p class="card-text"><%#Eval("Precio") %></p>
                            <div>
                                <a href="Detalle.aspx?Codigo=<%#Eval("Codigo") %>">Ver detalle</a>
                            </div>
                            <br />
                            <div> <asp:Button style="background-color:black ; color:white" ID="btnAgregar" runat="server" Text="Agregar al carrito" OnClick="btnAgregar_Click" CommandArgument='<%#Eval("Codigo") %>' CommandName="Codigo"/></div>
                        </div>
                      </div>
                    </div>

            </ItemTemplate>
        </asp:Repeater>

  
    </div>

</asp:Content>
