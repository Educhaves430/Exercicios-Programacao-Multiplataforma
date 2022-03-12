using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp7
{
    public class ModelLines
    {
        //public event MethodWithoutArgs LineInserted;
        public event MethodWithAString LineInserted;
        public string Line;
        public List<String> Lines;

        public ModelLines()
        {
            Lines = new List<String>();
        }
        public void Add(string text)
        {
            if ((text.Length == 0) || (text.Length > 5))
                throw new InvalidLineException("Erro! O texto deve estar no intervalo [1-5] carateres!");
            Line = text.ToUpper();
            Lines.Add(Line);
            if (LineInserted != null)
                LineInserted(Line);
        }
    }
}
