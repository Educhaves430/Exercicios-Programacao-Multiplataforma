using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

using ModelSomaNamespace;

namespace WPFAppC
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public ModelSoma ModeloSoma { get; private set; }

        public App()
        {
            ModeloSoma = new ModelSoma();
        }
    }
}
