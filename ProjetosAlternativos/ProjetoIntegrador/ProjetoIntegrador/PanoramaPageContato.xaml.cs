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
    public partial class PanoramaPageContato : PhoneApplicationPage
    {
        public PanoramaPageContato()
        {
            InitializeComponent();
            WebBrowser1.Navigate(new Uri("http://www.facebook.com", UriKind.Absolute));
            WebBrowser2.Navigate(new Uri("http://www.twitter.com", UriKind.Absolute));
          
        }

       

        
    }
}