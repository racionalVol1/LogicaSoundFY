using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSoundFY.Modelos
{
    internal class Playlist
    {

        public Playlist(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }
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
            string playlistComMusicas = Musicas.Count.ToString();
            return playlistComMusicas.ToString();
        }
    }
}
