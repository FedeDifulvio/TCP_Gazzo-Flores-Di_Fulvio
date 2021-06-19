<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegistrosPaciente.aspx.cs" Inherits="Presentacion.RegistrosPaciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container-fluid home">
        <div class="container">
            <div class="row justify-content-center mb-3">
            <div class="col-md-4 mt-3">
                <h1>Registro Pacientes</h1>
            </div>
        </div>
            <div class="row justify-content-center">
                <asp:GridView ID="GridPacientes" runat="server" CssClass="table table-light table-hover" AllowPaging="true" OnPageIndexChanging="GridPacientes_PageIndexChanging" OnRowDataBound ="GridPacientes_RowDataBound"> </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
