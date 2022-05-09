using System;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.EscribirTitulo("Bienvenidos a la Escuela 🏫");
            Printer.Beep(1500, cantidad:10);
            ImprimirCursosEscuela(engine.Escuela);


        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {

            Printer.EscribirTitulo("Cursos de la Escuela");


            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {curso.Nombre}, Id {curso.UniqueID}");
                }
            }

        }

    }
}