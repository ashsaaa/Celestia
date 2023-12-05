using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservation_Ngo
{
    public partial class reserve : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=celestia;");

        public reserve()
        {
            InitializeComponent();
            DisplayReservations();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addReserve addReserve = new addReserve(this);
            addReserve.Show();
        }

        public void DisplayReservations()
        {
            string query = @"SELECT reserve.id, CONCAT(client.c_lname, ', ', client.c_fname) AS ClientName, rdetails.rname AS RoomName, reserve.chIn AS CheckInDate, reserve.chOut AS CheckOutDate, reserve.Confirmation
                             FROM reserve
                             INNER JOIN client ON reserve.clientID = client.cid
                             INNER JOIN rdetails ON reserve.roomID = rdetails.rid";

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Function still not available. Sorry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
