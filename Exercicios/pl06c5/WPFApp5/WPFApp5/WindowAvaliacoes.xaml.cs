using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFApp5
{
    /// <summary>
    /// Interaction logic for WindowAvaliacoes.xaml
    /// </summary>
    public partial class WindowAvaliacoes : Window
    {
        private App app;
        public WindowAvaliacoes()
        {
            InitializeComponent();
            //Ligação à App
            app = App.Current as App;
            //Subscrição de método no evento do Model
            app.ModelNotas.NotaAdicionada += ModelNotas_NotaAdicionada;
        }
        private void ModelNotas_NotaAdicionada(string str)
        {
            double nota = Convert.ToDouble(str);

            if (nota >= 9.5)
                lvAvaliacoes.Items.Add("Aprovado (" + nota + ")");
            else
                lvAvaliacoes.Items.Add("Reprovado (" + nota + ")");
        }

        private void Window_Closed(object sender, EventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
