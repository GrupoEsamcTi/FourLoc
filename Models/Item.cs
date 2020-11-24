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
        public string CdBarras { get; set; }

        public int CdLocacao { get; set; }

        public int CdDevolucao { get; set; }

        public DateTime DtLocacao { get; set; }

        public DateTime DtDevolucao { get; set; }

        public  decimal Vl_Locacao { get; set; }

        public decimal Vl_Recebido { get; set; }

        public decimal NrMulta { get; set; }

        public char Recebido { get; set; }


        public string DsTitulo { get; set; }

        public string DsGenero { get; set; }

        public string DsAno { get; set; }

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
