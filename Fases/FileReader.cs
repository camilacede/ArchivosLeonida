namespace ArchivosLeonida.Fases
{
    public class FileReader
    {
        public string Leer(string ruta)
        {
            return File.ReadAllText(ruta);
        }
    }
}