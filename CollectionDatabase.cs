using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class CollectionDatabase
    {
        public int ColeccionID { get; set; }
        public string Coleccion { get; set; }
        public int TipoID { get; set; }
        public int GeneroID { get; set; }

        public CollectionDatabase()
        {
            ColeccionID = 0;
            Coleccion = "";
            TipoID = 0;
            GeneroID = 0;
        }

        public CollectionDatabase(int coleccionID, string coleccion, int tipoID, int generoID)
        {
            ColeccionID = coleccionID;
            Coleccion = coleccion;
            TipoID = tipoID;
            GeneroID = generoID;
        }
    }
}
