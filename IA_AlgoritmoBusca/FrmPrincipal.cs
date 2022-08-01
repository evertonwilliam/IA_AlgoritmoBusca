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


            /*Fila fila = new Fila(10);
            Cidade cidade = new Cidade();
            CCidade nomeCidade = new CCidade();
            cidade = nomeCidade.GetCidade("Votuporanga");
            this.fila.Enfileirar(cidade);

            cidade = nomeCidade.GetCidade("Fernandópolis");
            this.fila.Enfileirar(cidade);

            cidade = nomeCidade.GetCidade("Meridiano");
            this.fila.Enfileirar(cidade);

            cidade = nomeCidade.GetCidade("Vila Nova");
            this.fila.Enfileirar(cidade);

            cidade = nomeCidade.GetCidade("Carvalho");
            this.fila.Enfileirar(cidade);

            this.fila.Enfileirar(cidade);

            this.fila.Desenfileirar();
            this.fila.Desenfileirar();
            */
        }
    }
}
