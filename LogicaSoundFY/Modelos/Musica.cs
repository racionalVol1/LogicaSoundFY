using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSoundFY.Modelos
{
    internal class Musica
    {
        public string Nome { get; set; }
        public string Artista { get; set; }
        public string Album { get; set; }
        public string Genero { get; set; }

        public Musica(string nome, string artista, string album, string genero)
        {
            Nome = nome;
            Artista = artista;
            Album = album;
            Genero = genero;
        }   
        
        public static void OuvirMusica()
        {
            Console.WriteLine("Digite o nome da música: ");
            
        }
    }
}
