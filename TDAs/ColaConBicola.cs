namespace ArchivosLeonida.TDAs
{
    public class ColaConBicola<T>
    {
        private Bicola<T> datos;

        public int Cantidad
        {
            get { return datos.Cantidad; }
        }

        public ColaConBicola()
        {
            datos = new Bicola<T>();
        }

        public void Encolar(T valor)
        {
            datos.InsertarFinal(valor);
        }

        public T Desencolar()
        {
            return datos.EliminarFrente();
        }

        public T VerFrente()
        {
            return datos.VerFrente();
        }

        public bool EstaVacia()
        {
            return datos.EstaVacia();
        }

        public string Recorrer()
        {
            return datos.Recorrer();
        }
    }
}