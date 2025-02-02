﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AltaMedico.aspx.cs" Inherits="Presentacion.Medicos.AltaMedico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid " style="background-color: #f3e9d2; height: 100vh;">
        <div class="container">
            <div class="row justify-content-center mb-3">
                <div class="col-md-4 mt-4" style="text-align: center">
                    <h1>Alta de Nuevo Médico</h1>
                </div>
            </div>

            <br />
            <div class="row">
                <div class="col-md-4" style="text-align: center">
                    <asp:Label Text="Nombre" runat="server" CssClass="labels" />
                    <hr />
                </div>
                <div class="col-md-4" style="text-align: center">
                    <asp:Label Text="Apellido" runat="server" CssClass="labels" />
                    <hr />
                </div>
                <div class="col-md-4" style="text-align: center">
                    <asp:Label Text="Legajo" runat="server" CssClass="labels" />
                    <hr />
                </div>
            </div>
            <div class="row">
                <div class="col-md-4">
                    <asp:TextBox ID="TextBoxNombre" MaxLength="30" CssClass="form-control mb-3" ClientIDMode="Static" Placeholder="Nombre" runat="server" />
                    <div>
                    <h1 class="error-form" id="TextBoxNombre-inv"></h1>
                    </div>
                </div>
                
                <div class="col-md-4">
                    <asp:TextBox ID="TextBoxApellido" MaxLength="30" CssClass="form-control mb-3" ClientIDMode="Static" Placeholder="Apellido" runat="server" />
                 <div>
                    <h1 class="error-form" id="TextBoxApellido-inv"></h1>
                </div>
                </div>
               
                <div class="col-md-4">
                    <asp:TextBox ID="TextBoxLegajo"  MaxLength="5" CssClass="form-control mb-3" ClientIDMode="Static" Placeholder="Legajo" runat="server" />
                <div>
                    <h1 class="error-form" id="TextBoxLegajo-inv"></h1>        
                </div>
                    
                </div>
                
            </div>
            <div class="row justify-content-center mb-3">
                <div class="col-md-4 mt-2 mb-2">
                    <asp:Label ID="lblLegajo"  Text="El legajo no se encuentra disponible" CssClass="alert alert-danger" runat="server" />
                    <asp:Button ID="btnOkLegajo" OnClick="btnOkLegajo_Click" CssClass="btn btn-danger" Text="Ok" runat="server" />
                </div>     
            </div>
            <div class="row justify-content-center mb-3">
                <div class="col-md-4 mt-2 mb-4" style="text-align: center">
                    <asp:Button ID="btnAgregar" CssClass="btn btn-primary" OnClick="btnAgregar_Click" OnClientClick="return validarFormularioMedico()" Text="Agregar" runat="server" />
                </div>
            </div>

        </div>
    </div>

    <script src="../JavaScript/Funciones.js"></script>
    <script src="../JavaScript/ValidacionesMedico.js"></script>
</asp:Content>
