using System;
using System.Collections.Generic;

namespace LogicaSoundFY
{
    class Program
    {
        static List<Banda> bandas = new List<Banda>();
        static List<Album> albuns = new List<Album>();
        static List<Musica> musicas = new List<Musica>();

        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao SoundFY");
            bool menu = true;

            while (menu)
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1 - Cadastrar Banda");
                Console.WriteLine("2 - Cadastrar Álbum");
                Console.WriteLine("3 - Cadastrar Música");
                Console.WriteLine("4 - Listar Bandas");
                Console.WriteLine("5 - Listar Álbuns");
                Console.WriteLine("6 - Listar Músicas");
                Console.WriteLine("7 - Sair");
                Console.Write("Opção: ");

                string opcao = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(opcao))
                {
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    continue;
                }

                switch (opcao)
                {
                    case "1":
                        AdicionarBanda();
                        break;
                    case "2":
                        AdicionarAlbum();
                        break;
                    case "3":
                        AdicionarMusica();
                        break;
                    case "4":
                        ListarBandas();
                        break;
                    case "5":
                        ListarAlbuns();
                        break;
                    case "6":
                        ListarMusicas();
                        break;
                    case "7":
                        menu = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }

                if (menu)
                {
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }
            Console.WriteLine("Até mais!");
        }

        static void AdicionarBanda()
        {
            Console.Write("Digite o nome da banda: ");
            string nome = Console.ReadLine()?.Trim();
            Console.Write("Digite o gênero da banda: ");
            string genero = Console.ReadLine()?.Trim();
            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(genero))
            {
                bandas.Add(new Banda(nome, genero));
                Console.WriteLine("Banda cadastrada com sucesso!");
            }
            else
            {
                Console.WriteLine("Nome ou gênero inválidos!");
            }
        }

        static void AdicionarAlbum()
        {
            Console.Write("Digite o nome do álbum: ");
            string nome = Console.ReadLine()?.Trim();
            Console.Write("Digite o nome da banda: ");
            string banda = Console.ReadLine()?.Trim();
            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(banda))
            {
                albuns.Add(new Album(nome, banda));
                Console.WriteLine("Álbum cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("Nome do álbum ou da banda inválidos!");
            }
        }

        static void AdicionarMusica()
        {
            Console.Write("Digite o nome da música: ");
            string nome = Console.ReadLine()?.Trim();
            Console.Write("Digite o nome da banda: ");
            string banda = Console.ReadLine()?.Trim();
            Console.Write("Digite o nome do álbum: ");
            string album = Console.ReadLine()?.Trim();
            Console.Write("Digite o gênero da música: ");
            string genero = Console.ReadLine()?.Trim();
            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(banda) && !string.IsNullOrEmpty(album) && !string.IsNullOrEmpty(genero))
            {
                musicas.Add(new Musica(nome, banda, album, genero));
                Console.WriteLine("Música cadastrada com sucesso!");
            }
            else
            {
                Console.WriteLine("Dados inválidos!");
            }
        }

        static void ListarBandas()
        {
            Console.WriteLine("\nBandas cadastradas:");
            if (bandas.Count == 0)
                Console.WriteLine("Nenhuma banda cadastrada.");
            else
                bandas.ForEach(b => Console.WriteLine($"- {b.Nome} ({b.Genero})"));
        }

        static void ListarAlbuns()
        {
            Console.WriteLine("\nÁlbuns cadastrados:");
            if (albuns.Count == 0)
                Console.WriteLine("Nenhum álbum cadastrado.");
            else
                albuns.ForEach(a => Console.WriteLine($"- {a.Nome} (Banda: {a.Banda})"));
        }

        static void ListarMusicas()
        {
            Console.WriteLine("\nMúsicas cadastradas:");
            if (musicas.Count == 0)
                Console.WriteLine("Nenhuma música cadastrada.");
            else
                musicas.ForEach(m => Console.WriteLine($"- {m.Nome} (Banda: {m.Banda}, Álbum: {m.Album}, Gênero: {m.Genero})"));
        }
    }

    class Banda
    {
        public string Nome { get; set; }
        public string Genero { get; set; }

        public Banda(string nome, string genero)
        {
            Nome = nome;
            Genero = genero;
        }
    }

    class Album
    {
        public string Nome { get; set; }
        public string Banda { get; set; }

        public Album(string nome, string banda)
        {
            Nome = nome;
            Banda = banda;
        }
    }

    class Musica
    {
        public string Nome { get; set; }
        public string Banda { get; set; }
        public string Album { get; set; }
        public string Genero { get; set; }

        public Musica(string nome, string banda, string album, string genero)
        {
            Nome = nome;
            Banda = banda;
            Album = album;
            Genero = genero;
        }
    }
}