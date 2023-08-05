using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using Finanzauto.Datos;
using Finanzauto.Negocio;
using Finanzauto.ServiceReference1;
using static Finanzauto.Web.Clases.Relaciones;

namespace Finanzauto.Web
{
    public partial class Estudiantes : Page
    {
        //private Finanzauto.ServiceReference1.IService1 servicio = new ServiceReference1.IService1(); // Usar el nombre de tu proxy generado
        private Service1Client servicio = new Service1Client();




        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarEstudiantes();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            servicio.InsertarEstudiante(txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCurso.Text);
            LimpiarCampos();
            CargarEstudiantes();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(hfID.Value);
            servicio.ActualizarEstudiante(id, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCurso.Text);
            LimpiarCampos();
            CargarEstudiantes();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(hfID.Value);
            servicio.EliminarEstudiantes(id);
            LimpiarCampos();
            CargarEstudiantes();
        }

        protected void gvEstudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvEstudiantes.SelectedRow;
            hfID.Value = row.Cells[1].Text;
            txtNombre.Text = row.Cells[2].Text;
            txtApellido.Text = row.Cells[3].Text;
            txtTelefono.Text = row.Cells[4].Text;
            txtCurso.Text = row.Cells[5].Text;
        }

        private void CargarEstudiantes()
        {
            RelacionesEstudiante[] estudiantesService = servicio.BuscarEstudiantes();
            List<Estudiante> estudiantes = new List<Estudiante>();

            foreach (RelacionesEstudiante estudianteService in estudiantesService)
            {
                Estudiante estudiante = new Estudiante
                {
                    ID = estudianteService.ID,
                    Nombre = estudianteService.Nombre,
                    Apellido = estudianteService.Apellido,
                    Telefono = estudianteService.Telefono,
                    Curso = estudianteService.Curso
                };

                estudiantes.Add(estudiante);
            }

            gvEstudiantes.DataSource = estudiantes;
            gvEstudiantes.DataBind();
        }

        private void LimpiarCampos()
        {
            hfID.Value = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtCurso.Text = "";
        }

        protected void btnIrAProfesores_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profesores.aspx");
        }
    }
}