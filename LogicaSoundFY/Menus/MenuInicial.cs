using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LogicaSoundFY.Modelos
{
    internal class MenuInicial
    {
        public static void ExibirMenuInicial()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao SounFY");
            Console.WriteLine("1 - Entrar como ADM");
            Console.WriteLine("2 - Entrar como Ouvinte");
            Console.WriteLine("3 - Entrar como artista");
            Console.WriteLine("4 - Sair");

            Console.Write("Opção: ");
            string opcao = Console.ReadLine()!;
            switch (opcao)
            {
                case "1":
                    MenuAdm.ExibirMenuAdm();
                    break;
                case "2":
                    new CadastroOuvinte().GuardaOuvinteNaLista();
                    break;
                case"3":
                    new CadastroArtista().GuardaArtistaNaLista();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    Console.WriteLine("Pressione qualquer tecla para tentar novamente...");
                    Console.ReadKey(); 
                    ExibirMenuInicial(); 
                    break;

            }
        }
    }
}
