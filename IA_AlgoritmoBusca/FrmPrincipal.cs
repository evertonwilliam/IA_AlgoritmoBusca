﻿using IA_AlgoritmoBusca.controller;
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
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtLoad_Click(object sender, EventArgs e)
        {
            ConnDBASqlite conn = new ConnDBASqlite();
            BtLoad.Enabled = false;
        }
    }
}
