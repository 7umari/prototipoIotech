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
            MessageBox.Show("Adiministrador contatado.", "Atenção!", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
