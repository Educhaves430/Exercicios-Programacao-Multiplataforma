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

using Microsoft.Win32;

namespace WPFApp6
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

            app.ModelFile.ReadingFinished += ModelFile_FileWRead;
            app.ModelFile.WrittingFinished += ModelFile_FileWritten;
        }

        private void ModelFile_FileWRead()
        {
            tbConteudo.Text = app.ModelFile.Content;
        }

        private void btAbrir_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Ficheiros de Texto (*.txt)|*.txt|Todos os ficheiros (*.*)|*.*";
            if (dlg.ShowDialog() == true)
                app.ModelFile.ReadFile(dlg.FileName);
        }

        private void ModelFile_FileWritten()
        {
            MessageBox.Show("Ficheiro guardado com sucesso!!!");
        }

        private void btGuardar_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Ficheiros de Texto (*.txt)|*.txt|Todos os ficheiros (*.*)|*.*";
            if (dlg.ShowDialog() == true)
                app.ModelFile.WriteFile(dlg.FileName, tbConteudo.Text);
        }
    }
}
