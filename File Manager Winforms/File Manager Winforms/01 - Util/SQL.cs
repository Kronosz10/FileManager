using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Manager_Winforms._01___Util
{
    public class SQL
    {
        public SqlConnection conn { get; set; }
        public SqlTransaction sqlTransaction { get; set; }
        public SqlCommand command { get; set; }
        public SqlDataAdapter dataAdapter { get; set; }
        
        public SQL()
        {
            conn = new SqlConnection(File_Manager_Winforms.Properties.Settings.Default.Main);

        }

        public void AbrirConexao()
        {
            FecharConexao();

            conn.Open();
            
        }

        public DataSet Select(string query)
        {
            DataSet ds = new DataSet();
            try
            {
                AbrirConexao();

                dataAdapter = new SqlDataAdapter(query, conn);
                dataAdapter.Fill(ds);

                FecharConexao();

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message + "/r/t" + ex.StackTrace, "ERRO!");
                return null;
            }

        }

        public bool Executar(string query)
        {
            try
            {
                AbrirConexao();

                sqlTransaction = conn.BeginTransaction("ExecutarComando");

                command = new SqlCommand(query, conn, sqlTransaction);

                command.ExecuteNonQuery();

                FecharConexao();

                sqlTransaction.Commit();

                return true;
            }
            catch (Exception ex)
            {
                if(sqlTransaction != null)
                {
                    sqlTransaction.Rollback();
                }

                MessageBox.Show("Erro: " + ex.Message + "/r/t" + ex.StackTrace, "ERRO!");
                return false;
            }

        }

        public bool Importar_Arquivo(string caminhoArquivo)
        {
            string query = "INSERT INTO TB_ARQUIVOS (ARQUIVO, NOME_ARQUIVO, TAMANHO_ARQUIVO, DATA_IMPORTACAO, USUARIO_IMPORTACAO) VALUES (@dadosArquivo, @nomeArquivo, @tamanhoArquivo, GETDATE(), 'GABRIEL')";

            try
            {
                byte[] dadosArquivo = File.ReadAllBytes(caminhoArquivo);

                FileInfo info = new FileInfo(caminhoArquivo);

                string nomeArquivo = info.Name;

                long tamanhoArquivo = info.Length;

                AbrirConexao();

                sqlTransaction = conn.BeginTransaction("ExecutarComando");

                command = new SqlCommand(query, conn, sqlTransaction);

                command.Parameters.Add("@nomeArquivo", SqlDbType.VarChar).Value = nomeArquivo;
                command.Parameters.Add("@tamanhoArquivo", SqlDbType.BigInt).Value = tamanhoArquivo;
                command.Parameters.Add("@dadosArquivo", SqlDbType.VarBinary).Value = dadosArquivo;

                command.ExecuteNonQuery();

                sqlTransaction.Commit();
                FecharConexao();

                return true;
            }
            catch (Exception ex)
            {
                if (sqlTransaction != null)
                {
                    sqlTransaction.Rollback();
                }

                MessageBox.Show("Erro: " + ex.Message + "/r/t" + ex.StackTrace, "ERRO!");
                return false;
            }

        }

        public void FecharConexao()
        {
            if(conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
