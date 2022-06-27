using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class CollectionGender
    {
        public int GeneroID { get; set; }
        public string Genero { get; set; }
        public CollectionGender()
        {
            GeneroID = 0;
            Genero = "";
        }

        public CollectionGender(int generoID, string genero)
        {
            GeneroID = generoID;
            Genero = genero;
        }
    }
}
