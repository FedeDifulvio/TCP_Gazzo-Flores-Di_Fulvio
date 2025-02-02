﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegistroTurnos.aspx.cs" Inherits="Presentacion.Turnos.RegistroTurnos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" style="background-color:#f3e9d2; height: 100%;">
        <div class="container">
            <div class="row justify-content-center mb-3">
            <div class="col-md-4 mt-3" style="text-align:center">
                <h1>Registro de Turnos</h1>
            </div>
        </div>
            <div class="row justify-content">
                <table id="example" class="display table table-light table-hover">
                    <thead class="table-dark">
                        <tr>
                            <th scope="col">Numero</th>
                            <th scope="col">Paciente</th>
                            <th scope="col">Medico</th>
                            <th scope="col">Especialidad</th>
                            <th scope="col">Fecha</th>
                            <th scope="col">Hora</th>
                            <th scope="col">Observaciones</th>
                            <th scope="col">Estado</th>                     
                            <th></th>
                            <th></th>
                        </tr>
                   </thead>
                    <tbody>
                        <%foreach (Dominio.Turno item in lista) {
                                if ( (item.Estado == "Asignado" || item.Estado == "Reprogramado" ) && item.Fecha < DateTime.Today) item.Estado = "Vencido";
                                %>   
                                    <tr >
                                         <th><%= item.ID %> </th> 
                                         <th><%= item.Paciente.Nombre  %>  <% = item.Paciente.Apellido %></th>
                                         <th><%= item.Medico.Nombre  %>  <% = item.Medico.Apellido %></th> 
                                        <th><%= item.Especialidad.Nombre  %>  </th> 
                                        <th><%= item.Fecha.ToShortDateString() %> </th> 
                                        <th><%= item.Hora %> Hs </th> 
                                        <th> <span class="btn btn-success" onClick="verObservacion('<%=item.Observacion %>')">Observaciones</span> </th> 
                                        <%
                                            switch (item.Estado)
                                            {
                                                case "Asignado": %><th> <label style="color: green; border: 2px solid green; border-radius:5px; padding: 5px; text-align: center;" > <%= item.Estado %></label> </th>    <%
                                                break;
                                                case "Reprogramado": %><th><label style="color: rebeccapurple; border: 2px solid purple; border-radius:5px; padding: 5px; text-align: center;" > <%= item.Estado %></label> </th>    <%
                                                break;
                                                case "Cancelado": %><th> <label style="color: red; border: 2px solid red; border-radius:5px; padding: 5px; text-align: center;" > <%= item.Estado %></label> </th>    <%
                                                break;
                                                case "Atendido": %><th><label style="color: blue; border: 2px solid blue; border-radius:5px; padding: 5px; text-align: center;" > <%= item.Estado %></label> </th>    <%
                                                break;
                                                case "Vencido": %><th><label style="color: orangered; border: 2px solid orangered; border-radius:5px; padding: 5px; text-align: center;" > <%= item.Estado %></label> </th>    <%
                                                break;
                                            }

                                            %>
                                                                            
                                         <th><%
                                                     if(item.Estado != "Cancelado" && item.Estado!= "Atendido" && item.Estado!= "Vencido")
                                                     {
                                                         %>
                                                        <a href="ReprogramarTurnos.aspx?id=<%= item.ID %> "> <img style="width:30px; height:30px;" src="../img/edit.png" alt="Alternate Text" /> </a> 
                                                        <%
                                                     }
                                                   
                                                 
                                                     %>
                                           
                                         </th> 
                                          <th> 
                                              <%
                                                      if(item.Estado != "Cancelado" && item.Estado!= "Atendido" && item.Estado!= "Vencido")
                                                      {
                                                          %>
                                                          <a href="CancelarTurno.aspx?id=<%= item.ID %> "> <img style="width:30px; height:30px;" src="../img/remove.png" alt="Alternate Text" /> </a> 
                                                          <%
                                                      }
                                                    
                                                 
                                                     %>

                                          </th> 
                                    </tr>
                                 <%

                            }
                               %>
                    </tbody>   
                </table>
            </div>
             <div class="row justify-content-center mb-3">
                <div class="col-md-4 mt-2 mb-2" style="text-align:center" >
                    <a  href="NuevoTurno.aspx" class="btn btn-danger">Dar alta Turno</a>
                </div>
            </div> 
            <div class="row justify-content-center">
                 <div class="col-md-4 mb-3" style="text-align:center">
                       <a class="btn btn-secondary" href="../Info/Home.aspx"> ← Volver </a>
                 </div>
              </div>
            <div class="modal-contenedor">

        </div>
        </div>
    </div>
  
    <script src="../JavaScript/popup.js"></script> 


</asp:Content>
