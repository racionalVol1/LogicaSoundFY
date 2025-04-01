using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSoundFY.Modelos
{
    internal class Album
    {

        public Album(string nome)
        {
            Nome = nome;
        }

        private string Nome { get; set; }
        public List<Musica> Musica { get; set; }

        public static void AdicionarAlbum()
        {

        }

        public static void ListarAlbuns()
        {
            Console.Clear();                 

        }

        public static void ExcluirAlbum()
        {
           

        }

        public static void EditarAlbum()
        {
           
        }
    }
}

