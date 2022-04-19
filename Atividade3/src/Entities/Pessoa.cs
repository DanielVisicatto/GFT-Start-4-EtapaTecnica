using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3.src.Entities
{
    internal class Pessoa
    {
        public string NomePessoa { get; set; }
        public int IdadePessoa { get; set; }
        public Cachorro Pet { get; set; } = new Cachorro();

        public Pessoa()
        {
        }

        public Pessoa(string nomePessoa, int idadePessoa)
        {
            NomePessoa = nomePessoa;
            IdadePessoa = idadePessoa;
        }
    }
}
