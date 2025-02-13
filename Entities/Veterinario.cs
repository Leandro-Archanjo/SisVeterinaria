using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVeterinaria.Entities
{
    class Veterinario
    {
        public string Nome { get; set; }

        public Veterinario(string nome) 
        {
            Nome = nome;
        }

        public override string ToString() { return Nome; }
    }
}
