using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Dcument_Expiry_Alert_System
{
    public partial class Notification : Form
    {
        string connect = "User Id=system;Password=it4;Data Source=localhost:1521;";

        public Notification()
        {
            InitializeComponent();
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
          
            LoadNotification();   
        }

        public void LoadNotification()
        {
            OracleConnection con = new OracleConnection(connect);

            try
            {
                con.Open();

                string query = $@"Select d.Document_number,n.Message,n.notification_date from  notifications n join documents d on d.document_id=n.document_id where n.User_ID={Program.LoggedInUserId} order by n.notification_Date desc";

                OracleCommand cmd = new OracleCommand(query, con);
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No notifications available.");
                }

                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
