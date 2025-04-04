﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LogicaSoundFY.Modelos
{
    internal class Musica
    {

        public Musica(string nome, string artista, string album, string genero)
        {
            Nome = nome;
            Artista = artista;
            Album = album;
            Genero = genero;
        }

        private string Nome { get; set; }
        private string Artista { get; set; }
        private string Album { get; set; }
        private string Genero { get; set; }     



        public void ListarMusicas()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Album: {Album}");
            Console.WriteLine($"Genero: {Genero}");
        }
    }
}
