using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSoundFY.Modelos
{
    internal class Playlist
    {
        public static void AdicionarPlaylist()
        {
            Console.WriteLine("Digite o nome do album: ");
            Console.WriteLine("Digite as músicas do album: ");
        }

        public static void ListarPlaylists()
        {
            Console.WriteLine("Lista de playlists: ");
        }

        public static void ExcluirPlaylist()
        {
            Console.WriteLine("Digite o nome do album: ");
        }

        public static void EditarPlaylist()
        {
            Console.WriteLine("Digite o nome do album: ");
            Console.WriteLine("Digite o novo nome do album: ");
            Console.WriteLine("Digite as músicas do album: ");
        }
    }
}
