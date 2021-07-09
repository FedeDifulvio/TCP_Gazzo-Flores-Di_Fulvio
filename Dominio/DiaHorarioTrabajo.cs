using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class DiaHorarioTrabajo
    {
        public int ID { get; set; }

        public int idMedico { get; set; }

        public int idDia { get; set; }

        public string Dia { get; set; }

        public string HoraInicio { get; set; }

        public string HoraFin { get; set; } 
    }
}
