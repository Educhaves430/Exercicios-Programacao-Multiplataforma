using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WPFApp5
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //View 2 janelas
        public WindowNotas WindowNotas { get; private set; }
        public WindowAvaliacoes WindowAvaliacoes { get; private set; }
        //Model 1 class
        public ModelNotas ModelNotas { get; private set; }
        public App()
        {
            //Modelo / Model
            ModelNotas = new ModelNotas();
            //Vista / View
            WindowNotas = new WindowNotas();
            WindowAvaliacoes = new WindowAvaliacoes();
        }
    }
}
