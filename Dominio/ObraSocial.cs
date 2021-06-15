using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class ObraSocial
    {
        public int ID { get; set; }
        public string Nombre { get; set; } 

        public ObraSocial( int id, string nombre)
        {
            ID = id;
            Nombre = nombre; 
        }
    }
}
