using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Airi_Puhkusegraafik
{
    class Database
    {
        SqlConnection Connection;
        string connectionString;
        
        public Database()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Airi_Puhkusegraafik.Properties.Settings.VacationsConnectionString"].ConnectionString;
        }

        public void InsertUser(Name name)
        {
            string query = "INSERT INTO Nimed VALUES (@Name);";
            using (Connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                Connection.Open();
                
                command.Parameters.AddWithValue("@Name", name.name);

                command.ExecuteNonQuery();
                
            }


        }
        public void InsertVacation(Vacations vacations)
        {

            string query = "INSERT INTO Nimed VALUES (@VacStart, @VacEnd, @UserID);";
            using (Connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                Connection.Open();

                command.Parameters.AddWithValue("@VacStart", vacations._vacEnd);
                command.Parameters.AddWithValue("@VacEnd", vacations._vacStart);
                command.Parameters.AddWithValue("@UserID", vacations._UserID);

                command.ExecuteNonQuery();

            }


        }
        public List<Name> RetriveNames()
        {
            var names = new List<Name>();
            using (Connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT * FROM Nimed", Connection))
            {
                Connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Name name = new Name();

                        name.id = Convert.ToInt32(reader["Id"]);
                        name.name = reader["Name"].ToString();
                        names.Add(name);
                    }

                }
                Connection.Close();
            }
            return names;
        }
        

        public List<Vacations> RetriveVacation(Name name)
        {
            string query = "SELECT * FROM Puhkused AS a INNER JOIN Nimed AS b ON b.Id = a.UserID WHERE b.id = @User_Id";
            var vacations = new List<Vacations>();
            using (Connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, Connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                Connection.Open();
                command.Parameters.AddWithValue("@User_Id", name.id);

                command.ExecuteScalar();
                
                using (SqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        Vacations vacation = new Vacations();

                        vacation._Id = Convert.ToInt32(reader["Id"]);
                        vacation._vacEnd = Convert.ToDateTime(reader["VacEnd"]);
                        vacation._vacStart = Convert.ToDateTime(reader["VacStart"]);
                        vacation._UserID = Convert.ToInt32(reader["UserID"]);
                        vacations.Add(vacation);
                        
                    }

                }
                Connection.Close();
                
            }
            return vacations;
        }

    }
}
