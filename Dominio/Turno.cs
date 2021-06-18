using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Turno
    {
        public int ID { get; set; }

        public  Medico Medico { get; set; }

        public Paciente Paciente { get; set; }

        public DateTime Fecha { get; set; }

        public int Estado { get; set; }
    }
}
