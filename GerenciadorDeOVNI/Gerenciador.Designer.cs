namespace GerenciadorDeOVNI {
    partial class Gerenciador {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gerenciador));
            this.grbInformacoes = new System.Windows.Forms.GroupBox();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.btnLigar = new System.Windows.Forms.Button();
            this.lblAbduzidos = new System.Windows.Forms.Label();
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.grbTripulantes = new System.Windows.Forms.GroupBox();
            this.btnRemoverTrip = new System.Windows.Forms.Button();
            this.btnAdicionarTrip = new System.Windows.Forms.Button();
            this.grbAbduzidos = new System.Windows.Forms.GroupBox();
            this.btnRemoverAbduzidos = new System.Windows.Forms.Button();
            this.btnAdicionarAbduzidos = new System.Windows.Forms.Button();
            this.pibIcon = new System.Windows.Forms.PictureBox();
            this.grbPlantas = new System.Windows.Forms.GroupBox();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnMudarPlaneta = new System.Windows.Forms.Button();
            this.cmbPlanetas = new System.Windows.Forms.ComboBox();
            this.lblPlanetaAtual = new System.Windows.Forms.Label();
            this.grbInformacoes.SuspendLayout();
            this.grbTripulantes.SuspendLayout();
            this.grbAbduzidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibIcon)).BeginInit();
            this.grbPlantas.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInformacoes
            // 
            this.grbInformacoes.Controls.Add(this.lblPlanetaAtual);
            this.grbInformacoes.Controls.Add(this.btnDesligar);
            this.grbInformacoes.Controls.Add(this.btnLigar);
            this.grbInformacoes.Controls.Add(this.lblAbduzidos);
            this.grbInformacoes.Controls.Add(this.lblTripulantes);
            this.grbInformacoes.Controls.Add(this.lblSituacao);
            this.grbInformacoes.Location = new System.Drawing.Point(12, 12);
            this.grbInformacoes.Name = "grbInformacoes";
            this.grbInformacoes.Size = new System.Drawing.Size(200, 228);
            this.grbInformacoes.TabIndex = 0;
            this.grbInformacoes.TabStop = false;
            this.grbInformacoes.Text = "Informações";
            // 
            // btnDesligar
            // 
            this.btnDesligar.Location = new System.Drawing.Point(6, 168);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(188, 43);
            this.btnDesligar.TabIndex = 5;
            this.btnDesligar.Text = "Desligar";
            this.btnDesligar.UseVisualStyleBackColor = true;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // btnLigar
            // 
            this.btnLigar.Location = new System.Drawing.Point(3, 121);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(191, 41);
            this.btnLigar.TabIndex = 4;
            this.btnLigar.Text = "Ligar";
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // lblAbduzidos
            // 
            this.lblAbduzidos.AutoSize = true;
            this.lblAbduzidos.Location = new System.Drawing.Point(6, 68);
            this.lblAbduzidos.Name = "lblAbduzidos";
            this.lblAbduzidos.Size = new System.Drawing.Size(59, 13);
            this.lblAbduzidos.TabIndex = 3;
            this.lblAbduzidos.Text = "Abduzidos:";
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Location = new System.Drawing.Point(6, 48);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(62, 13);
            this.lblTripulantes.TabIndex = 2;
            this.lblTripulantes.Text = "Tripulantes:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(10, 29);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(52, 13);
            this.lblSituacao.TabIndex = 1;
            this.lblSituacao.Text = "Situação:";
            // 
            // grbTripulantes
            // 
            this.grbTripulantes.Controls.Add(this.btnRemoverTrip);
            this.grbTripulantes.Controls.Add(this.btnAdicionarTrip);
            this.grbTripulantes.Location = new System.Drawing.Point(12, 246);
            this.grbTripulantes.Name = "grbTripulantes";
            this.grbTripulantes.Size = new System.Drawing.Size(200, 134);
            this.grbTripulantes.TabIndex = 1;
            this.grbTripulantes.TabStop = false;
            this.grbTripulantes.Text = "Tripulantes";
            // 
            // btnRemoverTrip
            // 
            this.btnRemoverTrip.Location = new System.Drawing.Point(6, 74);
            this.btnRemoverTrip.Name = "btnRemoverTrip";
            this.btnRemoverTrip.Size = new System.Drawing.Size(188, 49);
            this.btnRemoverTrip.TabIndex = 1;
            this.btnRemoverTrip.Text = "Remover";
            this.btnRemoverTrip.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarTrip
            // 
            this.btnAdicionarTrip.Location = new System.Drawing.Point(6, 19);
            this.btnAdicionarTrip.Name = "btnAdicionarTrip";
            this.btnAdicionarTrip.Size = new System.Drawing.Size(188, 49);
            this.btnAdicionarTrip.TabIndex = 0;
            this.btnAdicionarTrip.Text = "Adicionar";
            this.btnAdicionarTrip.UseVisualStyleBackColor = true;
            this.btnAdicionarTrip.Click += new System.EventHandler(this.btnAdicionarTrip_Click);
            // 
            // grbAbduzidos
            // 
            this.grbAbduzidos.Controls.Add(this.btnRemoverAbduzidos);
            this.grbAbduzidos.Controls.Add(this.btnAdicionarAbduzidos);
            this.grbAbduzidos.Location = new System.Drawing.Point(237, 12);
            this.grbAbduzidos.Name = "grbAbduzidos";
            this.grbAbduzidos.Size = new System.Drawing.Size(200, 134);
            this.grbAbduzidos.TabIndex = 2;
            this.grbAbduzidos.TabStop = false;
            this.grbAbduzidos.Text = "Abduzidos";
            // 
            // btnRemoverAbduzidos
            // 
            this.btnRemoverAbduzidos.Location = new System.Drawing.Point(6, 74);
            this.btnRemoverAbduzidos.Name = "btnRemoverAbduzidos";
            this.btnRemoverAbduzidos.Size = new System.Drawing.Size(188, 49);
            this.btnRemoverAbduzidos.TabIndex = 1;
            this.btnRemoverAbduzidos.Text = "Remover";
            this.btnRemoverAbduzidos.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarAbduzidos
            // 
            this.btnAdicionarAbduzidos.Location = new System.Drawing.Point(6, 19);
            this.btnAdicionarAbduzidos.Name = "btnAdicionarAbduzidos";
            this.btnAdicionarAbduzidos.Size = new System.Drawing.Size(188, 49);
            this.btnAdicionarAbduzidos.TabIndex = 0;
            this.btnAdicionarAbduzidos.Text = "Adicionar";
            this.btnAdicionarAbduzidos.UseVisualStyleBackColor = true;
            // 
            // pibIcon
            // 
            this.pibIcon.Image = global::GerenciadorDeOVNI.Properties.Resources.e_tIcon;
            this.pibIcon.Location = new System.Drawing.Point(437, 12);
            this.pibIcon.Name = "pibIcon";
            this.pibIcon.Size = new System.Drawing.Size(237, 368);
            this.pibIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibIcon.TabIndex = 3;
            this.pibIcon.TabStop = false;
            // 
            // grbPlantas
            // 
            this.grbPlantas.Controls.Add(this.btnRetornar);
            this.grbPlantas.Controls.Add(this.btnMudarPlaneta);
            this.grbPlantas.Controls.Add(this.cmbPlanetas);
            this.grbPlantas.Location = new System.Drawing.Point(237, 152);
            this.grbPlantas.Name = "grbPlantas";
            this.grbPlantas.Size = new System.Drawing.Size(200, 162);
            this.grbPlantas.TabIndex = 4;
            this.grbPlantas.TabStop = false;
            this.grbPlantas.Text = "Planetas";
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(6, 102);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(188, 49);
            this.btnRetornar.TabIndex = 2;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            // 
            // btnMudarPlaneta
            // 
            this.btnMudarPlaneta.Location = new System.Drawing.Point(6, 47);
            this.btnMudarPlaneta.Name = "btnMudarPlaneta";
            this.btnMudarPlaneta.Size = new System.Drawing.Size(188, 49);
            this.btnMudarPlaneta.TabIndex = 2;
            this.btnMudarPlaneta.Text = "Mudar";
            this.btnMudarPlaneta.UseVisualStyleBackColor = true;
            // 
            // cmbPlanetas
            // 
            this.cmbPlanetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanetas.FormattingEnabled = true;
            this.cmbPlanetas.Location = new System.Drawing.Point(7, 20);
            this.cmbPlanetas.Name = "cmbPlanetas";
            this.cmbPlanetas.Size = new System.Drawing.Size(187, 21);
            this.cmbPlanetas.TabIndex = 0;
            // 
            // lblPlanetaAtual
            // 
            this.lblPlanetaAtual.AutoSize = true;
            this.lblPlanetaAtual.Location = new System.Drawing.Point(6, 88);
            this.lblPlanetaAtual.Name = "lblPlanetaAtual";
            this.lblPlanetaAtual.Size = new System.Drawing.Size(72, 13);
            this.lblPlanetaAtual.TabIndex = 6;
            this.lblPlanetaAtual.Text = "Planeta atual:";
            // 
            // Gerenciador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(707, 399);
            this.Controls.Add(this.grbPlantas);
            this.Controls.Add(this.pibIcon);
            this.Controls.Add(this.grbAbduzidos);
            this.Controls.Add(this.grbTripulantes);
            this.Controls.Add(this.grbInformacoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Gerenciador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador";
            this.grbInformacoes.ResumeLayout(false);
            this.grbInformacoes.PerformLayout();
            this.grbTripulantes.ResumeLayout(false);
            this.grbAbduzidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibIcon)).EndInit();
            this.grbPlantas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInformacoes;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Label lblAbduzidos;
        private System.Windows.Forms.GroupBox grbTripulantes;
        private System.Windows.Forms.Button btnAdicionarTrip;
        private System.Windows.Forms.Button btnRemoverTrip;
        private System.Windows.Forms.GroupBox grbAbduzidos;
        private System.Windows.Forms.Button btnRemoverAbduzidos;
        private System.Windows.Forms.Button btnAdicionarAbduzidos;
        private System.Windows.Forms.PictureBox pibIcon;
        private System.Windows.Forms.GroupBox grbPlantas;
        private System.Windows.Forms.ComboBox cmbPlanetas;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Button btnMudarPlaneta;
        private System.Windows.Forms.Label lblPlanetaAtual;
    }
}