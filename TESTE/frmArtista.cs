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
    public partial class frmArtista : Form
    {
        public frmArtista()
        {
            InitializeComponent();
        }

        private void LimparCadastro()
        {
            txtCodigo.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtCidade.Text = string.Empty;
            cbTipo.Text = string.Empty;
            
        }

        private void CarregarArtista()
        {
            DALPessoa pDAL = new DALPessoa();
           
        }

        private void bttCad_Click(object sender, EventArgs e)
        {
            {
                Pessoa objPessoa = new Pessoa();

                objPessoa.NmPessoa = txtNome.Text;
                objPessoa.DtNascimento = dtpDtNasc.Value;
                objPessoa.DsCidade = txtCidade.Text;
                objPessoa.DsTipo = cbTipo.Text;

                DALPessoa pDAL = new DALPessoa();

                pDAL.InserirArtista(objPessoa);


                MessageBox.Show("Artista cadastrada com sucesso");

                CarregarArtista();


            }

        }

        private void bttExcluir_Click(object sender, EventArgs e)
        {
            Pessoa objPessoa = new Pessoa();
            objPessoa.CdPessoa = Convert.ToInt32(txtCodigo.Text);

            DALPessoa pDAL = new DALPessoa();
            pDAL.ExcluirArtista(objPessoa.CdPessoa);
            MessageBox.Show("Artista excluido com sucesso");

            CarregarArtista();


        }

        private void bttAtualizar_Click(object sender, EventArgs e)
        {
            Pessoa objPessoa = new Pessoa();

            objPessoa.NmPessoa = txtNome.Text;
            objPessoa.DtNascimento = dtpDtNasc.Value;
            objPessoa.DsCidade = txtCidade.Text;
            objPessoa.DsTipo = cbTipo.Text;


            DALPessoa pDAL = new DALPessoa();

            pDAL.AtualizarArtista(objPessoa);


            MessageBox.Show("Artista atualizado com sucesso");

            LimparCadastro();
            CarregarArtista();
        }

        private void bttPesq_Click(object sender, EventArgs e)
        {
            int cdPessoa = Convert.ToInt32(txtCodigo.Text);

            DALPessoa pDAL = new DALPessoa();
            Pessoa pessoa = pDAL.ObterCliente(cdPessoa);

            if (pessoa == null)
            {
                MessageBox.Show("Artista não encontrada.");
            }

            else
            {
                txtNome.Text = pessoa.NmPessoa;
                dtpDtNasc.Value = pessoa.DtNascimento;
                txtCidade.Text = pessoa.DsCidade;
                cbTipo.Text = pessoa.DsTipo;
            }

            CarregarArtista();

        }
    }
}
