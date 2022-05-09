using static System.Console;

namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void dibujarLinea(int tam = 10)
        {
            WriteLine("".PadLeft(tam, '='));
        }

        public static void EscribirTitulo(string titulo)
        {
            var tamaño = titulo.Length + 4;
            dibujarLinea(tamaño);
            WriteLine($"| {titulo} |");
            dibujarLinea(tamaño);
        }
         public static void Beep(int hz = 2000, int tiempo=500, int cantidad =1)
        {
            while (cantidad-- > 0)
            {
                System.Console.Beep(hz, tiempo);
            }
        }
    }
}