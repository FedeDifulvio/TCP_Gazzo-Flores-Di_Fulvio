using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ObraSocial
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public ObraSocial( int id, string nombre)
        {
            ID = id;
            Nombre = nombre; 
        }

        public ObraSocial(int id)
        {
            ID = id;

        }

        public ObraSocial()
        {

        }
    }
}
