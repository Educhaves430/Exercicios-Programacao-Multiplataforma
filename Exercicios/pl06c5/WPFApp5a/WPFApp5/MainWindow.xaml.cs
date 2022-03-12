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

namespace WPFApp5
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

            app.ModelNotas.NotaMensagem += ModelNotas_NotaMensagem;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            app.WindowNotas.Show();
            app.WindowAvaliacoes.Show();
        }
        private void MainWindow_Closed(object sender, EventArgs e)
        {
            app.WindowNotas.Close();
            app.WindowAvaliacoes.Close();
        }
        private void ModelNotas_NotaMensagem(string str)
        {
            sbiMensagem.Content = str;
        }

        private void btAdicionar_Click(object sender, RoutedEventArgs e)
        {
            app.ModelNotas.Adiciona(tbNotas.Text);
        }

        private void Window_Closed(object sender, EventArgs e)
        {

        }
    }
}