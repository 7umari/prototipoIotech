using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace prototipoIotech.View
{
    /// <summary>
    /// Lógica interna para telaLogin.xaml
    /// </summary>
    public partial class telaLogin : Window
    {
        public telaLogin()
        {
            InitializeComponent();
        }



        private void AlterarSenha(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Adiministrador contatado.",
                            "Atenção!",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
        }

        private void EntrarNoApp(object sender, RoutedEventArgs e)
        {
            FazerLogin(textBoxUsuarioLogin.Text, passwordSenhaLogin.Password);
            
            if(VerificaCampos() == false) 
            {
                MessageBoxResult result = MessageBox.Show(
                        "Preencha todos os campos!",
                        "Atenção",
                        MessageBoxButton.OK,
                        MessageBoxImage.Warning);
            }
        }
        private void FazerLogin(string nome, string senha)
        {
            if (VerificaCampos() == true)
            {

                Usuario usuario = cUsuario.ObterUsuarioPeloNomeSenha(nome, senha);
                if (usuario != null)
                {
                    var frmTelaPrincipal = new telaPrincipal();
                    frmTelaPrincipal.Show();
                    Close();
                }

                else
                {
                    MessageBoxResult result = MessageBox.Show(
                        "Usuário ou senha incorretos!",
                        "Atenção",
                        MessageBoxButton.OK,
                        MessageBoxImage.Warning);
                }

            }
        }


        private bool VerificaCampos()
        {
            if (textBoxUsuarioLogin.Text != "" && passwordSenhaLogin.Password != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }


    }
}
