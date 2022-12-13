using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ConsultasUsuario
{
    public static bool CadastrarUsuario(string nome, string email, string senha)
    {
        var conexao = new MySqlConnection(ConexaoBD.Connection.ConnectionString);
        bool usuarioCadastrado = false;
        string senhaCriptografada = Criptografia.CriptografarMD5(senha);

        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"INSERT INTO Usuario(nome, email, senha)
                                    VALUES (@usuario,@email,@senha)";
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@senha", senhaCriptografada);
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

    public static bool AlterarUsuario(string nome, string email, string senha, bool tipoUsuario)
    {
        var conexao = new MySqlConnection(ConexaoBD.Connection.ConnectionString);
        bool usuarioAlterado = false;

        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"
                        UPDATE Usuario
                        SET nome = @usuario, email = @email, senha = @senha
                        WHERE id = @id";
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@senha", senha);
            var leitura = comando.ExecuteReader();
            usuarioAlterado = true;

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

        return usuarioAlterado;
    }
    public static bool VerificarUsuarioExistente(string nome)
    {
        var conexao = new MySqlConnection(ConexaoBD.Connection.ConnectionString);
        bool usuarioExiste = false;

        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"Select * from Usuario Where nome = @nome";
            comando.Parameters.AddWithValue("@nome", nome);
            var leitura = comando.ExecuteReader(); 
            while (leitura.Read())
            {
                usuarioExiste = true;
                break;
            }
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

        return usuarioExiste;
    }

    public static Usuario ObterUsuarioPeloNomeSenha(string nome, string senha)
    {
        var conexao = new MySqlConnection(ConexaoBD.Connection.ConnectionString);
        Usuario usuario = null;
        //string senhaCriptografada = Criptografia.CriptografarMD5(senha);

        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"Select * from Usuario Where nome = @nome and senha = @senha";
            comando.Parameters.AddWithValue("@senha", senha);
            comando.Parameters.AddWithValue("@nome", nome);
            var leitura = comando.ExecuteReader();

            while (leitura.Read())
            {
                usuario = new Usuario();
                usuario.id = leitura.GetInt32("id");
                usuario.nome = leitura.GetString("nome");
                usuario.senha = leitura.GetString("senha");
                break;
            }
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

        return usuario;
    }
}


