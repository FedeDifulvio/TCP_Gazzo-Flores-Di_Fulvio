using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Paciente
    {

        public int ID { get; set; } 

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string DNI { get; set; }

        public string Direccion { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Mail  { get; set; }

        public string Telefono { get; set; }

        public ObraSocial ObraSocial { get; set; }

        public bool Estado { get; set; }
    }
}
