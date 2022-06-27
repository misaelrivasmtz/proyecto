using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
     public class BookUser
    {
        public int EjemplarID { get; set; }
        public string EjemplarName { get; set; }
        public Bitmap Portada { get; set; }
        public DateTime FechaPub { get; set; }
        public string Editorial { get; set; }
        public string Coleccion { get; set; }
        public string Formato { get; set; }
        public string Autor { get; set; }

        public BookUser()
        {
            EjemplarID = 0;
            EjemplarName = "";
            Portada = null;
            FechaPub = new DateTime();
            Editorial = "";
            Coleccion = "";
            Formato = "";
            Autor = "";
        }

        public BookUser(int ejemplarID, string ejemplarName, Bitmap portada, DateTime fechaPub, string editorial, string coleccion, string formato, string autor)
        {
            EjemplarID = ejemplarID;
            EjemplarName = ejemplarName;
            Portada = portada;
            FechaPub = fechaPub;
            Editorial = editorial;
            Coleccion = coleccion;
            Formato = formato;
            Autor = autor;
        }
    }
}
