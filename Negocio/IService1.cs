using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using static Finanzauto.Web.Clases.Relaciones;


namespace Finanzauto.Negocio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void InsertarEstudiante(string nombre, string apellido, string telefono, string curso);

        [OperationContract]
        void ActualizarEstudiante(int ID, string nombre, string apellido, string telefono, string curso);

        [OperationContract]
        void EliminarEstudiantes(int ID);

        [OperationContract]
        List<Estudiante> BuscarEstudiantes();

        [OperationContract]
        void InsertarProfesor(string nombre, string apellido, string especialidad);

        [OperationContract]
        void  EliminarProfesores(int id);

        [OperationContract]
        void ActualizarProfesor(int id, string nombre, string apellido, string especialidad);

        [OperationContract]
        List<Profesor> BuscarProfesores();

    }
}
