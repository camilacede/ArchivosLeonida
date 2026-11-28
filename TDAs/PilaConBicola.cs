namespace ArchivosLeonida.TDAs
{
    public class PilaConBicola<T>
    {
        private Bicola<T> datos;

        public int Cantidad
        {
            get { return datos.Cantidad; }
        }

        public PilaConBicola()
        {
            datos = new Bicola<T>();
        }

        public void Apilar(T valor)
        {
            datos.InsertarFrente(valor);
        }

        public T Desapilar()
        {
            return datos.EliminarFrente();
        }

        public T VerTope()
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