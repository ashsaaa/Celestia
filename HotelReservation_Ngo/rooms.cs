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
    public partial class rooms : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=celestia;");

        public rooms()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addRoom addRoom = new addRoom(this);
            addRoom.Show();
        }

        private void rooms_Load(object sender, EventArgs e)
        {
            displayData();
        }

        public void displayData()
        {
            try
            {
                connection.Open();

                string query = "SELECT rdetails.rid, rdetails.rname, rdetails.occupancy, rdetails.price, roomtype.rtypeid, bedtype.bedtype_id " +
                               "FROM rdetails " +
                               "INNER JOIN roomtype ON rdetails.rtypeid = roomtype.rtypeid " +
                               "INNER JOIN bedtype ON rdetails.btype_id = bedtype.bedtype_id";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
