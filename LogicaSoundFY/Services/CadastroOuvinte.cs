using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSoundFY.Modelos
{
    internal class CadastroOuvinte
    {
        private List<Ouvinte> ouvintes = new List<Ouvinte>();
        
        public List<Ouvinte> Ouvintes
        {
            get { return ouvintes; }
            set { ouvintes = value; }
        }

        public void GuardaOuvinteNaLista()
        {
            Console.Clear();
            Console.WriteLine("Qual o nome do Ouvinte ou banda?");
            string nomeOuvinte = Console.ReadLine()!;

          
            Ouvinte novoOuvinte = new Ouvinte(nomeOuvinte); 

            ouvintes.Add(novoOuvinte);

            Console.WriteLine($"Ouvinte '{novoOuvinte.Nome}' adicionado com sucesso!");
            Thread.Sleep(2000);
            MenuOuvinte.ExibirMenuOuvinte();
        }
    }
}
