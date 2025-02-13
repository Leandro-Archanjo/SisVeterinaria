using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVeterinaria.Entities
{
    class Tratamento
    {
        public List<Consulta> Consultas { get; set; } = new List<Consulta>();

        public void AddConsultas(Consulta consulta)
        {
            Consultas.Add(consulta);
        }
    }
}
