using ArchivosLeonida.TDAs;
using System.Text;

namespace ArchivosLeonida.Fases
{
    public class Destroyer
    {
        public string Destruir(ColaConBicola<Registro> colaEliminados)
        {
            StringBuilder reporte = new StringBuilder();
            reporte.AppendLine("REPORTE DE DESTRUCCION");
            int cantidad = 0;

            while (!colaEliminados.EstaVacia())
            {
                Registro reg = colaEliminados.Desencolar();
                cantidad++;
                reporte.AppendLine(cantidad + ". " + reg.ToString());
            }

            reporte.AppendLine("Total destruidos: " + cantidad);
            return reporte.ToString();
        }
    }
}