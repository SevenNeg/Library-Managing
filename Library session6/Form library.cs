using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace Library_session6
{
    public partial class Main : Form
    {
        public Main()
        {
            List<User> users = null;
            List<Book> books = null;
            books = new List<Book>();
            users = new List<User>();
            InitializeComponent();
        }

        private void continuebutton_Click(object sender, EventArgs e)
        {

            if ((MaincheckedListBox.GetItemCheckState(0) == CheckState.Checked) && MaincheckedListBox.GetItemCheckState(1) == CheckState.Checked)
            {
                MessageBox.Show("You can't choose multiple items");

            }
            else if (MaincheckedListBox.GetItemCheckState(0) == CheckState.Checked)
            {
                Add_a_user Form = new Add_a_user();
                this.Hide();
                Form.ShowDialog();
                this.Show();
            }
            else if (MaincheckedListBox.GetItemCheckState(1) == CheckState.Checked)
            {
                Add_a_book Form = new Add_a_book();
                this.Hide();
                Form.ShowDialog();
                this.Show();
            }
            if (MaincheckedListBox.GetItemCheckState(2) == CheckState.Checked)
            {
                Reservation Form = new Reservation();
                this.Hide();
                Form.ShowDialog();
                this.Show();
            }

        }


    }
}