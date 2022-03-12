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

namespace WPFApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void FigurasAdicionar_Click(object sender, RoutedEventArgs e)
        {
            WindowFiguras wFiguras = new WindowFiguras();
            if (wFiguras.ShowDialog() == true)
            {
                lbFiguras.Items.Add(wFiguras.FiguraEscolhida);
                canvasRepresentacao.Children.Clear();

                switch (wFiguras.FiguraEscolhida)
                {
                    case "Quadrado":
                        Rectangle r1 = new Rectangle();
                        r1.Width = 50;
                        r1.Height = 50;
                        r1.Stroke = Brushes.Red;
                        r1.StrokeThickness = 1;
                        canvasRepresentacao.Children.Add(r1);
                        break;
                    case "Retangulo":
                        Rectangle r2 = new Rectangle();
                        r2.Width = 100;
                        r2.Height = 50;
                        r2.Stroke = Brushes.Green;
                        r2.StrokeThickness = 1;
                        break;
                    case "Circulo":
                        Ellipse el = new Ellipse();
                        el.Width = 100;
                        el.Height = 100;
                        el.Stroke = Brushes.Blue;
                        el.StrokeThickness = 1;
                        canvasRepresentacao.Children.Add(el);
                        break;
                    case "Elipse":
                        Ellipse e2 = new Ellipse();
                        e2.Width = 100;
                        e2.Height = 200;
                        e2.Stroke = Brushes.DarkCyan;
                        e2.StrokeThickness = 1;
                        canvasRepresentacao.Children.Add(e2);
                        break;
                }
            }
        }

        private void FigurasSair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
