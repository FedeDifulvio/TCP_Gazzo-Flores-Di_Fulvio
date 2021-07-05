<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ObrasSociales.aspx.cs" Inherits="Presentacion.ObrasSociales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" style="background-color:#f3e9d2; height: 100%;">
        <div class="container">
            <div class="row justify-content-center mb-3">
            <div class="col-md-4 mt-3"  style="text-align:center">
                <h1>Obras Sociales</h1>
            </div>
        </div>
            <div class="row">
                <div class="col-md-6" style="padding:0px 70px">
                    <asp:Label ID="LabelAlta" runat="server" CssClass="labels" Text="Alta de Obra Social"></asp:Label>
                    <br />
                    <asp:Label ID="labelMod" CssClass="labels" Text="Modificar Obra Social " runat="server" />
                    <asp:TextBox ID="TextBoxNombre" CssClass="form-control mb-3" MaxLength="30" ClientIdMode="Static" PlaceHolder="Obra Social" runat="server" />
                    <div>
                        <h1 class="error-form" id="TextBoxNombre-inv"></h1>
                    </div>
                    <asp:Button ID="BtnAgregar" CssClass="btn btn-primary" onClick="BtnAgregar_Click" OnClientClick="return ValidarNombre()"  Text="Agregar" runat="server" />
                    <asp:Button ID="BtnModificar" CssClass="btn btn-primary" OnClientClick="return ValidarNombre()" Text="Modificar" OnClick="BtnModificar_Click" runat="server" />
                    <asp:Button ID="cancelarMod" Text="Cancelar"  CssClass="btn btn-danger" OnClick="cancelarMod_Click" runat="server" />
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
                        <%foreach (Dominio.ObraSocial item in ListaObrasSociales) { 
                            
                                %>   
                                    <tr >
                                         <th><%= item.Nombre %> </th>                                   
                                         <th>  <a href="../ObrasSociales.aspx?id=<%=item.ID %>&action=mod"> <img style="width:30px; height:30px;" src="../img/edit.png" alt="Alternate Text" /></a></th> 
                                          <th> <span  onClick="crearModal(<%=item.ID %>, '../ObrasSociales.aspx')" ><img class="openModalEliminar" style="width:30px; height:30px;" src="../img/remove.png" alt="Alternate Text" /></span> </th> 
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
        <script src="../JavaScript/popup.js"></script> 
    </div>

</asp:Content>
