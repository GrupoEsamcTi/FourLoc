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
    public partial class frmFilme : Form
    {
        public frmFilme()
        {
            InitializeComponent();
        }

        private void frmFilme_Load(object sender, EventArgs e)
        {

        }

        private void bttInserir_Click(object sender, EventArgs e)
        {
            Item objItem = new Item();

            objItem.CdBarras = Convert.ToInt32(txtCdBarras.Text);
            objItem.DsTitulo = txtTitulo.Text;
            objItem.NrPreco = Convert.ToDecimal(mtbPreco.Text);
            objItem.DtAdquirida = dtpDtAdquirida.Value;
            objItem.NrValorCusto = Convert.ToDecimal(mtbVlCusto.Text);
            objItem.DsSituacao = cbSituacao.Text;
            objItem.DsAtores = txtAtores.Text;
            objItem.DsDiretor = txtDiretor.Text;
            //objItem.CdFoto = Convert.ToInt32(txtCdFoto.Text);


            DALItem iDAL = new DALItem();

            iDAL.InserirItem(objItem);


           

            MessageBox.Show("Filme cadastrada com sucesso");
        }

        //private void bttIns_Click(object sender, EventArgs e)
        //{
        //    Item objItem = new Item();

        //    objItem.NmFotoCapa = txtNmCapa.Text;

        //    DALItem iDAL = new DALItem();

        //    iDAL.InserirImagem(objItem);
        //}

        private void mtbVlCusto_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbPreco_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }

}
