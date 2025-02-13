using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVeterinaria.Entities
{
    class Consulta
    {
        public DateTime Data { get; set; }
        public string Resumo { get; set; }
        public Veterinario Veterinario { get; set; }
        public List<Exame> Exames { get; set; } = new List<Exame>();

        public Consulta(DateTime data, string resumo, Veterinario veterinario)
        {
            Data = data;
            Resumo = resumo;
            Veterinario = veterinario;
        }

        public void AddExames(Exame exame)
        {
            Exames.Add(exame);
        }

        public void ListarExames()
        {
            foreach (Exame ex in Exames)
            {
                Console.WriteLine(ex);
            }
        }

        public override string ToString()
        {
            return Data.ToString("dd/MM/yyyy") + " " + Resumo;
        }
    }
}
