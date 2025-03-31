using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSoundFY.Modelos
{
    internal class Ouvinte
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Ouvinte(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}
