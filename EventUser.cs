using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class EventUser
    {
        public int EventoID { get; set; }
        public string Titulo { get; set; }
        public Bitmap Imagen { get; set; }

        public string Objetivos { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public int Asistentes { get; set; }
        public string Area { get; set; }

        public EventUser()
        {
            this.EventoID = 0;
            this.Titulo = "";
            this.Imagen = null;
            this.Objetivos = "";
            this.Inicio = new DateTime();
            this.Fin = new DateTime();
            this.Asistentes = 0;
            this.Area = "";
        }

        public EventUser(int eventoID, string titulo, Bitmap imagen, string objetivos, DateTime inicio, DateTime fin, int asistentes, string area)
        {
            EventoID = eventoID;
            Titulo = titulo;
            Imagen = imagen;
            Objetivos = objetivos;
            Inicio = inicio;
            Fin = fin;
            Asistentes = asistentes;
            Area = area;
        }
    }
}
