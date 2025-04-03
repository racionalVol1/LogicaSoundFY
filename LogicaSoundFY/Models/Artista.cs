using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSoundFY.Modelos
{
    internal class Artista
    {
        public Artista(string nome, string genero)
        {
            Nome = nome;
        }

        public string Nome { get; set; }
        public List<Album> Albuns { get; set; } = new List<Album>();
        public object Genero { get;  set; }

        public void AdicionarAlbum(Album album) 
        {            
            Albuns.Add(album);            
        }

        public void RemoverAlbum(Album album)
        {
            Albuns.Remove(album);
        }

        public string ListarAlbuns()
        {
            string artistaComAlbuns = Albuns.Count.ToString();
            return artistaComAlbuns.ToString();
        }    


    }
}
