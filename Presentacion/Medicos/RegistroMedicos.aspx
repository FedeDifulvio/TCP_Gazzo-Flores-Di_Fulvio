<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegistroMedicos.aspx.cs" Inherits="Presentacion.Medicos.RegistroMedicos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div class="container-fluid" style="background-color:#f3e9d2; height: 100%;">
        <div class="container">
            <div class="row justify-content-center mb-3">
            <div class="col-md-4 mt-3"  style="text-align:center">
                <h1>Registro Medicos</h1>
            </div>
        </div>
            <div class="row justify-content">
                <table id="example" class="display table table-light table-hover">
                    <thead class="table-dark">
                        <tr>
                            <th scope="col">Nombre</th>
                            <th scope="col">Apellido</th>
                            <th scope="col">Legajo</th>
                            <th scope="col">Detalle</th>
                            <th></th>
                            <th></th>
                        </tr>
                   </thead>
                    <tbody>
                        <%foreach (Dominio.Medico item in Lista) { 
                            
                                %>   
                                    <tr >
                                         <th><%= item.Nombre %> </th> 
                                         <th><%= item.Apellido %> </th>
                                         <th><%= item.Legajo %> </th> 
                                         <th><a class="btn btn-success " href="DetalleMedico.aspx?idMedico=<%=item.ID %>">Detalle</a></th>
                                         <th> <a href="ModificarMedico.aspx?id=<%=item.ID %>"> <img style="width:30px; height:30px;" src="../img/edit.png" alt="Alternate Text" /> </a> </th> 
                                          <th> <a href="EliminarMedico.aspx?id=<%=item.ID %>"> <img style="width:30px; height:30px;" src="../img/remove.png" alt="Alternate Text" /> </a> </th> 
                                    </tr>

                                       
                                
                                 <%

                            }
                               %>
                    </tbody>   
                </table>
            </div>
             <div class="row justify-content-center mb-3">
                <div class="col-md-4 mt-2 mb-4" style="text-align:center" >
                    <a  href="AltaMedico.aspx" class="btn btn-danger">Dar alta Medico</a>
                </div>
            </div> 
             <div class="row justify-content-center">
                 <div class="col-md-4 mb-3" style="text-align:center">
                       <a class="btn btn-secondary" href="../Info/Home.aspx"> ← Volver </a>
                 </div>
              </div>
        </div>
    </div>

</asp:Content>
