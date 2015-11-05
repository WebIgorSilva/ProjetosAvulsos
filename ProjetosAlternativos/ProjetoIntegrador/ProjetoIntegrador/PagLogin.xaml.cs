using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace ProjetoIntegrador
{
    public partial class PagLogin : PhoneApplicationPage
    {
        public PagLogin()
        {
            InitializeComponent();
        }

        private void EntrarButton_Click(object sender, RoutedEventArgs e)
        {
            
            NavigationService.Navigate(new Uri("/PanoramaPageVagas.xaml", UriKind.Relative));
        }

        private void Limpar ()
        {
            LoginTextBox.Text = "";
            SenhaPasswordBox.Password = "";
            
        }

        private void LimparButton_Click(object sender, RoutedEventArgs e)
        {
            Limpar();
        }

        private void CadastroHyperLink_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PanoramaPageCadastro.xaml", UriKind.Relative));
        }
    }
}