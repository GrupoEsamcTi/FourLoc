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
    public class DALPessoa
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["BDFourLocConnectionString"].ConnectionString;

    ///////////////////////////////////////////////// FUNCIONARIO ////////////////////////////////////////////////////////////////////////////
        public void InserirFuncionario (Pessoa objPessoa)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "INSERT INTO TBL_FUNCIONARIOS VALUES (@nm,@nasc,@sx,@ec,@rg,@cpf,@end,@cid,@cep,@est,@telefone,@cel,@email,@sta)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nm", objPessoa.NmPessoa);
            cmd.Parameters.AddWithValue("@nasc", objPessoa.DtNascimento);
            cmd.Parameters.AddWithValue("@sx", objPessoa.DsSexo);
            cmd.Parameters.AddWithValue("@ec", objPessoa.DsEstadoCivil);
            cmd.Parameters.AddWithValue("@rg", objPessoa.NrRG);
            cmd.Parameters.AddWithValue("@cpf", objPessoa.NrCPF);
            cmd.Parameters.AddWithValue("@end", objPessoa.DsEndereco);
            cmd.Parameters.AddWithValue("@cid", objPessoa.DsCidade);
            cmd.Parameters.AddWithValue("@cep", objPessoa.DsCEP);
            cmd.Parameters.AddWithValue("@est", objPessoa.DsEstado);
            cmd.Parameters.AddWithValue("@telefone", objPessoa.NrTelefone);
            cmd.Parameters.AddWithValue("@cel", objPessoa.NrCelular);
            cmd.Parameters.AddWithValue("@email", objPessoa.DsEmail);
            cmd.Parameters.AddWithValue("@sta", objPessoa.DsStatus);

            cmd.ExecuteNonQuery();

            conn.Close();


        }

        public Pessoa ObterFuncionario(int cdPessoa)

        {
            Pessoa pessoa = null;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM TBL_FUNCIONARIOS WHERE CODIGO_F = @cod";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cod", cdPessoa);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {

                pessoa = new Pessoa();
                pessoa.CdPessoa = cdPessoa;
                pessoa.NmPessoa = dr["NOME_F"].ToString();
                pessoa.DtNascimento = Convert.ToDateTime(dr["DT_NASC_F"]);
                pessoa.DsSexo = Convert.ToChar(dr["SEXO_F"]);
                pessoa.DsEstadoCivil = Convert.ToChar(dr["ESTADO_CIVIL_F"]);
                pessoa.NrRG = dr["RG_F"].ToString();
                pessoa.NrCPF = dr["CPF_F"].ToString();
                pessoa.DsEndereco = dr["ENDERECO_F"].ToString();
                pessoa.DsCidade = dr["CIDADE_F"].ToString();
                pessoa.DsCEP = dr["CEP_F"].ToString();
                pessoa.DsEstado = dr["ESTADO_F"].ToString();
                pessoa.NrTelefone = dr["TELEFONE_F"].ToString();
                pessoa.NrCelular = dr["CELULAR_F"].ToString();
                pessoa.DsEmail = dr["EMAIL_F"].ToString();
                pessoa.DsStatus = dr["STATUS_F"].ToString();

            }

            conn.Close();

            return pessoa;

        }


        public List<Pessoa> ListarFuncionario()
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT CODIGO_F,NOME_F,CPF_F,STATUS_F FROM TBL_FUNCIONARIOS";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Pessoa objPessoa;
                while (dr.Read())
                {

                    objPessoa = new Pessoa();
                    objPessoa.CdPessoa = Convert.ToInt32(dr["CODIGO_F"]);
                    objPessoa.NmPessoa = dr["NOME_F"].ToString();
                    objPessoa.NrCPF = dr["CPF_F"].ToString();
                    objPessoa.DsStatus = dr["STATUS_F"].ToString();

                    listaPessoas.Add(objPessoa);
                }

            }

            conn.Close();

            return listaPessoas;
        }

        public void AtualizarFuncionario(Pessoa objPessoa)

        {

            SqlConnection conn = new SqlConnection(connectionString);


            conn.Open();

            string sql = "UPDATE TBL_FUNCIONARIOS SET  NOME_F = @Nome, DT_NASC_F = @nasc, SEXO_F = @sexo, ESTADO_CIVIL_F = @ec, RG_F = @rg, CPF_F = @cpf," +
                " ENDERECO_F = @end, CIDADE_F = @cid, CEP_F = @cep, ESTADO_F = @est, TELEFONE_F = @telefone,CELULAR_F = @cel, EMAIL_F = @email," +
                " STATUS_F = @sta WHERE CODIGO_F = @cod";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@cod", objPessoa.CdPessoa);
            cmd.Parameters.AddWithValue("@Nome", objPessoa.NmPessoa);
            cmd.Parameters.AddWithValue("@nasc", objPessoa.DtNascimento);
            cmd.Parameters.AddWithValue("@sexo", objPessoa.DsSexo);
            cmd.Parameters.AddWithValue("@ec", objPessoa.DsEstadoCivil);
            cmd.Parameters.AddWithValue("@rg", objPessoa.NrRG);
            cmd.Parameters.AddWithValue("@cpf", objPessoa.NrCPF);
            cmd.Parameters.AddWithValue("@end", objPessoa.DsEndereco);
            cmd.Parameters.AddWithValue("@cid", objPessoa.DsCidade);
            cmd.Parameters.AddWithValue("@cep", objPessoa.DsCEP);
            cmd.Parameters.AddWithValue("@est", objPessoa.DsEstado);
            cmd.Parameters.AddWithValue("@telefone", objPessoa.NrTelefone);
            cmd.Parameters.AddWithValue("@cel", objPessoa.NrCelular);
            cmd.Parameters.AddWithValue("@email", objPessoa.DsEmail);
            cmd.Parameters.AddWithValue("@sta", objPessoa.DsStatus);

            cmd.ExecuteNonQuery();

            conn.Close();

        }


        public void ExcluirFuncionario(int cdPessoa)

        {

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "DELETE FROM TBL_FUNCIONARIOS WHERE CODIGO_F = @cod";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cod", cdPessoa);

            cmd.ExecuteNonQuery();


            conn.Close();



        }


        public List<Pessoa> ListarFuncionarioFiltros(string cod, string cpf)
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM TBL_FUNCIONARIOS WHERE CODIGO_F LIKE @cod and CPF_F LIKE @cpf";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@cod", $"%{cod}%");
            cmd.Parameters.AddWithValue("@cpf", $"%{cpf}%");

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Pessoa objPessoa;
                while (dr.Read())
                {


                    objPessoa = new Pessoa();
                    objPessoa.CdPessoa = Convert.ToInt32(dr["CODIGO_F"]);
                    objPessoa.NmPessoa = dr["NOME_F"].ToString();
                    objPessoa.DtNascimento = Convert.ToDateTime(dr["DT_NASC_F"]);
                    objPessoa.DsSexo = Convert.ToChar(dr["SEXO_F"]);
                    objPessoa.DsEstadoCivil = Convert.ToChar(dr["ESTADO_CIVIL_F"]);
                    objPessoa.NrRG = dr["RG_F"].ToString();
                    objPessoa.NrCPF = dr["CPF_C"].ToString();
                    objPessoa.DsEndereco = dr["ENDERECO_F"].ToString();
                    objPessoa.DsCidade = dr["CIDADE_F"].ToString();
                    objPessoa.DsCEP = dr["CEP_F"].ToString();
                    objPessoa.DsEstado = dr["ESTADO_F"].ToString();
                    objPessoa.NrTelefone = dr["TELEFONE_F"].ToString();
                    objPessoa.NrCelular = dr["CELULAR_F"].ToString();
                    objPessoa.DsEmail = dr["EMAIL_F"].ToString();
                    objPessoa.DsStatus = dr["STATUS_F"].ToString();

                    listaPessoas.Add(objPessoa);
                }

            }

            conn.Close();

            return listaPessoas;
        }

        //////////////////////////////////////////////////////////////////// CLIENTE ///////////////////////////////////////////////////////////////////

        public void InserirCliente(Pessoa objPessoa)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "INSERT INTO TBL_CLIENTES VALUES (@Nome,@nasc,@sexo,@ec,@rg,@cpf,@end,@cid,@cep,@est,@telefone,@cel,@email,@sta)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Nome", objPessoa.NmPessoa);
            cmd.Parameters.AddWithValue("@nasc", objPessoa.DtNascimento);
            cmd.Parameters.AddWithValue("@sexo", objPessoa.DsSexo);
            cmd.Parameters.AddWithValue("@ec", objPessoa.DsEstadoCivil);
            cmd.Parameters.AddWithValue("@rg", objPessoa.NrRG);
            cmd.Parameters.AddWithValue("@cpf", objPessoa.NrCPF);
            cmd.Parameters.AddWithValue("@end", objPessoa.DsEndereco);
            cmd.Parameters.AddWithValue("@cid", objPessoa.DsCidade);
            cmd.Parameters.AddWithValue("@cep", objPessoa.DsCEP);
            cmd.Parameters.AddWithValue("@est", objPessoa.DsEstado);
            cmd.Parameters.AddWithValue("@telefone", objPessoa.NrTelefone);
            cmd.Parameters.AddWithValue("@cel", objPessoa.NrCelular);
            cmd.Parameters.AddWithValue("@email", objPessoa.DsEmail);
            cmd.Parameters.AddWithValue("@sta", objPessoa.DsStatus);

            cmd.ExecuteNonQuery();

            conn.Close();


        }

        public Pessoa ObterCliente(int cdPessoa)

        {
            Pessoa pessoa = null;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM TBL_CLIENTES WHERE CODIGO_C = @cod";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cod", cdPessoa);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {

                pessoa = new Pessoa();
                pessoa.CdPessoa = cdPessoa;
                pessoa.NmPessoa = dr["NOME_C"].ToString();
                pessoa.DtNascimento = Convert.ToDateTime(dr["DT_NASC_C"]);
                pessoa.DsSexo = Convert.ToChar(dr["SEXO_C"]);
                pessoa.DsEstadoCivil = Convert.ToChar(dr["ESTADO_CIVIL_C"]);
                pessoa.NrRG = dr["RG_C"].ToString();
                pessoa.NrCPF = dr["CPF_C"].ToString();
                pessoa.DsEndereco = dr["ENDERECO_C"].ToString();
                pessoa.DsCidade = dr["CIDADE_C"].ToString();
                pessoa.DsCEP = dr["CEP_C"].ToString();
                pessoa.DsEstado = dr["ESTADO_C"].ToString();
                pessoa.NrTelefone = dr["TELEFONE_C"].ToString();
                pessoa.NrCelular = dr["CELULAR_C"].ToString();
                pessoa.DsEmail = dr["EMAIL_C"].ToString();
                pessoa.DsStatus = dr["STATUS_C"].ToString();

            }

            conn.Close();

            return pessoa;

        }


        public List<Pessoa> ListarCliente()
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM TBL_CLIENTES";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Pessoa objPessoa;
                while (dr.Read())
                {



                    objPessoa = new Pessoa();
                    objPessoa.CdPessoa = Convert.ToInt32(dr["CODIGO_C"]);
                    objPessoa.NmPessoa = dr["NOME_C"].ToString();
                    objPessoa.DtNascimento = Convert.ToDateTime(dr["DT_NASC_C"]);
                    objPessoa.DsSexo = Convert.ToChar(dr["SEXO_C"]);
                    objPessoa.DsEstadoCivil = Convert.ToChar(dr["ESTADO_CIVIL_C"]);
                    objPessoa.NrRG = dr["RG_C"].ToString();
                    objPessoa.NrCPF = dr["CPF_C"].ToString();
                    objPessoa.DsEndereco = dr["ENDERECO_C"].ToString();
                    objPessoa.DsCidade = dr["CIDADE_C"].ToString();
                    objPessoa.DsCEP = dr["CEP_C"].ToString();
                    objPessoa.DsEstado = dr["ESTADO_C"].ToString();
                    objPessoa.NrTelefone = dr["TELEFONE_C"].ToString();
                    objPessoa.NrCelular = dr["CELULAR_C"].ToString();
                    objPessoa.DsEmail = dr["EMAIL_C"].ToString();
                    objPessoa.DsStatus = dr["STATUS_C"].ToString();

                    listaPessoas.Add(objPessoa);
                }

            }

            conn.Close();

            return listaPessoas;
        }

        public void AtualizarCliente(Pessoa objPessoa)

        {

            SqlConnection conn = new SqlConnection(connectionString);


            conn.Open();

            string sql = "UPDATE TBL_CLIENTES SET NOME_C = @Nome, DT_NASC_C = @nasc, SEXO_C = @sexo, ESTADO_CIVIL_C = @ec, RG_C = @rg, CPF_C = @cpf, ENDERECO_C = @end, CIDADE_C = @cid, CEP_C = @cep, ESTADO_C = @est, TELEFONE_C = @telefone, CELULAR_C = @cel, EMAIL_C = @email, STATUS_C = @sta WHERE CODIGO_C = @cod";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@cod", objPessoa.CdPessoa);
            cmd.Parameters.AddWithValue("@Nome", objPessoa.NmPessoa);
            cmd.Parameters.AddWithValue("@nasc", objPessoa.DtNascimento);
            cmd.Parameters.AddWithValue("@sexo", objPessoa.DsSexo);
            cmd.Parameters.AddWithValue("@ec", objPessoa.DsEstadoCivil);
            cmd.Parameters.AddWithValue("@rg", objPessoa.NrRG);
            cmd.Parameters.AddWithValue("@cpf", objPessoa.NrCPF);
            cmd.Parameters.AddWithValue("@end", objPessoa.DsEndereco);
            cmd.Parameters.AddWithValue("@cid", objPessoa.DsCidade);
            cmd.Parameters.AddWithValue("@cep", objPessoa.DsCEP);
            cmd.Parameters.AddWithValue("@est", objPessoa.DsEstado);
            cmd.Parameters.AddWithValue("@telefone", objPessoa.NrTelefone);
            cmd.Parameters.AddWithValue("@cel", objPessoa.NrCelular);
            cmd.Parameters.AddWithValue("@email", objPessoa.DsEmail);
            cmd.Parameters.AddWithValue("@sta", objPessoa.DsStatus);

            cmd.ExecuteNonQuery();

            conn.Close();

        }


        public void ExcluirCliente(int cdPessoa)

        {

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "DELETE FROM TBL_CLIENTES WHERE CODIGO_C = @cod";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cod", cdPessoa);

            cmd.ExecuteNonQuery();


            conn.Close();



        }


        public List<Pessoa> ListarClienteFiltros(string cod, string cpf)
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM TBL_CLIENTES WHERE CODIGO_C LIKE @cod and CPF_C LIKE @cpf";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@cod", $"%{cod}%");
            cmd.Parameters.AddWithValue("@cpf", $"%{cpf}%");

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Pessoa objPessoa;
                while (dr.Read())
                {


                    objPessoa = new Pessoa();
                    objPessoa.CdPessoa = Convert.ToInt32(dr["CODIGO_C"]);
                    objPessoa.NmPessoa = dr["NOME_C"].ToString();
                    objPessoa.DtNascimento = Convert.ToDateTime(dr["DT_NASC_C"]);
                    objPessoa.DsSexo = Convert.ToChar(dr["SEXO_C"]);
                    objPessoa.DsEstadoCivil = Convert.ToChar(dr["ESTADO_CIVIL_C"]);
                    objPessoa.NrRG = dr["RG_C"].ToString();
                    objPessoa.NrCPF = dr["CPF_C"].ToString();
                    objPessoa.DsEndereco = dr["ENDERECO_C"].ToString();
                    objPessoa.DsCidade = dr["CIDADE_C"].ToString();
                    objPessoa.DsCEP = dr["CEP_C"].ToString();
                    objPessoa.DsEstado = dr["ESTADO_C"].ToString();
                    objPessoa.NrTelefone = dr["TELEFONE_C"].ToString();
                    objPessoa.NrCelular = dr["CELULAR_C"].ToString();
                    objPessoa.DsEmail = dr["EMAIL_C"].ToString();
                    objPessoa.DsStatus = dr["STATUS_C"].ToString();

                    listaPessoas.Add(objPessoa);
                }

            }

            conn.Close();

            return listaPessoas;
        }



        ///////////////////////////////////////////////// ARTISTA E DIRETOR ///////////////////////////////////////////////////////////



        public void InserirArtista(Pessoa objPessoa)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "INSERT INTO TBL_ARTISTA VALUES (@Nome,@nasc,@pais,@tipo)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Nome", objPessoa.NmPessoa);
            cmd.Parameters.AddWithValue("@nasc", objPessoa.DtNascimento);
            cmd.Parameters.AddWithValue("@pais", objPessoa.DsPais);
            cmd.Parameters.AddWithValue("@tipo", objPessoa.DsTipo);


            cmd.ExecuteNonQuery();

            conn.Close();


        }

        public Pessoa ObterArtista(int  CdPessoa)

        {
            Pessoa pessoa = null;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM TBL_ARTISTA WHERE CODIGO_A = @cod";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cod", CdPessoa);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {

                pessoa = new Pessoa();
                pessoa.CdPessoa = Convert.ToInt32(dr["CODIGO_A"]);
                pessoa.NmPessoa = dr["NOME_A"].ToString();
                pessoa.DtNascimento = Convert.ToDateTime(dr["DT_NASC"]);
                pessoa.DsPais = dr["PAIS_NASC"].ToString();
                pessoa.DsTipo = dr["TIPO_A"].ToString();


            }

            conn.Close();

            return pessoa;

        }


        public List<Pessoa> ListarArtista()
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM TBL_ARTISTA";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Pessoa objPessoa;
                while (dr.Read())
                {



                    objPessoa = new Pessoa();
                    objPessoa.CdPessoa = Convert.ToInt32(dr["CODIGO_C"]);
                    objPessoa.NmPessoa = dr["NOME_C"].ToString();
                    objPessoa.DtNascimento = Convert.ToDateTime(dr["DT_NASC"]);
                    objPessoa.DsPais = dr["PAIS_NASC"].ToString();
                    objPessoa.DsTipo = dr["TIPO_A"].ToString();


                    listaPessoas.Add(objPessoa);
                }

            }

            conn.Close();

            return listaPessoas;
        }

        public void AtualizarArtista(Pessoa objPessoa)

        {

            SqlConnection conn = new SqlConnection(connectionString);


            conn.Open();

            string sql = "UPDATE TBL_ARTISTA SET NOME_A = @Nome, DT_NASC = @nasc, PAIS_NASC = @pais, TIPO_A = @tipo WHERE CODIGO_A = @cod";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@cod", objPessoa.CdPessoa);
            cmd.Parameters.AddWithValue("@Nome", objPessoa.NmPessoa);
            cmd.Parameters.AddWithValue("@nasc", objPessoa.DtNascimento);
            cmd.Parameters.AddWithValue("@pais", objPessoa.DsPais);
            cmd.Parameters.AddWithValue("@tipo", objPessoa.DsTipo);


            cmd.ExecuteNonQuery();

            conn.Close();

        }


        public void ExcluirArtista(int cdPessoa)

        {

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "DELETE FROM TBL_ARTISTA WHERE CODIGO_A = @cod";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cod", cdPessoa);

            cmd.ExecuteNonQuery();


            conn.Close();



        }


        public List<Pessoa> ListarArtistaFiltros(string pais, string nome)
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM TBL_ARTISTA WHERE PAIS_NASC LIKE @pais and NOME_A LIKE @nome";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@pais", $"%{pais}%");
            cmd.Parameters.AddWithValue("@nome", $"%{nome}%");

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Pessoa objPessoa;
                while (dr.Read())
                {


                    objPessoa = new Pessoa();
                    objPessoa.CdPessoa = Convert.ToInt32(dr["CODIGO_A"]);
                    objPessoa.NmPessoa = dr["NOME_A"].ToString();
                    objPessoa.DtNascimento = Convert.ToDateTime(dr["DT_NASC"]);
                    objPessoa.DsPais = dr["PAIS_NASC"].ToString();
                    objPessoa.DsTipo = dr["TIPO_A"].ToString();


                    listaPessoas.Add(objPessoa);
                }

            }

            conn.Close();

            return listaPessoas;
        }






    }
}
