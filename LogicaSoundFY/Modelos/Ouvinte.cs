using System;
using System.Collections.Generic;

namespace LogicaSoundFY.Modelos
{
    internal class Ouvinte
    {
        private List<Playlist> ListaDePlaylists = new List<Playlist>();
        public Ouvinte(string nome)
        {
            Nome = nome;            
        }

        public string Nome { get; set; }

        public void AdicionarPlaylist(Playlist playlist)
        {
            ListaDePlaylists.Add(playlist);
        }

        public void ListarPlaylists()
        {
            foreach (var playlist in ListaDePlaylists)
            {
                Console.WriteLine($"Playlist: {playlist.Nome}");
                playlist.ListarMusicas();
            }
        }   
    }
} 
