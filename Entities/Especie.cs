using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVeterinaria.Entities
{
    class Especie
    {
        public string Nome { get; set; }
        public Especie(string nome)
        {
            Nome = nome;
        }
        public override string ToString()
        {
            return Nome;
        }
    }
}
