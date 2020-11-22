using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using DAL;

namespace TESTE
{
    public partial class frmGenero : Form
    {
        public frmGenero()
        {
            InitializeComponent();
        }

        private void frmGenero_Load(object sender, EventArgs e)
        {

        }


        private void LimparCadastro()
        {
            txtCodigo.Text = string.Empty;
            txtGenero.Text = string.Empty;
           
        }


        private void bttCad_Click(object sender, EventArgs e)
        {
            Item objItem = new Item();

            objItem.DsGenero = txtGenero.Text;

            DALItem iDAL = new DALItem();

            iDAL.InserirGenero(objItem);


            MessageBox.Show("Gênero cadastrada com sucesso");

            LimparCadastro();

        }

        private void bttExcluir_Click(object sender, EventArgs e)
        {
            Item objItem = new Item();
            objItem.CdGenero = Convert.ToInt32(txtCodigo.Text);

            DALItem iDAL = new DALItem();
            iDAL.ExcluirGenero(objItem.CdGenero);

            LimparCadastro();

            MessageBox.Show("Gênero excluido com sucesso");

        }

        private void bttAtualizar_Click(object sender, EventArgs e)
        {
            Item objItem = new Item();

            objItem.CdGenero = Convert.ToInt32(txtCodigo.Text);
            objItem.DsGenero = txtGenero.Text;

            DALItem iDAL = new DALItem();
            iDAL.AtualizarGenero(objItem);

            LimparCadastro();

            MessageBox.Show("Gênero atualizado com sucesso");


        }

        private void bttPesq_Click(object sender, EventArgs e)
        {
            int cdGenero = Convert.ToInt32(txtCodigo.Text);

            DALItem iDAL = new DALItem();
            Item item = iDAL.ObterGenero(cdGenero);

            if (item == null)
            {
                MessageBox.Show("Gênero não encontrada.");
            }

            else
            {
                txtGenero.Text = item.DsGenero;
            }

        }



    }
}
