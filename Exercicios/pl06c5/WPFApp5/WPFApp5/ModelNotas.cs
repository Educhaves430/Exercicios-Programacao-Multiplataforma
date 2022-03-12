using System;
using System.Collections.Generic;
using System.Text;

namespace WPFApp5
{
    public class ModelNotas
    {
        //Criar delegate
        public delegate void DelegacaoNotaAdicionada(string str);
        //Criar evento
        public event DelegacaoNotaAdicionada NotaAdicionada;
        public List<string> ListaNotas { get; private set; }
        public ModelNotas()
        {
            ListaNotas = new List<string>();
        }
        public void Adiciona(string nota)
        {
            ListaNotas.Add(nota);
            //Lançar event
            if (NotaAdicionada != null)
                NotaAdicionada(nota);
        }
    }
}
