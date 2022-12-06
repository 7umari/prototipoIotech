using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ConsultasUsuario
{
    public static bool CadastrarUsuario(string usuario, string email, string senha, bool tipoUsuario)
    {
        var conexao = new MySqlConnection(ConexaoBD.Connection.ConnectionString);
        bool usuarioCadastrado = false;

        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"INSERT INTO Usuario(usuario, email, senha, tipoUsuario)
                                    VALUES (@usuario,@email,@senha,@tipoUsuario)";
            comando.Parameters.AddWithValue("@nome", usuario);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@senha", senha);
            comando.Parameters.AddWithValue("@tipoUsuario", tipoUsuario);
            var leitura = comando.ExecuteReader();
            usuarioCadastrado = true;

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            if(conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }

        return usuarioCadastrado;
    }

    public static bool ExcluirUsuario(int id)
    {
        var conexao = new MySqlConnection(ConexaoBD.Connection.ConnectionString);
        bool usuarioExcluido = false;

        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"DELETE FROM Usuario WHERE id = @id;";
            comando.Parameters.AddWithValue("@id", id);
            var leitura = comando.ExecuteReader();
            usuarioExcluido = true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }

        return usuarioExcluido;
    }
}

