using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class cUsuario
{
    public static bool VerificarUsuarioExistente(string email)
    {
        return ConsultasUsuario.VerificarUsuarioExistente(email);
    }

    public static bool NovoUsuario(string usuario, string email, string senha, bool tipoUsuario)
    {
        return ConsultasUsuario.CadastrarUsuario(usuario, email, senha, tipoUsuario);
    }

    public static Usuario ObterUsuarioPeloEmailSenha(string email, string senha)
    {
        return ConsultasUsuario.ObterUsuarioPeloEmailSenha(email, senha);
    }
}