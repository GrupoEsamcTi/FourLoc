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

            }

        }

        private void bttExcluir_Click(object sender, EventArgs e)
        {
            Pessoa objPessoa = new Pessoa();
            objPessoa.CdPessoa = Convert.ToInt32(txtCodigo.Text);

            DALPessoa pDAL = new DALPessoa();
            pDAL.ExcluirArtista(objPessoa.CdPessoa);
            MessageBox.Show("Cliente excluido com sucesso");

        }
    }
}
