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
    public partial class FrmPilha : Form
    {
        Pilha pilha = new Pilha(10);
        public FrmPilha()
        {
            InitializeComponent();
        }
        private void FrmPilha_Load(object sender, EventArgs e)
        {
            CCidade cidade = new CCidade();
            CbCidades.DataSource = cidade.GetAllCidades();
            CbCidades.DisplayMember = "Cidade";
            CbCidades.ValueMember = "NomeCidade";
        }

        private void BtEmpilhar_Click(object sender, EventArgs e)
        {
            try
            {
                Cidade cidades = new Cidade();
                CCidade nomeCidade = new CCidade();
                cidades = nomeCidade.GetCidade(CbCidades.Text);

                this.pilha.Empilhar(cidades);
                LstBox.Items.Clear();

                foreach (Cidade cid in pilha.GetPilha().Reverse())
                {
                    if (cid != null)
                    {
                        LstBox.Items.Add(cid.NomeCidade);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtDesempilhar_Click(object sender, EventArgs e)
        {
            this.pilha.Desempilhar();
            LstBox.Items.Clear();

            foreach (Cidade cid in pilha.GetPilha().Reverse())
            {
                if (cid != null)
                {
                    LstBox.Items.Add(cid.NomeCidade);
                }
            }
        }
    }
}
