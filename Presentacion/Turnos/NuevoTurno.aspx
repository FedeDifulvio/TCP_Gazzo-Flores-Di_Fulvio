<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="NuevoTurno.aspx.cs" Inherits="Presentacion.NuevoTurno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container-fluid" style="background-color:#f3e9d2; height:100%">
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-md-4 mt-4 mb-4" style="justify-content: center; display: flex">
                    <h1>Nuevo Turno</h1>
                </div>
            </div>

            <div class="row">
                <div class="col-md-4">
                </div>

                <div class="col-md-3" style="text-align: center;">
                    <asp:TextBox ID="DniTxt" PlaceHolder="Dni del paciente" MaxLength="8" ClientIDMode="Static"  runat="server" CssClass="form-control" />

                    <div>
                        <h1 class="error-form" id="DniTxt-inv"></h1>
                    </div>
                </div>


                <div class="col-md-3">
                    <asp:Button ID="DniBtn" Text="Buscar" runat="server" OnClientClick="return ValidarDniPaciente()" OnClick="DniBtn_Click" CssClass="btn btn-primary" />

                </div>

                <div class="col-md-2">
                </div>

            </div>
             <div class="row mt-2"  style="text-align:center">
                 <asp:Label ID="DniLBL" CssClass="alert alert-danger" Text="Dni erroneo o no encontrado" visible="false" runat="server" />

            </div>

            <div class="row mb-5" >
                <div class="col-md-6">
                    <asp:Label ID="NombreLbl" Text="Nombre" CssClass="label-turno" runat="server" visible="false" />
                    <asp:TextBox ID="NombreTxt" Enabled="false" visible="false" runat="server" CssClass="form-control mb-3" />

                    <asp:Label ID="ApellidoLbl" Text="Apellido"  CssClass="label-turno" runat="server" visible="false" />
                    <asp:TextBox ID="ApellidoTxt" Enabled="false" visible="false" runat="server" CssClass="form-control mb-3" />
                </div>

                <div class="col-md-6">

                    <asp:Label ID="DniLabel" Text="Dni"  CssClass="label-turno" runat="server" visible="false" />
                    <asp:TextBox ID="dniTextBox" Enabled="false" visible="false" runat="server" CssClass="form-control mb-3"/>

                    <asp:Label ID="ObraSocialLbl" Text="Obra social"  CssClass="label-turno" runat="server" visible="false" />
                    <asp:TextBox ID="ObraSocialTxt" Enabled="false" visible="false" runat="server" CssClass="form-control" />
                </div>


            </div>

            <div class="row">

                <div class="col-md-6">
                    <asp:Label ID="Especialidades" Text="Seleccionar Especialidad"  CssClass="label-turno2" visible="false" runat="server"   />

                    <asp:DropDownList ID="DdlEspecialidades" visible="false"   runat="server" AutoPostBack="true" AppendDataBoundItems="true" OnSelectedIndexChanged="DdlEspecialidades_SelectedIndexChanged">
                    </asp:DropDownList>
                </div>

                <div class="col-md-6">
                    <asp:label ID="LblMedico" text="Seleccionar Médico" visible="false"  CssClass="label-turno2" runat="server" />
                    <asp:DropDownList ID="DdlMedicos" visible="false" AutoPostBack="true" AppendDataBoundItems="true" OnTextChanged ="DdlMedicos_TextChanged" runat="server">
                        
                    </asp:DropDownList>

                </div>
            </div> 

            <div class="row">
                <div class="col-md-6 mt-5">
                    <asp:Calendar ID="Calendario" Visible ="false" OnDayRender="Calendario_DayRender" OnSelectionChanged="Calendario_SelectionChanged"  runat="server"></asp:Calendar>
                </div>
                <div class="col-md-6 mt-5"> 
                    <asp:Label ID="lblFecha" CssClass="label-turno2 mb-3"  visible ="false" Text="" runat="server" />
                    <br />
                    <asp:DropDownList ID="ddlHorarios" CssClass="mt-3 mb-3" Visible="false" runat="server"></asp:DropDownList>
                    <br />
                    <asp:TextBox ID="txtObservaciones" TextMode="MultiLine" runat="server" Visible="false" CssClass="form-control mb-3" ClientIDMode="Static" MaxLength="300"></asp:TextBox>

                     <div>
                        <h1 class="error-form" id="txtObservaciones-inv"></h1>
                    </div>

                    <asp:Button ID="btnAgregarTurno" Visible="false" CssClass="btn btn-success mt-3" Text="Confirmar"  
                        OnClientClick="return ValidarObservacion()"  OnClick="btnAgregarTurno_Click" runat="server"  />
                    

                </div>
                
            </div>
             <div class="row justify-content-center">
                <div class="col-md-" style="text-align:center">
                    <asp:Button ID="btnCancelar" CssClass="btn btn-danger mt-5 mb-4" Visible="false" OnClick="btnCancelar_Click"  Text="Cancelar" runat="server" />
                </div> 
            </div>
             <div class="row justify-content-center">
                 <div class="col-md-4 mb-3" style="text-align:center">
                       <a class="btn btn-secondary" href="../Info/Home.aspx"> ← Volver </a>
                 </div>
              </div>

            <div class="modal-contenedor"> </div>
        </div>
        
     
         <script src="../JavaScript/Funciones.js"></script>
         <script src="../JavaScript/ValidacionesTurnos.js"></script>
         <script src="../JavaScript/popup.js"></script>  
</asp:Content>
