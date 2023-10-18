using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_session6.Business
{
    public class UserBusiness
    {
        const string ConnectionString = "Data Source=NEG-LAB724148\\MSSQLSERVER2019;Initial Catalog=Library;Integrated Security=True";
        public List<User> GetUsers()
        {
            List<User> users = new List<User>();

            string Tablename = "UserAdding";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = $"Select Firstname, lastname, Cellphone, SubCode, Email From {Tablename}";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        User user1 = new User
                        {
                            FirstName = reader["Firstname"].ToString(),
                            LastName = reader["Lastname"].ToString(),
                            Cellphone = (int)reader["Cellphone"],
                            Subcode = (int)reader["SubCode"],
                            Email = reader["Email"].ToString()

                        };
                        users.Add(user1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("");
                }
                finally
                {
                    connection.Close();
                }
                return users;

            }

        }
        public bool InsertUser(User user1)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {

                connection.Open();

                string tablename = "UserAdding";
                string query = $"INSERT INTO {tablename}  (Firstname, Lastname, Cellphone, Subcode, Email)" +
                    "Values (@Firstname, @Lastname, @Cellphone, @Subcode, @Email )";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Firstname", user1.FirstName);
                command.Parameters.AddWithValue("@Lastname", user1.LastName);
                command.Parameters.AddWithValue("@Cellphone", user1.Cellphone);
                command.Parameters.AddWithValue("@Subcode", user1.Subcode);
                command.Parameters.AddWithValue("@Email", user1.Email);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;

                connection.Close();
            }
        }
    }
}
