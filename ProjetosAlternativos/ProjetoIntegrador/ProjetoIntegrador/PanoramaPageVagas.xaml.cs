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
    public partial class PanoramaPageVagas : PhoneApplicationPage
    {
        public PanoramaPageVagas()
        {
            InitializeComponent();

            var items = new List<string> { };
            for (int i = 0; i < 20; i++)
            {
                items.Add("Minha lista de Vagas" + i.ToString());
            }
            ListBoxVagas.ItemsSource = items;
        }

        private void DetalheHyperLink_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PivotPageDetalheVaga.xaml", UriKind.Relative));
        }

       

             
       

        
    }
}