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
    public partial class Change_Password : Form
    {
        string connect = "User Id=system;Password=it4;Data Source=localhost:1521;";

        public Change_Password()
        {
            InitializeComponent();
        }

        private void changebtn_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(connect);

            try
            {
                con.Open();
                if (currtxt.Text == "" || newtxt.Text == "" || contxt.Text == "")
                {
                    MessageBox.Show("All fields are required!");
                    return;
                }
                string query = $@"Select * from users Where User_ID={Program.LoggedInUserId}";

                OracleCommand cmd = new OracleCommand(query, con);
                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string pass = reader["password"].ToString();

                    if (pass != currtxt.Text)
                    {
                        MessageBox.Show("Current Password Is Wrong!");
                        reader.Close();
                        con.Close();
                        return;
                    }

                    if (newtxt.Text == pass)
                    {
                        MessageBox.Show("New Password Cannot Be Same As Old Password!");
                        reader.Close();
                        con.Close();
                        return;
                    }
                }
                reader.Close();


                if (newtxt.Text != contxt.Text)
                {
                    MessageBox.Show("Password Is Not Matching!");
                    con.Close();
                    return;
                }

                string update = $@"update users set password='{newtxt.Text}' where User_ID={Program.LoggedInUserId}";

                OracleCommand cmd2 = new OracleCommand(update, con);
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Password Updated Successfully");
                con.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void Change_Password_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
