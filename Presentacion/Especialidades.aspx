<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Especialidades.aspx.cs" Inherits="Presentacion.Especialidades" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid" style="background-color:#f3e9d2; height: 100%;">
        <div class="container">
            <div class="row justify-content-center mb-3">
            <div class="col-md-4 mt-3"  style="text-align:center">
                <h1>Especialidades</h1>
            </div>
        </div>
            <div class="row">
                <div class="col-md-6" style="padding:0px 70px">
                    <asp:Label ID="labelAlta" CssClass="labels" Text="Alta Especialidad" runat="server" />
                    <br />
                    <asp:Label ID="labelModificar"  CssClass="labels"  Text="Modificar Especialidad" runat="server" />
                    <asp:TextBox id="TextBoxNombre" CssClass="form-control mb-3" MaxLength="30" ClientIdMode="Static" PlaceHolder="Especialidad" runat="server" />
                    <div>
                        <h1 class="error-form" id="TextBoxNombre-inv"></h1>
                    </div>
                    <asp:Button ID="BtnAgregar" CssClass="btn btn-primary" OnClick="BtnAgregar_Click" OnClientClick="return ValidarNombre()"  Text="Agregar" runat="server" />
                    <asp:Button ID="BtnModificar"  CssClass="btn btn-primary" Text="Modificar" OnClientClick="return ValidarNombre()" OnClick="BtnModificar_Click" runat="server" />
                    <asp:Button ID="BtnCancelar" Text="Cancelar" CssClass="btn btn-danger" OnClick="BtnCancelar_Click" runat="server" />
                </div>
                <div class="col-md-6 mb-3">
                    <table id="example" class="display table table-light table-hover">
                    <thead class="table-dark">
                        <tr>
                            <th scope="col">Nombre</th>                        
                            <th></th>
                            <th></th>
                        </tr>
                   </thead>
                    <tbody>
                        <%foreach (Dominio.Especialidad item in ListaEspecialidades) { 
                            
                                %>   
                                    <tr >
                                         <th><%= item.Nombre %> </th>                                   
                                         <th>  <a href="../Especialidades.aspx?id=<%=item.ID %>&action=mod"> <img style="width:30px; height:30px;" src="../img/edit.png" alt="Alternate Text" /></a> </th> 
                                          <th> <span  onClick="crearModal(<%=item.ID %>,'../Especialidades.aspx')" ><img class="openModalEliminar" style="width:30px; height:30px;" src="../img/remove.png" alt="Alternate Text" /></span> </th> 
                                    </tr>
                                 <%

                          }
                               %>
                    </tbody>   
                </table>

                </div>
                
            </div> 
        </div> 

        <div class="modal-contenedor">

        </div>

        <script src="../JavaScript/FuncionesValidaciones.js"></script>
        <script src="../JavaScript/Validaciones_ObraSocial_Especialidades.js"></script>
         <script src="../JavaScript/popup.js"></script> v
    </div>













</asp:Content>
