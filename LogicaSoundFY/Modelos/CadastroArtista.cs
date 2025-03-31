using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSoundFY.Modelos
{
    internal class CadastroArtista
    {
        private static List<Artista> artistas = new List<Artista>();

        public static void InformacoesArtistas()
        {
            Console.Clear();
            Console.WriteLine("Qual o nome do artista ou banda?");
            string nomeArtista = Console.ReadLine()!;

            Console.WriteLine("Qual o estilo musical da banda?");
            string estiloMusical = Console.ReadLine()!;
 
            Artista novoArtista = new Artista(nomeArtista, estiloMusical);
            
            artistas.Add(novoArtista);

            Console.WriteLine($"Artista '{novoArtista.Nome}' do gênero '{novoArtista.Genero}' adicionado com sucesso!");           
            Thread.Sleep(2000)  ;
            MenuArtista.ExibirMenuArtista();
        }
       
        public static void ExibirArtistas()
        {
            Console.Clear();
            Console.WriteLine("Lista de Artistas Cadastrados:");
            foreach (var artista in artistas)
            {
                Console.WriteLine($"Nome: {artista.Nome}, Gênero: {artista.Genero}");
            }
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            MenuAdm.ExibirMenuAdm();
        }
    }
}
