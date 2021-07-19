<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Presentacion.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-+0n0xVW2eSR5OomGNYDnhzAbDsOXxcvSN1TPprVMTNDbiYZCxYbOOl7+AMvyTG2x" crossorigin="anonymous">

    <title></title>
</head>
<body style="background-color: #ace6f6"">
    <form id="form1" runat="server">
        <div class="container">
            <div class="row" style="margin-top: 150px;">
                 <div class="col-md-4"></div>
                 <div class="col-md-4" style="padding: 20px; border-radius: 10px; background-color: #f3e9d2;">
                <img src="../img/logotipo.png" alt="Alternate Text" />
                <h3>Usuario</h3>
                
                <asp:TextBox CssClass="form-control" runat="server" />
                <br />
                <h3>Contraseña</h3>
                <asp:TextBox ID="txtPassword" CssClass="form-control" type="password" runat="server" />
                <br />
                <br />
                 <div class="d-grid gap-2" >
                      <asp:Button ID="btnLogin" CssClass="btn btn-primary btn-lg" OnClick="btnLogin_Click" Text="Ingresar" runat="server" />
                 </div>
                
            </div>
            <div class="col-md-4"></div>
            </div>
        </div>
    </form>
</body>
</html>
