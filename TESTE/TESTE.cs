using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Models;


namespace TESTE
{
    public partial class TESTE : Form
    {
        public TESTE()
        {
            InitializeComponent();
        }

        private void bttTeste_Click(object sender, EventArgs e)
        {
            string nmFotoCapa = txtTeste.Text;

            string caminho = $@"C:\Users\MISL\FourLoc\Imagens\{nmFotoCapa}";

            var Imagem = File.ReadAllBytes(caminho);

            var base64image = Convert.ToBase64String(Imagem);

            DALItem DALi = new DALItem();
            DALi.InserirImagem(base64image);



        }

        private void bttMostrar_Click(object sender, EventArgs e)
        {



            DALItem DALi = new DALItem();
            string img = DALi.SELEÇÃOImagem();
            var bytes = Convert.FromBase64String(img);
            using (var stream = new MemoryStream(bytes))
            {
                pbImagem.SizeMode = PictureBoxSizeMode.StretchImage;

                pbImagem.Image = Image.FromStream(stream);
            }


        }
    }
}
