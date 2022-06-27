using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public static class UserDBO
    {
        //Obteniendo todos los eventos
        public static List<UserUser> ShowAll()
        {
            List<UserUser> list = new List<UserUser>();
            string stringConnection = "Data Source = ANTSKIF34; Initial Catalog = databankPOObj; Integrated Security = True";

            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    string query = "Select UsuarioID, Nombre, Ocupacion, Direccion, Institucion, Telefono, Fotografia, Correo " +
                                    "From Usuario ";
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UserUser user = new UserUser();
                            user.UsuarioID = Convert.ToInt32(reader[0].ToString());
                            user.Usuario = reader[1].ToString();
                            user.Ocupacion = reader[2].ToString();
                            user.Direccion = reader[3].ToString();
                            user.Institucion = reader[4].ToString();
                            user.Telefono = reader[5].ToString();
                            MemoryStream ms = new MemoryStream((byte[])reader[6]);
                            Bitmap bm = new Bitmap(ms);
                            user.Fotografia = bm;
                            user.Correo = "";
                            list.Add(user);

                        }
                    }
                    connection.Close();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            return list;

        }

        public static List<UserUser> ShowOne(int id)
        {
            List<UserUser> list = new List<UserUser>();
            string stringConnection = "Data Source = ANTSKIF34; Initial Catalog = databankPOObj; Integrated Security = True";

            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    string query = "Select UsuarioID, Nombre, Ocupacion, Direccion, Institucion, Telefono, Fotografia, Correo " +
                                    "From Usuario " +
                                    "Where UsuarioID = @id";
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UserUser user = new UserUser();
                            user.UsuarioID = Convert.ToInt32(reader[0].ToString());
                            user.Usuario = reader[1].ToString();
                            user.Ocupacion = reader[2].ToString();
                            user.Direccion = reader[3].ToString();
                            user.Institucion = reader[4].ToString();
                            user.Telefono = reader[5].ToString();
                            MemoryStream ms = new MemoryStream((byte[])reader[6]);
                            Bitmap bm = new Bitmap(ms);
                            user.Fotografia = bm;
                            user.Correo = "";
                            list.Add(user);

                        }
                    }
                    connection.Close();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            return list;

        }

        // insertando datos en base de datos

        public static bool AddUser(UserDatabase e) 
        {
            bool exito = true;
            try
            {
                string stringConnection = "Data Source = ANTSKIF34; Initial Catalog = databankPOObj; Integrated Security = True";
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    string query = "INSERT INTO Usuario(UsuarioID, Nombre, Ocupacion, Direccion, Institucion, Telefono, Fotografia, Correo) " +
                                   "VALUES(@id, @n, @o, @d, @i, @t, @f, @c) ";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    command.Parameters.AddWithValue("@id", e.UsuarioID);
                    command.Parameters.AddWithValue("@n", e.Usuario);
                    command.Parameters.AddWithValue("@o", e.Ocupacion);
                    command.Parameters.AddWithValue("@d", e.Direccion);
                    command.Parameters.AddWithValue("@i", e.Institucion);
                    command.Parameters.AddWithValue("@t", e.Telefono);
                    command.Parameters.AddWithValue("@f", e.Image);
                    command.Parameters.AddWithValue("@c", e.Correo);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                exito = false;
                MessageBox.Show(ex.Message);
            }

            return exito;
        }

        //Filtrar un evento
        public static string FilterUser(int id)
        {
            string returnValue = "";
            string stringConnection = "Data Source = ANTSKIF34; Initial Catalog = databankPOObj; Integrated Security = True";
            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    string query = "Select UsuarioID, Nombre, Ocupacion, Direccion, Institucion, Telefono, Fotografia, Correo " +
                                    "From Usuario " +
                                    "Where UsuarioID = @id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            returnValue = reader[1].ToString();
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en filtrado de datos!", "sqlConnection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return returnValue;
        }



        //Update Registro
        public static bool UpdateUser(UserDatabase e)
        {
            bool exito = true;
            try
            {
                string stringConnection = "Data Source = ANTSKIF34; Initial Catalog = databankPOObj; Integrated Security = True";
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    string query = "UPDATE Usuario " +
                                    "SET Nombre = @n, Ocupacion = @o, Direccion = @d, Institucion = @i, Telefono = @t, Fotografia = @f, Correo = @c" +
                                    "Where UsuarioID = @id ";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    command.Parameters.AddWithValue("@id", e.UsuarioID);
                    command.Parameters.AddWithValue("@n", e.Usuario);
                    command.Parameters.AddWithValue("@o", e.Ocupacion);
                    command.Parameters.AddWithValue("@d", e.Direccion);
                    command.Parameters.AddWithValue("@i", e.Institucion);
                    command.Parameters.AddWithValue("@t", e.Telefono);
                    command.Parameters.AddWithValue("@f", e.Image);
                    command.Parameters.AddWithValue("@c", e.Correo);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                exito = false;
                MessageBox.Show(ex.Message);
            }

            return exito;
        }

        //delete registro

        public static bool DeleteUser(int id)
        {
            bool exito = true;
            try
            {
                string stringConnection = "Data Source = ANTSKIF34; Initial Catalog = databankPOObj; Integrated Security = True";
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    string query = "DELETE FROM Ejemplar WHERE ID = @id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                exito = false;
            }

            return exito;
        }
    }
}
