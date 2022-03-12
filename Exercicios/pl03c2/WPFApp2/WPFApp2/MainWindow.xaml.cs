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

namespace WPFApp2
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

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            tbFullName.Text = tbName.Text + " " + tbSurname.Text;
            comboBox.Items.Add(tbFullName.Text);
            listBox.Items.Add(tbFullName.Text);
            listView.Items.Add(tbFullName.Text);
            treeView.Items.Add(tbFullName.Text);
        }

        private void btReset_Click(object sender, RoutedEventArgs e)
        {
            tbFullName.Text = "";
            comboBox.Items.Clear();
            listBox.Items.Clear();
            listView.Items.Clear();
            treeView.Items.Clear();
        }
    }
}
