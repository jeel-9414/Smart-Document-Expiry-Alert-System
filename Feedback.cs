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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Smart_Dcument_Expiry_Alert_System
{
    public partial class Feedback : Form
    {
        string conn = "User Id=system;Password=it4;Data Source=localhost:1521;";
        int feedback_id = 0;
        bool isEdit = false;
        public Feedback()
        {
            InitializeComponent();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text.Trim() == "" || ratingcb.Text == "")
            {
                MessageBox.Show("All Fields Are Mandatory!");
                return;
            }

            OracleConnection con = new OracleConnection(conn);

            try
            {
                con.Open();


                string insertQuery = $@"INSERT INTO FEEDBACK
                                            (FEEDBACK_ID, USER_ID, MESSAGE, RATING)
                                            VALUES
                                            (FEEDBACK_SEQ.NEXTVAL,
                                             {Program.LoggedInUserId},
                                             '{txtMessage.Text.Trim()}',
                                             {ratingcb.Text})";

                OracleCommand cmd = new OracleCommand(insertQuery, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Feedback Submitted Successfully!");


                con.Close();
                Clear();
                dispbtn.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        public void Clear()
        {
            txtMessage.Clear();
            ratingcb.SelectedIndex = -1;
            feedback_id = 0;
            isEdit = false;
            //savebtn.Text = "Save";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dispbtn_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(conn);

            try
            {
                con.Open();

                string query = $@"SELECT 
                                  FEEDBACK_ID,
                                  MESSAGE,
                                  RATING,
                                  CREATED_DATE
                                  FROM FEEDBACK
                                  WHERE USER_ID = {Program.LoggedInUserId}
                                  ORDER BY FEEDBACK_ID DESC";

                OracleCommand cmd = new OracleCommand(query, con);
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No documents found!");
                }

                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = dt;

                dataGridView1.Columns["FEEDBACK_ID"].Visible = false;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void Feedback_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
