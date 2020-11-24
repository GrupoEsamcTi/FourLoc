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
    public partial class frmCadastroFuncionario : Form
    {
        public frmCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void frmCadastroFuncionario_Load(object sender, EventArgs e)
        {
            CarregarFuncionario();
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

      
        private void CarregarFuncionario()
        {
            DALPessoa pDAL = new DALPessoa();
            dgvFuncionario.DataSource = pDAL.ListarFuncionario();
        }

      
       // private void btnLimpar_Click(object sender, EventArgs e)
        //{
         //   LimparCadastro();
       // }

        

        private void bttCad_Click_1(object sender, EventArgs e)
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

            pDAL.InserirFuncionario(objPessoa);


            MessageBox.Show("Funcionario cadastrada com sucesso", "Cadastrado");

            LimparCadastro();
            CarregarFuncionario();

        }

        private void bttExcluir_Click_1(object sender, EventArgs e)
        {
            DialogResult OpcaoExcluir = new DialogResult();
            OpcaoExcluir = MessageBox.Show("Deseja excluir esse usuario", "Atenção", MessageBoxButtons.YesNo);

            if (OpcaoExcluir == DialogResult.Yes)
            {

                Pessoa objPessoa = new Pessoa();
                objPessoa.CdPessoa = Convert.ToInt32(txtCodigo.Text);

                DALPessoa pDAL = new DALPessoa();
                pDAL.ExcluirFuncionario(objPessoa.CdPessoa);
                MessageBox.Show("Funcionario excluido com sucesso","Excluido");

                CarregarFuncionario();
            }

            else
            {
                MessageBox.Show("Exclusão cancelada","Cancelado");

            }



        }

        private void bttAtualizar_Click_1(object sender, EventArgs e)
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

            pDAL.AtualizarFuncionario(objPessoa);


            MessageBox.Show("Funcionario atualizado com sucesso","Atualizado");

            LimparCadastro();
            CarregarFuncionario();

        }

        private void bttPesq_Click_1(object sender, EventArgs e)
        {
               int cdPessoa = Convert.ToInt32(txtCodigo.Text);

            DALPessoa pDAL = new DALPessoa();
            Pessoa pessoa = pDAL.ObterFuncionario(cdPessoa);

            if (pessoa == null)
            {
                MessageBox.Show("Funcionario não encontrada.");
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

                CarregarFuncionario();
            }
        }

        private void dgvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int CdPessoa = Convert.ToInt32(dgvFuncionario.Rows[e.RowIndex].Cells["CdPessoa"].Value.ToString());

            if (dgvFuncionario.Columns[e.ColumnIndex] == dgvFuncionario.Columns["Editar"])
            {
                DALPessoa pDAL = new DALPessoa();
                Pessoa pessoa = pDAL.ObterFuncionario(CdPessoa);

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
            else if (dgvFuncionario.Columns[e.ColumnIndex] == dgvFuncionario.Columns["Excluir"])
            {


                DialogResult OpcaoExcluir = new DialogResult();
                OpcaoExcluir = MessageBox.Show("Deseja excluir esse funcionario", "Atenção", MessageBoxButtons.YesNo);

                if (OpcaoExcluir == DialogResult.Yes)
                {

                    Pessoa objPessoa = new Pessoa();
                    objPessoa.CdPessoa = Convert.ToInt32(dgvFuncionario.Rows[e.RowIndex].Cells["CdPessoa"].Value.ToString()); 

                    DALPessoa pDAL = new DALPessoa();
                    pDAL.ExcluirFuncionario(objPessoa.CdPessoa);
                    MessageBox.Show("Funcionario excluido com sucesso","Excluido");

                    CarregarFuncionario();
                }

                else
                {
                    MessageBox.Show("Exclusão cancelada","Cancelado");

                }

            }
        }

        private void dgvFuncionario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvFuncionario.Rows[e.RowIndex].Cells["Editar"].ToolTipText = "Clique aqui para editar.";
            dgvFuncionario.Rows[e.RowIndex].Cells["Excluir"].ToolTipText = "Clique aqui para excluir.";
        }
    }
}
