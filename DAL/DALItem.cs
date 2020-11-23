using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Models;
using System.Data.SqlClient;
using System.CodeDom;

namespace DAL
{
   public class DALItem
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["BDFourLocConnectionString"].ConnectionString;

        ///////////////////////////////////////////////// ITEM ////////////////////////////////////////////////////////////////////////////
        public void InserirItem(Item objItem)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "INSERT INTO TBL_ITEM VALUES (@cdb, @tit, @preco, @dt_ad, @vlc, @sit, @ator, @dir)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@cdb", objItem.CdBarras);
            cmd.Parameters.AddWithValue("@tit", objItem.DsTitulo);
            cmd.Parameters.AddWithValue("@preco", objItem.NrPreco);
            cmd.Parameters.AddWithValue("@dt_ad", objItem.DtAdquirida);
            cmd.Parameters.AddWithValue("@vlc", objItem.NrValorCusto);
            cmd.Parameters.AddWithValue("@sit", objItem.DsSituacao);
            cmd.Parameters.AddWithValue("@ator", objItem.DsAtores);
            cmd.Parameters.AddWithValue("@dir", objItem.DsDiretor);


            cmd.ExecuteNonQuery();

            conn.Close();

       


        }



        public void InserirImagem(Item objItem)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "INSERT INTO TBL_ITEM VALUES (@nmfoto,FOTO_CAPA) SELECT '@nmfoto',* FROM OPENROWSET(BULK N'C:\\Users\\MISL\\FourLoc\\Imagens\\@nmfoto', SINGLE_BLOB) Load;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nmfoto", objItem.NmFotoCapa);
           

            cmd.ExecuteNonQuery();

            conn.Close();


        }

        public Item ObterItem(int cdItem)

        {
            Item item = null;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM TBL_ITEM  AS I JOIN TBL_IMAGEM AS M ON I.CODIGO_F = M.CODIGO_F  WHERE CODIGO_I = @cod";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cod", cdItem);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {

                item = new Item();
                item.CdFilme = cdItem;
                item.DsTitulo = dr["TITULO"].ToString();
                item.NrPreco = Convert.ToDecimal(dr["PRECO"]);
                item.DtAdquirida = Convert.ToDateTime(dr["DT_ADQUIRIDA"]);
                item.NrValorCusto = Convert.ToDecimal(dr["VALOR_CUSTO"]);
                item.DsSituacao = dr["SITUACAO"].ToString();
                item.DsAtores = dr["ATORES_P"].ToString();
                item.DsDiretor = dr["DIRETOR"].ToString();
                item.CdFoto = Convert.ToInt32(dr["CODIGO_F"]);

            }

            conn.Close();

            return item;

        }


        public List<Item> ListarItem()
        {
            List<Item> listaItem = new List<Item>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM TBL_ITEM";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Item objItem;
                while (dr.Read())
                {

                    objItem = new Item();
                    objItem.CdFilme = Convert.ToInt32(dr["CODIGO_I"]);
                    objItem.CdBarras = Convert.ToInt32(dr["CODIGO_B"]);
                    objItem.DsTitulo = dr["TITULO"].ToString();
                    objItem.NrPreco = Convert.ToDecimal(dr["PRECO"]);
                    objItem.DtAdquirida = Convert.ToDateTime(dr["DT_ADQUIRIDA"]);
                    objItem.NrValorCusto = Convert.ToDecimal(dr["VALOR_CUSTO"]);
                    objItem.DsSituacao = dr["SITUACAO"].ToString();
                    objItem.DsAtores = dr["ATORES_P"].ToString();
                    objItem.DsDiretor = dr["DIRETOR"].ToString();
                   

                    listaItem.Add(objItem);
                }

            }

            conn.Close();

            return listaItem;
        }

        public void AtualizarItem(Item objItem)

        {

            SqlConnection conn = new SqlConnection(connectionString);


            conn.Open();

            string sql = "UPDATE TBL_ITEM SET  CODIGO_B = @cdb, TITULO = @tit, PRECO = @preco, DT_ADQUIRIDA = @dta, VALOR_CUSTO = @vlc, SITUACAO = @sit," +
                " ATORES_P = @ator, DIRETOR = @dir WHERE CODIGO_I = @cod";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@cod", objItem.CdFilme);
            cmd.Parameters.AddWithValue("@cdb", objItem.CdBarras);
            cmd.Parameters.AddWithValue("@tit", objItem.DsTitulo);
            cmd.Parameters.AddWithValue("@preco", objItem.NrPreco);
            cmd.Parameters.AddWithValue("@dt_ad", objItem.DtAdquirida);
            cmd.Parameters.AddWithValue("@vlc", objItem.NrValorCusto);
            cmd.Parameters.AddWithValue("@sit", objItem.DsSituacao);
            cmd.Parameters.AddWithValue("@ator", objItem.DsAtores);
            cmd.Parameters.AddWithValue("@dir", objItem.DsDiretor);

            cmd.ExecuteNonQuery();

            conn.Close();

        }


        public void ExcluirItem(int cdItem)

        {

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "DELETE FROM TBL_ITEM WHERE CODIGO_I = @cod";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cod", cdItem);

            cmd.ExecuteNonQuery();


            conn.Close();



        }


        public List<Item> ListarItemFiltros(string cod, string tit)
        {
            List<Item> listaItem = new List<Item>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM TBL_ITEM WHERE CODIGO_I LIKE @cod and TITULO LIKE @tit";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@cod", $"%{cod}%");
            cmd.Parameters.AddWithValue("@tit", $"%{tit}%");

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Item objItem;
                while (dr.Read())
                {


                    objItem = new Item();
                    objItem.CdFilme = Convert.ToInt32(dr["CODIGO_I"]);
                    objItem.CdBarras = Convert.ToInt32(dr["CODIGO_B"]);
                    objItem.DsTitulo = dr["TITULO"].ToString();
                    objItem.NrPreco = Convert.ToDecimal(dr["PRECO"]);
                    objItem.DtAdquirida = Convert.ToDateTime(dr["DT_ADQUIRIDA"]);
                    objItem.NrValorCusto = Convert.ToDecimal(dr["VALOR_CUSTO"]);
                    objItem.DsSituacao = dr["SITUACAO"].ToString();
                    objItem.DsAtores = dr["ATORES_P"].ToString();
                    objItem.DsDiretor = dr["DIRETOR"].ToString();

                    listaItem.Add(objItem);
                }

            }

            conn.Close();

            return listaItem;
        }


        ///////////////////////////////////////////////// GENERO ////////////////////////////////////////////////////////////////////////////

        public void InserirGenero(Item objItem)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "INSERT INTO TBL_GENERO VALUES (@nome)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nome", objItem.DsGenero);



            cmd.ExecuteNonQuery();

            conn.Close();


        }

        public Item ObterGenero(int cdItem)

        {
            Item item = null;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM TBL_GENERO WHERE CODIGO_I = @cod";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cod", cdItem);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {

                item = new Item();
                item.CdGenero = cdItem;
                item.DsTitulo = dr["NOME_G"].ToString();


            }

            conn.Close();

            return item;

        }


        public List<Item> ListarGenero()
        {
            List<Item> listaItem = new List<Item>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM TBL_GENERO";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Item objItem;
                while (dr.Read())
                {

                    objItem = new Item();
                    objItem.CdGenero = Convert.ToInt32(dr["CODIGO_G"]);
                    objItem.DsGenero = dr["NOME_G"].ToString();



                    listaItem.Add(objItem);
                }

            }

            conn.Close();

            return listaItem;
        }

        public void AtualizarGenero(Item objItem)

        {

            SqlConnection conn = new SqlConnection(connectionString);


            conn.Open();

            string sql = "UPDATE TBL_GENERO SET DIRETOR = @dir WHERE CODIGO_G = @cod";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@cod", objItem.CdGenero);
            cmd.Parameters.AddWithValue("@cdb", objItem.DsGenero);


            cmd.ExecuteNonQuery();

            conn.Close();

        }


        public void ExcluirGenero(int cdItem)

        {

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "DELETE FROM TBL_GENERO WHERE CODIGO_G = @cod";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cod", cdItem);

            cmd.ExecuteNonQuery();


            conn.Close();



        }


        public List<Item> ListarGeneroFiltros(string cod, string gen)
        {
            List<Item> listaItem = new List<Item>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM TBL_GENERO WHERE CODIGO_G LIKE @cod and NOME_G LIKE @gen";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@cod", $"%{cod}%");
            cmd.Parameters.AddWithValue("@gen", $"%{gen}%");

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Item objItem;
                while (dr.Read())
                {


                    objItem = new Item();
                    objItem.CdGenero = Convert.ToInt32(dr["CODIGO_G"]);
                    objItem.DsGenero = dr["NOME_G"].ToString();
   

                    listaItem.Add(objItem);
                }

            }

            conn.Close();

            return listaItem;
        }


        ///////////////////////////////////////////////// Locação ////////////////////////////////////////////////////////////////////////////
        public void InserirLocacao(Item objItem, Pessoa objPessoa)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "INSERT INTO TBL_LOCACAO " +
                "SELECT " +
                "" +
                "VALUES (@cdp,@cpf,@nm,@dtl,@dtd,@cdb,@tit,@vll,@vlr,@rec)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@cdp", objPessoa.CdPessoa);
            cmd.Parameters.AddWithValue("@cpf", objPessoa.NrCPF);
            cmd.Parameters.AddWithValue("@nm", objPessoa.NmPessoa);
            cmd.Parameters.AddWithValue("@dtl", objItem.DtLocacao);
            cmd.Parameters.AddWithValue("@dtd", objItem.DtDevolucao);
            cmd.Parameters.AddWithValue("@cdb", objItem.CdBarras);
            cmd.Parameters.AddWithValue("@tit", objItem.DsTitulo);
            cmd.Parameters.AddWithValue("@vll", objItem.Vl_Locacao);
            cmd.Parameters.AddWithValue("@vlr", objItem.Vl_Recebido);
            cmd.Parameters.AddWithValue("@rec", objItem.Recebido);



            cmd.ExecuteNonQuery();

            conn.Close();




        }



       
  public List<Pessoa> ListarLocacaoF()
        {
            List<Pessoa> listaPessoa = new List<Pessoa>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT CODIGO_F FROM TBL_FUNCIONARIOS";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Pessoa objPessoa;
                while (dr.Read())
                {

                    objPessoa = new Pessoa();
                    objPessoa.CdPessoa = Convert.ToInt32(dr["CODIGO_F"]);


                    listaPessoa.Add(objPessoa);
                }

            }

            conn.Close();

            return listaPessoa;

        }


        public List<Item> ListarLocacao()
        {
            List<Item> listaItem = new List<Item>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM TBL_ITEM";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Item objItem;
                while (dr.Read())
                {

                    objItem = new Item();
                    objItem.CdFilme = Convert.ToInt32(dr["CODIGO_I"]);
                    objItem.CdBarras = Convert.ToInt32(dr["CODIGO_B"]);
                    objItem.DsTitulo = dr["TITULO"].ToString();
                    objItem.NrPreco = Convert.ToDecimal(dr["PRECO"]);
                    objItem.DtAdquirida = Convert.ToDateTime(dr["DT_ADQUIRIDA"]);
                    objItem.NrValorCusto = Convert.ToDecimal(dr["VALOR_CUSTO"]);
                    objItem.DsSituacao = dr["SITUACAO"].ToString();
                    objItem.DsAtores = dr["ATORES_P"].ToString();
                    objItem.DsDiretor = dr["DIRETOR"].ToString();


                    listaItem.Add(objItem);
                }

            }

            conn.Close();

            return listaItem;
        }

        public void AtualizarLocacao(Item objItem)

        {

            SqlConnection conn = new SqlConnection(connectionString);


            conn.Open();

            string sql = "UPDATE TBL_ITEM SET  CODIGO_B = @cdb, TITULO = @tit, PRECO = @preco, DT_ADQUIRIDA = @dta, VALOR_CUSTO = @vlc, SITUACAO = @sit," +
                " ATORES_P = @ator, DIRETOR = @dir WHERE CODIGO_I = @cod";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@cod", objItem.CdFilme);
            cmd.Parameters.AddWithValue("@cdb", objItem.CdBarras);
            cmd.Parameters.AddWithValue("@tit", objItem.DsTitulo);
            cmd.Parameters.AddWithValue("@preco", objItem.NrPreco);
            cmd.Parameters.AddWithValue("@dt_ad", objItem.DtAdquirida);
            cmd.Parameters.AddWithValue("@vlc", objItem.NrValorCusto);
            cmd.Parameters.AddWithValue("@sit", objItem.DsSituacao);
            cmd.Parameters.AddWithValue("@ator", objItem.DsAtores);
            cmd.Parameters.AddWithValue("@dir", objItem.DsDiretor);

            cmd.ExecuteNonQuery();

            conn.Close();

        }


        public void ExcluirLocacao(int cdItem)

        {

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "DELETE FROM TBL_ITEM WHERE CODIGO_I = @cod";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cod", cdItem);

            cmd.ExecuteNonQuery();


            conn.Close();



        }


        public List<Item> ListarLocacaoFiltros(string cod, string tit)
        {
            List<Item> listaItem = new List<Item>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM TBL_ITEM WHERE CODIGO_I LIKE @cod and TITULO LIKE @tit";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@cod", $"%{cod}%");
            cmd.Parameters.AddWithValue("@tit", $"%{tit}%");

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Item objItem;
                while (dr.Read())
                {


                    objItem = new Item();
                    objItem.CdFilme = Convert.ToInt32(dr["CODIGO_I"]);
                    objItem.CdBarras = Convert.ToInt32(dr["CODIGO_B"]);
                    objItem.DsTitulo = dr["TITULO"].ToString();
                    objItem.NrPreco = Convert.ToDecimal(dr["PRECO"]);
                    objItem.DtAdquirida = Convert.ToDateTime(dr["DT_ADQUIRIDA"]);
                    objItem.NrValorCusto = Convert.ToDecimal(dr["VALOR_CUSTO"]);
                    objItem.DsSituacao = dr["SITUACAO"].ToString();
                    objItem.DsAtores = dr["ATORES_P"].ToString();
                    objItem.DsDiretor = dr["DIRETOR"].ToString();

                    listaItem.Add(objItem);
                }

            }

            conn.Close();

            return listaItem;
        }

    }
}
