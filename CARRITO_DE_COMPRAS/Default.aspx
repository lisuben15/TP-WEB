<%@ Page Title="" Language="C#" MasterPageFile="~/Mi_Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs"
  Inherits="CARRITO_DE_COMPRAS.Página1" %>
  <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


  </asp:Content>

  <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row row-cols-1 row-cols-md-5 g-5">

      <asp:Repeater ID="Repetidor1" runat="server">
        <ItemTemplate>
          <div class="col ml-3px mt-5px">
            <div class="card" style="width:300px;height:400px">
              <div class="row justify-content-center">
                <button class="carousel-control-prev-icon" aria-hidden="true" type="button"
                  data-bs-target="#cardCarousel" data-bs-slide="prev">
                </button>
                <img style="width:250px; height: 200px; object-fit: cover;" src="<%#Eval(" UrlImagen") %>" class="card-img-top" alt="...">
                <button class="carousel-control-next-icon" aria-hidden="true" type="button"
                  data-bs-target="#cardCarousel" data-bs-slide="next">
                </button>
                <div class="card-body">
                  <h5 class="card-title">
                    <%#Eval("Nombre") %>
                  </h5>
                  <p class="card-text">
                    <%#Eval("Precio") %>
                  </p>
                  <div>
                    <a class="btn" style="border: 1px solid gray" href="Detalle.aspx?Codigo=<%#Eval(" Codigo") %>">Ver detalle</a>
                  </div>
                  <br />

                  <div>
                    <asp:Button class="btn btn-success" ID="btnAgregar" runat="server" Text="Agregar al carrito"
                      OnClick="btnAgregar_Click" CommandArgument='<%#Eval("Codigo") %>' CommandName="Codigo" />
                  </div>
                </div>
              </div>
            </div>
          </div>

        </ItemTemplate>
      </asp:Repeater>

    </div>

  </asp:Content>