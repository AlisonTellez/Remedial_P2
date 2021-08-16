﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mostrar_PerfilProfesor.aspx.cs" Inherits="WebCapaPresentacion.Mostrar_PerfilProfesor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Perfil profesional</title>

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
                <asp:Label ID="Label1" runat="server" Text="Selecciona profesor:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="dlselecprofesor" runat="server"></asp:DropDownList>
                <br />
                <center><asp:Button ID="btnmostprofesor" runat="server" class="btn btn-primary" Text="Mostrar" OnClick="btnmostprofesor_Click"/></center>
                <br />
                <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
            <!--Formulario.-->

        </div>
    </form>
</body>
</html>
