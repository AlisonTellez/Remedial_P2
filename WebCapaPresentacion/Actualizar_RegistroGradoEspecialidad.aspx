﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Actualizar_RegistroGradoEspecialidad.aspx.cs" Inherits="WebCapaPresentacion.Actualizar_RegistroGradoEspecialidad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registro Grado/Especialidad</title>

    <!--Bootstrap.-->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet"/>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.2/dist/umd/popper.min.js""></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.min.js"></script>
    <!--Bootstrap.-->

</head>
<body>
    <form id="form1" runat="server">
        <div>

            <!--Barra de navegación.-->
            <nav class="navbar navbar-expand-lg navbar-light bg-light" style="background-color: #A5C6C3;">
                <div class="container-fluid">
                    <img src="img/logo.png" width="30" height="30" class="d-inline-block align-top" alt=""/>
                    <a class="navbar-brand" href="RegistrarProfe.aspx">Bitácora de laboratorio (UTP) 2021.</a>
                    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                        <span class="navbar-toggler-icon"></span>
                    </button>
                    <div class="collapse navbar-collapse">
                    <ul class="navbar-nav">
                        <li class="nav-item">
                            <a class="nav-link active" href="Inicio.aspx">Inicio</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link active" href="RegistroClientes.aspx">Registrar Cliente</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link active" href="MuestraClientes.aspx">Mostrar Clientes</a>
                        </li>
                    </ul>
                    </div>
                </div>
            </nav>
            <!--Barra de navegación.-->

            <!--Formulario.-->
            <div class="form-group" style="width:700px; margin-left:400px; margin-top:50px;">
                <asp:Label ID="Label1" runat="server" Text="Título:"></asp:Label>
                <asp:TextBox ID="txttitulo" runat="server" class="form-control"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" Text="Institución:"></asp:Label>
                <asp:TextBox ID="txtinstitucion" runat="server" class="form-control"></asp:TextBox>
                <asp:Label ID="Label3" runat="server" Text="País:"></asp:Label>
                <asp:TextBox ID="txtpais" runat="server" class="form-control"></asp:TextBox>
                <asp:Label ID="Label4" runat="server" Text="Extra (dato):"></asp:Label>
                <asp:TextBox ID="txtextra" runat="server" class="form-control"></asp:TextBox>
            </div>
            <br/>
            <div style="margin-left:400px;">
                <asp:Button ID="btnActualizar" runat="server" class="btn btn-primary" Text="Actualizar" OnClick="btnActualizar_Click"/>               
            </div>
            <!--Formulario.-->

        </div>
    </form>
</body>
</html>
