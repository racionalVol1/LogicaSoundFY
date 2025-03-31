using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSoundFY.Modelos
{
    internal class CadastroOuvinte
    {
        private static List<Ouvinte> ouvintes = new List<Ouvinte>();

        public static void InformacoesOuvintes()
        {
            Console.Clear();
            Console.WriteLine("Qual o nome do ouvinte?");
            string nomeOuvinte = Console.ReadLine()!;

            Console.WriteLine("Qual o email do ouvinte?");
            string emailOuvinte = Console.ReadLine()!;

            Ouvinte novoOuvinte = new Ouvinte(nomeOuvinte, emailOuvinte);
        
            ouvintes.Add(novoOuvinte);

            Console.WriteLine($"Ouvinte '{novoOuvinte.Nome}' com o email '{novoOuvinte.Email}' adicionado com sucesso!");
            Thread.Sleep(2000);
          
            MenuOuvinte.ExibirMenuOuvinte();
        }

        public static void ExibirOuvintes()
        {
            Console.Clear();
            Console.WriteLine("Lista de Ouvintes Cadastrados:");
            foreach (var ouvinte in ouvintes)
            {
                Console.WriteLine($"Nome: {ouvinte.Nome}, Email: {ouvinte.Email}");
            }
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();

            MenuAdm.ExibirMenuAdm();
        }
    }
}
