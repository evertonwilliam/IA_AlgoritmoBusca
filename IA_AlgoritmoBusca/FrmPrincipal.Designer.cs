namespace IA_AlgoritmoBusca
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtLoad = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtAEstrela = new System.Windows.Forms.Button();
            this.BtLargura = new System.Windows.Forms.Button();
            this.BtGuloso = new System.Windows.Forms.Button();
            this.BtProfundidade = new System.Windows.Forms.Button();
            this.BtPilha = new System.Windows.Forms.Button();
            this.BtFila = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtLoad
            // 
            this.BtLoad.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtLoad.Location = new System.Drawing.Point(12, 12);
            this.BtLoad.Name = "BtLoad";
            this.BtLoad.Size = new System.Drawing.Size(81, 61);
            this.BtLoad.TabIndex = 0;
            this.BtLoad.Text = "Load";
            this.BtLoad.UseVisualStyleBackColor = true;
            this.BtLoad.Click += new System.EventHandler(this.BtLoad_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtAEstrela);
            this.panel1.Controls.Add(this.BtLargura);
            this.panel1.Controls.Add(this.BtGuloso);
            this.panel1.Controls.Add(this.BtProfundidade);
            this.panel1.Controls.Add(this.BtPilha);
            this.panel1.Controls.Add(this.BtFila);
            this.panel1.Controls.Add(this.BtLoad);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 85);
            this.panel1.TabIndex = 1;
            // 
            // BtAEstrela
            // 
            this.BtAEstrela.Enabled = false;
            this.BtAEstrela.Location = new System.Drawing.Point(548, 12);
            this.BtAEstrela.Name = "BtAEstrela";
            this.BtAEstrela.Size = new System.Drawing.Size(81, 61);
            this.BtAEstrela.TabIndex = 6;
            this.BtAEstrela.Text = "A*";
            this.BtAEstrela.UseVisualStyleBackColor = true;
            // 
            // BtLargura
            // 
            this.BtLargura.Enabled = false;
            this.BtLargura.Location = new System.Drawing.Point(386, 13);
            this.BtLargura.Name = "BtLargura";
            this.BtLargura.Size = new System.Drawing.Size(81, 61);
            this.BtLargura.TabIndex = 5;
            this.BtLargura.Text = "Largura";
            this.BtLargura.UseVisualStyleBackColor = true;
            // 
            // BtGuloso
            // 
            this.BtGuloso.Enabled = false;
            this.BtGuloso.Location = new System.Drawing.Point(467, 12);
            this.BtGuloso.Name = "BtGuloso";
            this.BtGuloso.Size = new System.Drawing.Size(81, 61);
            this.BtGuloso.TabIndex = 4;
            this.BtGuloso.Text = "Guloso";
            this.BtGuloso.UseVisualStyleBackColor = true;
            // 
            // BtProfundidade
            // 
            this.BtProfundidade.Enabled = false;
            this.BtProfundidade.Location = new System.Drawing.Point(305, 13);
            this.BtProfundidade.Name = "BtProfundidade";
            this.BtProfundidade.Size = new System.Drawing.Size(81, 61);
            this.BtProfundidade.TabIndex = 3;
            this.BtProfundidade.Text = "Profundo";
            this.BtProfundidade.UseVisualStyleBackColor = true;
            // 
            // BtPilha
            // 
            this.BtPilha.Enabled = false;
            this.BtPilha.Location = new System.Drawing.Point(172, 12);
            this.BtPilha.Name = "BtPilha";
            this.BtPilha.Size = new System.Drawing.Size(81, 61);
            this.BtPilha.TabIndex = 2;
            this.BtPilha.Text = "Pilha";
            this.BtPilha.UseVisualStyleBackColor = true;
            // 
            // BtFila
            // 
            this.BtFila.Enabled = false;
            this.BtFila.Location = new System.Drawing.Point(92, 12);
            this.BtFila.Name = "BtFila";
            this.BtFila.Size = new System.Drawing.Size(81, 61);
            this.BtFila.TabIndex = 1;
            this.BtFila.Text = "Fila";
            this.BtFila.UseVisualStyleBackColor = true;
            this.BtFila.Click += new System.EventHandler(this.BtFila_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 224);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 357);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudo dos Algorítmos de Busca";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtLoad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtAEstrela;
        private System.Windows.Forms.Button BtLargura;
        private System.Windows.Forms.Button BtGuloso;
        private System.Windows.Forms.Button BtProfundidade;
        private System.Windows.Forms.Button BtPilha;
        private System.Windows.Forms.Button BtFila;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

