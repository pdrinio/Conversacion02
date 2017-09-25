using System;

namespace Conversacion01
{
    class Program
    {
        static void Main(string[] args)
        {
            Presencia MiPresencia = new Presencia();
            Lenguaje MiLenguaje = new Lenguaje();
            Conversacion MiConversacion = new Conversacion();

            MiConversacion.NodoInicial = MiLenguaje.NodosLenguaje.IndexOf(0);

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}