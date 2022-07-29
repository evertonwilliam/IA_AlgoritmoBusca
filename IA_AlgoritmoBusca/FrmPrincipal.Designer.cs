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
            this.panel1.SuspendLayout();
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
            this.panel1.Controls.Add(this.BtLoad);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 86);
            this.panel1.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 332);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPrincipal";
            this.Text = "Estudo dos Algorítmos de Busca";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtLoad;
        private System.Windows.Forms.Panel panel1;
    }
}

