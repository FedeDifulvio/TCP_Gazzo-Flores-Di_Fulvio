<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegistrosPaciente.aspx.cs" Inherits="Presentacion.RegistrosPaciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container-fluid " style="background-color: #4b89ac;">
        <div class="container">
            <div class="row justify-content-center mb-3">
            <div class="col-md-4 mt-3">
                <h1 style="color:white;">Registro Pacientes</h1>
            </div>
        </div>
            <div class="row mb-3">
                <div class="col-md-2"></div>
                <div class="col-md-7">
                    <asp:TextBox ID="Buscador" runat="server"  CssClass="form-control me-2 search"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <asp:Button ID="btnFiltrar" Text="Buscar" CssClass="btn btn-primary" OnClick="btnFiltrar_Click" runat="server" />
                </div>
            </div>


            <div class="row justify-content-center">
                <asp:GridView ID="GridPacientes" runat="server" CssClass="table table-light table-hover" AllowPaging="true" OnPageIndexChanging="GridPacientes_PageIndexChanging" OnRowDataBound ="GridPacientes_RowDataBound"> </asp:GridView>
            </div>

            <div class="row justify-content-center mb-3">
                <div class="col-md-4 mt-2 mb-3" style="margin-left:185px">
                    <a  href="AltaPaciente.aspx" class="btn btn-danger">Dar alta paciente</a>
                </div>
            </div>

         
        </div>
    </div>
  
</asp:Content>
