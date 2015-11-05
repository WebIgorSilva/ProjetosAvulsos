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
    public partial class PanoramaPageCadastro : PhoneApplicationPage
    {
        public PanoramaPageCadastro()
        {
            InitializeComponent();
        }

        private void CadastrarButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show ("Usuário cadastrado com sucesso!");
            NavigationService.Navigate(new Uri("/PanoramaPageVagas.xaml", UriKind.Relative));
        }
    }
}