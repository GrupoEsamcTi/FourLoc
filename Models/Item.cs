using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Item
    {
        public int CdFilme { get; set; }

        public int CdGenero { get; set; }
        public int CdBarras { get; set; }

        public string DsTitulo { get; set; }

        public string DsGenero { get; set; }

        public char DsAno { get; set; }

        public string DsTipo { get; set; }

        public decimal NrPreco { get; set; }

        public DateTime DtAdquirida { get; set; }

        public decimal NrValorCusto { get; set; }

        public string DsSituacao { get; set; }

        public string DsAtores { get; set; }

        public string DsDiretor { get; set; }

        public string DsFotoCapa { get; set; }

    }
}
