using ArchivosLeonida.Fases;
using System.Text;

namespace ArchivosLeonida
{
    public partial class Form1 : Form
    {
        private string contenido = "";
        private ChannelEnqueuer extractor = new ChannelEnqueuer();
        private RoundRobinSimulator simulador = new RoundRobinSimulator();
        private StoryBuilder historia = new StoryBuilder();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            string ruta = Path.Combine(AppContext.BaseDirectory, "transmisiones.txt");
            if (!File.Exists(ruta))
            {
                MessageBox.Show("No se encontro transmisiones.txt");
                return;
            }

            FileReader lector = new FileReader();
            contenido = lector.Leer(ruta);

            StringBuilder sb = new StringBuilder();
            StringReader lineas = new StringReader(contenido);
            string? linea = lineas.ReadLine();
            int numero = 0;
            while (linea != null)
            {
                numero++;
                string corta = linea;
                if (corta.Length > 60)
                {
                    corta = corta.Substring(0, 60) + "...";
                }
                sb.AppendLine(numero + " | largo " + linea.Length + " | " + corta);
                linea = lineas.ReadLine();
            }
            txtVistaPrevia.Text = sb.ToString();

            lblEstado.Text = "Cargado: " + numero + " lineas" + "\n" + contenido.Length + " caracteres";
            lblEstado.ForeColor = Color.FromArgb(0, 212, 255);
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            if (contenido == "")
            {
                MessageBox.Show("Primero carga el archivo (Fase 1)");
                return;
            }

            extractor = new ChannelEnqueuer();
            extractor.Separar(contenido);

            txtCanal1.Text = extractor.canal1.Recorrer();
            txtCanal2.Text = extractor.canal2.Recorrer();
            txtCanal3.Text = extractor.canal3.Recorrer();

            lblCantidad1.Text = extractor.canal1.Cantidad + " REG.";
            lblCantidad2.Text = extractor.canal2.Cantidad + " REG.";
            lblCantidad3.Text = extractor.canal3.Cantidad + " REG.";

            int total = extractor.canal1.Cantidad + extractor.canal2.Cantidad + extractor.canal3.Cantidad;
            lblEstadoCanales.Text = "Total: " + total + " registros";
            lblEstadoCanales.ForeColor = Color.FromArgb(0, 212, 255);
        }

        private void btnRoundRobin_Click(object sender, EventArgs e)
        {
            if (extractor.canal1.Cantidad + extractor.canal2.Cantidad + extractor.canal3.Cantidad == 0)
            {
                MessageBox.Show("Primero extrae a canales (Fase 2)");
                return;
            }

            simulador = new RoundRobinSimulator();
            simulador.Simular(extractor.canal1, extractor.canal2, extractor.canal3);

            txtCanal1.Text = extractor.canal1.Recorrer();
            txtCanal2.Text = extractor.canal2.Recorrer();
            txtCanal3.Text = extractor.canal3.Recorrer();
            lblCantidad1.Text = extractor.canal1.Cantidad + " REG.";
            lblCantidad2.Text = extractor.canal2.Cantidad + " REG.";
            lblCantidad3.Text = extractor.canal3.Cantidad + " REG.";

            txtGuardado.Text = simulador.colaGuardado.Recorrer();
            txtEliminados.Text = simulador.colaEliminados.Recorrer();
            lblCantGuardado.Text = simulador.colaGuardado.Cantidad + " REG.";
            lblCantEliminados.Text = simulador.colaEliminados.Cantidad + " REG.";

            lblSenal.Text = "SEÑAL INVERTIR\r\n" + simulador.inversiones + " inversiones";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (simulador.colaEliminados.EstaVacia())
            {
                MessageBox.Show("No hay registros para destruir");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "Se destruiran " + simulador.colaEliminados.Cantidad + " senuelos. Continuar?",
                "Confirmar destruccion",
                MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.No)
            {
                return;
            }

            Destroyer destructor = new Destroyer();
            string reporte = destructor.Destruir(simulador.colaEliminados);

            txtEliminados.Text = reporte;
            lblCantEliminados.Text = simulador.colaEliminados.Cantidad + " REG.";
        }

        private void btnEnsamblar_Click(object sender, EventArgs e)
        {
            if (simulador.colaGuardado.EstaVacia())
            {
                MessageBox.Show("No hay registros guardados. Haz primero la Fase 3.");
                return;
            }

            historia = new StoryBuilder();
            historia.Armar(simulador.colaGuardado);

            txtGuardado.Text = "";
            lblCantGuardado.Text = simulador.colaGuardado.Cantidad + " REG.";

            if (historia.bicolaPaginas.EstaVacia())
            {
                MessageBox.Show("No se armo ninguna pagina");
                return;
            }

            Carrusel carrusel = new Carrusel(historia.bicolaPaginas, historia.audioBase64);
            carrusel.ShowDialog();
        }

        private void lblRedSegura_Click(object sender, EventArgs e)
        {

        }
    }
}