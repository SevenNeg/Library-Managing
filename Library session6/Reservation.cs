using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_session6
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();

            string file = @"C:\\Users\\NoteBook\\Desktop\\PR\\Classes\\Library session6\\ReservationMessage.txt";
            if (File.Exists(file))
            {
                string str = File.ReadAllText(file);
                MessageBox.Show(str);
            }

        }

        private void ReserveButton_Click(object sender, EventArgs e)
        {
            string JsonDataStrFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "jsonInf.json");
            string jsonDatastr = File.ReadAllText(JsonDataStrFilePath);
            List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonDatastr);
            NameGridView.DataSource = null;
            NameGridView.DataSource = users;
            NameGridView.Refresh();

            for (int j = 0; j < 2; j++)
            {
                
                DataGridViewRow row = NameGridView.SelectedRows[j];
                DataGridViewCell cell = row.Cells[3];
                string value = cell.Value.ToString();
                if (value == SubcodeTxt.Text)
                {

                    const string ConnectionString = "Data Source=NEG-LAB724148\\MSSQLSERVER2019;Initial Catalog=Library;Integrated Security=True";
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();
                        //async & await
                        string tablename = "BookAdding";
                        string query = $"INSERT INTO {tablename} (Reserved_By)" + "Values (@SubCode)";
                        SqlCommand command = new SqlCommand(query, connection);

                        command.Parameters.AddWithValue("@SubCode", SubcodeTxt.Text);

                        string tablename2 = "UserAdding";
                        string query2 = $"INSERT INTO {tablename2} (Books_Reserved)" + "Values (@BookCode)";
                        SqlCommand command1 = new SqlCommand(query2, connection);

                        command.Parameters.AddWithValue("@BookCode", BookCodeTxt.Text);
                    }

                }
                else
                {
                    MessageBox.Show("Sign in and Try again");
                }


            }
        }

        private void Addingbutton_Click(object sender, EventArgs e)
        {
            Add_a_user Form = new Add_a_user();
            this.Hide();
            Form.ShowDialog();
            this.Show();
        }
        
    }
}
