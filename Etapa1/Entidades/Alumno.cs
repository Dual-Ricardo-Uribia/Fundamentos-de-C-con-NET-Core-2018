using System;

namespace CoreEscuela.Entidades
{
    public class Alumno
    {
        public string UniqueID { get; private set; }

        public string Nombre { get; set; }
        public List<Evaluaciones> Evaluacion { get; internal set; }

        public Alumno() 
        {
            UniqueID= Guid.NewGuid().ToString();
            Evaluacion = new List<Evaluaciones>();
        } 
    }
}