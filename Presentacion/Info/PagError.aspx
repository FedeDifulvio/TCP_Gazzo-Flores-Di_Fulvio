<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="PagError.aspx.cs" Inherits="Presentacion.PagError" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" style="background-color:#f3e9d2; height:80vh; display: flex;justify-content: center;align-items: center;">
         <div class="row">
                <div class="alert alert-danger">
                    <%=error %>
                </div>
             <div class="row justify-content-center">
                 <div class="col-md-4 mb-3" style="text-align:center">
                       <a class="btn btn-secondary" href="../Info/Home.aspx"> ← Volver </a>
                 </div>
              </div>
            </div>
     </div>
</asp:Content>
