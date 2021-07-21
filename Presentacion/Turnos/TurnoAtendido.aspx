<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="TurnoAtendido.aspx.cs" Inherits="Presentacion.Turnos.TurnoAtendido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" style="background-color:#f3e9d2; height:90vh">
        <div class="container">   
                 <div class="row justify-content-center">
                <div class="col-md-4 mt-4 mb-4" style="justify-content: center; display: flex">
                    <h1>Datos del Turno</h1>
                </div>
            </div>

            <div class="row mb-5" >
                <div class="col-md-6">
                    <asp:Label ID="NombreLbl" Text="Paciente" CssClass="label-turno" runat="server"  />
                    <asp:TextBox ID="NombreTxt" Enabled="false"  runat="server" CssClass="form-control mb-3" />

                    <asp:Label ID="EspecialidadLbl" Text="Especialidad"  CssClass="label-turno" runat="server"  />
                    <asp:TextBox ID="EspecialidadTxt" Enabled="false"  runat="server" CssClass="form-control mb-3" />
                </div>

                <div class="col-md-6">

                    <asp:Label ID="FechaLabel" Text="Fecha"  CssClass="label-turno" runat="server"  />
                    <asp:TextBox ID="FechaTextBox" Enabled="false"  runat="server" CssClass="form-control mb-3"/>

                    <asp:Label ID="HoraLbl" Text="Hora"  CssClass="label-turno" runat="server"  />
                    <asp:TextBox ID="HoraTxt" Enabled="false"  runat="server" CssClass="form-control" />
                </div>

            </div>
            <div class="row justify-content-center">
                <div class="col-md-3"></div>
                <div class="col-md-6 justify-content-center">
                    <asp:Label ID="LabelObservacion" Text="Observación"  CssClass="label-turno" runat="server"  />
                    <asp:TextBox ID="txtObservaciones" TextMode="MultiLine" runat="server" CssClass="form-control mb-3" ClientIDMode="Static" MaxLength="300"></asp:TextBox>
                    <div>
                        <h1 class="error-form" id="txtObservaciones-inv"></h1>
                    </div>
                    <div style="text-align: center;">
                        <asp:Button ID="btnFinalizarTurno" OnClick="btnFinalizarTurno_Click" OnClientClick="return ValidarObservacion()" CssClass="btn btn-success mt-3"  Text="Finalizar" runat="server" />
                    </div>
                    

                </div>
                <div class="col-md-3"></div>
            </div>
        </div>
        <div class="modal-contenedor"></div>
    </div>



         <script src="../JavaScript/Funciones.js"></script>
         <script src="../JavaScript/ValidacionesTurnos.js"></script>
         <script src="../JavaScript/popup.js"></script>  
</asp:Content>
