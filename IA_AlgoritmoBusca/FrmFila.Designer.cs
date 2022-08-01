namespace IA_AlgoritmoBusca
{
    partial class FrmFila
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
            this.CbCidade = new System.Windows.Forms.ComboBox();
            this.LbCidade = new System.Windows.Forms.Label();
            this.BtEnfileirar = new System.Windows.Forms.Button();
            this.BtDesenfileirar = new System.Windows.Forms.Button();
            this.LstBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CbCidade
            // 
            this.CbCidade.FormattingEnabled = true;
            this.CbCidade.Location = new System.Drawing.Point(12, 31);
            this.CbCidade.Name = "CbCidade";
            this.CbCidade.Size = new System.Drawing.Size(265, 24);
            this.CbCidade.TabIndex = 0;
            // 
            // LbCidade
            // 
            this.LbCidade.AutoSize = true;
            this.LbCidade.Location = new System.Drawing.Point(11, 13);
            this.LbCidade.Name = "LbCidade";
            this.LbCidade.Size = new System.Drawing.Size(51, 16);
            this.LbCidade.TabIndex = 1;
            this.LbCidade.Text = "Cidade";
            // 
            // BtEnfileirar
            // 
            this.BtEnfileirar.Location = new System.Drawing.Point(12, 61);
            this.BtEnfileirar.Name = "BtEnfileirar";
            this.BtEnfileirar.Size = new System.Drawing.Size(130, 38);
            this.BtEnfileirar.TabIndex = 2;
            this.BtEnfileirar.Text = "Enfileirar";
            this.BtEnfileirar.UseVisualStyleBackColor = true;
            this.BtEnfileirar.Click += new System.EventHandler(this.BtEnfileirar_Click);
            // 
            // BtDesenfileirar
            // 
            this.BtDesenfileirar.Location = new System.Drawing.Point(147, 61);
            this.BtDesenfileirar.Name = "BtDesenfileirar";
            this.BtDesenfileirar.Size = new System.Drawing.Size(130, 38);
            this.BtDesenfileirar.TabIndex = 3;
            this.BtDesenfileirar.Text = "Desenfileirar";
            this.BtDesenfileirar.UseVisualStyleBackColor = true;
            this.BtDesenfileirar.Click += new System.EventHandler(this.BtDesenfileirar_Click);
            // 
            // LstBox
            // 
            this.LstBox.FormattingEnabled = true;
            this.LstBox.ItemHeight = 16;
            this.LstBox.Location = new System.Drawing.Point(12, 106);
            this.LstBox.Name = "LstBox";
            this.LstBox.Size = new System.Drawing.Size(265, 132);
            this.LstBox.TabIndex = 4;
            // 
            // FrmFila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 247);
            this.Controls.Add(this.LstBox);
            this.Controls.Add(this.BtDesenfileirar);
            this.Controls.Add(this.BtEnfileirar);
            this.Controls.Add(this.LbCidade);
            this.Controls.Add(this.CbCidade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmFila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Processando Filas";
            this.Load += new System.EventHandler(this.FrmFila_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbCidade;
        private System.Windows.Forms.Label LbCidade;
        private System.Windows.Forms.Button BtEnfileirar;
        private System.Windows.Forms.Button BtDesenfileirar;
        private System.Windows.Forms.ListBox LstBox;
    }
}