using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp5
{
    public class ModelNotas
    {
        public List<string> ListaNotas { get; private set; }
        //Criar delegate
        public delegate void MetodosComString(string str);
        //Criar evento
        public event MetodosComString NotaAdicionada;
        public event MetodosComString NotaMensagem;
        public ModelNotas()
        {
            ListaNotas = new List<string>();
        }
        public void Adiciona(string nota)
        {
            double valor = Convert.ToDouble(nota);

            if ((valor >= 0) && (valor <= 20))
                { 
                    ListaNotas.Add(nota);
                    //Lançar event
                    if (NotaAdicionada != null)
                        NotaAdicionada(nota);
                    if (NotaMensagem != null)
                        NotaMensagem("Nota de " + nota + " adicionada");
            }
            else
            {
                if (NotaMensagem != null)
                    NotaMensagem("Nota de " + nota + " fora de limites");
            }
        }
    }
}
