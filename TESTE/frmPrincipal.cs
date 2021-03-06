﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario tela = new frmCadastroFuncionario();
            tela.MdiParent = this;
            tela.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCliente tela = new frmCadastroCliente();
            tela.MdiParent = this;
            tela.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void filmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFilme tela = new frmFilme();
            tela.MdiParent = this;
            tela.Show();

        }

        private void locaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocacao tela = new frmLocacao();
            tela.MdiParent = this;
            tela.Show();

        }

        private void artistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArtista tela = new frmArtista();
            tela.MdiParent = this;
            tela.Show();

        }

        private void gêneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGenero tela = new frmGenero();
            tela.MdiParent = this;
            tela.Show();
        }

        private void dEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDevolucao tela = new frmDevolucao();
            tela.MdiParent = this;
            tela.Show();

        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TESTE tela = new TESTE();
            tela.MdiParent = this;
            tela.Show();

        }
    }
}
