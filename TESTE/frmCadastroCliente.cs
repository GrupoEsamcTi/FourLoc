using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Models;

namespace TESTE
{
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }


        private void LimparCadastro()
        {
            txtCodigo.Text = string.Empty;
            txtNome.Text = string.Empty;
            mtbRG.Text = string.Empty;
            mtbCPF.Text = string.Empty;
            dtpDtNasc.Text = string.Empty;
            cbEstado.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtEmail.Text = string.Empty;
            mtbCEP.Text = string.Empty;
            mtbTel.Text = string.Empty;
            mtbCel.Text = string.Empty;
            cbStatus.Text = string.Empty;
            rbMasculino.Checked = true;
            rbFeminino.Checked = false;

        }

        private void bttPesq_Click(object sender, EventArgs e)
        {
            int cdPessoa = Convert.ToInt32(txtCodigo.Text);

            DALPessoa pDAL = new DALPessoa();
            Pessoa pessoa = pDAL.ObterCliente(cdPessoa);

            if (pessoa == null)
            {
                MessageBox.Show("Cliente não encontrada.");
            }

            else
            {
                txtNome.Text = pessoa.NmPessoa;
                dtpDtNasc.Value = pessoa.DtNascimento;
                rbFeminino.Checked = pessoa.DsSexo == 'F';
                rbMasculino.Checked = pessoa.DsSexo == 'M';
                switch (pessoa.DsEstadoCivil)
                {
                    case 'S':
                        cbEstado.Text = "Solteiro";
                        break;
                    case 'C':
                        cbEstado.Text = "Casado";
                        break;
                    default:
                        cbEstado.Text = "Divorciado";
                        break;
                }
                mtbRG.Text = pessoa.NrRG;
                mtbCPF.Text = pessoa.NrCPF;
                txtEndereco.Text = pessoa.DsEndereco;
                txtEstado.Text = pessoa.DsEstado;
                txtCidade.Text = pessoa.DsCidade;
                mtbCEP.Text = pessoa.DsCEP;
                txtEmail.Text = pessoa.DsEmail;
                mtbTel.Text = pessoa.NrTelefone;
                mtbCel.Text = pessoa.NrCelular;
                cbStatus.Text = pessoa.DsStatus;


            }
        }


        private void bttCad_Click(object sender, EventArgs e)
        {
            Pessoa objPessoa = new Pessoa();

            objPessoa.NmPessoa = txtNome.Text;
            objPessoa.DtNascimento = dtpDtNasc.Value;
            objPessoa.DsSexo = rbMasculino.Checked ? 'M' : 'F';
            switch (cbEstado.Text)
            {
                case "Solteiro":
                    objPessoa.DsEstadoCivil = 'S';
                    break;
                case "Casado":
                    objPessoa.DsEstadoCivil = 'C';
                    break;
                default:
                    objPessoa.DsEstadoCivil = 'D';
                    break;
            }

            objPessoa.NrRG = mtbRG.Text;
            objPessoa.NrCPF = mtbCPF.Text;
            objPessoa.DsCidade = txtCidade.Text;
            objPessoa.DsEndereco = txtEndereco.Text;
            objPessoa.DsEstado = txtEstado.Text;
            objPessoa.DsCEP = mtbCEP.Text;
            objPessoa.DsEmail = txtEmail.Text;
            objPessoa.NrTelefone = mtbTel.Text;
            objPessoa.NrCelular = mtbCel.Text;
            objPessoa.DsStatus = cbStatus.Text;



            DALPessoa pDAL = new DALPessoa();

            pDAL.InserirCliente(objPessoa);


            MessageBox.Show("Cliente cadastrada com sucesso");

            LimparCadastro();

            CarregarCliente();
        }


           
        private void bttExcluir_Click(object sender, EventArgs e)
        {
            Pessoa objPessoa = new Pessoa(); 
            DALPessoa pDAL = new DALPessoa();
            pDAL.ExcluirCliente(objPessoa.CdPessoa);
            MessageBox.Show("Cliente excluido com sucesso");

            CarregarCliente();

        }
   

        
            

        private void bttAtualizar_Click(object sender, EventArgs e)
        {
            Pessoa objPessoa = new Pessoa();

            objPessoa.CdPessoa = Convert.ToInt32(txtCodigo.Text);
            objPessoa.NmPessoa = txtNome.Text;
            objPessoa.DtNascimento = dtpDtNasc.Value;
            objPessoa.DsSexo = rbMasculino.Checked ? 'M' : 'F';

            switch (cbEstado.Text)
            {
                case "Solteiro":
                    objPessoa.DsEstadoCivil = 'S';
                    break;
                case "Casado":
                    objPessoa.DsEstadoCivil = 'C';
                    break;
                default:
                    objPessoa.DsEstadoCivil = 'D';
                    break;
            }
                    objPessoa.NrRG = mtbRG.Text;
                    objPessoa.NrCPF = mtbCPF.Text;
                    objPessoa.DsCidade = txtCidade.Text;
                    objPessoa.DsEndereco = txtEndereco.Text;
                    objPessoa.DsEstado = txtEstado.Text;
                    objPessoa.DsCEP = mtbCEP.Text;
                    objPessoa.DsEmail = txtEmail.Text;
                    objPessoa.NrTelefone = mtbTel.Text;
                    objPessoa.NrCelular = mtbCel.Text;
                    objPessoa.DsStatus = cbStatus.Text;


                    DALPessoa pDAL = new DALPessoa();

                    pDAL.AtualizarCliente(objPessoa);


                    MessageBox.Show("Cliente atualizado com sucesso");

                    LimparCadastro();
                    pDAL.ListarCliente();

                    CarregarCliente();

            
        }


    private void CarregarCliente()
        {
            DALPessoa pDAL = new DALPessoa();
            dgvCliente.DataSource = pDAL.ListarCliente();
        }

    }

}

