<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CancelarTurno.aspx.cs" Inherits="Presentacion.Turnos.CancelarTurno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container-fluid" style="background-color:#f3e9d2; height:90vh">
        <div class="container">

            <div class="row justify-content-center">

                <div class="col-md-4 mt-3" style="text-align:center">

                    <h1>Cancelar Turno</h1>
                </div>
            </div>

            <div class="row mt-4" >
                <div class="col-md-6">
                    <div>
                        <asp:TextBox ID="TextBoxNumero" CssClass="form-control mb-3" Enabled="false" MaxLength="30"  ClientIDMode="Static" placeholder="Nombre"  runat="server"></asp:TextBox>
                        <asp:TextBox ID="TextBoxPaciente" CssClass="form-control mb-3" Enabled="false" MaxLength="30" ClientIDMode="Static" placeholder="Apellido"  runat="server"></asp:TextBox>
                        <asp:TextBox ID="TextBoxMedico" CssClass="form-control mb-3" Enabled="false" ClientIDMode="Static"  MaxLength="10" placeholder="DNI"  runat="server"></asp:TextBox>
                        
                        
                    </div>
                </div>
                <div class="col-md-6">
                    <div >
                        <asp:TextBox ID="TextBoxFecha" CssClass="form-control mb-3" Enabled="false" MaxLength="50" ClientIDMode="Static" placeholder="Dirección"  runat="server"></asp:TextBox>
                        <asp:TextBox ID="TextBoxHora" CssClass="form-control mb-3" Enabled="false" placeholder="Mail"  ClientIDMode="Static" runat="server"></asp:TextBox>
                        <asp:TextBox ID="TextBoxEstado" CssClass="form-control mb-3" Enabled="false" placeholder="Telefono"  ClientIDMode="Static" runat="server"></asp:TextBox>
                        
                    </div>
                </div>
            </div>

            <div class="row justify-content-center">

                <div class="col-md-4 mt-3" style="margin-left:270px">
                    <asp:Button ID="btnCancelar" Text="Cancelar Turno" CssClass="btn btn-danger" OnClick="btnCancelar_Click" Style="width:150px; height:50px" runat="server" />                 
                </div>
            </div>
            <div class="row justify-content-center">
                 <div class="col-md-4 mt-5" style="text-align:center">
                       <a class="btn btn-secondary" href="RegistroTurnos.aspx"> ← Cancelar  </a>
                 </div>
              </div>
        </div>
    </div>

</asp:Content>
