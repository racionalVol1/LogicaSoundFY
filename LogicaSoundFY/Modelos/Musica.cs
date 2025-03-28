using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSoundFY.Modelos
{
    internal class Musica
    {
        public string Nome { get; set; }
        public string Artista { get; set; }
        public string Album { get; set; }
        public string Genero { get; set; }

        public void ExibirMusica()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Album: {Album}");
            Console.WriteLine($"Genero: {Genero}");
        }

        public void AdcionarMusica()
        {
            Console.Write("Digite o nome da música: ");
            Nome = Console.ReadLine()!;
            Console.Write("Digite o nome do artista: ");
            Artista = Console.ReadLine()!;
            Console.Write("Digite o nome do album: ");
            Album = Console.ReadLine()!;
            Console.Write("Digite o genero da música: ");
            Genero = Console.ReadLine()!;
        }
    }
}
