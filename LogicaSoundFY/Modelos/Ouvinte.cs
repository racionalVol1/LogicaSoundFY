using System;
using System.Collections.Generic;

namespace LogicaSoundFY.Modelos
{
    internal class Ouvinte
    {
        private string nomeOuvinte;

        public Ouvinte(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public Ouvinte(string nomeOuvinte)
        {
            this.nomeOuvinte = nomeOuvinte;
        }

        public string Nome { get; set; }
        public string Email { get; set; }

        public List<Playlist> Playlists { get; set; } = new List<Playlist>();

        public void AdicionarPlaylist(Playlist playlist)
        {
            Playlists.Add(playlist);
        }

        public void RemoverPlaylist(Playlist playlist)
        {
            Playlists.Remove(playlist);
        }

        public string ListarPlaylists()
        {
            string ouvinteComPlaylists = Playlists.Count.ToString();
            return ouvinteComPlaylists;
        }     
    }
} 
