<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Presentacion.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container-fluid home">
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-md-4" style="justify-content: center; display: flex">
                    <asp:Button Text="Pedir turno" CssClass="btn btn-primary btnHome" runat="server" />
                </div>
            </div>
        </div>

</asp:Content>
