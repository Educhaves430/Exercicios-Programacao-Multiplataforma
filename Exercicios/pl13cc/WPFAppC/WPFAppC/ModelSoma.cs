using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelSomaNamespace
{
    public class ModelSoma
    {
        public string Soma { get; private set; }

        public event voidNoArgs SomaTerminada;

        public void Add(string item1, string item2)
        {
            Soma = (Convert.ToInt32(item1) + Convert.ToInt32(item2)).ToString();

            if (SomaTerminada != null)
                SomaTerminada();
        }
    }
}
