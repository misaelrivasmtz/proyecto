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
    public static class BookDBO
    {

        public static string Filter(int id)
        {
            string stringConnection = "Data Source = ANTSKIF34; Initial Catalog = databankPOObj; Integrated Security = True";
            string name = "";
            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    string query = "Select Nombre From Ejemplar Where ID = @id";
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            name = reader[0].ToString();
                        }
                    }
                    connection.Close();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            return name;

        }

        // insertando datos en base de datos

        public static bool AddBook(BookDatabase e)
        {
            bool exito = true;
            try
            {
                string stringConnection = "Data Source = ANTSKIF34; Initial Catalog = databankPOObj; Integrated Security = True";
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    string query = "INSERT INTO Ejemplar (ID, Nombre, Portada, Publicacion, EditorialID, ColeccionID, FormatoID, IdiomaID, EtiquetaID)" +
                        "VALUES(@id, @name, @port, @pub, @ed, @col, @format, @idioma, @etiqueta) ";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    command.Parameters.AddWithValue("@id", e.EjemplarID);
                    command.Parameters.AddWithValue("@name", e.EjemplarName);
                    command.Parameters.AddWithValue("@port", e.Portada);
                    command.Parameters.AddWithValue("@pub", e.FechaPub);
                    command.Parameters.AddWithValue("@ed", e.EditorialID);
                    command.Parameters.AddWithValue("@col", e.ColeccionID);
                    command.Parameters.AddWithValue("@format", e.FormatoID);
                    command.Parameters.AddWithValue("@idioma", e.IdiomaID);
                    command.Parameters.AddWithValue("@etiqueta", e.EtiquetaID);
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

        
        //Update Registro
        public static bool UpdateBook(BookDatabase e)
        {
            bool exito = true;
            try
            {
                string stringConnection = "Data Source = ANTSKIF34; Initial Catalog = databankPOObj; Integrated Security = True";
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    string query = "UPDATE Ejemplar " +
                        "SET Nombre = @name, Portada = @port, Publicacion = @pub, EditorialID = @ed, " +
                        "ColeccionID = @col, FormatoID = @format, IdiomaID = @idioma, EquiquetaID = @etiqueta " +
                        "WHERE ID = @id ";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    command.Parameters.AddWithValue("@id", e.EjemplarID);
                    command.Parameters.AddWithValue("@name", e.EjemplarName);
                    command.Parameters.AddWithValue("@port", e.Portada);
                    command.Parameters.AddWithValue("@pub", e.FechaPub);
                    command.Parameters.AddWithValue("@ed", e.EditorialID);
                    command.Parameters.AddWithValue("@col", e.ColeccionID);
                    command.Parameters.AddWithValue("@format", e.FormatoID);
                    command.Parameters.AddWithValue("@idioma", e.IdiomaID);
                    command.Parameters.AddWithValue("@etiqueta", e.EtiquetaID);
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

        public static bool DeleteBook(int id)
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

        //Buscando por Titulo completo
       /* public static List<BookUser> FilterTitle(string title)
        {

        }*/
    }
}
   
