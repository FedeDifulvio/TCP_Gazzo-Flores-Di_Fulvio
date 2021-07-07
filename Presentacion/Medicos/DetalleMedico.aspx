<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DetalleMedico.aspx.cs" Inherits="Presentacion.Medicos.DetalleMedico" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" AutoPostBack="false" runat="server">


    <div class="container-fluid " style="background-color: #f3e9d2; height: 100vh;">
        <div class="container">
            <div class="row justify-content-center mb-3">
                <div class="col-md-4 mt-4" style="text-align:center">
                    <h1>Detalle Médico</h1>
                </div>
            </div>

            <br />
            <div class="row">
                <div class="col-md-4" style="text-align:center">
                    <asp:Label Text="Nombre" runat="server" CssClass="labels" />
                    <hr />
                </div>
                <div class="col-md-4" style="text-align:center">
                    <asp:Label Text="Apellido" runat="server"  CssClass="labels"  />
                    <hr />
                </div>
                <div class="col-md-4" style="text-align:center">
                    <asp:Label Text="Legajo" runat="server"  CssClass="labels" />
                    <hr />
                </div>
            </div>
            <div class="row">
                <div class="col-md-4">
                    <asp:TextBox ID="TextBoxNombre" CssClass="form-control mb-3" Enabled="false" ClientIDMode="Static" runat="server" />
                </div>
                <div class="col-md-4">
                    <asp:TextBox ID="TextBoxApellido" CssClass="form-control mb-3" Enabled="false" ClientIDMode="Static"  runat="server" />
                </div>
                <div class="col-md-4">
                    <asp:TextBox ID="TextBoxLegajo" CssClass="form-control mb-3" Enabled="false" ClientIDMode="Static" runat="server" />
                </div>
            </div>
            <br />
            <br />
            <br />
         

            <div class="row">
                <div class="col-md-4">
                    <table class="display table table-light table-hover">
                        <thead class="table-dark" >
                            <tr>
                                <td>Día</td>
                                <td>Entrada</td>
                                <td>Salida</td>
                            </tr>

                        </thead>

                        <tbody >
                        
                          

                            <%foreach (Dominio.DiaHorarioTrabajo item in DiaHorario )
                                {%>

                                <tr>

                                    <td> <% =item.Dia %> </td>
                                    <td>  <%=item.HoraInicio %> Hs </td>
                                    <td>  <% =item.HoraFin %> Hs </td>

                                </tr>


                            <%    } %>

                        </tbody>
                    </table>
                    <div style="text-align:center">
                        <asp:Button ID="btnAgregarDia" CssClass="btn btn-primary" Text="+" runat="server" />
                    </div>
                    
                </div>
                <div class="col-md-4">
                    <table class="display table table-light table-hover">
                        <thead class="table-dark" style="text-align:center">
                            <tr>
                                <td>Especialidades</td>
                            </tr>

                        </thead>

                        <tbody  style="text-align:center">
                               <%foreach (Dominio.Especialidad item in Especialidades )
                                {%>

                                <tr>

                                    <td> <%=item.Nombre %> </td>

                                </tr>


                            <%    } %>

                        </tbody>
                    </table>
                    <div style="text-align:center">
                        <asp:Button ID="btnAgregarEspe" CssClass="btn btn-primary" Text="+" runat="server" />
                    </div>
                    
                </div>
                <div class="col-md-4 ">
                    <table class="display table table-light table-hover">
                        <thead class="table-dark"  style="text-align:center">
                            <tr >
                                <td colspan="2">Obra Sociales</td> 
                                
                            </tr>
                           
                        </thead>

                        <tbody  >
                            <%foreach (Dominio.ObraSocialDeMedico item in ObraSocial)
                                {%>

                                <tr>

                                    <td style="text-align:center"> <%=item.obraSocial.Nombre %>  </td>
                                    <td><a href="DetalleMedico.aspx?idMedico=<% =item.idMedico %>&idObra=<% =item.id %>&table=obra" class="btn btn-danger">-</a></td>

                                </tr>
                                 
                                
                  
                            <%   } %>
                       
                        </tbody>

                    </table>
                    <div style="text-align:center">
                        <asp:Button ID="btnVerMas" CssClass="btn btn-primary" OnClick="btnAgregarObra_Click" Text="+"  runat="server" />
                    </div>
                    <div style="text-align:center">
                        <asp:DropDownList ID="ddlObraSocial" runat="server"></asp:DropDownList>
                        <asp:Button ID="btnAltaObra" Text="Agregar" OnClick="btnAltaObra_Click" CssClass="btn btn-primary" runat="server" />
                        <asp:Button id="btnCancelarObra" Text="Cancelar" OnClick="btnCancelarObra_Click" CssClass="btn btn-danger" runat="server" />
                    </div>
                    
                </div>
            </div>
            <div class="row justify-content-center">
                 <div class="col-md-4 mt-3 mb-3" style="text-align:center">
                       <a class="btn btn-secondary" href="RegistroMedicos.aspx"> ← Volver </a>
                 </div>
              </div>

        </div>
    </div>




</asp:Content>
