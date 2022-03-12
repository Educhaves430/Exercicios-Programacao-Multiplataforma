using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace IoTAppC
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private App app;
        public MainPage()
        {
            this.InitializeComponent();

            app = App.Current as App;
            app.ModeloSoma.SomaTerminada += Page_SomaTerminada;
        }

        private void Page_SomaTerminada()
        {
            tbResultado.Text = app.ModeloSoma.Soma;
        }

        private void btAdicionar_Click(object sender, RoutedEventArgs e)
        {
            app.ModeloSoma.Add(tbValor1.Text, tbValor2.Text);
        }
    }
}
