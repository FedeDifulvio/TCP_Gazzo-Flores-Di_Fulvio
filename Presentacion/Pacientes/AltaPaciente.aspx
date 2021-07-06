<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AltaPaciente.aspx.cs" Inherits="Presentacion.AltaPaciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" AutoPostBack="false" runat="server">
   

    <div class="container-fluid" style="background-color:#f3e9d2; height:90vh">
        <div class="container">

            <div class="row justify-content-center">

                <div class="col-md-4 mt-3"  style="text-align:center">

                    <h1>Alta paciente</h1>
                </div>
            </div>

            <div class="row mt-4" >
                <div class="col-md-6">
                    <div>
                        <asp:TextBox ID="TextBoxNombre" CssClass="form-control mb-3" MaxLength="30"  ClientIDMode="Static" placeholder="Nombre"  runat="server"></asp:TextBox>
                        <div>
                            <h1 class="error-form" id="TextBoxNombre-inv"></h1>
                        </div>
                        <asp:TextBox ID="TextBoxApellido" CssClass="form-control mb-3"  MaxLength="30" ClientIDMode="Static" placeholder="Apellido" runat="server" />
                         <div>
                            <h1 class="error-form" id="TextBoxApellido-inv"></h1>
                        </div>
                        <asp:TextBox ID="TextBoxDni"  CssClass="form-control mb-3"  MaxLength="15" ClientIDMode="Static" placeholder="DNI" runat="server" />
                         <div>
                            <h1 class="error-form" id="TextBoxDni-inv"></h1>
                        </div>
                        <asp:TextBox ID="txtDate" CssClass="form-control mb-3"  ClientIDMode="Static" runat="server" placeholder="From" type="date"></asp:TextBox>
                        <div>
                            <h1 class="error-form" id="txtDate-inv"></h1>
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

            <div class="row justify-content-center mb-3" >
                <div class="col-md-4 mt-2 mb-2" >
                    <asp:Label ID="lblDNI" Text="El DNI no puede repetirse" CssClass="alert alert-danger" runat="server" />
                    <asp:Button ID="btnOK" Text="Ok" CssClass="btn btn-danger" OnClick="btnOK_Click" runat="server" />
                </div>
            </div>

            <div class="row justify-content-center">

                <div class="col-md-4 mt-3" style="text-align:center">
                    <asp:Button ID="btnAgregar" Text="Agregar" runat="server" CssClass="btn btn-primary" Style="width:150px; height:50px" OnClientClick="return validarFormularioPaciente()" Onclick="btnAgregar_Click"/>
                </div> 
                 
            </div>
             <div class="row justify-content-center">
                 <div class="col-md-4 mt-5" style="text-align:center">
                       <a class="btn btn-danger" href="RegistrosPaciente.aspx"> ← Cancelar  </a>
                 </div>
              </div>
                     
        </div>
    </div>
     <script src="../JavaScript/FuncionesValidaciones.js"></script>
    <script src="../JavaScript/ValidacionesPaciente.js"></script>
</asp:Content>
