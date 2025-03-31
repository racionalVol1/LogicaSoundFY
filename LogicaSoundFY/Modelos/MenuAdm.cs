using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSoundFY.Modelos
{
    internal class MenuAdm
    {
        public static void ExibirMenuAdm() 
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ADM");
            Console.WriteLine("1 - Cadastrar album");
            Console.WriteLine("2 - Listar albuns");
            Console.WriteLine("3 - Excluir album");
            Console.WriteLine("4 - Editar album");
            Console.WriteLine("5 - Voltar ao menu principal");
            Console.WriteLine("6 - Sair");
            Console.Write("Opção: ");
            string opcao = Console.ReadLine()!;
            switch (opcao)
            {
                case "1":
                    Album.AdicionarAlbum();
                    break;
                case "2":
                    Album.ExcluirAlbum();
                    break;
                case "3":
                    Album.ListarAlbuns();
                    break;
                case "4":
                    Album.EditarAlbum();
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
                    ExibirMenuAdm();
                    break;
            }

        }
    }
}
