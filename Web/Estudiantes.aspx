<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Estudiantes.aspx.cs" Inherits="Finanzauto.Web.Estudiantes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Estudiantes</title>
    <!-- Enlace al archivo CSS de Bootstrap desde un CDN -->
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/css/bootstrap.min.css">
</head>
<body>
    <form id="form1" runat="server" class="container mt-5">
        <asp:HiddenField ID="hfID" runat="server" />
        <div>
            <h1 class="mb-4">Administración de Estudiantes</h1>

            <h2>Registro de Estudiante</h2>
            <div class="mb-3">
                <label for="txtNombre" class="form-label">Nombre:</label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtApellido" class="form-label">Apellido:</label>
                <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtTelefono" class="form-label">Teléfono:</label>
                <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtCurso" class="form-label">Curso:</label>
                <asp:TextBox ID="txtCurso" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" CssClass="btn btn-primary" />
            <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" CssClass="btn btn-success" />
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" CssClass="btn btn-danger" />
        </div>

        <h2 class="mt-5">Lista de Estudiantes</h2>
        <asp:GridView ID="gvEstudiantes" runat="server" AutoGenerateSelectButton="true" AutoGenerateColumns="false" OnSelectedIndexChanged="gvEstudiantes_SelectedIndexChanged" CssClass="table">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
                <asp:BoundField DataField="Telefono" HeaderText="Teléfono" />
                <asp:BoundField DataField="Curso" HeaderText="Curso" />
            </Columns>
        </asp:GridView>

        <div class="mt-5">
            <asp:Button ID="btnIrAProfesores" runat="server" Text="Ir a Profesores" OnClick="btnIrAProfesores_Click" CssClass="btn btn-secondary" />
        </div>
    </form>
</body>
</html>