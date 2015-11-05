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
    public partial class PivotPageDetalheVaga : PhoneApplicationPage
    {
        public PivotPageDetalheVaga()
        {
            InitializeComponent();
        }

        private void EnviarButton1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PageEnvio.xaml", UriKind.Relative));
        }

        private void EnviarButton2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PageEnvio.xaml", UriKind.Relative));
        }
    }
}