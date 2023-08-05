using Finanzauto.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using static Finanzauto.Web.Clases.Relaciones;

namespace Finanzauto.Negocio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        private ConexionSql ConexionSql;

        public Service1()
        {
            ConexionSql = new ConexionSql();
        }

        public void InsertarEstudiante(string nombre, string apellido, string telefono, string curso)
        {
            using (SqlConnection connection = ConexionSql.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("InsertarEstudiantes", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Apellido", apellido);
                command.Parameters.AddWithValue("@Telefono", telefono);
                command.Parameters.AddWithValue("@Curso", curso);

                command.ExecuteNonQuery();
            }
        }

        public List<Estudiante> BuscarEstudiantes()
        {
            List<Estudiante> estudiantes = new List<Estudiante>();

            using (SqlConnection connection = ConexionSql.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("BuscarEstudiante", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Estudiante estudiante = new Estudiante();
                    estudiante.ID = (int)reader["ID"];
                    estudiante.Nombre = reader["Nombre"].ToString();
                    estudiante.Apellido = reader["Apellido"].ToString();
                    estudiante.Telefono = reader["Telefono"].ToString();
                    estudiante.Curso = reader["Curso"].ToString();

                    estudiantes.Add(estudiante);
                }

                reader.Close();
            }

            return estudiantes;
        }

        public void InsertarProfesor(string nombre, string apellido, string especialidad)
        {
            using (SqlConnection connection = ConexionSql.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("InsertarProfesores", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Apellido", apellido);
                command.Parameters.AddWithValue("@Especialidad", especialidad);

                command.ExecuteNonQuery();
            }
        }


        public void EliminarProfesores(int id)
        {
            using (SqlConnection connection = ConexionSql.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("EliminarProfesores", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", id);

                command.ExecuteNonQuery();
            }
        }

        public void ActualizarProfesor(int id, string nombre, string apellido, string especialidad)
        {
            using (SqlConnection connection = ConexionSql.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("ActualizarProfesores", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@Especialidad", especialidad);

                    
                    command.ExecuteNonQuery();
                }
            }
        }


        public void ActualizarEstudiante(int id, string nombre, string apellido, string telefono, string curso)
        {
            using (SqlConnection connection = ConexionSql.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("ActualizarEstudiantes", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Apellido", apellido);
                command.Parameters.AddWithValue("@Telefono", telefono);
                command.Parameters.AddWithValue("@Curso", curso);

                command.ExecuteNonQuery();
            }
        }

        public void EliminarEstudiantes(int id)
        {
            using (SqlConnection connection = ConexionSql.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("EliminarEstudiantes", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", id);

                command.ExecuteNonQuery();
            }
        }

        public List<Profesor> BuscarProfesores()
        {
            List<Profesor> profesores = new List<Profesor>();

            using (SqlConnection connection = ConexionSql.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("BuscarProfesor", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Profesor profesor = new Profesor();
                    profesor.ID = (int)reader["ID"];
                    profesor.Nombre = reader["Nombre"].ToString();
                    profesor.Apellido = reader["Apellido"].ToString();
                    profesor.Especialidad = reader["Especialidad"].ToString();

                    profesores.Add(profesor);
                }

                reader.Close();
            }

            return profesores;
        }
    }
}
