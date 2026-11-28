using ArchivosLeonida.TDAs;
using System.Text;

namespace ArchivosLeonida.Fases
{
    public class ChannelEnqueuer
    {
        public ColaConBicola<Registro> canal1 = new ColaConBicola<Registro>();
        public ColaConBicola<Registro> canal2 = new ColaConBicola<Registro>();
        public ColaConBicola<Registro> canal3 = new ColaConBicola<Registro>();

        public void Separar(string contenido)
        {
            StringReader lineas = new StringReader(contenido);
            string? linea = lineas.ReadLine();
            while (linea != null)
            {
                ProcesarLinea(linea);
                linea = lineas.ReadLine();
            }
        }

        private void ProcesarLinea(string linea)
        {
            PilaConBicola<char> pila = new PilaConBicola<char>();
            StringBuilder acumulado = new StringBuilder();
            int id = 0;
            int canal = 0;
            string operacion = "";
            string payload = "";

            for (int i = 0; i < linea.Length; i++)
            {
                char c = linea[i];

                if (pila.EstaVacia())
                {
                    if (c == '(' || c == '[' || c == '<' || c == '{')
                    {
                        pila.Apilar(c);
                        acumulado.Clear();
                    }
                }
                else if (c == Cierre(pila.VerTope()))
                {
                    char abre = pila.Desapilar();
                    string campo = acumulado.ToString();
                    if (abre == '(')
                    {
                        id = int.Parse(campo);
                    }
                    else if (abre == '[')
                    {
                        canal = int.Parse(campo);
                    }
                    else if (abre == '<')
                    {
                        operacion = campo;
                    }
                    else
                    {
                        payload = campo;
                    }
                }
                else
                {
                    acumulado.Append(c);
                }
            }

            if (canal < 1 || canal > 3)
            {
                return;
            }

            Registro reg = new Registro(id, canal, operacion, payload);
            if (canal == 1)
            {
                canal1.Encolar(reg);
            }
            else if (canal == 2)
            {
                canal2.Encolar(reg);
            }
            else
            {
                canal3.Encolar(reg);
            }
        }

        private char Cierre(char abre)
        {
            if (abre == '(')
            {
                return ')';
            }
            if (abre == '[')
            {
                return ']';
            }
            if (abre == '<')
            {
                return '>';
            }
            return '}';
        }
    }
}