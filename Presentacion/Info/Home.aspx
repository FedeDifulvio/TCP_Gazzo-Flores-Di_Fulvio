<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Presentacion.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container-fluid home">
        <div class="container">
            <%if (usuario.TipoUsuario.Id==2)
                {
                   %>
            <div class="row">
                <div class="col-md-4" style="justify-content: center; display: flex">
                     <div class="card-menu">
                        <img  style=" margin-left: 30px;" class="img-card-menu" src="../img/registro.png" alt="Alternate Text"; />
                        <hr />
                          <a  class="btn btn-primary" href="../Turnos/RegistroTurnos.aspx">Registro Turnos</a>
                    </div>   
                </div>
                <div class="col-md-4" style="justify-content: center; display: flex">
                    <div class="card-menu">
                        <img style=" margin-left: 30px;" class="img-card-menu" src="../img/calendar.png" alt="Alternate Text"; />
                        <hr />
                        <a  class="btn btn-primary" href="../Turnos/NuevoTurno.aspx">Asignar Turno</a>
                    </div>   
                </div>
                <div class="col-md-4" style="justify-content: center; display: flex">
                    <div class="card-menu">
                        <img style=" margin-left: 10px;" class="img-card-menu" src="../img/user.png" alt="Alternate Text"; />
                        <hr />
                        <a  class="btn btn-primary" href="../Pacientes/RegistrosPaciente.aspx">Pacientes</a>
                    </div>
            </div>
          </div>
            <%
                } %>
            
                <%if (usuario.TipoUsuario.Id == 1)
                    {
                                   %>
                            <div class="row">
                                <div class="col-md-3" style="justify-content: center; display: flex">
                                     <div class="card-menu">
                                        <img  style=" margin-left: 15px;" class="img-card-menu" src="../img/Medico.png" alt="Alternate Text"; />
                                        <hr />
                                          <a  class="btn btn-primary" href="../Medicos/AltaMedico.aspx">Alta Medico</a>
                                    </div>   
                                </div>
                                <div class="col-md-3" style="justify-content: center; display: flex">
                                    <div class="card-menu">
                                        <img style=" margin-left: 15px;" class="img-card-menu" src="../img/user.png" alt="Alternate Text"; />
                                        <hr />
                                        <a  class="btn btn-primary" href="../Usuario/AltaUsuario.aspx">Alta Usuario</a>
                                    </div>   
                                </div>
                                <div class="col-md-3" style="justify-content: center; display: flex">
                                    <div class="card-menu">
                                        <img style=" margin-left: 30px;" class="img-card-menu" src="../img/ObraSocial.png" alt="Alternate Text"; />
                                        <hr />
                                        <a  class="btn btn-primary" href="../ObrasSociales/ObrasSociales.aspx">Alta Obra Social</a>
                                    </div>
                            </div>

                                    <div class="col-md-3" style="justify-content: center; display: flex">
                                    <div class="card-menu">
                                        <img style=" margin-left: 45px;" class="img-card-menu" src="../img/EspecialidadMedica.png" alt="Alternate Text"; />
                                        <hr />
                                        <a  class="btn btn-primary" href="../Especialidades/Especialidades.aspx">Alta Especialidades</a>
                                    </div>
                            </div>
                          </div>
                            <%
                                } %>


             <%if (usuario.TipoUsuario.Id == 3)
                    {
                                   %>
                            <div class="row">
                                <div class="col-md-4"></div>
                                <div class="col-md-4" style="justify-content: center; display: flex">
                                     <div class="card-menu">
                                        <img  style=" margin-left: 15px;" class="img-card-menu" src="../img/Medico.png" alt="Alternate Text"; />
                                        <hr />
                                          <a  class="btn btn-primary" href="../Turnos/TurnosMedico.aspx">Turnos Medico</a>
                                    </div>   
                                </div>
                                    <div class="col-md-4"></div>
                             
                          </div>
                            <%
                                } %>
            



      </div>
    </div>



</asp:Content>
