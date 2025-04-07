using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSoundFY.Modelos
{
    internal class Album
    {
        private List<Musica> ListaDeMusicas = new List<Musica>();
        public Album(string nome, string artista)
        {
            Nome = nome;
            Artista = artista;            
        }

        public string Nome { get; set; }
        public string Artista { get; set; }
      

        public void AdicionarMusica(Musica musica)
        {
            ListaDeMusicas.Add(musica);
        }

        public void ListarMusicas()
        {
            foreach (var musica in ListaDeMusicas)
            {
                musica.ListarMusicas();
            }
        } 
    } 
}

