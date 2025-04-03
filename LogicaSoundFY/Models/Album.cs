using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSoundFY.Modelos
{
    internal class Album
    {

        public Album(string nome)
        {
            Nome = nome;
        }

        private string Nome { get; set; }
        public List<Musica> Musicas { get; set; } = new List<Musica>();

        public void AdicionarMusica(Musica musica)
        {
            Musicas.Add(musica);
        }

        public void RemoverMusica(Musica musica)
        {
            Musicas.Remove(musica);
        }

        public string ListarMusicas()
        {
            string albumComMusicas = Musicas.Count.ToString();
            return albumComMusicas.ToString();
        }    
    }
}

