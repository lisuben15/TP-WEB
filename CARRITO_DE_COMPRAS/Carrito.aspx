<%@ Page Title="" Language="C#" MasterPageFile="~/Mi_Master.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="CARRITO_DE_COMPRAS.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 > Productos agregados</h1>



         <div class="row row-cols-1 row-cols-md-4 g-3">
     
                    <asp:Repeater ID="Repetidor2" runat="server">
                      <ItemTemplate>
                        <div style="color:teal" class="col">
                          <div class="card">
                              <div class="row justify-content-center">
                            <img style="max-width:200px;" src="<%#Eval("UrlImagen") %>" class="card-img-top" alt="...">
                            <div class="card-body">
                              <h5 class="card-title"><%#Eval("Nombre") %></h5>
                              <p class="card-text"><%#Eval("Precio") %></p>  
                                
                                <div> <asp:Button style="background-color:red ; color:white" ID="btnEliminar" runat="server" Text="Quitar" OnClick="btnEliminar_Click" CommandArgument='<%#Eval("Codigo") %>' CommandName="Codigo"  /></div>
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
