<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ModificarPaciente.aspx.cs" Inherits="Presentacion.ModificarPaciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid" style="background-color:#f3e9d2; height:90vh">
        <div class="container">

            <div class="row justify-content-center">

                <div class="col-md-4 mt-3" style="margin-left:150px">

                    <h1>Modificar paciente</h1>
                </div>
            </div>

            <div class="row mt-4" >
                <div class="col-md-6">
                    <div>
                        <asp:TextBox ID="TextBoxNombre" CssClass="form-control mb-3" MaxLength="30"  ClientIDMode="Static" placeholder="Nombre"  runat="server"></asp:TextBox>
                        <div class="invalid-feedback">
                           El nombre no puede estar vacío o contener números.
                        </div> 
                        <asp:TextBox ID="TextBoxApellido" CssClass="form-control mb-3"  MaxLength="30" ClientIDMode="Static" placeholder="Apellido"  runat="server"></asp:TextBox>
                        <asp:TextBox ID="TextBoxDni" CssClass="form-control mb-3"  ClientIDMode="Static"  MaxLength="10" placeholder="DNI"  runat="server"></asp:TextBox>
                        <asp:TextBox  ID="from_date" CssClass="form-control mb-3"  runat="server" placeholder="from" type="date"></asp:TextBox>
                        
                        
                        
                    </div>
                </div>
                <div class="col-md-6">
                    <div >
                        <asp:TextBox ID="TextBoxDireccion" CssClass="form-control mb-3" MaxLength="50" ClientIDMode="Static" placeholder="Dirección"  runat="server"></asp:TextBox>
                        <asp:TextBox ID="TextBoxMail" CssClass="form-control mb-3" placeholder="Mail"  ClientIDMode="Static" runat="server"></asp:TextBox>
                        <asp:TextBox ID="TextBoxTelefono" CssClass="form-control mb-3" placeholder="Telefono"  ClientIDMode="Static" runat="server"></asp:TextBox>
                        <asp:DropDownList ID="DdlObraSocial"  CssClass="form-select"  ClientIDMode="Static" runat="server"></asp:DropDownList>
                        
                    </div>
                </div>
            </div>

            <div class="row justify-content-center">

                <div class="col-md-4 mt-3" style="margin-left:270px">
                    <asp:Button ID="BtnModificar" runat="server" Text="Modificar" CssClass="btn btn-primary" Style="width:150px; height:50px" OnClientClick="return validarFormularioPaciente()" OnClick="BtnModificar_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
