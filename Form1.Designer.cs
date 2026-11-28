namespace ArchivosLeonida
{
    partial class Form1
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
            pnlLineaTitulo = new Panel();
            pnlFuenteBorder = new Panel();
            grpFuente = new Panel();
            panelHoja = new Panel();
            lblTipo = new Label();
            lblArchivo = new Label();
            lblEstado = new Label();
            btnCargarArchivo = new Button();
            pnlVistaBorder = new Panel();
            txtVistaPrevia = new TextBox();
            pnlCanalesBorder = new Panel();
            grpCanales = new Panel();
            btnExtraer = new Button();
            btnRoundRobin = new Button();
            lblEstadoCanales = new Label();
            pnlC1Border = new Panel();
            pnlCanal1 = new Panel();
            lblNumero1 = new Label();
            lblNombre1 = new Label();
            lblCantidad1 = new Label();
            pnlLineC1 = new Panel();
            txtCanal1 = new TextBox();
            pnlC2Border = new Panel();
            pnlCanal2 = new Panel();
            lblNumero2 = new Label();
            lblNombre2 = new Label();
            lblCantidad2 = new Label();
            pnlLineC2 = new Panel();
            txtCanal2 = new TextBox();
            pnlC3Border = new Panel();
            pnlCanal3 = new Panel();
            lblNumero3 = new Label();
            lblNombre3 = new Label();
            lblCantidad3 = new Label();
            pnlLineC3 = new Panel();
            txtCanal3 = new TextBox();
            pnlGuardadoBorder = new Panel();
            grpGuardado = new Panel();
            lblTitGuardado = new Label();
            lblCantGuardado = new Label();
            txtGuardado = new TextBox();
            pnlEliminadosBorder = new Panel();
            grpEliminados = new Panel();
            lblTitEliminados = new Label();
            lblCantEliminados = new Label();
            txtEliminados = new TextBox();
            pnlSenalBorder = new Panel();
            lblSenal = new Label();
            btnConfirmar = new Button();
            btnEnsamblar = new Button();
            pnlTopBar.SuspendLayout();
            pnlLogoBorder.SuspendLayout();
            pnlFuenteBorder.SuspendLayout();
            grpFuente.SuspendLayout();
            panelHoja.SuspendLayout();
            pnlVistaBorder.SuspendLayout();
            pnlCanalesBorder.SuspendLayout();
            grpCanales.SuspendLayout();
            pnlC1Border.SuspendLayout();
            pnlCanal1.SuspendLayout();
            pnlC2Border.SuspendLayout();
            pnlCanal2.SuspendLayout();
            pnlC3Border.SuspendLayout();
            pnlCanal3.SuspendLayout();
            pnlGuardadoBorder.SuspendLayout();
            grpGuardado.SuspendLayout();
            pnlEliminadosBorder.SuspendLayout();
            grpEliminados.SuspendLayout();
            pnlSenalBorder.SuspendLayout();
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
            lblBrandTitle.Location = new Point(70, 15);
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
            lblNavFases.Text = "[ 01 LECTURA · 02 CANALES · 03 ROUND-ROBIN · 04 DESTRUCCIÓN ]   ·   05 ENSAMBLAJE   ·   06 CARRUSEL";
            lblNavFases.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRedSegura
            // 
            lblRedSegura.Font = new Font("Consolas", 8F, FontStyle.Bold);
            lblRedSegura.ForeColor = Color.FromArgb(0, 212, 255);
            lblRedSegura.Location = new Point(1214, 21);
            lblRedSegura.Name = "lblRedSegura";
            lblRedSegura.Size = new Size(115, 15);
            lblRedSegura.TabIndex = 4;
            lblRedSegura.Text = "● RED SEGURA";
            lblRedSegura.TextAlign = ContentAlignment.MiddleRight;
            lblRedSegura.Click += lblRedSegura_Click;
            // 
            // lblFases
            // 
            lblFases.AutoSize = true;
            lblFases.Font = new Font("Consolas", 8.5F, FontStyle.Bold);
            lblFases.ForeColor = Color.FromArgb(0, 212, 255);
            lblFases.Location = new Point(30, 64);
            lblFases.Name = "lblFases";
            lblFases.Size = new Size(328, 18);
            lblFases.TabIndex = 1;
            lblFases.Text = "CONSOLA DE INTERCEPCIÓN // FASES 01 – 04";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(28, 79);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(472, 35);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "PROCESAMIENTO DE TRANSMISIONES";
            // 
            // pnlLineaTitulo
            // 
            pnlLineaTitulo.BackColor = Color.FromArgb(30, 41, 59);
            pnlLineaTitulo.Location = new Point(30, 112);
            pnlLineaTitulo.Name = "pnlLineaTitulo";
            pnlLineaTitulo.Size = new Size(1300, 1);
            pnlLineaTitulo.TabIndex = 3;
            // 
            // pnlFuenteBorder
            // 
            pnlFuenteBorder.BackColor = Color.FromArgb(0, 212, 255);
            pnlFuenteBorder.Controls.Add(grpFuente);
            pnlFuenteBorder.Location = new Point(30, 122);
            pnlFuenteBorder.Name = "pnlFuenteBorder";
            pnlFuenteBorder.Padding = new Padding(1);
            pnlFuenteBorder.Size = new Size(1300, 130);
            pnlFuenteBorder.TabIndex = 4;
            // 
            // grpFuente
            // 
            grpFuente.BackColor = Color.FromArgb(17, 23, 36);
            grpFuente.Controls.Add(panelHoja);
            grpFuente.Controls.Add(lblArchivo);
            grpFuente.Controls.Add(lblEstado);
            grpFuente.Controls.Add(btnCargarArchivo);
            grpFuente.Controls.Add(pnlVistaBorder);
            grpFuente.Dock = DockStyle.Fill;
            grpFuente.Location = new Point(1, 1);
            grpFuente.Name = "grpFuente";
            grpFuente.Size = new Size(1298, 128);
            grpFuente.TabIndex = 0;
            // 
            // panelHoja
            // 
            panelHoja.BackColor = Color.FromArgb(12, 16, 26);
            panelHoja.BorderStyle = BorderStyle.FixedSingle;
            panelHoja.Controls.Add(lblTipo);
            panelHoja.Location = new Point(18, 16);
            panelHoja.Name = "panelHoja";
            panelHoja.Size = new Size(46, 50);
            panelHoja.TabIndex = 0;
            // 
            // lblTipo
            // 
            lblTipo.Dock = DockStyle.Fill;
            lblTipo.Font = new Font("Consolas", 9.5F, FontStyle.Bold);
            lblTipo.ForeColor = Color.FromArgb(0, 212, 255);
            lblTipo.Location = new Point(0, 0);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(44, 48);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "TXT";
            lblTipo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblArchivo
            // 
            lblArchivo.AutoSize = true;
            lblArchivo.Font = new Font("Consolas", 12.5F, FontStyle.Bold);
            lblArchivo.ForeColor = Color.White;
            lblArchivo.Location = new Point(74, 16);
            lblArchivo.Name = "lblArchivo";
            lblArchivo.Size = new Size(214, 24);
            lblArchivo.TabIndex = 1;
            lblArchivo.Text = "transmisiones.txt";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 8.5F);
            lblEstado.ForeColor = Color.FromArgb(244, 63, 94);
            lblEstado.Location = new Point(74, 38);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(140, 20);
            lblEstado.TabIndex = 2;
            lblEstado.Text = "Sin archivo cargado";
            // 
            // btnCargarArchivo
            // 
            btnCargarArchivo.BackColor = Color.FromArgb(0, 212, 255);
            btnCargarArchivo.Cursor = Cursors.Hand;
            btnCargarArchivo.FlatAppearance.BorderSize = 0;
            btnCargarArchivo.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 224, 255);
            btnCargarArchivo.FlatStyle = FlatStyle.Flat;
            btnCargarArchivo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCargarArchivo.ForeColor = Color.FromArgb(11, 15, 23);
            btnCargarArchivo.Location = new Point(18, 76);
            btnCargarArchivo.Name = "btnCargarArchivo";
            btnCargarArchivo.Size = new Size(300, 36);
            btnCargarArchivo.TabIndex = 3;
            btnCargarArchivo.Text = "CARGAR ARCHIVO";
            btnCargarArchivo.UseVisualStyleBackColor = false;
            btnCargarArchivo.Click += btnCargarArchivo_Click;
            // 
            // pnlVistaBorder
            // 
            pnlVistaBorder.BackColor = Color.FromArgb(30, 41, 59);
            pnlVistaBorder.Controls.Add(txtVistaPrevia);
            pnlVistaBorder.Location = new Point(336, 14);
            pnlVistaBorder.Name = "pnlVistaBorder";
            pnlVistaBorder.Padding = new Padding(1);
            pnlVistaBorder.Size = new Size(944, 100);
            pnlVistaBorder.TabIndex = 4;
            // 
            // txtVistaPrevia
            // 
            txtVistaPrevia.BackColor = Color.FromArgb(11, 15, 23);
            txtVistaPrevia.BorderStyle = BorderStyle.None;
            txtVistaPrevia.Dock = DockStyle.Fill;
            txtVistaPrevia.Font = new Font("Consolas", 9F);
            txtVistaPrevia.ForeColor = Color.FromArgb(203, 213, 225);
            txtVistaPrevia.Location = new Point(1, 1);
            txtVistaPrevia.Multiline = true;
            txtVistaPrevia.Name = "txtVistaPrevia";
            txtVistaPrevia.ReadOnly = true;
            txtVistaPrevia.ScrollBars = ScrollBars.Vertical;
            txtVistaPrevia.Size = new Size(942, 98);
            txtVistaPrevia.TabIndex = 0;
            // 
            // pnlCanalesBorder
            // 
            pnlCanalesBorder.BackColor = Color.FromArgb(36, 48, 72);
            pnlCanalesBorder.Controls.Add(grpCanales);
            pnlCanalesBorder.Location = new Point(30, 262);
            pnlCanalesBorder.Name = "pnlCanalesBorder";
            pnlCanalesBorder.Padding = new Padding(1);
            pnlCanalesBorder.Size = new Size(1300, 290);
            pnlCanalesBorder.TabIndex = 5;
            // 
            // grpCanales
            // 
            grpCanales.BackColor = Color.FromArgb(17, 23, 36);
            grpCanales.Controls.Add(btnExtraer);
            grpCanales.Controls.Add(btnRoundRobin);
            grpCanales.Controls.Add(lblEstadoCanales);
            grpCanales.Controls.Add(pnlC1Border);
            grpCanales.Controls.Add(pnlC2Border);
            grpCanales.Controls.Add(pnlC3Border);
            grpCanales.Dock = DockStyle.Fill;
            grpCanales.Location = new Point(1, 1);
            grpCanales.Name = "grpCanales";
            grpCanales.Size = new Size(1298, 288);
            grpCanales.TabIndex = 0;
            // 
            // btnExtraer
            // 
            btnExtraer.BackColor = Color.FromArgb(236, 72, 153);
            btnExtraer.Cursor = Cursors.Hand;
            btnExtraer.FlatAppearance.BorderSize = 0;
            btnExtraer.FlatAppearance.MouseOverBackColor = Color.FromArgb(244, 114, 182);
            btnExtraer.FlatStyle = FlatStyle.Flat;
            btnExtraer.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnExtraer.ForeColor = Color.White;
            btnExtraer.Location = new Point(18, 14);
            btnExtraer.Name = "btnExtraer";
            btnExtraer.Size = new Size(260, 36);
            btnExtraer.TabIndex = 0;
            btnExtraer.Text = "EXTRAER A CANALES";
            btnExtraer.UseVisualStyleBackColor = false;
            btnExtraer.Click += btnExtraer_Click;
            // 
            // btnRoundRobin
            // 
            btnRoundRobin.BackColor = Color.FromArgb(255, 115, 0);
            btnRoundRobin.Cursor = Cursors.Hand;
            btnRoundRobin.FlatAppearance.BorderSize = 0;
            btnRoundRobin.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 138, 36);
            btnRoundRobin.FlatStyle = FlatStyle.Flat;
            btnRoundRobin.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnRoundRobin.ForeColor = Color.White;
            btnRoundRobin.Location = new Point(1020, 14);
            btnRoundRobin.Name = "btnRoundRobin";
            btnRoundRobin.Size = new Size(260, 36);
            btnRoundRobin.TabIndex = 1;
            btnRoundRobin.Text = "SIMULAR ROUND-ROBIN";
            btnRoundRobin.UseVisualStyleBackColor = false;
            btnRoundRobin.Click += btnRoundRobin_Click;
            // 
            // lblEstadoCanales
            // 
            lblEstadoCanales.AutoSize = true;
            lblEstadoCanales.Font = new Font("Consolas", 9.5F, FontStyle.Bold);
            lblEstadoCanales.ForeColor = Color.FromArgb(255, 115, 0);
            lblEstadoCanales.Location = new Point(294, 24);
            lblEstadoCanales.Name = "lblEstadoCanales";
            lblEstadoCanales.Size = new Size(171, 19);
            lblEstadoCanales.TabIndex = 2;
            lblEstadoCanales.Text = "Canales sin llenar";
            // 
            // pnlC1Border
            // 
            pnlC1Border.BackColor = Color.FromArgb(0, 168, 204);
            pnlC1Border.Controls.Add(pnlCanal1);
            pnlC1Border.Location = new Point(18, 60);
            pnlC1Border.Name = "pnlC1Border";
            pnlC1Border.Padding = new Padding(1);
            pnlC1Border.Size = new Size(410, 212);
            pnlC1Border.TabIndex = 3;
            // 
            // pnlCanal1
            // 
            pnlCanal1.BackColor = Color.FromArgb(12, 16, 26);
            pnlCanal1.Controls.Add(lblNumero1);
            pnlCanal1.Controls.Add(lblNombre1);
            pnlCanal1.Controls.Add(lblCantidad1);
            pnlCanal1.Controls.Add(pnlLineC1);
            pnlCanal1.Controls.Add(txtCanal1);
            pnlCanal1.Dock = DockStyle.Fill;
            pnlCanal1.Location = new Point(1, 1);
            pnlCanal1.Name = "pnlCanal1";
            pnlCanal1.Size = new Size(408, 210);
            pnlCanal1.TabIndex = 0;
            // 
            // lblNumero1
            // 
            lblNumero1.AutoSize = true;
            lblNumero1.Font = new Font("Consolas", 10.5F, FontStyle.Bold);
            lblNumero1.ForeColor = Color.FromArgb(0, 212, 255);
            lblNumero1.Location = new Point(12, 10);
            lblNumero1.Name = "lblNumero1";
            lblNumero1.Size = new Size(30, 22);
            lblNumero1.TabIndex = 0;
            lblNumero1.Text = "01";
            // 
            // lblNombre1
            // 
            lblNombre1.AutoSize = true;
            lblNombre1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblNombre1.ForeColor = Color.White;
            lblNombre1.Location = new Point(42, 9);
            lblNombre1.Name = "lblNombre1";
            lblNombre1.Size = new Size(85, 21);
            lblNombre1.TabIndex = 1;
            lblNombre1.Text = "CANAL 01";
            // 
            // lblCantidad1
            // 
            lblCantidad1.Font = new Font("Consolas", 9.5F, FontStyle.Bold);
            lblCantidad1.ForeColor = Color.FromArgb(0, 212, 255);
            lblCantidad1.Location = new Point(308, 9);
            lblCantidad1.Name = "lblCantidad1";
            lblCantidad1.Size = new Size(88, 18);
            lblCantidad1.TabIndex = 2;
            lblCantidad1.Text = "0 REG.";
            lblCantidad1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlLineC1
            // 
            pnlLineC1.BackColor = Color.FromArgb(30, 41, 59);
            pnlLineC1.Location = new Point(12, 34);
            pnlLineC1.Name = "pnlLineC1";
            pnlLineC1.Size = new Size(384, 1);
            pnlLineC1.TabIndex = 4;
            // 
            // txtCanal1
            // 
            txtCanal1.BackColor = Color.FromArgb(15, 21, 33);
            txtCanal1.BorderStyle = BorderStyle.None;
            txtCanal1.Font = new Font("Consolas", 9F);
            txtCanal1.ForeColor = Color.FromArgb(226, 232, 240);
            txtCanal1.Location = new Point(12, 43);
            txtCanal1.Multiline = true;
            txtCanal1.Name = "txtCanal1";
            txtCanal1.ReadOnly = true;
            txtCanal1.ScrollBars = ScrollBars.Vertical;
            txtCanal1.Size = new Size(384, 155);
            txtCanal1.TabIndex = 3;
            txtCanal1.WordWrap = false;
            // 
            // pnlC2Border
            // 
            pnlC2Border.BackColor = Color.FromArgb(0, 168, 204);
            pnlC2Border.Controls.Add(pnlCanal2);
            pnlC2Border.Location = new Point(444, 60);
            pnlC2Border.Name = "pnlC2Border";
            pnlC2Border.Padding = new Padding(1);
            pnlC2Border.Size = new Size(410, 212);
            pnlC2Border.TabIndex = 4;
            // 
            // pnlCanal2
            // 
            pnlCanal2.BackColor = Color.FromArgb(12, 16, 26);
            pnlCanal2.Controls.Add(lblNumero2);
            pnlCanal2.Controls.Add(lblNombre2);
            pnlCanal2.Controls.Add(lblCantidad2);
            pnlCanal2.Controls.Add(pnlLineC2);
            pnlCanal2.Controls.Add(txtCanal2);
            pnlCanal2.Dock = DockStyle.Fill;
            pnlCanal2.Location = new Point(1, 1);
            pnlCanal2.Name = "pnlCanal2";
            pnlCanal2.Size = new Size(408, 210);
            pnlCanal2.TabIndex = 0;
            // 
            // lblNumero2
            // 
            lblNumero2.AutoSize = true;
            lblNumero2.Font = new Font("Consolas", 10.5F, FontStyle.Bold);
            lblNumero2.ForeColor = Color.FromArgb(0, 212, 255);
            lblNumero2.Location = new Point(12, 10);
            lblNumero2.Name = "lblNumero2";
            lblNumero2.Size = new Size(30, 22);
            lblNumero2.TabIndex = 0;
            lblNumero2.Text = "02";
            // 
            // lblNombre2
            // 
            lblNombre2.AutoSize = true;
            lblNombre2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblNombre2.ForeColor = Color.White;
            lblNombre2.Location = new Point(42, 9);
            lblNombre2.Name = "lblNombre2";
            lblNombre2.Size = new Size(85, 21);
            lblNombre2.TabIndex = 1;
            lblNombre2.Text = "CANAL 02";
            // 
            // lblCantidad2
            // 
            lblCantidad2.Font = new Font("Consolas", 9.5F, FontStyle.Bold);
            lblCantidad2.ForeColor = Color.FromArgb(0, 212, 255);
            lblCantidad2.Location = new Point(308, 9);
            lblCantidad2.Name = "lblCantidad2";
            lblCantidad2.Size = new Size(88, 18);
            lblCantidad2.TabIndex = 2;
            lblCantidad2.Text = "0 REG.";
            lblCantidad2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlLineC2
            // 
            pnlLineC2.BackColor = Color.FromArgb(30, 41, 59);
            pnlLineC2.Location = new Point(12, 34);
            pnlLineC2.Name = "pnlLineC2";
            pnlLineC2.Size = new Size(384, 1);
            pnlLineC2.TabIndex = 4;
            // 
            // txtCanal2
            // 
            txtCanal2.BackColor = Color.FromArgb(15, 21, 33);
            txtCanal2.BorderStyle = BorderStyle.None;
            txtCanal2.Font = new Font("Consolas", 9F);
            txtCanal2.ForeColor = Color.FromArgb(226, 232, 240);
            txtCanal2.Location = new Point(12, 43);
            txtCanal2.Multiline = true;
            txtCanal2.Name = "txtCanal2";
            txtCanal2.ReadOnly = true;
            txtCanal2.ScrollBars = ScrollBars.Vertical;
            txtCanal2.Size = new Size(384, 155);
            txtCanal2.TabIndex = 3;
            txtCanal2.WordWrap = false;
            // 
            // pnlC3Border
            // 
            pnlC3Border.BackColor = Color.FromArgb(0, 168, 204);
            pnlC3Border.Controls.Add(pnlCanal3);
            pnlC3Border.Location = new Point(870, 60);
            pnlC3Border.Name = "pnlC3Border";
            pnlC3Border.Padding = new Padding(1);
            pnlC3Border.Size = new Size(410, 212);
            pnlC3Border.TabIndex = 5;
            // 
            // pnlCanal3
            // 
            pnlCanal3.BackColor = Color.FromArgb(12, 16, 26);
            pnlCanal3.Controls.Add(lblNumero3);
            pnlCanal3.Controls.Add(lblNombre3);
            pnlCanal3.Controls.Add(lblCantidad3);
            pnlCanal3.Controls.Add(pnlLineC3);
            pnlCanal3.Controls.Add(txtCanal3);
            pnlCanal3.Dock = DockStyle.Fill;
            pnlCanal3.Location = new Point(1, 1);
            pnlCanal3.Name = "pnlCanal3";
            pnlCanal3.Size = new Size(408, 210);
            pnlCanal3.TabIndex = 0;
            // 
            // lblNumero3
            // 
            lblNumero3.AutoSize = true;
            lblNumero3.Font = new Font("Consolas", 10.5F, FontStyle.Bold);
            lblNumero3.ForeColor = Color.FromArgb(0, 212, 255);
            lblNumero3.Location = new Point(12, 10);
            lblNumero3.Name = "lblNumero3";
            lblNumero3.Size = new Size(30, 22);
            lblNumero3.TabIndex = 0;
            lblNumero3.Text = "03";
            // 
            // lblNombre3
            // 
            lblNombre3.AutoSize = true;
            lblNombre3.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblNombre3.ForeColor = Color.White;
            lblNombre3.Location = new Point(42, 9);
            lblNombre3.Name = "lblNombre3";
            lblNombre3.Size = new Size(85, 21);
            lblNombre3.TabIndex = 1;
            lblNombre3.Text = "CANAL 03";
            // 
            // lblCantidad3
            // 
            lblCantidad3.Font = new Font("Consolas", 9.5F, FontStyle.Bold);
            lblCantidad3.ForeColor = Color.FromArgb(0, 212, 255);
            lblCantidad3.Location = new Point(308, 9);
            lblCantidad3.Name = "lblCantidad3";
            lblCantidad3.Size = new Size(88, 18);
            lblCantidad3.TabIndex = 2;
            lblCantidad3.Text = "0 REG.";
            lblCantidad3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlLineC3
            // 
            pnlLineC3.BackColor = Color.FromArgb(30, 41, 59);
            pnlLineC3.Location = new Point(12, 34);
            pnlLineC3.Name = "pnlLineC3";
            pnlLineC3.Size = new Size(384, 1);
            pnlLineC3.TabIndex = 4;
            // 
            // txtCanal3
            // 
            txtCanal3.BackColor = Color.FromArgb(15, 21, 33);
            txtCanal3.BorderStyle = BorderStyle.None;
            txtCanal3.Font = new Font("Consolas", 9F);
            txtCanal3.ForeColor = Color.FromArgb(226, 232, 240);
            txtCanal3.Location = new Point(12, 43);
            txtCanal3.Multiline = true;
            txtCanal3.Name = "txtCanal3";
            txtCanal3.ReadOnly = true;
            txtCanal3.ScrollBars = ScrollBars.Vertical;
            txtCanal3.Size = new Size(384, 155);
            txtCanal3.TabIndex = 3;
            txtCanal3.WordWrap = false;
            // 
            // pnlGuardadoBorder
            // 
            pnlGuardadoBorder.BackColor = Color.FromArgb(0, 212, 255);
            pnlGuardadoBorder.Controls.Add(grpGuardado);
            pnlGuardadoBorder.Location = new Point(30, 562);
            pnlGuardadoBorder.Name = "pnlGuardadoBorder";
            pnlGuardadoBorder.Padding = new Padding(1);
            pnlGuardadoBorder.Size = new Size(420, 190);
            pnlGuardadoBorder.TabIndex = 6;
            // 
            // grpGuardado
            // 
            grpGuardado.BackColor = Color.FromArgb(17, 23, 36);
            grpGuardado.Controls.Add(lblTitGuardado);
            grpGuardado.Controls.Add(lblCantGuardado);
            grpGuardado.Controls.Add(txtGuardado);
            grpGuardado.Dock = DockStyle.Fill;
            grpGuardado.Location = new Point(1, 1);
            grpGuardado.Name = "grpGuardado";
            grpGuardado.Size = new Size(418, 188);
            grpGuardado.TabIndex = 0;
            // 
            // lblTitGuardado
            // 
            lblTitGuardado.AutoSize = true;
            lblTitGuardado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTitGuardado.ForeColor = Color.FromArgb(0, 212, 255);
            lblTitGuardado.Location = new Point(14, 11);
            lblTitGuardado.Name = "lblTitGuardado";
            lblTitGuardado.Size = new Size(139, 20);
            lblTitGuardado.TabIndex = 2;
            lblTitGuardado.Text = "COLA GUARDADO";
            // 
            // lblCantGuardado
            // 
            lblCantGuardado.Font = new Font("Consolas", 9.5F, FontStyle.Bold);
            lblCantGuardado.ForeColor = Color.FromArgb(0, 212, 255);
            lblCantGuardado.Location = new Point(318, 10);
            lblCantGuardado.Name = "lblCantGuardado";
            lblCantGuardado.Size = new Size(86, 18);
            lblCantGuardado.TabIndex = 0;
            lblCantGuardado.Text = "0 REG.";
            lblCantGuardado.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtGuardado
            // 
            txtGuardado.BackColor = Color.FromArgb(11, 15, 23);
            txtGuardado.BorderStyle = BorderStyle.None;
            txtGuardado.Font = new Font("Consolas", 9F);
            txtGuardado.ForeColor = Color.FromArgb(226, 232, 240);
            txtGuardado.Location = new Point(14, 36);
            txtGuardado.Multiline = true;
            txtGuardado.Name = "txtGuardado";
            txtGuardado.ReadOnly = true;
            txtGuardado.ScrollBars = ScrollBars.Vertical;
            txtGuardado.Size = new Size(390, 140);
            txtGuardado.TabIndex = 1;
            txtGuardado.WordWrap = false;
            // 
            // pnlEliminadosBorder
            // 
            pnlEliminadosBorder.BackColor = Color.FromArgb(236, 72, 153);
            pnlEliminadosBorder.Controls.Add(grpEliminados);
            pnlEliminadosBorder.Location = new Point(466, 562);
            pnlEliminadosBorder.Name = "pnlEliminadosBorder";
            pnlEliminadosBorder.Padding = new Padding(1);
            pnlEliminadosBorder.Size = new Size(420, 190);
            pnlEliminadosBorder.TabIndex = 7;
            // 
            // grpEliminados
            // 
            grpEliminados.BackColor = Color.FromArgb(17, 23, 36);
            grpEliminados.Controls.Add(lblTitEliminados);
            grpEliminados.Controls.Add(lblCantEliminados);
            grpEliminados.Controls.Add(txtEliminados);
            grpEliminados.Dock = DockStyle.Fill;
            grpEliminados.Location = new Point(1, 1);
            grpEliminados.Name = "grpEliminados";
            grpEliminados.Size = new Size(418, 188);
            grpEliminados.TabIndex = 0;
            // 
            // lblTitEliminados
            // 
            lblTitEliminados.AutoSize = true;
            lblTitEliminados.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTitEliminados.ForeColor = Color.FromArgb(244, 63, 94);
            lblTitEliminados.Location = new Point(14, 11);
            lblTitEliminados.Name = "lblTitEliminados";
            lblTitEliminados.Size = new Size(145, 20);
            lblTitEliminados.TabIndex = 2;
            lblTitEliminados.Text = "COLA ELIMINADOS";
            // 
            // lblCantEliminados
            // 
            lblCantEliminados.Font = new Font("Consolas", 9.5F, FontStyle.Bold);
            lblCantEliminados.ForeColor = Color.FromArgb(244, 63, 94);
            lblCantEliminados.Location = new Point(318, 10);
            lblCantEliminados.Name = "lblCantEliminados";
            lblCantEliminados.Size = new Size(86, 18);
            lblCantEliminados.TabIndex = 0;
            lblCantEliminados.Text = "0 REG.";
            lblCantEliminados.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtEliminados
            // 
            txtEliminados.BackColor = Color.FromArgb(11, 15, 23);
            txtEliminados.BorderStyle = BorderStyle.None;
            txtEliminados.Font = new Font("Consolas", 9F);
            txtEliminados.ForeColor = Color.FromArgb(253, 164, 175);
            txtEliminados.Location = new Point(14, 36);
            txtEliminados.Multiline = true;
            txtEliminados.Name = "txtEliminados";
            txtEliminados.ReadOnly = true;
            txtEliminados.ScrollBars = ScrollBars.Vertical;
            txtEliminados.Size = new Size(390, 140);
            txtEliminados.TabIndex = 1;
            txtEliminados.WordWrap = false;
            // 
            // pnlSenalBorder
            // 
            pnlSenalBorder.BackColor = Color.FromArgb(255, 115, 0);
            pnlSenalBorder.Controls.Add(lblSenal);
            pnlSenalBorder.Location = new Point(902, 562);
            pnlSenalBorder.Name = "pnlSenalBorder";
            pnlSenalBorder.Padding = new Padding(1);
            pnlSenalBorder.Size = new Size(428, 70);
            pnlSenalBorder.TabIndex = 8;
            // 
            // lblSenal
            // 
            lblSenal.BackColor = Color.FromArgb(26, 20, 18);
            lblSenal.Dock = DockStyle.Fill;
            lblSenal.Font = new Font("Consolas", 9.5F, FontStyle.Bold);
            lblSenal.ForeColor = Color.FromArgb(255, 158, 64);
            lblSenal.Location = new Point(1, 1);
            lblSenal.Name = "lblSenal";
            lblSenal.Size = new Size(426, 68);
            lblSenal.TabIndex = 0;
            lblSenal.Text = "SEÑAL INVERTIR\r\nSin anomalías";
            lblSenal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(225, 29, 72);
            btnConfirmar.Cursor = Cursors.Hand;
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatAppearance.MouseOverBackColor = Color.FromArgb(244, 63, 94);
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(902, 642);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(428, 50);
            btnConfirmar.TabIndex = 9;
            btnConfirmar.Text = "DESTRUIR";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnEnsamblar
            // 
            btnEnsamblar.BackColor = Color.FromArgb(0, 212, 255);
            btnEnsamblar.Cursor = Cursors.Hand;
            btnEnsamblar.FlatAppearance.BorderSize = 0;
            btnEnsamblar.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 224, 255);
            btnEnsamblar.FlatStyle = FlatStyle.Flat;
            btnEnsamblar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEnsamblar.ForeColor = Color.FromArgb(11, 15, 23);
            btnEnsamblar.Location = new Point(902, 702);
            btnEnsamblar.Name = "btnEnsamblar";
            btnEnsamblar.Size = new Size(428, 50);
            btnEnsamblar.TabIndex = 10;
            btnEnsamblar.Text = "ENSAMBLAR   ▶";
            btnEnsamblar.UseVisualStyleBackColor = false;
            btnEnsamblar.Click += btnEnsamblar_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(12, 16, 26);
            ClientSize = new Size(1360, 768);
            Controls.Add(btnEnsamblar);
            Controls.Add(btnConfirmar);
            Controls.Add(pnlSenalBorder);
            Controls.Add(pnlEliminadosBorder);
            Controls.Add(pnlGuardadoBorder);
            Controls.Add(pnlCanalesBorder);
            Controls.Add(pnlFuenteBorder);
            Controls.Add(pnlLineaTitulo);
            Controls.Add(lblTitulo);
            Controls.Add(lblFases);
            Controls.Add(pnlTopBar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Archivos Leonida - Procesamiento";
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            pnlLogoBorder.ResumeLayout(false);
            pnlFuenteBorder.ResumeLayout(false);
            grpFuente.ResumeLayout(false);
            grpFuente.PerformLayout();
            panelHoja.ResumeLayout(false);
            pnlVistaBorder.ResumeLayout(false);
            pnlVistaBorder.PerformLayout();
            pnlCanalesBorder.ResumeLayout(false);
            grpCanales.ResumeLayout(false);
            grpCanales.PerformLayout();
            pnlC1Border.ResumeLayout(false);
            pnlCanal1.ResumeLayout(false);
            pnlCanal1.PerformLayout();
            pnlC2Border.ResumeLayout(false);
            pnlCanal2.ResumeLayout(false);
            pnlCanal2.PerformLayout();
            pnlC3Border.ResumeLayout(false);
            pnlCanal3.ResumeLayout(false);
            pnlCanal3.PerformLayout();
            pnlGuardadoBorder.ResumeLayout(false);
            grpGuardado.ResumeLayout(false);
            grpGuardado.PerformLayout();
            pnlEliminadosBorder.ResumeLayout(false);
            grpEliminados.ResumeLayout(false);
            grpEliminados.PerformLayout();
            pnlSenalBorder.ResumeLayout(false);
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
        private Panel pnlLineaTitulo;
        private Panel pnlFuenteBorder;
        private Panel grpFuente;
        private Panel panelHoja;
        private Label lblTipo;
        private Label lblArchivo;
        private Label lblEstado;
        private Button btnCargarArchivo;
        private Panel pnlVistaBorder;
        private TextBox txtVistaPrevia;
        private Panel pnlCanalesBorder;
        private Panel grpCanales;
        private Button btnExtraer;
        private Button btnRoundRobin;
        private Label lblEstadoCanales;
        private Panel pnlC1Border;
        private Panel pnlCanal1;
        private Label lblNumero1;
        private Label lblNombre1;
        private Label lblCantidad1;
        private Panel pnlLineC1;
        private TextBox txtCanal1;
        private Panel pnlC2Border;
        private Panel pnlCanal2;
        private Label lblNumero2;
        private Label lblNombre2;
        private Label lblCantidad2;
        private Panel pnlLineC2;
        private TextBox txtCanal2;
        private Panel pnlC3Border;
        private Panel pnlCanal3;
        private Label lblNumero3;
        private Label lblNombre3;
        private Label lblCantidad3;
        private Panel pnlLineC3;
        private TextBox txtCanal3;
        private Panel pnlGuardadoBorder;
        private Panel grpGuardado;
        private Label lblTitGuardado;
        private Label lblCantGuardado;
        private TextBox txtGuardado;
        private Panel pnlEliminadosBorder;
        private Panel grpEliminados;
        private Label lblTitEliminados;
        private Label lblCantEliminados;
        private TextBox txtEliminados;
        private Panel pnlSenalBorder;
        private Label lblSenal;
        private Button btnConfirmar;
        private Button btnEnsamblar;
    }
}