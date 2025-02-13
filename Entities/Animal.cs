using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVeterinaria.Entities
{
    class Animal
    {
        public string Nome { get; set; }
        public char Sexo { get; set; }
        public int Idade { get; set; }
        public Especie Especie { get; set; }
        public List<Tratamento> Tratamentos { get; set; } = new List<Tratamento>();

        public Animal(string nome, char sexo, int idade, Especie especie)
        {
            Nome = nome;
            Sexo = sexo;
            Idade = idade;
            Especie = especie;
        }

        public void AddTratamentos(Tratamento tratamento)
        {
            Tratamentos.Add(tratamento);
        }

        public override string ToString()
        {
            return Nome + " " +
                Sexo + " " +
                Idade + " " +
                Especie;
        }
    }
}
