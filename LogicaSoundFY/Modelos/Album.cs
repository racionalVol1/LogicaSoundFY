using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSoundFY.Modelos
{
    internal class Album
    {
        public string Nome { get; set; }
        public string Artista { get; set; }
        public List<Musica> Musicas { get; set; }
       
        public void ExibirAlbum()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Artista: {Artista}");
            foreach (var musica in Musicas)
            {
                musica.ExibirMusica();
            }
        }

        public void AdicionarMusica(Musica musica)
        {
            Musicas.Add(musica);
        }

        public void RemoverMusica(Musica musica)
        {
            Musicas.Remove(musica);
        }
    }
}
