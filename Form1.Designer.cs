namespace ListaDeReproduccion_G2_2023_II
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstbReproduccion = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCancion = new System.Windows.Forms.Label();
            this.lbArtista = new System.Windows.Forms.Label();
            this.lbAlbum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reproducciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reproducirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.aleatoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automáticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siguienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anteriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbInicio = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ptbPortada = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // lstbReproduccion
            // 
            this.lstbReproduccion.FormattingEnabled = true;
            this.lstbReproduccion.ItemHeight = 20;
            this.lstbReproduccion.Items.AddRange(new object[] {
            "Bodies",
            "Cuando calienta el Sol",
            "Reavenhead"});
            this.lstbReproduccion.Location = new System.Drawing.Point(63, 146);
            this.lstbReproduccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstbReproduccion.Name = "lstbReproduccion";
            this.lstbReproduccion.Size = new System.Drawing.Size(282, 324);
            this.lstbReproduccion.TabIndex = 0;
            this.lstbReproduccion.SelectedIndexChanged += new System.EventHandler(this.lstbReproduccion_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(468, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Canción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(468, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Artista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(468, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Álbum";
            // 
            // lbCancion
            // 
            this.lbCancion.AutoSize = true;
            this.lbCancion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbCancion.Location = new System.Drawing.Point(584, 146);
            this.lbCancion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCancion.Name = "lbCancion";
            this.lbCancion.Size = new System.Drawing.Size(58, 20);
            this.lbCancion.TabIndex = 1;
            this.lbCancion.Text = "Bodies";
            // 
            // lbArtista
            // 
            this.lbArtista.AutoSize = true;
            this.lbArtista.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbArtista.Location = new System.Drawing.Point(585, 191);
            this.lbArtista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbArtista.Name = "lbArtista";
            this.lbArtista.Size = new System.Drawing.Size(111, 20);
            this.lbArtista.TabIndex = 1;
            this.lbArtista.Text = "Drowning Pool";
            // 
            // lbAlbum
            // 
            this.lbAlbum.AutoSize = true;
            this.lbAlbum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAlbum.Location = new System.Drawing.Point(584, 245);
            this.lbAlbum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAlbum.Name = "lbAlbum";
            this.lbAlbum.Size = new System.Drawing.Size(55, 20);
            this.lbAlbum.TabIndex = 1;
            this.lbAlbum.Text = "Sinner";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(58, 106);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Lista de Reproducción";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reproducciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1201, 35);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem,
            this.agregarToolStripMenuItem,
            this.toolStripMenuItem2,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.cargarToolStripMenuItem.Text = "Cargar";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(237, 6);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.guardarComoToolStripMenuItem.Text = "Guardar como...";
            // 
            // reproducciónToolStripMenuItem
            // 
            this.reproducciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reproducirToolStripMenuItem,
            this.detenerToolStripMenuItem,
            this.pausarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.aleatoriaToolStripMenuItem,
            this.automáticaToolStripMenuItem,
            this.siguienteToolStripMenuItem,
            this.anteriorToolStripMenuItem});
            this.reproducciónToolStripMenuItem.Name = "reproducciónToolStripMenuItem";
            this.reproducciónToolStripMenuItem.Size = new System.Drawing.Size(137, 29);
            this.reproducciónToolStripMenuItem.Text = "Reproducción";
            // 
            // reproducirToolStripMenuItem
            // 
            this.reproducirToolStripMenuItem.Image = global::ListaDeReproduccion_G2_2023_II.Properties.Resources.btn_play;
            this.reproducirToolStripMenuItem.Name = "reproducirToolStripMenuItem";
            this.reproducirToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.reproducirToolStripMenuItem.Text = "Reproducir";
            this.reproducirToolStripMenuItem.Click += new System.EventHandler(this.reproducirToolStripMenuItem_Click);
            // 
            // detenerToolStripMenuItem
            // 
            this.detenerToolStripMenuItem.Image = global::ListaDeReproduccion_G2_2023_II.Properties.Resources.boton_detener;
            this.detenerToolStripMenuItem.Name = "detenerToolStripMenuItem";
            this.detenerToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.detenerToolStripMenuItem.Text = "Detener";
            this.detenerToolStripMenuItem.Click += new System.EventHandler(this.detenerToolStripMenuItem_Click);
            // 
            // pausarToolStripMenuItem
            // 
            this.pausarToolStripMenuItem.Image = global::ListaDeReproduccion_G2_2023_II.Properties.Resources.pausa;
            this.pausarToolStripMenuItem.Name = "pausarToolStripMenuItem";
            this.pausarToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.pausarToolStripMenuItem.Text = "Pausar";
            this.pausarToolStripMenuItem.Click += new System.EventHandler(this.pausarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(199, 6);
            // 
            // aleatoriaToolStripMenuItem
            // 
            this.aleatoriaToolStripMenuItem.Name = "aleatoriaToolStripMenuItem";
            this.aleatoriaToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.aleatoriaToolStripMenuItem.Text = "aleatoria";
            // 
            // automáticaToolStripMenuItem
            // 
            this.automáticaToolStripMenuItem.Name = "automáticaToolStripMenuItem";
            this.automáticaToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.automáticaToolStripMenuItem.Text = "automática";
            // 
            // siguienteToolStripMenuItem
            // 
            this.siguienteToolStripMenuItem.Name = "siguienteToolStripMenuItem";
            this.siguienteToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.siguienteToolStripMenuItem.Text = "siguiente";
            // 
            // anteriorToolStripMenuItem
            // 
            this.anteriorToolStripMenuItem.Name = "anteriorToolStripMenuItem";
            this.anteriorToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.anteriorToolStripMenuItem.Text = "anterior";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(552, 345);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(440, 15);
            this.progressBar1.TabIndex = 3;
            // 
            // lbInicio
            // 
            this.lbInicio.AutoSize = true;
            this.lbInicio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbInicio.Location = new System.Drawing.Point(468, 342);
            this.lbInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInicio.Name = "lbInicio";
            this.lbInicio.Size = new System.Drawing.Size(34, 20);
            this.lbInicio.TabIndex = 1;
            this.lbInicio.Text = "0[s]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(1038, 342);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "5 [s]";
            // 
            // ptbPortada
            // 
            this.ptbPortada.Image = global::ListaDeReproduccion_G2_2023_II.Properties.Resources.luismiguel;
            this.ptbPortada.Location = new System.Drawing.Point(764, 143);
            this.ptbPortada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ptbPortada.Name = "ptbPortada";
            this.ptbPortada.Size = new System.Drawing.Size(195, 180);
            this.ptbPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPortada.TabIndex = 4;
            this.ptbPortada.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1201, 514);
            this.Controls.Add(this.ptbPortada);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbInicio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbAlbum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbArtista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCancion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstbReproduccion);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Reproductor de Musica";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPortada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbReproduccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCancion;
        private System.Windows.Forms.Label lbArtista;
        private System.Windows.Forms.Label lbAlbum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reproducciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reproducirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detenerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pausarToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbInicio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox ptbPortada;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aleatoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automáticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siguienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anteriorToolStripMenuItem;
    }
}

