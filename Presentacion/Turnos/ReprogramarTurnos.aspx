<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ReprogramarTurnos.aspx.cs" Inherits="Presentacion.Turnos.ReprogramarTurnos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" style="background-color:#f3e9d2; height:90vh">
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-md-4 mt-4 mb-4" style="justify-content: center; display: flex">
                    <h1>Reprogramar Turno</h1>
                </div>
            </div>

            <div class="row mb-5" >
                <div class="col-md-6">
                    <asp:Label ID="NombreLbl" Text="Nombre" CssClass="label-turno" runat="server"  />
                    <asp:TextBox ID="NombreTxt" Enabled="false"  runat="server" CssClass="form-control mb-3" />

                    <asp:Label ID="ApellidoLbl" Text="Apellido"  CssClass="label-turno" runat="server"  />
                    <asp:TextBox ID="ApellidoTxt" Enabled="false"  runat="server" CssClass="form-control mb-3" />
                </div>

                <div class="col-md-6">

                    <asp:Label ID="DniLabel" Text="Dni"  CssClass="label-turno" runat="server"  />
                    <asp:TextBox ID="dniTextBox" Enabled="false"  runat="server" CssClass="form-control mb-3"/>

                    <asp:Label ID="ObraSocialLbl" Text="Obra social"  CssClass="label-turno" runat="server"  />
                    <asp:TextBox ID="ObraSocialTxt" Enabled="false"  runat="server" CssClass="form-control" />
                </div>


            </div>

            <div class="row">

                <div class="col-md-6">
                    <asp:Label ID="LblEspecialidad"   CssClass="label-turno2"  runat="server"   />

                    
                </div>

                <div class="col-md-6">
                    <asp:label ID="LblMedico"   CssClass="label-turno2" runat="server" />
                   

                </div>
            </div> 

            <div class="row">
                <div class="col-md-6 mt-5">
                    <asp:Calendar ID="Calendario" OnDayRender="Calendario_DayRender" OnSelectionChanged="Calendario_SelectionChanged"   runat="server"></asp:Calendar>
                </div>
                <div class="col-md-6 mt-5"> 
                    <asp:Label ID="lblFecha" CssClass="label-turno2 mb-3"  visible ="false" Text="" runat="server" />
                    <br />
                    <asp:DropDownList ID="ddlHorarios" CssClass="mt-3 mb-3" Visible=" false" runat="server"></asp:DropDownList>
                    <br />
                    <asp:Button ID="btnAlterarTurno" OnClick="btnAlterarTurno_Click" Visible="false" CssClass="btn btn-success mt-3"  Text="Reprogramar" runat="server" />
                </div>
                
            </div>
             <div class="row justify-content-center">
                <div class="col-md-" style="text-align:center">
                    <asp:Button ID="btnCancelar" OnClick="btnCancelar_Click" CssClass="btn btn-danger mt-5" Visible="false"  Text="Cancelar" runat="server" />
                </div>  
            </div>
        </div>
        

         <script src="../JavaScript/FuncionesValidaciones.js"></script>
         <script src="../JavaScript/ValidacionesTurnos.js"></script>
</asp:Content>
