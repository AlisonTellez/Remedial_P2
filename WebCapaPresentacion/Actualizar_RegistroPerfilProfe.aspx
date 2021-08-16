<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Actualizar_RegistroPerfilProfe.aspx.cs" Inherits="WebCapaPresentacion.Actualizar_RegistroPerfilProfe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registro PerfilProfesor</title>

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
            <nav class="navbar navbar-expand-lg navbar-light bg-light" style="background-color: #A5C6C3; top: 0px; left: 0px; height: 45px;">
            <div class="container-fluid">
            <img src="img/logo.png" width="50" height="50" class="d-inline-block align-top" alt="" style="margin-left:20px"/>
            <a class="navbar-brand" style="margin-left:20px">Bitácora de laboratorio (UTP) 2021.</a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
            </button>
            </div>
            </nav>
            <!--Barra de navegación.-->

            <!--Formulario.-->
            <div class="form-group" style="width:700px; margin-left:400px; margin-top:50px;">
                <asp:Label ID="Label1" runat="server" Text="Profesor:"></asp:Label>
                <br />
                <asp:DropDownList ID="dlprofesor" runat="server"></asp:DropDownList>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Grado/Especialidad:"></asp:Label>
                <br />
                <asp:DropDownList ID="dlgrado" runat="server"></asp:DropDownList>
                <br />
                <asp:Label ID="Label3" runat="server" Text="Estado:"></asp:Label>
                <asp:TextBox ID="txtestado" runat="server" class="form-control"></asp:TextBox>
                <asp:Label ID="Label4" runat="server" Text="Fecha de obtención:"></asp:Label>
                <br />
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                <asp:Label ID="Label5" runat="server" Text="Evidencia:"></asp:Label>
                <asp:TextBox ID="txtevidencia" runat="server" class="form-control"></asp:TextBox>
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
