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
    /// Lógica interna para telaPrincipal.xaml
    /// </summary>
    public partial class telaPrincipal : Window
    {
        public telaPrincipal()
        {
            InitializeComponent();
        }

        private void ProximaTela(object sender, MouseButtonEventArgs e)
        {
            objRetalguloLuzesDacasa1.Visibility = Visibility.Hidden;
            objRetalguloLuzesDacasa2.Visibility = Visibility.Hidden;
            textLuzesCasa.Visibility = Visibility.Hidden;
            btnLed1.Visibility = Visibility.Hidden;
            btnLed2.Visibility = Visibility.Hidden;
            btnLed3.Visibility = Visibility.Hidden;
            btnLed4.Visibility = Visibility.Hidden;
            objRetalguloPorta1.Visibility = Visibility.Hidden;
            objRetalguloPorta2.Visibility = Visibility.Hidden;
            btnAbrirPorta.Visibility = Visibility.Hidden;

            btnProximaTela.Visibility = Visibility.Hidden;

            btnVoltarTela.Visibility = Visibility.Visible;
            objRetalguloLCD1.Visibility = Visibility.Visible;
            objRetalguloLCD2.Visibility = Visibility.Visible;
            objRetalguloBuzzer1.Visibility = Visibility.Visible;
            objRetalguloBuzzer2.Visibility = Visibility.Visible;
            objRetalguloSensor1.Visibility = Visibility.Visible;
            objRetalguloSensor2.Visibility = Visibility.Visible;
            btnBuzzer.Visibility = Visibility.Visible;
            btnLCD.Visibility = Visibility.Visible;
            btnSensor.Visibility = Visibility.Visible;

        }

        private void AbrirMenu(object sender, MouseButtonEventArgs e)
        {
            objTelaMenu.Visibility = Visibility.Visible;
            btnConectarCasa.Visibility = Visibility.Visible;
            btnVoltarMenu.Visibility = Visibility.Visible;
            btnSairConta.Visibility = Visibility.Visible;
            btnCriarUsuario.Visibility = Visibility.Visible;
            imgLogoSemTexto.Visibility = Visibility.Visible;
            btnExcluirUsuario.Visibility = Visibility.Visible;
        }

        private void VoltarMenu(object sender, MouseButtonEventArgs e)
        {
            objTelaMenu.Visibility = Visibility.Hidden;
            btnConectarCasa.Visibility = Visibility.Hidden;
            btnVoltarMenu.Visibility = Visibility.Hidden;
            btnSairConta.Visibility = Visibility.Hidden;
            btnCriarUsuario.Visibility = Visibility.Hidden;
            imgLogoSemTexto.Visibility = Visibility.Hidden;
            btnExcluirUsuario.Visibility= Visibility.Hidden;
        }


        private void VoltarTela(object sender, MouseButtonEventArgs e)
        {
            objRetalguloLuzesDacasa1.Visibility = Visibility.Visible;
            objRetalguloLuzesDacasa2.Visibility = Visibility.Visible;
            textLuzesCasa.Visibility = Visibility.Visible;
            btnLed1.Visibility = Visibility.Visible;
            btnLed2.Visibility = Visibility.Visible;
            btnLed3.Visibility = Visibility.Visible;
            btnLed4.Visibility = Visibility.Visible;
            objRetalguloPorta1.Visibility = Visibility.Visible;
            objRetalguloPorta2.Visibility = Visibility.Visible;
            btnAbrirPorta.Visibility = Visibility.Visible;

            btnProximaTela.Visibility = Visibility.Visible;

            btnVoltarTela.Visibility = Visibility.Hidden;
            objRetalguloLCD1.Visibility = Visibility.Hidden;
            objRetalguloLCD2.Visibility = Visibility.Hidden;
            objRetalguloBuzzer1.Visibility = Visibility.Hidden;
            objRetalguloBuzzer2.Visibility = Visibility.Hidden;
            objRetalguloSensor1.Visibility = Visibility.Hidden;
            objRetalguloSensor2.Visibility = Visibility.Hidden;
            btnBuzzer.Visibility = Visibility.Hidden;
            btnLCD.Visibility = Visibility.Hidden;
            btnSensor.Visibility = Visibility.Hidden;
        }

        private void SairDaConta(object sender, MouseButtonEventArgs e)
        {
            var abrirTela = new telaLogin();
            abrirTela.Show();
            Close();
        }

        private void AbrirTelaConectarCasa(object sender, MouseButtonEventArgs e)
        {
            var abrirTela = new ConectarCasa();
            abrirTela.Show();
            Close();
        }

        private void AbrirCadastro(object sender, MouseButtonEventArgs e)
        {
            var abrirTela = new telaCadastroUsuario();
            abrirTela.Show();
            Close();
        }

        private void AbrirTelaExcluir(object sender, MouseButtonEventArgs e)
        {
            var abrirTela = new telaExcluirUsuario();
            abrirTela.Show();
            Close();
        }
    }
}
