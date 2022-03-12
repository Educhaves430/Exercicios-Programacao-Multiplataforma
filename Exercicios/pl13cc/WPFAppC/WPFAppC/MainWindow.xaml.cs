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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFAppC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private App app;

        public MainWindow()
        {
            InitializeComponent();

            app = App.Current as App;
            app.ModeloSoma.SomaTerminada += Window_SomaTerminada;
        }

        private void Window_SomaTerminada()
        {
            tbResultado.Text = app.ModeloSoma.Soma;
        }

        private void btSomar_Click(object sender, RoutedEventArgs e)
        {
            app.ModeloSoma.Add(tbValor1.Text, tbValor2.Text);
        }
    }
}
