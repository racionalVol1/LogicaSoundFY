using System;
using LogicaSoundFY.Modelos;

namespace LogicaSoundFY
{
    class Program
    {
        public void ExibirMenuInicial()
        {

            Console.WriteLine("Bem-vindo ao LogicaSoundFY!");
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1. Criar um novo álbum");
            Console.WriteLine("2. Adicionar música a um álbum existente");
            Console.WriteLine("3. Listar músicas de um álbum");
            Console.WriteLine("4. Sair");

            Console.Write("Opção: ");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    CriarAlbum();
                    break;
                case "2":
                    AdicionarMusicaAoAlbum();
                    break;
                case "3":
                    ListarMusicasDoAlbum();
                    break;
                case "4":
                    Console.WriteLine("Saindo...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    ExibirMenuInicial();
                    break;
            }
        }
    }  
}