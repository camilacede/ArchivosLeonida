using ArchivosLeonida.TDAs;
using System.Text;

namespace ArchivosLeonida.Fases
{
    public class StoryBuilder
    {
        public Bicola<Pagina> bicolaPaginas = new Bicola<Pagina>();
        public string audioBase64 = "";

        public void Armar(ColaConBicola<Registro> colaGuardado)
        {
            Image? imagenActual = null;
            int numero = 1;

            while (!colaGuardado.EstaVacia())
            {
                Registro reg = colaGuardado.Desencolar();

                if (reg.Operacion == "AUDIO")
                {
                    audioBase64 = reg.Payload;
                }
                else if (reg.Operacion == "IMAGEN")
                {
                    byte[] bytes = Convert.FromBase64String(reg.Payload);
                    MemoryStream ms = new MemoryStream(bytes);
                    Image temporal = Image.FromStream(ms);
                    imagenActual = new Bitmap(temporal);
                    temporal.Dispose();
                    ms.Dispose();
                }
                else if (reg.Operacion == "TEXTO")
                {
                    string texto = Desencriptar(reg.Payload);
                    Pagina pagina = new Pagina(numero, imagenActual, texto);
                    bicolaPaginas.InsertarFinal(pagina);
                    numero++;
                }
            }
        }

        private string Desencriptar(string cifrado)
        {
            PilaConBicola<char> pila = new PilaConBicola<char>();
            for (int i = 0; i < cifrado.Length; i++)
            {
                pila.Apilar(cifrado[i]);
            }

            StringBuilder sb = new StringBuilder();
            while (!pila.EstaVacia())
            {
                sb.Append(pila.Desapilar());
            }
            return sb.ToString();
        }
    }
}