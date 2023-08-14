using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Globais
{
    public class RepositUser
    {
        public static DataTable consulta(string sql)
        {
            SqlDataAdapter msdAdapter = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = DataConnection.ConexaoBanco();
                if (vcon == null)
                {
                    MessageBox.Show("Não foi possivel estabelecer a conexão com o banco de dados.\r\n" +
                        "Verifique o arquivo de configuração do banco ou entre em contato com o Suporte.", "Atenção!");

                    return null;
                }
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                msdAdapter = new SqlDataAdapter(cmd.CommandText, vcon);
                msdAdapter.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        // FUNÇÕES DA TELA NOVO USER
        //public static void NovoUsuario(Usuario user)
        //{
        //    if (existeUserName(user))
        //    {
        //        MessageBox.Show("Username já existe!");
        //        return;
        //    }
        //    try
        //    {
        //        var vcon = DataConnection.ConexaoBanco();
        //        var cmd = vcon.CreateCommand();
        //        cmd.CommandText = "INSERT INTO usuarios (nome_user, username, senha_user, status_user, nivel_user) VALUES (@nome, @username, @password, @status, @nivel)";

        //        cmd.Parameters.AddWithValue("@nome", user.nome);
        //        cmd.Parameters.AddWithValue("@username", user.username);
        //        cmd.Parameters.AddWithValue("@password", user.password);
        //        cmd.Parameters.AddWithValue("@status", user.status);
        //        cmd.Parameters.AddWithValue("@nivel", user.nivel);

        //        cmd.ExecuteNonQuery();

        //        MessageBox.Show("Novo Usuário Cadastrado!");
        //        vcon.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erro ao gravar novo usuário!" + ex);
        //    }
        //}

        public static async Task<int> NovoUsuario(Usuario user)
        {
            if (existeUserName(user))
            {
                MessageBox.Show("Username já existe!");
                return -1; // Ou outro valor que indique erro
            }
            try
            {
                var vcon = DataConnection.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO usuarios (nome_user, username, senha_user, status_user, nivel_user) VALUES (@nome, @username, @password, @status, @nivel)";

                cmd.Parameters.AddWithValue("@nome", user.nome);
                cmd.Parameters.AddWithValue("@username", user.username);
                cmd.Parameters.AddWithValue("@password", user.password);
                cmd.Parameters.AddWithValue("@status", user.status);
                cmd.Parameters.AddWithValue("@nivel", user.nivel);

                await cmd.ExecuteNonQueryAsync();

                cmd.CommandText = "SELECT @@IDENTITY"; // Consulta para obter o último ID inserido
                int newUserId = Convert.ToInt32(await cmd.ExecuteScalarAsync());

                MessageBox.Show("Novo Usuário Cadastrado!");
                vcon.Close();

                return newUserId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar novo usuário!" + ex);
                return -1; 
            }
        }



        public static bool existeUserName(Usuario user)
        {
            bool res;
            SqlDataAdapter msdAdapter = null;
            DataTable dt = new DataTable();

            var vcon = DataConnection.ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT username FROM usuarios WHERE username='" + user.username + "'";
            msdAdapter = new SqlDataAdapter(cmd.CommandText, vcon);
            msdAdapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            vcon.Close();
            return res;
        }
        // FIM DAS FUNÇÕES TELA NOVO USER
        //
        //
        //
        // FUNÇÕES DA TELA GESTÃO DE USUARIOS

        public static DataTable ObterUsuariosIdNome()
        {
            SqlDataAdapter msdAdapter = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = DataConnection.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT id_user as 'ID Usuário', nome_user as 'Nome Usuário' FROM usuarios";
                msdAdapter = new SqlDataAdapter(cmd.CommandText, vcon);
                msdAdapter.Fill(dt);
                vcon.Close();

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static DataTable ObterDadosUsuarios(string id)
        {
            SqlDataAdapter msdAdapter = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = DataConnection.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM usuarios WHERE id_user =" + id;
                msdAdapter = new SqlDataAdapter(cmd.CommandText, vcon);
                msdAdapter.Fill(dt);
                vcon.Close();

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void AtualizarDadosUsuario(Usuario u)
        {
            SqlDataAdapter msdAdapter = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = DataConnection.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE usuarios SET nome_user='" + u.nome + "', username='" + u.username + "', senha_user='" + u.password + "', status_user='" + u.status + "', nivel_user=" + u.nivel + " WHERE id_user=" + u.id;

                msdAdapter = new SqlDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static void ExcluirDadosUsuario(string id)
        {
            SqlDataAdapter msdAdapter = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = DataConnection.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM usuarios WHERE id_user=" + id;

                msdAdapter = new SqlDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

