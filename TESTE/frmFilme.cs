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
using System.IO;

namespace TESTE
{
    public partial class frmFilme : Form
    {
        public frmFilme()
        {
            InitializeComponent();
        }


        private void CarregarItem()
        {
            DALItem iDAL = new DALItem();
            dgvItem.DataSource = iDAL.ListarItem();
        }


        private void bttInserir_Click(object sender, EventArgs e)

        {
            string nmFotoCapa = txtFoto.Text;

            string caminho = $@"C:\Users\MISL\FourLoc\Imagens\Capa\{nmFotoCapa}";

            var Imagem = File.ReadAllBytes(caminho);

            var base64image = Convert.ToBase64String(Imagem);

            Item objItem = new Item();

            objItem.CdBarras = txtCdBarras.Text;
            objItem.DsTitulo = txtTitulo.Text;
            objItem.NrPreco = Convert.ToDecimal(mtbPreco.Text);
            objItem.DtAdquirida = dtpDtAdquirida.Value;
            objItem.NrValorCusto = Convert.ToDecimal(mtbVlCusto.Text);
            objItem.DsSituacao = cbSituacao.Text;
            objItem.DsAtores = txtAtores.Text;
            objItem.DsDiretor = txtDiretor.Text;
            objItem.DsFotoCapa = (base64image);


            DALItem iDAL = new DALItem();

            iDAL.InserirItem(objItem);
                  

            MessageBox.Show("Filme cadastrada com sucesso");
        }

        private void bttPesq_Click(object sender, EventArgs e)
        {
            int cdFilme = Convert.ToInt32(txtCodigo.Text);

            DALItem iDAL = new DALItem();
            Item item = iDAL.ObterItem(cdFilme);

            if (item == null)
            {
                MessageBox.Show("Filme não encontrada.");
            }

            else
            {
                
                txtCdBarras.Text= item.CdBarras;
                txtTitulo.Text = item.DsTitulo;
                txtGenero.Text = item.DsGenero;
                txtFoto.Text = item.DsFotoCapa;
                mtbAno.Text = item.DsAno;
                cbTipo.Text = item.DsTipo;
                mtbPreco.Text = item.NrPreco.ToString();
                dtpDtAdquirida.Value = item.DtAdquirida;
                mtbVlCusto.Text = item.NrValorCusto.ToString();

                if (item.DsSituacao == "Disponivel") 
                {
                    cbSituacao.Text = item.DsSituacao;

                }
                else
                {

                    cbSituacao.Text = item.DsSituacao;


                }
                txtAtores.Text = item.DsAtores;
                txtDiretor.Text = item.DsDiretor;
               
             }
        }
    }


}
