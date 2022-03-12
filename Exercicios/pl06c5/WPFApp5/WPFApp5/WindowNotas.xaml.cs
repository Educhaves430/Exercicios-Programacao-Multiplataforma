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
    /// Interaction logic for WindowNotas.xaml
    /// </summary>
    public partial class WindowNotas : Window
    {
        private App app;
        public WindowNotas()
        {
            InitializeComponent();
            //ligação à App
            app = App.Current as App;
            //Subscrição de um método no evento do Model
            app.ModelNotas.NotaAdicionada += ModelNotas_NotaAdicionada;
        }
        private void ModelNotas_NotaAdicionada(string str)
        {
            double nota = Convert.ToDouble(str);
            nota = Math.Round(nota);

            lbNotas.Items.Add(nota + " valores");
        }
    }
}
