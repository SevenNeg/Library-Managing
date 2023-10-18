using Library_session6;
using Library_session6.Enums;
using Microsoft.VisualBasic.ApplicationServices;
using RestSharp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Library_session6.Models;
using System.Diagnostics.Eventing.Reader;

namespace Library_session6
{
    public partial class Add_a_book : Form
    {
        public Add_a_book()
        {
            InitializeComponent();
            BookBusiness bookBusiness = new BookBusiness();
            List<Book> books = bookBusiness.GetBooks();

            BookGridView.DataSource = null;
            BookGridView.DataSource = books;
            BookGridView.Refresh();
                

        }

        private void userbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NametextBox.Text) || string.IsNullOrEmpty(Pricetextbox.Text) || string.IsNullOrEmpty(shortdiscTextbox.Text) || string.IsNullOrEmpty(AuthortextBox.Text))
            {
                MessageBox.Show("Don't keep any box blank");
                return;
            }
            else
            {
                Random random = new Random();
                int randomCode = random.Next(1, 4000);

                for (int i = 0; i < 100; i++)
                {
                    DataGridViewColumn column = BookGridView.SelectedColumns[1];
                    DataGridViewRow row = BookGridView.SelectedRows[i];
                    DataGridViewCell cell = row.Cells[1];
                    string value = cell.Value.ToString();
                    int number;
                    int.TryParse(value, out number);
                    if (number == randomCode)
                    {
                        int code;
                        Book book2 = new Book
                        {
                            Name = NametextBox.Text,
                            BookCode = CalculateNumber(out code),
                            Sdisc = shortdiscTextbox.Text,
                            Author = AuthortextBox.Text,
                            Price = Pricetextbox.Text,
                        };

                    }
                    else
                    {
                        Book book2 = new Book
                        {
                            Name = NametextBox.Text,
                            BookCode = randomCode,
                            Sdisc = shortdiscTextbox.Text,
                            Author = AuthortextBox.Text,
                            Price = Pricetextbox.Text,
                        };
                    }
                   
                }

            
              
                Book book1 = new Book
                {
                    Name = NametextBox.Text,
                    BookCode = randomCode,
                    Sdisc = shortdiscTextbox.Text,
                    Author = AuthortextBox.Text,
                    Price = Pricetextbox.Text,
                };
                BookBusiness bookBusiness1 = new BookBusiness();
                bookBusiness1.InsertBook(book1);

                List<Book> books1 = bookBusiness1.GetBooks();

                BookGridView.DataSource = null;
                BookGridView.DataSource = books1;
                BookGridView.Refresh();

                ClearForm();
            }

            //Number_Cheking.IsNumber(Bookcodetextbox.Text, "BookCode");



        }

        private int CalculateNumber(out int code)
        {
            throw new NotImplementedException();
        }

        private void Userbackbutton_Click(object sender, EventArgs e)
        {
            Main Form = new Main();
            this.Hide();
            Form.ShowDialog();
            this.Show();
        }
        private void ClearForm()
        {
            NametextBox.Text = null;
            Pricetextbox.Text = null;
            shortdiscTextbox.Text = null;
            AuthortextBox.Text = null;
        }
        public static int CalculateNumber()
        {
            Random random0 = new Random();
            int randomnumber0 = random0.Next(1, 4000);
            return randomnumber0;
        }

        private async void CallApiButton_Click(object sender, EventArgs e)
        {
            var options = new RestClientOptions("https://reqres.in");
            var client = new RestClient(options);
            var request = new RestRequest("/api/users?page=2", Method.Get);
           var  response = await client.ExecuteAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                ReqresApiResponse result = JsonConvert.DeserializeObject<ReqresApiResponse>(response.Content);

                BookGridView.Invoke((Action)(() =>
                {
                    BookGridView.DataSource = null;
                    BookGridView.DataSource = result.data;
                    BookGridView.Refresh();
                }));
            }
            ClearForm();
        }
    }
}
