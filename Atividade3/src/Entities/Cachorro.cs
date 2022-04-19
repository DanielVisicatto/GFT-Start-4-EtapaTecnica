using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3.src.Entities
{
    internal class Cachorro
    {
        public string Raça { get; set; }
        public string Porte { get; set; }
        public int Idade { get; set; }

        public Cachorro()
        {
        }

        public Cachorro(string raça, string porte, int idade)
        {
            Raça = raça;
            Porte = porte;
            Idade = idade;
        }
    }
}
