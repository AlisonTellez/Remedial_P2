﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarProfe.aspx.cs" Inherits="WebCapaPresentacion.RegistrarProfe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registro Profesor</title>

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
                <asp:Label ID="Label1" runat="server" Text="Número de registro de empleado:"></asp:Label>
                <asp:TextBox ID="txtregisempleado" runat="server" class="form-control"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
                <asp:TextBox ID="txtnombre" runat="server" class="form-control"></asp:TextBox>
                <asp:Label ID="Label3" runat="server" Text="Apellido paterno:"></asp:Label>
                <asp:TextBox ID="txtapp" runat="server" class="form-control"></asp:TextBox>
                <asp:Label ID="Label4" runat="server" Text="Apellido materno:"></asp:Label>
                <asp:TextBox ID="txtapm" runat="server" class="form-control"></asp:TextBox>
                <asp:Label ID="Label5" runat="server" Text="Género:"></asp:Label>
                <br />
                <asp:DropDownList ID="dlgenero" runat="server">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>Masculino</asp:ListItem>
                    <asp:ListItem>Femenino</asp:ListItem>
                </asp:DropDownList>
                <br />
                <asp:Label ID="Label6" runat="server" Text="Categoría:"></asp:Label>
                <asp:TextBox ID="txtcategoria" runat="server" class="form-control"></asp:TextBox>
                <asp:Label ID="Label7" runat="server" Text="Correo electrónico:"></asp:Label>
                <asp:TextBox ID="txtcorreo" runat="server" class="form-control"></asp:TextBox>
                <asp:Label ID="Label8" runat="server" Text="Celular:"></asp:Label>
                <asp:TextBox ID="txtcelular" runat="server" class="form-control"></asp:TextBox>
                <asp:Label ID="Label9" runat="server" Text="Estado civil:"></asp:Label>
                <br />
                <asp:DropDownList ID="dlestadocivil" runat="server"></asp:DropDownList>
            </div>
            <br/>
           <center><div style="margin-left:400px;">
                <asp:Button ID="btnInsertar" runat="server" class="btn btn-primary" Text="Registrar" OnClick="Button1_Click"/>
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnActualizar" runat="server" class="btn btn-primary" Text="Actualizar" OnClick="btnActualizar_Click" />
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnEliminar" runat="server" class="btn btn-primary" Text="Eliminar" OnClick="btnEliminar_Click"/>
            </div></center> 
            <!--Formulario.-->

        </div>
    </form>
</body>
</html>
