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
            Console.WriteLine("1 - Listar usuario ou artista");
            Console.WriteLine("2 - Excluir usuario ou artistas");
            Console.WriteLine("3 - Voltar ao menu principal");
            Console.WriteLine("4 - Sair");
            Console.Write("Opção: ");
            string opcao = Console.ReadLine()!;
            switch (opcao)
            {               
                case "1":
                    FuncoesAdm.ListarUsuarioOuArtista();
                    break;
                case "2":
                    FuncoesAdm.ExcluirUsuarioOuArtista();
                    break;
                case "3":
                    MenuInicial.ExibirMenuInicial();
                    break;
                case "4":
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
