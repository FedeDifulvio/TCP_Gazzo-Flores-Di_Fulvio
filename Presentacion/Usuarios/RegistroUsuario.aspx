<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegistroUsuario.aspx.cs" Inherits="Presentacion.Usuarios.RegistroUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid" style="background-color:#f3e9d2; height: 100%;">
        <div class="container">
            <div class="row justify-content-center mb-3">
            <div class="col-md-4 mt-3"  style="text-align:center">
                <h1>Registro Usuarios</h1>
            </div>
        </div>
            <div class="row justify-content">
                <table id="example" class="display table table-light table-hover">
                    <thead class="table-dark">
                        <tr>
                            <th scope="col">ID</th>
                            <th scope="col">Usuario </th>
                            <th scope="col">Contraseña</th>
                            <th scope="col">Tipo</th>
                            <th scope="col">Token</th>
                            
                            <th></th>
                        </tr>
                   </thead>
                    <tbody>
                        <%foreach (Dominio.Usuario item in Lista) {
                                if (item.TipoUsuario.Id != 3)
                                {
                                    item.Token = "--";
                                }   
                                %>   
                                    <tr >
                                         <th><%= item.Id %> </th> 
                                         <th><%= item.User %> </th>
                                         <th><%= item.Pass %> </th> 
                                         <th><%= item.TipoUsuario.Nombre %> </th>
                                         <th><%= item.Token %> </th> 
                               
                                       
                                        <th> <span  onClick="crearModal(<%=item.Id %>, '../Usuarios/RegistroUsuario.aspx')" ><img class="openModalEliminar" style="width:30px; height:30px;" src="../img/remove.png" alt="Alternate Text" /></span> </th> 


                                         
                                    </tr>

                                       
                                
                                 <%

                            }
                               %>
                    </tbody>   
                </table>
            </div>
             <div class="row justify-content-center mb-3">
                <div class="col-md-4 mt-2 mb-4" style="text-align:center" >
                    <a  href="../Usuarios/AltaUsuario.aspx" class="btn btn-danger">Dar alta Usuario</a>
                </div>
            </div> 
             <div class="row justify-content-center">
                 <div class="col-md-4 mb-3" style="text-align:center">
                       <a class="btn btn-secondary" href="../Info/Home.aspx"> ← Volver </a>
                 </div>
              </div>
        </div>
        <div class="modal-contenedor"> </div>
    </div>
     <script src="../JavaScript/popup.js"></script> 

</asp:Content>
