using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSoundFY.Modelos
{
    internal class MenuOuvinte
    {
        public static void ExibirMenuOuvinte()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo Ouvinte");
            Console.WriteLine("1 - Ouvir música");
            Console.WriteLine("2 - Criar playlist");
            Console.WriteLine("3 - Listar playlists");
            Console.WriteLine("4 - Editar playlist");
            Console.WriteLine("5 - Voltar ao menu principal");
            Console.WriteLine("6 - Sair");
            Console.Write("Opção: ");
            string opcao = Console.ReadLine()!;
            switch (opcao)
            {
                case "1":
                    Musica.OuvirMusica();
                    break;
                case "2":
                    Playlist.AdicionarPlaylist();
                    break;
                case "3":
                    Playlist.ListarPlaylists();
                    break;
                case "4":
                    Playlist.EditarPlaylist();
                    break;
                case "5":
                    MenuInicial.ExibirMenuInicial();
                    break;
                case "6":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    Console.WriteLine("Pressione qualquer tecla para tentar novamente...");
                    Console.ReadKey();
                    ExibirMenuOuvinte();
                    break;
            }
        }
    }
}
