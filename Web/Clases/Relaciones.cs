using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Finanzauto.Web.Clases
{
    public class Relaciones
    {

        public class Estudiante
        {
            public int ID { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Telefono { get; set; }
            public string Curso { get; set; }
        }


        public class Profesor
        {
            public int ID { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Especialidad { get; set; }
        }


        public class Curso
        {
            public int ID { get; set; }
            public string NombreCurso { get; set; }
        }

        public class Calificacion
        {
            public int ID { get; set; }
            public string Notas { get; set; }
        }



    }
}