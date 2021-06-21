<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegistrosPaciente.aspx.cs" Inherits="Presentacion.RegistrosPaciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container-fluid" style="background-color:#f3e9d2; height: 80vh;">
        <div class="container">
            <div class="row justify-content-center mb-3">
            <div class="col-md-4 mt-3">
                <h1>Registro Pacientes</h1>
            </div>
        </div>
            <div class="row justify-content">
                <table id="example" class="display table table-light table-hover">
                    <thead class="table-dark">
                        <tr>
                            <th scope="col">Nombre</th>
                            <th scope="col">Apellido</th>
                            <th scope="col">DNI</th>
                            <th scope="col">Dirección</th>
                            <th scope="col">Fecha de Nacimiento</th>
                            <th scope="col">Telefono</th>
                            <th scope="col">Mail</th>
                        </tr>
                   </thead>
                    <tbody>
                        <%foreach (Dominio.Paciente item in Lista) { 
                            
                                %>   
                                    <tr >
                                         <th><%= item.Nombre %> </th> 
                                         <th><%= item.Apellido %> </th>
                                         <th><%= item.DNI %> </th> 
                                        <th><%= item.Direccion %> </th> 
                                        <th><%= item.FechaNacimiento.ToShortDateString() %> </th> 
                                        <th><%= item.Telefono %> </th> 
                                        <th><%= item.Mail %> </th> 
                                    </tr>
                                 <%

                            }
                               %>
                    </tbody>   
                </table>
            </div>
             <div class="row justify-content-center mb-3">
                <div class="col-md-4 mt-2 mb-4" style="margin-left:185px">
                    <a  href="AltaPaciente.aspx" class="btn btn-danger">Dar alta paciente</a>
                </div>
            </div> 
        </div>
    </div>
  
</asp:Content>
