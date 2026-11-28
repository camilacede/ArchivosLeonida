namespace ArchivosLeonida
{
    public partial class Portada : Form
    {
        public Portada()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            principal.FormClosed += principal_FormClosed;
            principal.Show();
            Hide();
        }

        private void principal_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}