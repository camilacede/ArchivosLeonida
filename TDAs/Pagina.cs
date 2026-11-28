namespace ArchivosLeonida.TDAs
{
    public class Pagina
    {
        public int Numero { get; set; }
        public Image? Imagen { get; set; }
        public string Descripcion { get; set; }

        public Pagina(int numero, Image? imagen, string descripcion)
        {
            Numero = numero;
            Imagen = imagen;
            Descripcion = descripcion;
        }
    }
}