using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class BookDatabase
    {
        public int EjemplarID { get; set; }
        public string EjemplarName { get; set; }
        public byte[] Portada { get; set; }
        public DateTime FechaPub { get; set; }
        public int EditorialID { get; set; }
        public int ColeccionID { get; set; }
        public int FormatoID { get; set; }
        public int IdiomaID { get; set; }
        public string Autor { get; set; }
        public int EtiquetaID { get; set; }

        public BookDatabase()
        {
            EjemplarID = 0;
            EjemplarName = "";
            Portada = null;
            FechaPub = new DateTime();
            EditorialID = 0;
            ColeccionID = 0;
            FormatoID = 0;
            IdiomaID = 0;
            Autor = "";
            EtiquetaID = 0;
        }

        public BookDatabase(int ejemplarID, string ejemplarName, byte[] portada, DateTime fechaPub, int editorialID, int coleccionID, int formatoID, int idiomaID, string autor, int etiquetaID)
        {
            EjemplarID = ejemplarID;
            EjemplarName = ejemplarName;
            Portada = portada;
            FechaPub = fechaPub;
            EditorialID = editorialID;
            ColeccionID = coleccionID;
            FormatoID = formatoID;
            IdiomaID = idiomaID;
            Autor = autor;
            EtiquetaID = etiquetaID;
        }
    }
}
