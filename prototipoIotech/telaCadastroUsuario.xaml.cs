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
    /// Lógica interna para telaCadastroUsuario.xaml
    /// </summary>
    public partial class telaCadastroUsuario : Window
    {
        public telaCadastroUsuario()
        {
            InitializeComponent();
        }

        private void VoltarTelaPrincipal(object sender, MouseButtonEventArgs e)
        {
            var abrirTela = new telaPrincipal();
            abrirTela.Show();
            Close();
        }

        private void CadastrarUsuario(object sender, MouseButtonEventArgs e)
        {
            if (VerificaCampos() == true)
            {

                Usuario usuario = cUsuario.NovoUsuario(txtBoxUsuario.Text, txtBoxEmail.Text, txtBoxSenha.Text);
                if (usuario != false)
                {
                    MessageBoxResult result = MessageBox.Show(
                      "Usuário cadastrado com sucesso!",
                      "Atenção",
                      MessageBoxButton.OK,
                      MessageBoxImage.Information);
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

        private void AlterarUsuario(object sender, MouseButtonEventArgs e)
        {

        }

        private bool VerificaCampos()
        {
            if (txtBoxUsuario.Text != "" && txtBoxEmail.Text != "" && txtBoxSenha.Text != "" && txtBoxConfirmarSenha.Text != "")
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
