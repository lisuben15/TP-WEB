<%@ Page Title="" Language="C#" MasterPageFile="~/Mi_Master.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="CARRITO_DE_COMPRAS.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 > Productos agregados al carrito</h1>

         <div class="row row-cols-1 row-cols-md-4 g-3 mt-10">
                    <asp:Repeater ID="Repetidor2" runat="server">
                      <ItemTemplate>
                        <div style="color:teal" class="col">
                          <div class="card" style="width:300px; height:340px">
                              <div class="row justify-content-center">
                            <img style="max-width:200px; max-height:240px" src="<%#Eval("UrlImagen") %>" class="card-img-top" alt="Imagen no disponible">
                            <div class="card-body">
                              <h5 class="card-title"><%#Eval("Nombre") %> $<%#Eval("Precio") %></h5> 
                                <div class="position-absolute bottom-0 end-0 mb-2 mr-5">
                                <div> <asp:Button style="background-color:blueviolet ; color:white" ID="btnEliminar" runat="server" Text="Quitar todos" OnClick="btnEliminar_Click" CommandArgument='<%#Eval("Codigo") %>' CommandName="Codigo"  />
                                      <asp:Button  style="background-color:darkmagenta ; color:white" ID="btnEliminarUno" runat="server" Text="Quitar uno" OnClick="btnEliminarUno_Click" CommandArgument='<%#Eval("Codigo") %>' CommandName="Codigo"  /></div>
                                </div>
                                </div>
                            </div>
                          </div>
                        </div>

                    </ItemTemplate>
                 </asp:Repeater>

       </div>

    <a href="Default.aspx">Regresar</a>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CardsContainer" runat="server">

</asp:Content>
