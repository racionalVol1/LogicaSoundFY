using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LogicaSoundFY.Modelos
{
    internal class Musica
    {

        public Musica(string nome, string artista, string album, string genero)
        {
            Nome = nome;           
        }

        private string Nome { get; set; }  

        public void ListarMusicas()
        {
            Console.WriteLine($"Nome: {Nome}");      
        }
    }
}
