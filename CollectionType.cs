using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class CollectionType
    {
        public int TipoID { get; set; }
        public string Tipo { get; set; }

        public CollectionType()
        {
            TipoID = 0;
            Tipo = "";
        }

        public CollectionType(int tipoID, string tipo)
        {
            TipoID = tipoID;
            Tipo = tipo;
        }
    }
}
