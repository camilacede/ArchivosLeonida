namespace ArchivosLeonida
{
    partial class Carrusel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlTopBar = new Panel();
            pnlTopLine = new Panel();
            pnlLogoBorder = new Panel();
            lblLogoAL = new Label();
            lblBrandTitle = new Label();
            lblNavFases = new Label();
            lblRedSegura = new Label();
            lblFases = new Label();
            lblTitulo = new Label();
            pnlBadgeBorder = new Panel();
            lblBadgeEstado = new Label();
            pnlLineaTitulo = new Panel();
            pnlMarcoBorder = new Panel();
            pnlMarco = new Panel();
            lblMetaId = new Label();
            lblMetaEstado = new Label();
            pnlLineMeta = new Panel();
            pbFoto = new PictureBox();
            pnlLineDesc = new Panel();
            lblDescripcion = new Label();
            btnAnterior = new Button();
            pnlCenterStatus = new Panel();
            lblContador = new Label();
            lblAudio = new Label();
            btnSiguiente = new Button();
            pnlTopBar.SuspendLayout();
            pnlLogoBorder.SuspendLayout();
            pnlBadgeBorder.SuspendLayout();
            pnlMarcoBorder.SuspendLayout();
            pnlMarco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            pnlCenterStatus.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = Color.FromArgb(15, 20, 32);
            pnlTopBar.Controls.Add(pnlTopLine);
            pnlTopBar.Controls.Add(pnlLogoBorder);
            pnlTopBar.Controls.Add(lblBrandTitle);
            pnlTopBar.Controls.Add(lblNavFases);
            pnlTopBar.Controls.Add(lblRedSegura);
            pnlTopBar.Location = new Point(0, 0);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(1360, 56);
            pnlTopBar.TabIndex = 0;
            // 
            // pnlTopLine
            // 
            pnlTopLine.BackColor = Color.FromArgb(0, 212, 255);
            pnlTopLine.Location = new Point(0, 55);
            pnlTopLine.Name = "pnlTopLine";
            pnlTopLine.Size = new Size(1360, 1);
            pnlTopLine.TabIndex = 6;
            // 
            // pnlLogoBorder
            // 
            pnlLogoBorder.BackColor = Color.FromArgb(0, 212, 255);
            pnlLogoBorder.Controls.Add(lblLogoAL);
            pnlLogoBorder.Location = new Point(30, 11);
            pnlLogoBorder.Name = "pnlLogoBorder";
            pnlLogoBorder.Padding = new Padding(1);
            pnlLogoBorder.Size = new Size(34, 34);
            pnlLogoBorder.TabIndex = 0;
            // 
            // lblLogoAL
            // 
            lblLogoAL.BackColor = Color.FromArgb(15, 20, 32);
            lblLogoAL.Dock = DockStyle.Fill;
            lblLogoAL.Font = new Font("Consolas", 10F, FontStyle.Bold);
            lblLogoAL.ForeColor = Color.FromArgb(0, 212, 255);
            lblLogoAL.Location = new Point(1, 1);
            lblLogoAL.Name = "lblLogoAL";
            lblLogoAL.Size = new Size(32, 32);
            lblLogoAL.TabIndex = 0;
            lblLogoAL.Text = "AL";
            lblLogoAL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBrandTitle
            // 
            lblBrandTitle.AutoSize = true;
            lblBrandTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBrandTitle.ForeColor = Color.White;
            lblBrandTitle.Location = new Point(75, 16);
            lblBrandTitle.Name = "lblBrandTitle";
            lblBrandTitle.Size = new Size(175, 23);
            lblBrandTitle.TabIndex = 1;
            lblBrandTitle.Text = "ARCHIVOS LEONIDA";
            // 
            // lblNavFases
            // 
            lblNavFases.Font = new Font("Consolas", 8F, FontStyle.Bold);
            lblNavFases.ForeColor = Color.FromArgb(0, 212, 255);
            lblNavFases.Location = new Point(275, 11);
            lblNavFases.Name = "lblNavFases";
            lblNavFases.Size = new Size(915, 34);
            lblNavFases.TabIndex = 3;
            lblNavFases.Text = "01 LECTURA   ·   02 CANALES   ·   03 ROUND-ROBIN   ·   04 DESTRUCCIÓN   ·   05 ENSAMBLAJE   ·   [ 06 CARRUSEL ]";
            lblNavFases.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRedSegura
            // 
            lblRedSegura.Font = new Font("Consolas", 8F, FontStyle.Bold);
            lblRedSegura.ForeColor = Color.FromArgb(0, 212, 255);
            lblRedSegura.Location = new Point(1215, 22);
            lblRedSegura.Name = "lblRedSegura";
            lblRedSegura.Size = new Size(115, 15);
            lblRedSegura.TabIndex = 4;
            lblRedSegura.Text = "● RED SEGURA";
            lblRedSegura.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFases
            // 
            lblFases.AutoSize = true;
            lblFases.Font = new Font("Consolas", 8.5F, FontStyle.Bold);
            lblFases.ForeColor = Color.FromArgb(0, 212, 255);
            lblFases.Location = new Point(30, 64);
            lblFases.Name = "lblFases";
            lblFases.Size = new Size(280, 18);
            lblFases.TabIndex = 1;
            lblFases.Text = "FASE 06 // RECONSTRUCCIÓN COMPLETA";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(28, 79);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(276, 35);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "EXPEDIENTE LEONIDA";
            // 
            // pnlBadgeBorder
            // 
            pnlBadgeBorder.BackColor = Color.FromArgb(236, 72, 153);
            pnlBadgeBorder.Controls.Add(lblBadgeEstado);
            pnlBadgeBorder.Location = new Point(1150, 68);
            pnlBadgeBorder.Name = "pnlBadgeBorder";
            pnlBadgeBorder.Padding = new Padding(1);
            pnlBadgeBorder.Size = new Size(180, 34);
            pnlBadgeBorder.TabIndex = 3;
            // 
            // lblBadgeEstado
            // 
            lblBadgeEstado.BackColor = Color.FromArgb(28, 16, 30);
            lblBadgeEstado.Dock = DockStyle.Fill;
            lblBadgeEstado.Font = new Font("Consolas", 9F, FontStyle.Bold);
            lblBadgeEstado.ForeColor = Color.FromArgb(244, 63, 94);
            lblBadgeEstado.Location = new Point(1, 1);
            lblBadgeEstado.Name = "lblBadgeEstado";
            lblBadgeEstado.Size = new Size(178, 32);
            lblBadgeEstado.TabIndex = 0;
            lblBadgeEstado.Text = "DESCLASIFICADO";
            lblBadgeEstado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlLineaTitulo
            // 
            pnlLineaTitulo.BackColor = Color.FromArgb(30, 41, 59);
            pnlLineaTitulo.Location = new Point(30, 112);
            pnlLineaTitulo.Name = "pnlLineaTitulo";
            pnlLineaTitulo.Size = new Size(1300, 1);
            pnlLineaTitulo.TabIndex = 4;
            // 
            // pnlMarcoBorder
            // 
            pnlMarcoBorder.BackColor = Color.FromArgb(0, 212, 255);
            pnlMarcoBorder.Controls.Add(pnlMarco);
            pnlMarcoBorder.Location = new Point(30, 122);
            pnlMarcoBorder.Name = "pnlMarcoBorder";
            pnlMarcoBorder.Padding = new Padding(1);
            pnlMarcoBorder.Size = new Size(1300, 560);
            pnlMarcoBorder.TabIndex = 5;
            // 
            // pnlMarco
            // 
            pnlMarco.BackColor = Color.FromArgb(17, 23, 36);
            pnlMarco.Controls.Add(lblMetaId);
            pnlMarco.Controls.Add(lblMetaEstado);
            pnlMarco.Controls.Add(pnlLineMeta);
            pnlMarco.Controls.Add(pbFoto);
            pnlMarco.Controls.Add(pnlLineDesc);
            pnlMarco.Controls.Add(lblDescripcion);
            pnlMarco.Dock = DockStyle.Fill;
            pnlMarco.Location = new Point(1, 1);
            pnlMarco.Name = "pnlMarco";
            pnlMarco.Size = new Size(1298, 558);
            pnlMarco.TabIndex = 0;
            // 
            // lblMetaId
            // 
            lblMetaId.AutoSize = true;
            lblMetaId.Font = new Font("Consolas", 8.5F, FontStyle.Bold);
            lblMetaId.ForeColor = Color.FromArgb(0, 212, 255);
            lblMetaId.Location = new Point(18, 12);
            lblMetaId.Name = "lblMetaId";
            lblMetaId.Size = new Size(216, 18);
            lblMetaId.TabIndex = 0;
            lblMetaId.Text = "ID DE EXPEDIENTE // 305-06";
            // 
            // lblMetaEstado
            // 
            lblMetaEstado.Font = new Font("Consolas", 8.5F, FontStyle.Bold);
            lblMetaEstado.ForeColor = Color.FromArgb(255, 115, 0);
            lblMetaEstado.Location = new Point(1020, 12);
            lblMetaEstado.Name = "lblMetaEstado";
            lblMetaEstado.Size = new Size(260, 14);
            lblMetaEstado.TabIndex = 2;
            lblMetaEstado.Text = "ESTADO: ARCHIVO RECUPERADO";
            lblMetaEstado.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlLineMeta
            // 
            pnlLineMeta.BackColor = Color.FromArgb(30, 41, 59);
            pnlLineMeta.Location = new Point(16, 36);
            pnlLineMeta.Name = "pnlLineMeta";
            pnlLineMeta.Size = new Size(1266, 1);
            pnlLineMeta.TabIndex = 3;
            // 
            // pbFoto
            // 
            pbFoto.BackColor = Color.FromArgb(11, 15, 23);
            pbFoto.Location = new Point(16, 46);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(1266, 366);
            pbFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbFoto.TabIndex = 4;
            pbFoto.TabStop = false;
            // 
            // pnlLineDesc
            // 
            pnlLineDesc.BackColor = Color.FromArgb(30, 41, 59);
            pnlLineDesc.Location = new Point(16, 421);
            pnlLineDesc.Name = "pnlLineDesc";
            pnlLineDesc.Size = new Size(1266, 1);
            pnlLineDesc.TabIndex = 5;
            // 
            // lblDescripcion
            // 
            lblDescripcion.BackColor = Color.FromArgb(11, 15, 23);
            lblDescripcion.Font = new Font("Consolas", 11F);
            lblDescripcion.ForeColor = Color.FromArgb(226, 232, 240);
            lblDescripcion.Location = new Point(16, 430);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Padding = new Padding(14, 10, 14, 10);
            lblDescripcion.Size = new Size(1266, 114);
            lblDescripcion.TabIndex = 6;
            lblDescripcion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAnterior
            // 
            btnAnterior.BackColor = Color.FromArgb(17, 23, 36);
            btnAnterior.Cursor = Cursors.Hand;
            btnAnterior.FlatAppearance.BorderColor = Color.FromArgb(0, 212, 255);
            btnAnterior.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 36, 56);
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAnterior.ForeColor = Color.FromArgb(0, 212, 255);
            btnAnterior.Location = new Point(30, 696);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(220, 48);
            btnAnterior.TabIndex = 6;
            btnAnterior.Text = "◀   ANTERIOR";
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // pnlCenterStatus
            // 
            pnlCenterStatus.BackColor = Color.FromArgb(17, 23, 36);
            pnlCenterStatus.Controls.Add(lblContador);
            pnlCenterStatus.Controls.Add(lblAudio);
            pnlCenterStatus.Location = new Point(270, 696);
            pnlCenterStatus.Name = "pnlCenterStatus";
            pnlCenterStatus.Size = new Size(820, 48);
            pnlCenterStatus.TabIndex = 7;
            // 
            // lblContador
            // 
            lblContador.Font = new Font("Consolas", 11F, FontStyle.Bold);
            lblContador.ForeColor = Color.White;
            lblContador.Location = new Point(10, 4);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(800, 22);
            lblContador.TabIndex = 0;
            lblContador.Text = "DIAPOSITIVA 00 / 00";
            lblContador.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAudio
            // 
            lblAudio.Font = new Font("Consolas", 9F, FontStyle.Bold);
            lblAudio.ForeColor = Color.FromArgb(236, 72, 153);
            lblAudio.Location = new Point(10, 26);
            lblAudio.Name = "lblAudio";
            lblAudio.Size = new Size(800, 18);
            lblAudio.TabIndex = 1;
            lblAudio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.FromArgb(255, 115, 0);
            btnSiguiente.Cursor = Cursors.Hand;
            btnSiguiente.FlatAppearance.BorderSize = 0;
            btnSiguiente.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 138, 36);
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSiguiente.ForeColor = Color.White;
            btnSiguiente.Location = new Point(1110, 696);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(220, 48);
            btnSiguiente.TabIndex = 8;
            btnSiguiente.Text = "SIGUIENTE   ▶";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // Carrusel
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(12, 16, 26);
            ClientSize = new Size(1360, 768);
            Controls.Add(btnSiguiente);
            Controls.Add(pnlCenterStatus);
            Controls.Add(btnAnterior);
            Controls.Add(pnlMarcoBorder);
            Controls.Add(pnlLineaTitulo);
            Controls.Add(pnlBadgeBorder);
            Controls.Add(lblTitulo);
            Controls.Add(lblFases);
            Controls.Add(pnlTopBar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Carrusel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Archivos Leonida - Carrusel";
            FormClosing += Carrusel_FormClosing;
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            pnlLogoBorder.ResumeLayout(false);
            pnlBadgeBorder.ResumeLayout(false);
            pnlMarcoBorder.ResumeLayout(false);
            pnlMarco.ResumeLayout(false);
            pnlMarco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            pnlCenterStatus.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTopBar;
        private Panel pnlTopLine;
        private Panel pnlLogoBorder;
        private Label lblLogoAL;
        private Label lblBrandTitle;
        private Label lblNavFases;
        private Label lblRedSegura;
        private Label lblFases;
        private Label lblTitulo;
        private Panel pnlBadgeBorder;
        private Label lblBadgeEstado;
        private Panel pnlLineaTitulo;
        private Panel pnlMarcoBorder;
        private Panel pnlMarco;
        private Label lblMetaId;
        private Label lblMetaEstado;
        private Panel pnlLineMeta;
        private PictureBox pbFoto;
        private Panel pnlLineDesc;
        private Label lblDescripcion;
        private Button btnAnterior;
        private Panel pnlCenterStatus;
        private Label lblContador;
        private Label lblAudio;
        private Button btnSiguiente;
    }
}