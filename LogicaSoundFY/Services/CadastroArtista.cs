using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSoundFY.Modelos
{
    internal class CadastroArtista
    {
        private List<Artista> artistas = new List<Artista>();
        
        public List<Artista> Artistas
        {
            get { return artistas; }
            set { artistas = value; }
        }

        public void GuardaArtistaNaLista()
        {
            Console.Clear();
            Console.WriteLine("Qual o nome do artista ou banda?");
            string nomeArtista = Console.ReadLine()!;

            Console.WriteLine("Qual o genero musical da banda?");
            string estiloMusical = Console.ReadLine()!;

            Artista novoArtista = new Artista(nomeArtista, estiloMusical);

            
            artistas.Add(novoArtista);

            Console.WriteLine($"Artista '{novoArtista.Nome}' do gênero '{novoArtista.Genero}' adicionado com sucesso!");
            Thread.Sleep(2000);
            MenuArtista.ExibirMenuArtista();
        }
    }
}

