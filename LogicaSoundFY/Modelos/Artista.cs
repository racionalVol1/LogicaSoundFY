using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSoundFY.Modelos
{
    internal class Artista
    {
        public Artista(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }
        public List<Album> Albuns { get; set; }     


    }
}
