﻿#pragma checksum "C:\Users\Igor S. Menezes\Documents\Visual Studio 2013\Projects\ProjetoIntegrador\ProjetoIntegrador\PanoramaPageContato.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "74B710CF60CF02D3BD2AE32EDF485768"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace ProjetoIntegrador {
    
    
    public partial class PanoramaPageContato : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBox txtUrl;
        
        internal System.Windows.Controls.Button btnIr;
        
        internal Microsoft.Phone.Controls.WebBrowser WebBrowser1;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/ProjetoIntegrador;component/PanoramaPageContato.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.txtUrl = ((System.Windows.Controls.TextBox)(this.FindName("txtUrl")));
            this.btnIr = ((System.Windows.Controls.Button)(this.FindName("btnIr")));
            this.WebBrowser1 = ((Microsoft.Phone.Controls.WebBrowser)(this.FindName("WebBrowser1")));
        }
    }
}

