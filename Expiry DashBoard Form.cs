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
    public partial class Expiry_DashBoard_form : Form
    {
        string connect = "User Id=system;Password=it4;Data Source=localhost:1521;";

        public Expiry_DashBoard_form()
        {
            InitializeComponent();
        }

        private void Expiry_DashBoard_form_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            filtercb.SelectedIndex = 3;
            GenerateNotification();
        }

        public void GenerateNotification()
        {
            OracleConnection con = new OracleConnection(connect);
            con.Open();

            try
            {
                string query = $@"Select d.document_id,d.document_number,d.expiry_date 
                          from documents d 
                          join reminder_settings r on d.document_id=r.document_id 
                          where d.user_id={Program.LoggedInUserId} 
                          and trunc(d.expiry_date) - r.reminder_days_before <= trunc(sysdate) 
                          and r.is_active='Y' 
                          and not exists (
                              select 1 
                              from notifications n
                              where n.document_id = d.document_id
                          )";

                OracleCommand cmd = new OracleCommand(query, con);
                OracleDataReader reader = cmd.ExecuteReader();



                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["document_id"]);
                  
                    string message;

                    DateTime expiry = Convert.ToDateTime(reader["expiry_date"]);

                    if (expiry.Date <= DateTime.Now.Date)
                    {
                        message = "Your document has expired";
                    }
                    else
                    {
                        message = "Your document will expire soon";
                    }

                    string insert = $@"Insert into notifications 
                                       (Notification_ID,user_id,document_id,message) 
                                        values(Notification_SEQ.NEXTVAL,
                                       {Program.LoggedInUserId},
                                       {id},
                                       '{message}')";
                    OracleCommand cmd2 = new OracleCommand(insert, con);
                    cmd2.ExecuteNonQuery();
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        private void loadbtn_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(connect);
            try
            {
                con.Open();
                string query = "";
                if (filtercb.Text == "Expiring in 7 Days")
                {
                    query = $@"Select Document_number,Expiry_Date,Status from documents where user_ID={Program.LoggedInUserId} and status='ACTIVE' and Expiry_Date between sysdate and sysdate + 7";
                }
                else if (filtercb.Text == "Expiring in 30 Days")
                {
                    query = $@"Select Document_number,Expiry_Date,Status from Documents where User_ID={Program.LoggedInUserId} and status='ACTIVE' and Expiry_Date between sysdate and sysdate + 30";
                }
                else if (filtercb.Text == "Already Expired")
                {
                    query = $@"Select Document_Number,Expiry_Date,Status from Documents where User_ID={Program.LoggedInUserId} and status='ACTIVE' and Expiry_Date<Sysdate";
                }
                else
                {
                    query = $@"Select Document_Number,Expiry_Date,Status from Documents where User_ID={Program.LoggedInUserId} and status='ACTIVE'";
                }
                OracleCommand cmd = new OracleCommand(query, con);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No documents found!");
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

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            filtercb.SelectedIndex = 3;
            loadbtn_Click(null, null);
        }
    }
}
