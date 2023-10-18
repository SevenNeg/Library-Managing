using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace Library_session6
{
    public class BookBusiness
    {
        const string ConnectionString = "Data Source=NEG-LAB724148\\MSSQLSERVER2019;Initial Catalog=Library;Integrated Security=True";
        public List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();

            string Tablename = "BookAdding";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = $"Select Name, BookCode, Sdisc, Author From {Tablename}";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Book book1 = new Book
                        {
                            Name = reader["Name"].ToString(),
                            BookCode = (int)reader["Bookcode"],
                            Sdisc = reader["Sdisc"].ToString(),
                            Author = reader["Author"].ToString()

                        };
                        books.Add(book1);
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
                    return books;
                
            }
           
        }
        public bool InsertBook(Book book1)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {

                connection.Open();

                string tablename = "BookAdding";
                string query = $"INSERT INTO {tablename}  (Name, BookCode, Sdisc, Author)" +
                    "Values (@Name, @BookCode, @Sdisc, @Author )";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Name", book1.Name);
                command.Parameters.AddWithValue("@BookCode", book1.BookCode);
                command.Parameters.AddWithValue("@Sdisc", book1.Sdisc);
                command.Parameters.AddWithValue("@Author", book1.Author);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;

                connection.Close();
            


               
            }
        }

    }
 }
