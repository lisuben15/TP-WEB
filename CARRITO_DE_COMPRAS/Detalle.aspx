<%@ Page Title="" Language="C#" MasterPageFile="~/Mi_Master.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="CARRITO_DE_COMPRAS.Detalle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container text-center" style="margin-top: 50px;">
        <h1 style="color:white">Detalle</h1>

        <div class="col d-flex justify-content-center">
            <div class="card">

                <img ID="cardCarousel" style="max-width: 260px; max-height: 260px;" src="<%:articulo.UrlImagen %>" class="card-img-top" alt="Imagen no disponible">
                <div class=" justify-content-between">
                    <asp:Button class="btn btn-info" style="color:white; margin-top: 20px;" ID="btnPreviousUrl" runat="server" Text="<" OnClick="btnPreviousUrl_Click" />
                    <asp:Button class="btn btn-info" style="color:white; margin-top: 20px;" ID="btnNextUrl" runat="server" Text=">" OnClick="btnNextUrl_Click" />    
                </div>
                <div class="card-body">

                    <div style="display: flex; gap: 20px; margin-bottom: 20px; justify-content: center; align-items: center; flex-direction: column;">

                        <h2 class="card-text">
                            <%:articulo.Nombre %>
                        </h2>
                    </div>
                    <div style="display: flex; gap: 20px; justify-content: center; align-items: center;">
                        <asp:Label ID="Label2" runat="server" Text="Codigo: "></asp:Label>
                        <p class="card-text">
                            <%:articulo.Codigo %>
                        </p>
                    </div>
                    <div style="display: flex; gap: 20px; justify-content: center; align-items: center;">
                        <asp:Label ID="Label5" runat="server" Text="Marca:"></asp:Label>
                        <p class="card-text">
                            <%:articulo.Marca.Descripcion %>
                        </p>
                    </div>
                    <div style="display: flex; gap: 20px; justify-content: center; align-items: center;">
                        <asp:Label ID="Label3" runat="server" Text="Descripción:"></asp:Label>
                        <p class="card-text">
                            <%:articulo.Descripcion %>
                        </p>
                    </div>
                    <div style="display: flex; gap: 20px; justify-content: center; align-items: center;">
                        <asp:Label ID="Label4" runat="server" Text="Precio:"></asp:Label>
                        <p class="card-text">
                            <%:articulo.Precio %>
                        </p>
                    </div>
                    <div style="display: flex; gap: 20px; justify-content: center; align-items: center;">
                        <asp:Label ID="Label6" runat="server" Text="Categoria:"></asp:Label>
                        <p class="card-text">
                            <%:articulo.Categoria.Descripcion %>
                        </p>
                    </div>
                </div>
            </div>
        </div>

        <a class="btn btn-info" style="color:white; margin-top: 20px;" href="Default.aspx">Regresar</a>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="CardsContainer" runat="server">
</asp:Content>
