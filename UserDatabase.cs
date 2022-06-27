using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class UserDatabase
    {
        public int UsuarioID { get; set; }
        public string Usuario { get; set; }
        public string Ocupacion { get; set; }
        public string Direccion { get; set; }
        public string Institucion { get; set; }
        public string Telefono { get; set; }
        public byte[] Image { get; set; }
        public string Correo { get; set; }


        public UserDatabase()
            {
                UsuarioID = 0;
                Usuario = "";
                Ocupacion = "";
                Direccion = "";
                Institucion = "";
                Image = null;
                Telefono = "";
                Correo = "";
            }

            public UserDatabase(int usuarioID, string usuario, string ocupacion, string direccion, string institucion, string telefono, byte[] fotografia, string correo)
            {
                UsuarioID = usuarioID;
                Usuario = usuario;
                Ocupacion = ocupacion;
                Direccion = direccion;
                Institucion = institucion;
                Telefono = telefono;
                Image = fotografia;
                Correo = correo;
            }

        }
}
