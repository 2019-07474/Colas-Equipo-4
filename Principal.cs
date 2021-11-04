using System;

namespace Colas_Equipo_4
{
    class Principal
    {
        static void Main(String[] args)
        {
            Cola c = new Cola();
            c.insertarNodo();
            c.insertarNodo();
            c.insertarNodo();
            c.insertarNodo();
            c.insertarNodo();
            Console.WriteLine("\n cola Ingresada\n ");
            c.desplegarCola();
            Console.ReadLine();

        }
    }
}
