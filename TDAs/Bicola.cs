using System.Text;

namespace ArchivosLeonida.TDAs
{
    public class Bicola<T>
    {
        private Nodo<T>? frente;
        private Nodo<T>? final;
        public int Cantidad { get; private set; }

        public Bicola()
        {
            frente = null;
            final = null;
            Cantidad = 0;
        }

        public bool EstaVacia()
        {
            return Cantidad == 0;
        }

        public void InsertarFrente(T valor)
        {
            Nodo<T> nuevo = new Nodo<T>(valor);
            if (frente == null)
            {
                frente = nuevo;
                final = nuevo;
            }
            else
            {
                nuevo.Siguiente = frente;
                frente.Anterior = nuevo;
                frente = nuevo;
            }
            Cantidad++;
        }

        public void InsertarFinal(T valor)
        {
            Nodo<T> nuevo = new Nodo<T>(valor);
            if (final == null)
            {
                frente = nuevo;
                final = nuevo;
            }
            else
            {
                nuevo.Anterior = final;
                final.Siguiente = nuevo;
                final = nuevo;
            }
            Cantidad++;
        }

        public T EliminarFrente()
        {
            if (frente == null)
            {
                throw new InvalidOperationException("La bicola esta vacia");
            }
            T dato = frente.Dato;
            frente = frente.Siguiente;
            if (frente == null)
            {
                final = null;
            }
            else
            {
                frente.Anterior = null;
            }
            Cantidad--;
            return dato;
        }

        public T EliminarFinal()
        {
            if (final == null)
            {
                throw new InvalidOperationException("La bicola esta vacia");
            }
            T dato = final.Dato;
            final = final.Anterior;
            if (final == null)
            {
                frente = null;
            }
            else
            {
                final.Siguiente = null;
            }
            Cantidad--;
            return dato;
        }

        public T VerFrente()
        {
            if (frente == null)
            {
                throw new InvalidOperationException("La bicola esta vacia");
            }
            return frente.Dato;
        }

        public T VerFinal()
        {
            if (final == null)
            {
                throw new InvalidOperationException("La bicola esta vacia");
            }
            return final.Dato;
        }

        public string Recorrer()
        {
            StringBuilder sb = new StringBuilder();
            Nodo<T>? actual = frente;
            while (actual != null)
            {
                sb.AppendLine(actual.Dato?.ToString());
                actual = actual.Siguiente;
            }
            return sb.ToString();
        }

        public string RecorrerInverso()
        {
            StringBuilder sb = new StringBuilder();
            Nodo<T>? actual = final;
            while (actual != null)
            {
                sb.AppendLine(actual.Dato?.ToString());
                actual = actual.Anterior;
            }
            return sb.ToString();
        }
    }
}