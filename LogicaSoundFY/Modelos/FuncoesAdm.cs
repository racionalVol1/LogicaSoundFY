using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSoundFY.Modelos
{
    internal class FuncoesAdm
    {
        public static void ListarUsuarioOuArtista()
        {
           
            var ouvintes = CadastroOuvinte.ObterOuvintes();
            Console.WriteLine("Lista de Ouvintes Cadastrados:");
            foreach (var ouvinte in ouvintes)
            {
                Console.WriteLine($"Nome: {ouvinte.Nome}, Email: {ouvinte.Email}");
            }
         
            var artistas = CadastroArtista.ObterArtistas();
            Console.WriteLine("Lista de Artistas Cadastrados:");
            foreach (var artista in artistas)
            {
                Console.WriteLine($"Nome: {artista.Nome}, Gênero: {artista.Genero}");
            }
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            MenuAdm.ExibirMenuAdm();
        }

        public static void ExcluirArtista ()
        {
            Console.Clear();
            Console.WriteLine("Qual o nome do artista ou banda que deseja excluir?");
            string nomeArtista = Console.ReadLine()!;

            var artistaParaExcluir = CadastroArtista.ObterArtistas().FirstOrDefault(a => a.Nome.Equals(nomeArtista, StringComparison.OrdinalIgnoreCase));
            if (artistaParaExcluir != null)
            {
                CadastroArtista.ExcluirArtista(artistaParaExcluir);
                Console.WriteLine($"Artista '{artistaParaExcluir.Nome}' excluído com sucesso!");
            }
            else
            {
                Console.WriteLine($"Artista '{nomeArtista}' não encontrado.");
            }
             Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            MenuAdm.ExibirMenuAdm();
        }

        public static void ExcluirOuvinte()
        {
            Console.Clear();
            Console.WriteLine("Qual o nome do ouvinte que deseja excluir?");
            string nomeOuvinte = Console.ReadLine()!;

            var ouvinteParaExcluir = CadastroOuvinte.ObterOuvintes().FirstOrDefault(o => o.Nome.Equals(nomeOuvinte, StringComparison.OrdinalIgnoreCase));
            if (ouvinteParaExcluir != null)
            {
                CadastroOuvinte.ExcluirOuvinte(ouvinteParaExcluir);
                Console.WriteLine($"Ouvinte '{ouvinteParaExcluir.Nome}' excluído com sucesso!");
            }
            else
            {
                Console.WriteLine($"Ouvinte '{nomeOuvinte}' não encontrado.");
            }
             Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            MenuAdm.ExibirMenuAdm();
        }
     
        public static void ExcluirUsuarioOuArtista()
        {
            Console.Clear();
            Console.WriteLine("Você deseja excluir um artista ou um ouvinte? (Digite 'artista' ou 'ouvinte')");
            string tipoUsuario = Console.ReadLine()!;

            if (tipoUsuario.Equals("artista", StringComparison.OrdinalIgnoreCase))
            {
                ExcluirArtista();
            }
            else if (tipoUsuario.Equals("ouvinte", StringComparison.OrdinalIgnoreCase))
            {
                ExcluirOuvinte();
            }
            else
            {
                Console.WriteLine("Opção inválida. Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                MenuAdm.ExibirMenuAdm();
            }           

        }
    }
}
