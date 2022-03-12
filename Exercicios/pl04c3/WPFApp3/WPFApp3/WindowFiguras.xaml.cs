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

namespace WPFApp3
{
    /// <summary>
    /// Interaction logic for WindowFiguras.xaml
    /// </summary>
    public partial class WindowFiguras : Window
    {
        public string FiguraEscolhida { get; private set; }
        public WindowFiguras()
        {
            InitializeComponent();
        }

        private void btAdicionar_Click(object sender, RoutedEventArgs e)
        {
            FiguraEscolhida = cbFiguras.Text;
            this.DialogResult = true;
        }
    }
}
