using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSoundFY.Modelos
{
    public class Artista
    {
        private List<Album> ListaDeAlbuns = new List<Album>();

        public Artista(string nome)
        {
            Nome = nome;            
        }

        public string Nome { get; set; }

        public void AdicionarAlbum(Album album)
        {
            ListaDeAlbuns.Add(album);
        }

        public void ListarAlbuns()
        {
            foreach (var album in ListaDeAlbuns)
            {
                Console.WriteLine($"Album: {album.Nome} - Artista: {album.Artista}");
                album.ListarMusicas();
            }
        }
    }
}
