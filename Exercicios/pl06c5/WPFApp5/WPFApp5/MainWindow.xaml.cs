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
            //Ligação à App
            app = App.Current as App;

         //   this.Loaded += MainWindow_Loaded;
         //   this.Closed += MainWindow_Closed;
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
        private void btAdicionar_Click(object sender, RoutedEventArgs e)
        {
            app.ModelNotas.Adiciona(tbNotas.Text);
        }
    }
}
