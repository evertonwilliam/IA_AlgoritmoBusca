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
    public partial class FrmFila : Form
    {
        Fila fila = new Fila(10);
        public FrmFila()
        {
            InitializeComponent();
        }

        private void FrmFila_Load(object sender, EventArgs e)
        {
            CCidade cidade = new CCidade();
            CbCidade.DataSource = cidade.GetAllCidades();
            CbCidade.DisplayMember = "Cidade";
            CbCidade.ValueMember = "NomeCidade";
        }

        private void BtEnfileirar_Click(object sender, EventArgs e)
        {
            try
            {
                Cidade cidade = new Cidade();
                CCidade nomeCidade = new CCidade();
                cidade = nomeCidade.GetCidade(CbCidade.Text);

                this.fila.Enfileirar(cidade);
                LstBox.Items.Clear();

                foreach (Cidade cid in fila.GetFila())
                {
                    if (cid != null)
                    {
                        LstBox.Items.Add(cid.NomeCidade);
                    }

                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtDesenfileirar_Click(object sender, EventArgs e)
        {
            try {
                this.fila.Desenfileirar();
                LstBox.Items.Clear();

                foreach (Cidade cid in fila.GetFila())
                {
                    if (cid != null)
                    {
                        LstBox.Items.Add(cid.NomeCidade);
                    }

                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
