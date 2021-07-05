<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DetalleMedico.aspx.cs" Inherits="Presentacion.Medicos.DetalleMedico" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


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
                </div>
                <div class="col-md-4">
                    <table class="display table table-light table-hover">
                        <thead class="table-dark"  style="text-align:center">
                            <tr>
                                <td>Obra Sociales</td>
                            </tr>

                        </thead>

                        <tbody  style="text-align:center">
                            <%foreach (Dominio.ObraSocial item in ObraSocial)
                                {%>

                                <tr>

                                    <td> <%=item.Nombre %> </td>

                                </tr>


                            <%    } %>

                        </tbody>
                    </table>
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
