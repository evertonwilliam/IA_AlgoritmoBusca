namespace IA_AlgoritmoBusca
{
    partial class FrmPilha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CbCidades = new System.Windows.Forms.ComboBox();
            this.LbCidade = new System.Windows.Forms.Label();
            this.BtEmpilhar = new System.Windows.Forms.Button();
            this.BtDesempilhar = new System.Windows.Forms.Button();
            this.LstBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CbCidades
            // 
            this.CbCidades.FormattingEnabled = true;
            this.CbCidades.Location = new System.Drawing.Point(13, 35);
            this.CbCidades.Name = "CbCidades";
            this.CbCidades.Size = new System.Drawing.Size(310, 24);
            this.CbCidades.TabIndex = 0;
            // 
            // LbCidade
            // 
            this.LbCidade.AutoSize = true;
            this.LbCidade.Location = new System.Drawing.Point(10, 16);
            this.LbCidade.Name = "LbCidade";
            this.LbCidade.Size = new System.Drawing.Size(51, 16);
            this.LbCidade.TabIndex = 1;
            this.LbCidade.Text = "Cidade";
            // 
            // BtEmpilhar
            // 
            this.BtEmpilhar.Location = new System.Drawing.Point(13, 65);
            this.BtEmpilhar.Name = "BtEmpilhar";
            this.BtEmpilhar.Size = new System.Drawing.Size(148, 45);
            this.BtEmpilhar.TabIndex = 2;
            this.BtEmpilhar.Text = "Empilhar";
            this.BtEmpilhar.UseVisualStyleBackColor = true;
            this.BtEmpilhar.Click += new System.EventHandler(this.BtEmpilhar_Click);
            // 
            // BtDesempilhar
            // 
            this.BtDesempilhar.Location = new System.Drawing.Point(175, 65);
            this.BtDesempilhar.Name = "BtDesempilhar";
            this.BtDesempilhar.Size = new System.Drawing.Size(148, 45);
            this.BtDesempilhar.TabIndex = 3;
            this.BtDesempilhar.Text = "Desempilhar";
            this.BtDesempilhar.UseVisualStyleBackColor = true;
            this.BtDesempilhar.Click += new System.EventHandler(this.BtDesempilhar_Click);
            // 
            // LstBox
            // 
            this.LstBox.FormattingEnabled = true;
            this.LstBox.ItemHeight = 16;
            this.LstBox.Location = new System.Drawing.Point(13, 117);
            this.LstBox.Name = "LstBox";
            this.LstBox.Size = new System.Drawing.Size(310, 148);
            this.LstBox.TabIndex = 4;
            // 
            // FrmPilha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 277);
            this.Controls.Add(this.LstBox);
            this.Controls.Add(this.BtDesempilhar);
            this.Controls.Add(this.BtEmpilhar);
            this.Controls.Add(this.LbCidade);
            this.Controls.Add(this.CbCidades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPilha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Processando Pilhas";
            this.Load += new System.EventHandler(this.FrmPilha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbCidades;
        private System.Windows.Forms.Label LbCidade;
        private System.Windows.Forms.Button BtEmpilhar;
        private System.Windows.Forms.Button BtDesempilhar;
        private System.Windows.Forms.ListBox LstBox;
    }
}