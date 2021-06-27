<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ModificarPaciente.aspx.cs" Inherits="Presentacion.ModificarPaciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1"   runat="server">

    <div class="container-fluid" style="background-color:#f3e9d2; height:90vh">
        <div class="container">

            <div class="row justify-content-center">

                <div class="col-md-4 mt-3" style="margin-left:100px">

                    <h1>Modificar paciente</h1>
                </div>
            </div>

            <div class="row mt-4" >
                <div class="col-md-6">
                    <div>
                        <asp:TextBox ID="TextBoxNombre" CssClass="form-control mb-3" MaxLength="30"  ClientIDMode="Static" placeholder="Nombre"  runat="server"></asp:TextBox> 
                        <div>
                            <h1 class="error-form" id="TextBoxNombre-inv"></h1>
                        </div>
                        <asp:TextBox ID="TextBoxApellido" CssClass="form-control mb-3"  MaxLength="30" ClientIDMode="Static" placeholder="Apellido"  runat="server"></asp:TextBox>
                        <div>
                            <h1 class="error-form" id="TextBoxApellido-inv"></h1>
                        </div>
                        <asp:TextBox ID="TextBoxDni" CssClass="form-control mb-3"  ClientIDMode="Static"  MaxLength="10" placeholder="DNI"  runat="server"></asp:TextBox>
                        <div>
                            <h1 class="error-form" id="TextBoxDni-inv"></h1>
                        </div>
                        <asp:TextBox ID="txtDate" CssClass="form-control mb-3" type="date" ClientIDMode="Static" runat="server" />
                        <div>
                            <h1 class="error-form" id="txtBoxDate-inv"></h1>
                        </div>
                        
                        
                        
                    </div>
                </div>
                <div class="col-md-6">
                    <div >
                        <asp:TextBox ID="TextBoxDireccion" CssClass="form-control mb-3" MaxLength="50" ClientIDMode="Static" placeholder="Dirección"  runat="server"></asp:TextBox>
                        <div>
                            <h1 class="error-form" id="TextBoxDireccion-inv"></h1>
                        </div>
                        <asp:TextBox ID="TextBoxMail" CssClass="form-control mb-3" placeholder="Mail"  ClientIDMode="Static" runat="server"></asp:TextBox>
                        <div>
                            <h1 class="error-form" id="TextBoxMail-inv"></h1>
                        </div>
                        <asp:TextBox ID="TextBoxTelefono" CssClass="form-control mb-3" placeholder="Telefono"  ClientIDMode="Static" runat="server"></asp:TextBox>
                        <div>
                            <h1 class="error-form" id="TextBoxTelefono-inv"></h1>
                        </div>
                        <asp:DropDownList ID="DdlObraSocial"  CssClass="form-select"  ClientIDMode="Static" runat="server"></asp:DropDownList>
                        
                    </div>
                </div>
            </div>

            <div class="row justify-content-center">

                <div class="col-md-4 mt-3" style="margin-left:270px">
                    <asp:Button ID="btnModificar" Text="Modificar" CssClass="btn btn-primary" Style="width:150px; height:50px" runat="server" OnClientClick="return validarFormularioPaciente()" OnClick="btnModificar_Click" />
                </div>
            </div>
        </div>
    </div>
    <script src="JavaScript/FuncionesValidaciones.js"></script>
    <script src="JavaScript/ValidacionesPaciente.js"></script>
</asp:Content>
