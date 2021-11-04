using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas_Equipo_4
{
    class Cola
    {
        private Nodo Primero = new Nodo();
        private Nodo ultimo = new Nodo();

        public Cola() {
            Primero = null;
            ultimo = null;

        }


        // primero = 23         ultimo = 12        ACtual = null      Nuevo = 12           23, 56, 29, 12

        // Cola --                           23 -> 56  -> 29 -> 12 -> null3

        public void insertarNodo() {

            
            Nodo Nuevo = new Nodo(); 

            Console.Write(" Añadir elemento en una cola: ");

            Nuevo.Dato = int.Parse(Console.ReadLine());

            Console.Write(" Leer un elemento en una cola: ");

            Nuevo.Dato = int.Parse(Console.ReadLine());

            Console.Write(" Cola con prioridad: ");

            Nuevo.Dato = int.Parse(Console.ReadLine());

            Console.Write(" Añadir con prioridad: ");

            Nuevo.Dato = int.Parse(Console.ReadLine());

            Console.Write(" Eliminar elemento de mayor prioridad: ");

            if (Primero ==null) {
                Primero = Nuevo;
                Primero.Siguiente = null;
                ultimo = Nuevo;

            }
            else 
            {
                ultimo.Siguiente = Nuevo;
                Nuevo.Siguiente = null;
                ultimo = Nuevo;
            
            }
            Console.WriteLine("\n Nodo Añadido\n");
        } 

        public void desplegarCola() {
            Nodo Actual = new Nodo();
            Actual = Primero;
            if(Primero != null) 
            {
                while (Actual != null)
                {
                    Console.WriteLine(" " + Actual.Dato);
                    Actual = Actual.Siguiente; 
                }
            }
            else
            {
                Console.WriteLine("\n la cola se encuentra vacia\n");
            }
        
        }
    }
}
