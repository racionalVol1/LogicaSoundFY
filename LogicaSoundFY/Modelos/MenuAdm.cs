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
            Console.WriteLine("1 - Listar usuarios");
            Console.WriteLine("2 - Listar artistas");
            Console.WriteLine("3 - Listar usuario ou artista");
            Console.WriteLine("4 - Excluir usuario ou artistas");
            Console.WriteLine("5 - Voltar ao menu principal");
            Console.WriteLine("6 - Sair");
            Console.Write("Opção: ");
            string opcao = Console.ReadLine()!;
            switch (opcao)
            {
                case "1":
                    CadastroOuvinte.ExibirOuvintes();
                    break;
                case "2":
                    CadastroArtista.ExibirArtistas();
                    break;
                case "3":
                    FuncoesAdm.ListarUsuarioOuArtista();
                    break;
                case "4":
                    FuncoesAdm.ExcluirUsuarioOuArtista();
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
