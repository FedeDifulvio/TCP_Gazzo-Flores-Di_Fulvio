using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class EspecialidadDeMedico
    {
        public int id { get; set; }
        public int idMedico { get; set; }

        public Especialidad especialidad;
    }
}
