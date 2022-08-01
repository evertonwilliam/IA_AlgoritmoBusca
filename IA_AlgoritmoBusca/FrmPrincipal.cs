using IA_AlgoritmoBusca.controller;
using IA_AlgoritmoBusca.extruct;
using IA_AlgoritmoBusca.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IA_AlgoritmoBusca
{
    public partial class FrmPrincipal : Form
    {
        Fila fila = new Fila(10);
        public FrmPrincipal()
        {
            InitializeComponent();           
        }

        private void BtLoad_Click(object sender, EventArgs e)
        {
            ConnDBASqlite conn = new ConnDBASqlite();
            BtLoad.Enabled = false;
            BtAEstrela.Enabled = true;
            BtFila.Enabled = true;
            BtGuloso.Enabled = true;
            BtLargura.Enabled = true;
            BtPilha.Enabled = true;
            BtProfundidade.Enabled = true;
        }

        private void BtFila_Click(object sender, EventArgs e)
        {
            FrmFila frmFila = new FrmFila();
            frmFila.ShowDialog();
        }

        private void BtPilha_Click(object sender, EventArgs e)
        {
            FrmPilha frmPilha = new FrmPilha();
            frmPilha.ShowDialog(); 
        }
    }
}
