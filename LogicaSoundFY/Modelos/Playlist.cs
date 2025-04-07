using System;
using System.Collections.Generic;

namespace LogicaSoundFY.Modelos
{
    internal class Playlist
    {
        private List<Musica> ListaDeMusicas = new List<Musica>();
        public Playlist(string nome )
        {
            Nome = nome;                    
        }

        public string Nome { get; set; }

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

