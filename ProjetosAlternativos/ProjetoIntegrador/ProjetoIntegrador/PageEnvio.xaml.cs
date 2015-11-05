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
    public partial class PageEnvio : PhoneApplicationPage
    {
        public PageEnvio()
        {
            InitializeComponent();
        }

        private void EnviarButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Currículo cadastrado com sucesso!");
            NavigationService.Navigate(new Uri("/PanoramaPageVagas.xaml", UriKind.Relative));
        }
    }
}