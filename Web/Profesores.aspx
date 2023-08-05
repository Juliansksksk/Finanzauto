<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profesores.aspx.cs" Inherits="Finanzauto.Web.Profesores" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/css/bootstrap.min.css"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Administración de Profesores</title>
</head>
<body>
    <form id="form1" runat="server" class="container mt-5">
        <asp:HiddenField ID="hfID" runat="server" />
        <div>
            <h1 class="mb-4">Administración de Profesores</h1>

            <h2>Registro de Profesor</h2>
            <div class="mb-3">
                <label for="txtNombre" class="form-label">Nombre:</label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtApellido" class="form-label">Apellido:</label>
                <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtEspecialidad" class="form-label">Especialidad:</label>
                <asp:TextBox ID="txtEspecialidad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" CssClass="btn btn-primary" />
            <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" CssClass="btn btn-success" />
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" CssClass="btn btn-danger" />
        </div>

        <h2 class="mt-5">Lista de Profesores</h2>
        <asp:GridView ID="gvProfesores" runat="server" AutoGenerateSelectButton="true" AutoGenerateColumns="false" OnSelectedIndexChanged="gvProfesores_SelectedIndexChanged" CssClass="table">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
                <asp:BoundField DataField="Especialidad" HeaderText="Especialidad" />
            </Columns>
        </asp:GridView>

        <div class="mt-5">
            <asp:Button ID="btnIrAEstudiantes" runat="server" Text="Ir a Estudiantes" OnClick="btnIrAEstudiantes_Click" CssClass="btn btn-secondary" />
        </div>
    </form>
</body>
</html>