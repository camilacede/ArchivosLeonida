using ArchivosLeonida.TDAs;

namespace ArchivosLeonida.Fases
{
    public class RoundRobinSimulator
    {
        public ColaConBicola<Registro> colaGuardado = new ColaConBicola<Registro>();
        public ColaConBicola<Registro> colaEliminados = new ColaConBicola<Registro>();
        public int inversiones = 0;

        public void Simular(ColaConBicola<Registro> canal1, ColaConBicola<Registro> canal2, ColaConBicola<Registro> canal3)
        {
            int turno = 1;
            while (!canal1.EstaVacia() || !canal2.EstaVacia() || !canal3.EstaVacia())
            {
                ColaConBicola<Registro> canalActual;
                if (turno == 1)
                {
                    canalActual = canal1;
                }
                else if (turno == 2)
                {
                    canalActual = canal2;
                }
                else
                {
                    canalActual = canal3;
                }

                if (!canalActual.EstaVacia())
                {
                    Registro reg = canalActual.Desencolar();
                    Despachar(reg);
                }

                turno++;
                if (turno == 4)
                {
                    turno = 1;
                }
            }
        }

        private void Despachar(Registro reg)
        {
            if (reg.Operacion == "DESTRUIR")
            {
                colaEliminados.Encolar(reg);
            }
            else if (reg.Operacion == "INVERTIR")
            {
                InvertirGuardado();
                inversiones++;
            }
            else
            {
                colaGuardado.Encolar(reg);
            }
        }

        private void InvertirGuardado()
        {
            PilaConBicola<Registro> pila = new PilaConBicola<Registro>();
            while (!colaGuardado.EstaVacia())
            {
                pila.Apilar(colaGuardado.Desencolar());
            }
            while (!pila.EstaVacia())
            {
                colaGuardado.Encolar(pila.Desapilar());
            }
        }
    }
}