using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVeterinaria.Entities
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public List<Animal> Animais { get; set; } = new List<Animal>();

        public Cliente(string nome, string endereco, string telefone)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
        }

        public override string ToString()
        {
            return Nome + " "
                + Endereco + " "
                + Telefone;
        }
    }
}
