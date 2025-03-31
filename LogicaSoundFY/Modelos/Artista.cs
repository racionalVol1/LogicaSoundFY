using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSoundFY.Modelos
{
    internal class Artista
    {
        public string Nome { get; set; }
        public string Genero { get; set; }

        public Artista(string nome, string genero)
        {
            Nome = nome;
            Genero = genero;
        }
    }
}
