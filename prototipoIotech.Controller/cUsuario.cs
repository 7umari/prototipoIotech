using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class cUsuario
{
    public static bool VerificarUsuarioExistente(string nome)
    {
        return ConsultasUsuario.VerificarUsuarioExistente(nome);
    }

    public static bool NovoUsuario(string nome, string email, string senha)
    {
        return ConsultasUsuario.CadastrarUsuario(nome, email, senha);
    }

    public static Usuario ObterUsuarioPeloNomeSenha(string nome, string senha)
    {
        return ConsultasUsuario.ObterUsuarioPeloNomeSenha(nome, senha);
    }
}