using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Medico
    {
        public int ID { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Legajo { get; set; }

        public List<Especialidad> Especialidades;

        public List<DiaHorarioTrabajo> DiasHorarios;

        public List<ObraSocial> ObrasSociales;

        public bool Estado { get; set; }

    }
}
