<%@ Page Title="" Language="C#" MasterPageFile="~/Mi_Master.Master" AutoEventWireup="true" CodeBehind="Creadores.aspx.cs" Inherits="CARRITO_DE_COMPRAS.Creadores" %>
<asp:Content ID="Content4" ContentPlaceHolderID="head" runat="server">
    <style>
        .page-container {
            text-align: center;
        }

        .carrito-title {
            color: white;
        }

        .regresar-button {
            background-color: #007bff;
            color: white;
            border: none;
            padding: 10px 20px;
            border-radius: 5px;
            text-decoration: none;
            display: inline-block;
            margin: 10px;
        }

        .card-container {
            margin-top: 20px;
        }

        .total-label {
            font-size: 24px;
            font-weight: bold;
            color: #007bff;
        }

        .creadores-text {
            font-size: 24px;
            font-weight: bold;
            color: #007bff;
            margin-top: 20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page-container">
        <h1 class="carrito-title">Los Creadores del Proyecto</h1>
        <p class="creadores-text"> García Gastón, Rodriguez Ariel y Alejandro Bejarano</p>
        <img src="https://i.pinimg.com/originals/c0/7f/89/c07f8906bab19c5287273ed1446ed033.jpg" alt="Imagen sobre los creadores" width="350" /> 
        <div>
            <a class="regresar-button" href="Default.aspx">Regresar</a>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="CardsContainer" runat="server">
</asp:Content>

