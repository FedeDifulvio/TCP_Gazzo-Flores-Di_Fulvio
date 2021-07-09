<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EliminarMedico.aspx.cs" Inherits="Presentacion.Medicos.EliminarMedico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="container-fluid" style="background-color: #f3e9d2; height: 100vh;">
        <div class="container" >
            <div class="row justify-content-center mb-3">
                <div class="col-md-4 mt-4" style="text-align:center">
                    <h1>Eliminar Médico</h1>
                </div>
            </div>

            <br />
            <div class="row">
                <div class="col-md-4" style="text-align:center">
                    <asp:Label Text="Nombre" runat="server" CssClass="labels" />
                    <hr />
                </div>
                <div class="col-md-4" style="text-align:center">
                    <asp:Label Text="Apellido" runat="server"  CssClass="labels"  />
                    <hr />
                </div>
                <div class="col-md-4" style="text-align:center">
                    <asp:Label Text="Legajo" runat="server"  CssClass="labels" />
                    <hr />
                </div>
            </div>
            <div class="row">
                <div class="col-md-4">
                    <asp:TextBox ID="TextBoxNombre" CssClass="form-control mb-3" Enabled="false" ClientIDMode="Static" runat="server" />
                </div>
                <div class="col-md-4">
                    <asp:TextBox ID="TextBoxApellido" CssClass="form-control mb-3" Enabled="false" ClientIDMode="Static"  runat="server" />
                </div>
                <div class="col-md-4">
                    <asp:TextBox ID="TextBoxLegajo" CssClass="form-control mb-3" Enabled="false" ClientIDMode="Static" runat="server" />
                </div>
            </div>
        </div>

        <div class="row justify-content-center mb-3">
                <div class="col-md-4 mt-2 mb-4" style="text-align: center">
                    <asp:Button ID="btnEliminar" CssClass="btn btn-danger" onclick="btnEliminar_Click"  Text="Eliminar" runat="server" />
                </div>
            </div>
       <div class="row justify-content-center">
                 <div class="col-md-4 mt-5" style="text-align:center">
                       <a class="btn btn-secondary" href="RegistroMedicos.aspx"> ← Cancelar  </a>
                 </div>
              </div>

    </div>

</asp:Content>
 