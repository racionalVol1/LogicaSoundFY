﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSoundFY.Modelos
{
    internal class Playlist
    {
        public string Nome { get; set; }
        public List<Musica> Musicas { get; set; }
        public void ExibirPlaylist()
        {
            Console.WriteLine($"Nome: {Nome}");
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
