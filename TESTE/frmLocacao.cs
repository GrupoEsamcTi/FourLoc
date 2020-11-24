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
    public partial class frmLocacao : Form
    {
        public frmLocacao()
        {
            InitializeComponent();
        }

        private void txtCodigoF_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLocacao_Load(object sender, EventArgs e)
        {
            DALItem iDAL = new DALItem();
            cbListarF.DisplayMember = "CdPessoa";
            cbListarF.DataSource = iDAL.ListarLocacaoF();


            cbListaNomeC.DisplayMember = "NmPessoa";
            cbListaNomeC.DataSource = iDAL.ListarLocacaoC();

        }

        private void mtbCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {


        }

        private void bttPre_Click(object sender, EventArgs e)
        {
            String NmPessoa = cbListaNomeC.Text;

            DALPessoa pDAL = new DALPessoa();
            Pessoa pessoa = pDAL.ObterCPFC(NmPessoa);

            if (pessoa == null)
            {
                MessageBox.Show("CPF não encontrado.");
            }

            else
            {

                mtbCPF.Text = pessoa.NrCPF;

            }
        }
    }
}
