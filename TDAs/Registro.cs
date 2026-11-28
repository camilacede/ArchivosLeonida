namespace ArchivosLeonida.TDAs
{
    public class Registro
    {
        public int Id { get; set; }
        public int Canal { get; set; }
        public string Operacion { get; set; }
        public string Payload { get; set; }

        public Registro(int id, int canal, string operacion, string payload)
        {
            Id = id;
            Canal = canal;
            Operacion = operacion;
            Payload = payload;
        }

        public override string ToString()
        {
            string vista = Payload;
            if (vista.Length > 40)
            {
                vista = vista.Substring(0, 40) + "...";
            }
            return "(" + Id + ") [" + Canal + "] <" + Operacion + "> {" + vista + "} len=" + Payload.Length;
        }
    }
}