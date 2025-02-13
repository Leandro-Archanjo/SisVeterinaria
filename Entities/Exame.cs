using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVeterinaria.Entities
{
    class Exame
    {
        public string Nome { get; set; }

        public Exame(string nome)
        {
            Nome = nome;
        }

        public override string ToString() { return Nome; }
    }
}
