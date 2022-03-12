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

namespace WPFApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Figura> Lista { get; private set; }
        public MainWindow()
        {
            InitializeComponent();

            Lista = new List<Figura>();
        }

        private void FiguraAdicionar_Click(object sender, RoutedEventArgs e)
        {
            WindowAdicionar dlg = new WindowAdicionar();

            if (dlg.ShowDialog() == true)
            {
                lbFiguras.Items.Add(dlg.FiguraAdicionada.Nome);

                Lista.Add(dlg.FiguraAdicionada);

                lbFiguras.SelectedIndex = lbFiguras.Items.Count - 1;
                Figura fig = Lista[lbFiguras.Items.Count - 1];
                sbDimensoes.Content = "Largura: " + fig.Largura + " Altura: " + fig.Altura;
            }
        }

        private void lbFiguras_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int figuraselecionada = lbFiguras.SelectedIndex;
            Figura fig = Lista[figuraselecionada];
            sbDimensoes.Content = "Largura: " + fig.Largura + " Altura: " + fig.Altura;
        }
    }
}
