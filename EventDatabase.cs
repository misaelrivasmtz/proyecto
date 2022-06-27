using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class EventDatabase
    {
        public int EventoID { get; set; }
        public string Titulo { get; set; }
        public byte[] Imagen { get; set; }
        public string Objetivo { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public int Asistentes { get; set; }
        public int AreaID { get; set; }

        public string Area { get; set; }
        

        public EventDatabase()
        {
            EventoID = 0;
            Titulo = "";
            Imagen = null;
            Objetivo = "";
            Inicio = new DateTime();
            Fin = new DateTime();
            Asistentes = 0;
            AreaID = 0;
            Area = "";
        }

        public EventDatabase(int eventoID, string titulo, byte[] imagen, string objetivo, DateTime inicio, DateTime fin, int asistentes, int areaID, string area)
        {
            EventoID = eventoID;
            Titulo = titulo;
            Imagen = imagen;
            Objetivo = objetivo;
            Inicio = inicio;
            Fin = fin;
            Asistentes = asistentes;
            AreaID = areaID;
            Area = area;
        }
    }
}
