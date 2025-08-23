namespace GerenciadorDeOVNI {
    partial class TelaInicial {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.lblMaxTrip = new System.Windows.Forms.Label();
            this.lblMaxAbd = new System.Windows.Forms.Label();
            this.lblPlanet = new System.Windows.Forms.Label();
            this.txbMaxTrip = new System.Windows.Forms.TextBox();
            this.txbMaxAbd = new System.Windows.Forms.TextBox();
            this.cmbPlanet = new System.Windows.Forms.ComboBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pibIcone = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pibIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaxTrip
            // 
            this.lblMaxTrip.AutoSize = true;
            this.lblMaxTrip.Location = new System.Drawing.Point(263, 101);
            this.lblMaxTrip.Name = "lblMaxTrip";
            this.lblMaxTrip.Size = new System.Drawing.Size(98, 13);
            this.lblMaxTrip.TabIndex = 0;
            this.lblMaxTrip.Text = "MáximoTripulantes:";
            // 
            // lblMaxAbd
            // 
            this.lblMaxAbd.AutoSize = true;
            this.lblMaxAbd.Location = new System.Drawing.Point(263, 144);
            this.lblMaxAbd.Name = "lblMaxAbd";
            this.lblMaxAbd.Size = new System.Drawing.Size(95, 13);
            this.lblMaxAbd.TabIndex = 1;
            this.lblMaxAbd.Text = "MáximoAbduzidos:";
            // 
            // lblPlanet
            // 
            this.lblPlanet.AutoSize = true;
            this.lblPlanet.Location = new System.Drawing.Point(268, 193);
            this.lblPlanet.Name = "lblPlanet";
            this.lblPlanet.Size = new System.Drawing.Size(93, 13);
            this.lblPlanet.TabIndex = 2;
            this.lblPlanet.Text = "PlanetaDeOrigem:";
            // 
            // txbMaxTrip
            // 
            this.txbMaxTrip.Location = new System.Drawing.Point(367, 98);
            this.txbMaxTrip.Name = "txbMaxTrip";
            this.txbMaxTrip.Size = new System.Drawing.Size(118, 20);
            this.txbMaxTrip.TabIndex = 3;
            // 
            // txbMaxAbd
            // 
            this.txbMaxAbd.Location = new System.Drawing.Point(367, 144);
            this.txbMaxAbd.Name = "txbMaxAbd";
            this.txbMaxAbd.Size = new System.Drawing.Size(118, 20);
            this.txbMaxAbd.TabIndex = 4;
            // 
            // cmbPlanet
            // 
            this.cmbPlanet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanet.FormattingEnabled = true;
            this.cmbPlanet.Location = new System.Drawing.Point(364, 190);
            this.cmbPlanet.Name = "cmbPlanet";
            this.cmbPlanet.Size = new System.Drawing.Size(121, 21);
            this.cmbPlanet.TabIndex = 5;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(229, 248);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(322, 82);
            this.btnIniciar.TabIndex = 6;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(310, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(147, 37);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Iniciador";
            // 
            // pibIcone
            // 
            this.pibIcone.Image = global::GerenciadorDeOVNI.Properties.Resources.imagemIcon;
            this.pibIcone.InitialImage = null;
            this.pibIcone.Location = new System.Drawing.Point(-2, -1);
            this.pibIcone.Name = "pibIcone";
            this.pibIcone.Size = new System.Drawing.Size(185, 180);
            this.pibIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibIcone.TabIndex = 8;
            this.pibIcone.TabStop = false;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pibIcone);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.cmbPlanet);
            this.Controls.Add(this.txbMaxAbd);
            this.Controls.Add(this.txbMaxTrip);
            this.Controls.Add(this.lblPlanet);
            this.Controls.Add(this.lblMaxAbd);
            this.Controls.Add(this.lblMaxTrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicializador";
            ((System.ComponentModel.ISupportInitialize)(this.pibIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaxTrip;
        private System.Windows.Forms.Label lblMaxAbd;
        private System.Windows.Forms.Label lblPlanet;
        private System.Windows.Forms.TextBox txbMaxTrip;
        private System.Windows.Forms.TextBox txbMaxAbd;
        private System.Windows.Forms.ComboBox cmbPlanet;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pibIcone;
    }
}