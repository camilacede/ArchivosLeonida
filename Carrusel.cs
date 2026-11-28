using ArchivosLeonida.Fases;
using ArchivosLeonida.TDAs;

namespace ArchivosLeonida
{
    public partial class Carrusel : Form
    {
        private Bicola<Pagina> paginas;
        private AudioPlayer audio = new AudioPlayer();

        public Carrusel(Bicola<Pagina> paginas, string audioBase64)
        {
            InitializeComponent();
            this.paginas = paginas;

            if (audioBase64 != "")
            {
                audio.Reproducir(audioBase64);
                lblAudio.Text = "AUDIO EN PARALELO: ACTIVO";
            }
            else
            {
                lblAudio.Text = "SIN PISTA DE AUDIO";
                lblAudio.ForeColor = Color.FromArgb(178, 34, 34);
            }

            Mostrar();
        }

        private void Mostrar()
        {
            if (paginas.EstaVacia())
            {
                lblDescripcion.Text = "No hay paginas";
                return;
            }

            Pagina actual = paginas.VerFrente();
            pbFoto.Image = actual.Imagen;
            lblDescripcion.Text = actual.Descripcion;
            lblContador.Text = "DIAPOSITIVA " + actual.Numero.ToString("00") + " / " + paginas.Cantidad.ToString("00");
        }

        private void Siguiente()
        {
            Pagina p = paginas.EliminarFrente();
            paginas.InsertarFinal(p);
            Mostrar();
        }

        private void Anterior()
        {
            Pagina p = paginas.EliminarFinal();
            paginas.InsertarFrente(p);
            Mostrar();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Siguiente();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Anterior();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Right)
            {
                Siguiente();
                return true;
            }
            if (keyData == Keys.Left)
            {
                Anterior();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Carrusel_FormClosing(object? sender, FormClosingEventArgs e)
        {
            audio.Detener();
        }
    }
}