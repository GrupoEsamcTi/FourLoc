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

            cbCBarras.DisplayMember = "CdBarras";
            cbCBarras.DataSource = iDAL.ListarLocacao();

            DateTime hoje = DateTime.Now;
            dtpRetirada.Value = hoje.Date;
            dtpDevolucao.Value = dtpRetirada.Value.AddDays(5);

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

        private void bttPTitulo_Click(object sender, EventArgs e)
        {
            String CdBarras = cbCBarras.Text;

            DALItem iDAL = new DALItem();
            Item item = iDAL.ObterTituloValor(CdBarras);

            if (item == null)
            {
                MessageBox.Show("Filme não encontrado.");
            }

            else
            {

                txtTitulo.Text = item.DsTitulo;
                mtbVl.Text = item.NrPreco.ToString();

            }
        }



        private void bttLocacao_Click(object sender, EventArgs e)
        {
            Item objItem = new Item();
            Pessoa objPessoa = new Pessoa();

            objPessoa.CdPessoa = Convert.ToInt32(cbListarF.Text);
            objPessoa.NmPessoa = cbListaNomeC.Text;
            objPessoa.NrCPF = mtbCPF.Text;
            objItem.CdBarras = cbCBarras.Text;
            objItem.DsTitulo = txtTitulo.Text;
            objItem.Vl_Locacao = Convert.ToDecimal(mtbVl.Text);
            objItem.Vl_Recebido = Convert.ToDecimal(mtbVlR.Text);
            objItem.Recebido = cbPago.Text;
            objItem.DtLocacao = Convert.ToDateTime(dtpRetirada.Value);
            objItem.DtDevolucao = Convert.ToDateTime(dtpDevolucao.Value);
          
            DALItem iDAL = new DALItem();
            iDAL.InserirLocacao(objItem,objPessoa);
          


            MessageBox.Show("Locação executada com sucesso", "Locação");
        }

        private void dtpRetirada_ValueChanged(object sender, EventArgs e)
        {
            dtpDevolucao.Value = dtpRetirada.Value.AddDays(5);
        }

        private void dtpDevolucao_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
