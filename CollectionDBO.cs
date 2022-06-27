using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public static class CollectionDBO
    {
        // mostrando registros
        public static List<CollectionUsers> ShowAll()
        {
            List<CollectionUsers> list = new List<CollectionUsers>();
            string stringConnection = "Data Source = ANTSKIF34; Initial Catalog = databankPOObj; Integrated Security = True";

            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    string query = "Select ColeccionID, ColeccionName, Tipo, Genero " +
                                    "From Coleccion , Genero, Tipo " +
                                    "Where Coleccion.GeneroID = Genero.GeneroID AND Coleccion.TipoID = Tipo.TipoID";
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CollectionUsers col = new CollectionUsers();
                            col.ColeccionID = Convert.ToInt32(reader[0].ToString());
                            col.Coleccion = reader[1].ToString();
                            col.Tipo = reader[2].ToString();
                            col.Genero = reader[3].ToString();
                            list.Add(col);
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
            return list;

        }

        // extrayendo datos para inicializar combo box

        public static List<CollectionType> ShowTypes()
        {
            List<CollectionType> list = new List<CollectionType>();
            string stringConnection = "Data Source = ANTSKIF34; Initial Catalog = databankPOObj; Integrated Security = True";
            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    string query = "Select TipoID, Tipo " +
                        "From Tipo ";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CollectionType data = new CollectionType();
                            data.TipoID = Convert.ToInt32(reader[0].ToString());
                            data.Tipo = reader[1].ToString();
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

        public static List<CollectionGender> ShowGenders()
        {
            List<CollectionGender> list = new List<CollectionGender>();
            string stringConnection = "Data Source = ANTSKIF34; Initial Catalog = databankPOObj; Integrated Security = True";
            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    string query = "Select GeneroID, Genero " +
                        "From Genero ";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CollectionGender data = new CollectionGender();
                            data.GeneroID = Convert.ToInt32(reader[0].ToString());
                            data.Genero = reader[1].ToString();
                            list.Add(data);
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un Error", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return list;
        }

        // insertando registros

        public static bool AddCollection(CollectionDatabase e)
        {
            bool exito = true;
            try
            {
                string stringConnection = "Data Source = ANTSKIF34; Initial Catalog = databankPOObj; Integrated Security = True";
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    string query = "INSERT INTO Coleccion (ColeccionID, ColeccionName, TipoID, GeneroID) " +
                                   "VALUES(@id, @name, @type, @gender)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", e.ColeccionID);
                    command.Parameters.AddWithValue("@name", e.Coleccion);
                    command.Parameters.AddWithValue("@type", e.TipoID);
                    command.Parameters.AddWithValue("@gender", e.GeneroID);

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

        //Filtrar registro
        public static string FilterCollection(int id)
        {
            string returnValue = "";
            string stringConnection = "Data Source = ANTSKIF34; Initial Catalog = databankPOObj; Integrated Security = True";
            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    string query = "SELECT ColeccionName FROM Coleccion WHERE ColeccionID = @id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                            while (reader.Read())
                        {
                             returnValue = reader["ColeccionName"].ToString();
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
        public static bool UpdateCollection(CollectionDatabase e)
        {
            bool exito = true;
            try
            {
                string stringConnection = "Data Source = ANTSKIF34; Initial Catalog = databankPOObj; Integrated Security = True";
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    string query = "UPDATE EVENTO " +
                        "SET ColeccionName = @name, TipoID = @type, GeneroID = @gender " +
                        "WHERE ColeccionID = @id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", e.ColeccionID);
                    command.Parameters.AddWithValue("@name", e.Coleccion);
                    command.Parameters.AddWithValue("@type", e.TipoID);
                    command.Parameters.AddWithValue("@gender", e.GeneroID);

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

        public static bool DeleteCollection(int id)
        {
            bool exito = true;
            try
            {
                string stringConnection = "Data Source = ANTSKIF34; Initial Catalog = databankPOObj; Integrated Security = True";
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    string query = "DELETE FROM Coleccion WHERE ColeccionID = @id";
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
