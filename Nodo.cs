using System;

namespace Colas_Equipo_4
{
    class Nodo
    {
        private int dato;
        private Nodo siguiente;

        public int Dato { 
            get { return dato; }
            set { dato = value; }

        }

        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }

        }

    }
}
