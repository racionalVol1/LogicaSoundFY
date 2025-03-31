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
        public string Musicas { get; set; }

        public static void AdicionarAlbum()
        {
           

        }

        public static void ListarAlbuns()
        {
            Console.WriteLine("Lista de albuns: ");

        }

        public static void ExcluirAlbum()
        {
            Console.WriteLine("Digite o nome do album: ");
            string NomeAlbum = Console.ReadLine()!;

        }

        public static void EditarAlbum()
        {
            Console.WriteLine("Digite o nome do album: ");
            string NomeAlbum = Console.ReadLine()!;
            Console.WriteLine("Digite o novo nome do album: ");
            Console.WriteLine("Digite as músicas do album: ");
        }
    }
}

