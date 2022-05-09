using System;

namespace CoreEscuela
{
    class Escuela
    {
        public string nombre;
        public string direccion;
        public int añoFundacion;
        public string ceo = "Freddy Vega";

        public void Timbrar()
        {
            Console.Beep(2000,3000);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var miEscuela = new Escuela();
            miEscuela.nombre = "Platzi Academy";
            miEscuela.direccion = "Cr 9 Calle 72";
            miEscuela.añoFundacion = 2012;
            Console.WriteLine("Timbrando");
            miEscuela.Timbrar();
        }
    }
}