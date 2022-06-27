using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class CollectionUsers
    {
        public int ColeccionID { get; set; }
        public string Coleccion { get; set; }
        public string Tipo { get; set; }
        public string Genero { get; set; }

        public CollectionUsers()
        {
            ColeccionID = 0;
            Coleccion = "";
            Tipo = "";
            Genero = "";
        }

        public CollectionUsers(int coleccionID, string coleccion, string tipo, string genero)
        {
            ColeccionID = coleccionID;
            Coleccion = coleccion;
            Tipo = tipo;
            Genero = genero;
        }
    }
}
