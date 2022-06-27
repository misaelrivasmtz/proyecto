using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto;
using Proyecto.Properties;

namespace Proyecto
{
    public static class EventDBO
    {
        //Obteniendo todos los eventos
        public static List<EventUser> ShowAll()
        {
            List<EventUser> list = new List<EventUser>();
            string stringConnection = "Data Source = ANTSKIF34; Initial Catalog = databankPOObj; Integrated Security = True";

            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    string query = "Select e.EventoID, Titulo, Imagen, Objetivo, e.Inicio, e.Fin, e.Asistentes, a.Area " +
                                    "From EVENTO e, Area a " +
                                    "Where e.AreaID = a.AreaID";
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EventUser user = new EventUser();
                            user.EventoID = Convert.ToInt32(reader[0].ToString());
                            user.Titulo = reader[1].ToString();
                            MemoryStream ms = new MemoryStream((byte[])reader[2]);
                            Bitmap bm = new Bitmap(ms);
                            user.Imagen = bm;
                            user.Objetivos = reader[3].ToString();
                            user.Inicio = Convert.ToDateTime(reader[4].ToString());
                            user.Fin = Convert.ToDateTime(reader[5].ToString());
                            user.Asistentes = Convert.ToInt32(reader[6].ToString());
                            user.Area = reader[7].ToString();
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

        // extrayendo áreas para llenar cmbArea

        public static List<EventArea> ShowArea()
        {
            List<EventArea> list = new List<EventArea>();
            string stringConnection = "Data Source = ANTSKIF34; Initial Catalog = databankPOObj; Integrated Security = True";
            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    string query = "Select AreaID, Area " +
                        "From Area ";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EventArea data = new EventArea();
                            data.AreaID = Convert.ToInt32(reader[0].ToString());
                            data.Area = reader[1].ToString();
                            list.Add(data);
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un Error", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return list;
        }

        // insertando datos en base de datos

        public static bool AddEvent(EventDatabase e)
        {
            bool exito = true;
            try
            {
                string stringConnection = "Data Source = ANTSKIF34; Initial Catalog = databankPOObj; Integrated Security = True";
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    string query = "INSERT INTO EVento (EventoID, Titulo, Imagen, Objetivo, inicio, Fin, Asistentes, AreaID) " +
                                   "VALUES(@id, @title, @image, @objetivo, @start, @end, @assistants, @area)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", e.EventoID);
                    command.Parameters.AddWithValue("@title", e.Titulo);
                    command.Parameters.AddWithValue("@image", e.Imagen);
                    command.Parameters.AddWithValue("@objetivo", e.Objetivo);
                    command.Parameters.AddWithValue("@start", e.Inicio);
                    command.Parameters.AddWithValue("@end", e.Fin);
                    command.Parameters.AddWithValue("@assistants", e.Asistentes);
                    command.Parameters.AddWithValue("@area", e.AreaID);

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

        //Filtrar un evento
        public static string FilterEvent(int id)
        {
            string returnValue = "";
            string stringConnection = "Data Source = ANTSKIF34; Initial Catalog = databankPOObj; Integrated Security = True";
            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    string query = "Select EventoID as ID, Titulo, Imagen, Objetivo, Inicio, Fin, Asistentes, a.Area " +
                                    "From EVENTO e, Area a " +
                                    "Where (e.AreaID = a.AreaID) AND e.EventoID = @id";
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
        public static bool UpdateEvent(EventDatabase e)
        {
            bool exito = true;
            try
            {
                string stringConnection = "Data Source = ANTSKIF34; Initial Catalog = databankPOObj; Integrated Security = True";
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    string query = "UPDATE EVENTO " +
                        "SET Titulo = @title,Imagen = @image, Objetivo = @objetivo, Inicio = @start, Fin = @end, Asistentes = @assistants, AreaID = @area " +
                        "WHERE EventoID = @id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", e.EventoID);
                    command.Parameters.AddWithValue("@title", e.Titulo);
                    command.Parameters.AddWithValue("@image", e.Imagen);
                    command.Parameters.AddWithValue("@objetivo", e.Objetivo);
                    command.Parameters.AddWithValue("@start", e.Inicio);
                    command.Parameters.AddWithValue("@end", e.Fin);
                    command.Parameters.AddWithValue("@assistants", e.Asistentes);
                    command.Parameters.AddWithValue("@area", e.AreaID);

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

        //delete registro

        public static bool DeleteEvent(int id)
        {
            bool exito = true;
            try
            {
                string stringConnection = "Data Source = ANTSKIF34; Initial Catalog = databankPOObj; Integrated Security = True";
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    string query = "DELETE FROM EVENTO WHERE EventoID = @id";
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
