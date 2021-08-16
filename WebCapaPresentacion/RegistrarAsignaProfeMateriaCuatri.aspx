<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarAsignaProfeMateriaCuatri.aspx.cs" Inherits="WebCapaPresentacion.AsignaProfeMateriaCuatri" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registro APMC</title>

    <!--Bootstrap.-->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet"/>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.2/dist/umd/popper.min.js""></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.min.js"></script>
    <!--Bootstrap.-->
    <link href="CSS/sweetalert2.min.css" rel="stylesheet" />
    <script src="JS/JavaScript.js"></script>
    <script src="JS/sweetalert2.all.min.js"></script>

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
                <asp:Label ID="Label2" runat="server" Text="Materia:"></asp:Label>
                <br />
                <asp:DropDownList ID="dlmateria" runat="server"></asp:DropDownList>
                <br />
                 <asp:Label ID="Label3" runat="server" Text="Grupo/Cuatrimestre:"></asp:Label>
                <br />
                <asp:DropDownList ID="dlgrupocuatri" runat="server"></asp:DropDownList>
                <br />
                <asp:Label ID="Label4" runat="server" Text="Extra:"></asp:Label>
                <asp:TextBox ID="txtextra" runat="server" class="form-control"></asp:TextBox>
            </div>
            <br/>
            <div style="margin-left:400px;">
                <asp:Button ID="btnInsertar" runat="server" class="btn btn-primary" Text="Registrar" OnClick="Button1_Click"/>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnActualizar" runat="server" class="btn btn-primary" Text="Actualizar" OnClick="btnActualizar_Click"/>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnEliminar" runat="server" class="btn btn-primary" Text="Eliminar" OnClick="btnEliminar_Click"/>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnSig" runat="server" class="btn btn-primary" Text="-->" OnClick="btnSig_Click"/>  
            </div>
            <!--Formulario.-->

        </div>
    </form>
</body>
</html>
