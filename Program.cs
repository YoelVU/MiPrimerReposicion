using System;

namespace LISTAS_CIRCULARES_DOBLES
{
    class Nodo
    { 
        public int dato;
        public Nodo sgte;
    }
    class Pila
    {
        public Nodo inicio;
        public Pila() 
        {
            inicio = null; 
        }
        public Nodo getInicio() 
        { 
            return inicio;
        }
        public void Push(int valor) 
        { 
            Nodo nuevoNodo;
            nuevoNodo = new Nodo();
            nuevoNodo.dato = valor;
            nuevoNodo.sgte = inicio;
            inicio = nuevoNodo;
        }
        public int Pop()
        {
            Nodo aux = inicio;
            int valor = aux.dato;
            inicio = inicio.sgte;
            aux = null;
            return valor;
        }
        public void InsertarPosicionX(int dato, int posicion)
        {
            Pila aux = new Pila();
            int posicionActual = 1;

            while (this.inicio != null)
            {
                if (posicionActual == posicion)
                {
                    aux.Push(dato);
                }
                aux.Push(Pop());
                posicionActual++;
            }

            while (aux.inicio != null)
            {
                Push(aux.Pop());
            }
        }
        public void Listar()
        {
            while (this.inicio != null)
            {
                Console.WriteLine(Pop());
            }
        }
        public void listar2() { 
        Pila auxiliar = new Pila();

            while(this.inicio != null)
            {
            auxiliar.Push(this.Pop());
            
            }

            while(auxiliar.inicio != null)
            {
                this.Push(auxiliar.Pop());
            }

 
        }
    }
    internal class Program { static void Main(string[] args) { 
            Pila pila = new Pila();
            int n;
            int valor,posicion,ndato;

            Console.WriteLine("Cantidad de elementos : ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) { 
                Console.WriteLine("Elemento " + i + ":");
                valor = int.Parse(Console.ReadLine());
                pila.Push(valor);
            }

           
            Console.WriteLine("Ingrese posicion a cambiar");
            posicion = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nuevo dato");
            ndato = int.Parse(Console.ReadLine());
            pila.InsertarPosicionX(ndato,posicion);
            Console.WriteLine("\n\n Nueva Lista");

            pila.Listar();
        } 
    }
}

