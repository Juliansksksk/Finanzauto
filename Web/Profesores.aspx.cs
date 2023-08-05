using Finanzauto.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static Finanzauto.Web.Clases.Relaciones;


namespace Finanzauto.Web
{
    public partial class Profesores : System.Web.UI.Page
    {
        private Service1Client servicio = new Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarProfesores();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            servicio.InsertarProfesor(txtNombre.Text, txtApellido.Text, txtEspecialidad.Text);
            LimpiarCampos();
            CargarProfesores();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(hfID.Value);
            servicio.ActualizarProfesor(id, txtNombre.Text, txtApellido.Text, txtEspecialidad.Text);


            LimpiarCampos();
                CargarProfesores();
            
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(hfID.Value);
            servicio.EliminarProfesores(id);
            LimpiarCampos();
            CargarProfesores();
        }

        protected void gvProfesores_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvProfesores.SelectedRow;
            hfID.Value = row.Cells[1].Text;
            txtNombre.Text = row.Cells[2].Text;
            txtApellido.Text = row.Cells[3].Text;
            txtEspecialidad.Text = row.Cells[4].Text;
        }

        private void CargarProfesores()
        {
            RelacionesProfesor[] profesoresService = servicio.BuscarProfesores();
            List<Profesor> profesores = new List<Profesor>();

            foreach (RelacionesProfesor profesorService in profesoresService)
            {
                Profesor profesor = new Profesor
                {
                    ID = profesorService.ID,
                    Nombre = profesorService.Nombre,
                    Apellido = profesorService.Apellido,
                    Especialidad = profesorService.Especialidad
                };

                profesores.Add(profesor);
            }

            gvProfesores.DataSource = profesores;
            gvProfesores.DataBind();
        }

        private void LimpiarCampos()
        {
            hfID.Value = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEspecialidad.Text = "";
        }

        protected void btnIrAEstudiantes_Click(object sender, EventArgs e)
        {
            Response.Redirect("Estudiantes.aspx");
        }
    }
}