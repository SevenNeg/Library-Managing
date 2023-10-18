using Library_session6;
using Library_session6.Business;
using Library_session6.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_session6
{
    public partial class Add_a_user : Form
    {
        public Add_a_user()
        {
            InitializeComponent();
            UserBusiness userBusiness = new UserBusiness();
            List<User> users = userBusiness.GetUsers();

            Usergridview.DataSource = null;
            Usergridview.DataSource = users;
            Usergridview.Refresh();
        }

        private void UserButtonn_Click(object sender, EventArgs e)
        {
  
            if (Number_Cheking.IsNumber(Cellphoneusertxt.Text, "Cellphone") && Number_Cheking.IsNumber(Cellphoneusertxt.Text, "Cellphone"))
            {

            if ((string.IsNullOrEmpty(NameUserTxt.Text) || string.IsNullOrEmpty(Lnameusertxt.Text) || string.IsNullOrEmpty(Cellphoneusertxt.Text) || string.IsNullOrEmpty(Emailtxt.Text)))
            {
                MessageBox.Show("Don't keep any box blank");
                return;
            }
            else
            {
                int cell;
                int.TryParse(Cellphoneusertxt.Text, out cell);

                Random random1 = new Random();
                int randomumber1 = random1.Next(1, 5000);
                User user1 = new User
                {
                    FirstName = NameUserTxt.Text,
                    LastName = Lnameusertxt.Text,
                    Cellphone = cell,
                    Subcode = randomumber1,
                    Email = Emailtxt.Text,


                };
                UserBusiness userbusiness1 = new UserBusiness();
                userbusiness1.InsertUser(user1);

                List<User> users1 = userbusiness1.GetUsers();

                Usergridview.DataSource = null;
                Usergridview.DataSource = users1;
                Usergridview.Refresh();

                ClearForm();
            }
            }

            

            

        }
        private void ClearForm()
        {
            NameUserTxt.Text = null;
            Lnameusertxt.Text = null;
            Cellphoneusertxt.Text = null;
            Emailtxt.Text = null;
        }

        private void UserBackbutton_Click(object sender, EventArgs e)
        {
            Main Form = new Main();
            this.Hide();
            Form.ShowDialog();
            this.Show();
        }

        private async void UserCallApi_Click(object sender, EventArgs e)
        {
            var options = new RestClientOptions("https://reqres.in");
            var client = new RestClient(options);
            var request = new RestRequest("/api/users?page=2", Method.Get);
            var response = await client.ExecuteAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                ReqresApiResponse result = JsonConvert.DeserializeObject<ReqresApiResponse>(response.Content);

                Usergridview.Invoke((Action)(() =>
                {
                    Usergridview.DataSource = null;
                    Usergridview.DataSource = result.data;
                    Usergridview.Refresh();


                }));
            }
            ClearForm();
        }

        private void ReserveBackButton_Click(object sender, EventArgs e)
        {
            Reservation Form = new Reservation();
            this.Hide();
            Form.ShowDialog();
            this.Show();
        }
    }
}
