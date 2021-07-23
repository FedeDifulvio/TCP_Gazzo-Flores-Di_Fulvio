<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AltaUsuario.aspx.cs" Inherits="Presentacion.Usuarios.AltaUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid " style="background-color: #f3e9d2; height: 100vh;">
        <div class="container">
            <div class="row justify-content-center mb-3">
                <div class="col-md-4 mt-4" style="text-align: center">
                    <h1>Alta de Nuevo Usuario</h1>
                </div>
            </div>

            <br />
            <div class="row">
                <div class="col-md-3" style="text-align: center">
                    <asp:Label Text="Usuario" runat="server" CssClass="labels" />
                    <hr />
                </div>
                <div class="col-md-3" style="text-align: center">
                    <asp:Label Text="Contraseña" runat="server" CssClass="labels" />
                    <hr />
                </div>
                <div class="col-md-3" style="text-align: center">
                    <asp:Label Text="Tipo de Usuario" runat="server" CssClass="labels" />
                    <hr />
                </div>
                <div class="col-md-3" style="text-align: center">
                    <asp:Label Text="Token" runat="server" CssClass="labels" />
                    <hr />
                </div>

            </div>
            <div class="row">
                <div class="col-md-3">
                    <asp:TextBox ID="TextBoxNombre" MaxLength="30" CssClass="form-control mb-3" ClientIDMode="Static" Placeholder="Nombre" runat="server" />
                    <div>
                    <h1 class="error-form" id="TextBoxNombre-inv"></h1>
                    </div>
                </div>
                
                <div class="col-md-3">
                    <asp:TextBox ID="TextBoxContrasenia" MaxLength="30" CssClass="form-control mb-3" ClientIDMode="Static" Placeholder="Contraseña" runat="server" />
                 <div>
                    <h1 class="error-form" id="TextBoxContrasenia-inv"></h1>
                </div>
                </div>
               
                 <div class="col-md-3">
                   
                     <asp:DropDownList  ID="DdlTipoUsuario" OnSelectedIndexChanged="DdlTipoUsuario_SelectedIndexChanged"  AutoPostBack="true" CssClass="form-control mb-3" runat="server"></asp:DropDownList>
                    
                </div>

                <div class="col-md-3">
                    <asp:TextBox ID="TextBoxToken"  MaxLength="5" CssClass="form-control mb-3" ClientIDMode="Static" Placeholder="Token" runat="server" visible="false" />
                <div>
                    <h1 class="error-form" id="TextBoxToken-inv"></h1>        
                </div>
                    
                </div>




                
            </div>
            <div class="row justify-content-center mb-3">
                <div class="col-md-6 mt-2 mb-2">
                    <asp:Label ID="lblToken" Visible="false" Text="El Token debe coincidir con un legajo de medico" CssClass="alert alert-danger" runat="server" />
                    <asp:Button ID="btnOkToken" OnClick="btnOkToken_Click" Visible="false"  CssClass="btn btn-danger" Text="Ok" runat="server" />
                </div>     
            </div>
            <div class="row justify-content-center mb-3">
                <div class="col-md-4 mt-2 mb-4" style="text-align: center">
                    <asp:Button ID="btnAgregar" CssClass="btn btn-primary" OnClientClick="return validarFormularioUsuario()" OnClick="btnAgregar_Click" Text="Agregar" runat="server" />
                </div>
            </div>
             <div class="modal-contenedor"></div>
        </div>
    </div>
     
    <script src="../JavaScript/popup.js"></script>
    <script src="../JavaScript/Funciones.js"></script>
    <script src="../JavaScript/ValidacionesUsuarios.js"></script>







</asp:Content>
