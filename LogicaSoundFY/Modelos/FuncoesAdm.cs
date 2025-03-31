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
        }

        public static void ExcluirUsuarioOuArtista()
        {

        }
    }
}
