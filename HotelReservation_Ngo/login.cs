using MySql.Data.MySqlClient;

namespace HotelReservation_Ngo
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            setColor();
        }

        private void setColor()
        {
            loginbtn.BackColor = System.Drawing.ColorTranslator.FromHtml("#07263A");
            loginbtn.ForeColor = System.Drawing.ColorTranslator.FromHtml("#CE9F41");
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            splitContainer1.Panel1.BackColor = Color.FromArgb(7, 38, 58);

        }

        private void extbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usertxt_Click(object sender, EventArgs e)
        {
            if (usertxt.Text == "Username")
            {
                usertxt.Text = string.Empty;
            }
        }

        private void usertxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usertxt.Text))
            {
                usertxt.Text = "Username";
            }
        }

        private void passtxt_Click(object sender, EventArgs e)
        {
            if (passtxt.Text == "Password")
            {
                passtxt.Text = string.Empty;
            }
        }

        private void passtxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passtxt.Text))
            {
                passtxt.Text = "Password";
            }
        }

        private void passtxt_TextChanged(object sender, EventArgs e)
        {
            if (passtxt.Text != "Password")
            {
                passtxt.PasswordChar = '*';
            }
            else
            {
                passtxt.PasswordChar = '\0';
            }
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string username = usertxt.Text;
            string password = passtxt.Text;

            bool isAuthenticated = AuthenticateUser(username, password);

            if (isAuthenticated)
            {
                this.Hide();

                // Open the IndexForm
                index index = new index();
                index.WindowState = FormWindowState.Maximized;
                index.Show();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.");
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            string connectionString = "server=localhost;user=root;password=;database=celestia;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Check if the provided username and password match a record in the database
                    string query = "SELECT * FROM user WHERE username = @username AND password = @password";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }
    }
}