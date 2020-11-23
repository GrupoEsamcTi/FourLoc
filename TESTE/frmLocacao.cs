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
            DALItem iDAL = new DALItem();
            iDAL.ListarLocacaoF();
        }
    }
}
