using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Dcument_Expiry_Alert_System
{
    public partial class Login : Form
    {
        string connect = "User Id=system;Password=it4;Data Source=localhost:1521;";
        public Login()
        {
            InitializeComponent();
        }


        private void logbtn_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(connect);
            string username = utxt.Text;
            string password = ptxt.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter Username and Password!");
                return;
            }


            try
            {
                con.Open();


                string query1 = $@"select * from USERS where username='{username}'";
                OracleCommand cmd = new OracleCommand(query1, con);
                OracleDataReader reader = cmd.ExecuteReader();
                if (!reader.Read())
                {
                    MessageBox.Show("User Does Not Exist.Please Register First!");
                    reader.Close();
                    con.Close();
                    return;
                }
                reader.Close();

                string query = $@"select USER_ID from USERS where username='{username}' and password='{password}'";
                OracleCommand cmd2 = new OracleCommand(query, con);
                OracleDataReader reader2 = cmd2.ExecuteReader();

                if (reader2.Read())
                {
                    Program.LoggedInUserId = Convert.ToInt32(reader2["USER_ID"].ToString());

                    string reset = "update users set remember_me='N'";
                    OracleCommand cmdReset = new OracleCommand(reset, con);
                    cmdReset.ExecuteNonQuery();

                    string remember = remcb.Checked ? "Y" : "N";

                    string update = $@"update users set remember_me='{remember}' where User_Id={Program.LoggedInUserId}";

                    OracleCommand cmd1 = new OracleCommand(update, con);
                    cmd1.ExecuteNonQuery();

                    MessageBox.Show("Login Successfully!");
                    reader2.Close();
                    con.Close();

                    MainForm sys = new MainForm();
                    sys.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!");
                    reader2.Close();
                    con.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void reglbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Registration reg = new Registration();
            reg.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(connect);

            try
            {
                con.Open();
                string query = $@"Select username,password from users where remember_me='Y'";

                OracleCommand cmd = new OracleCommand(query, con);
                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    utxt.Text = reader["username"].ToString();
                    ptxt.Text = reader["password"].ToString();

                    remcb.Checked = true;
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

        private void utxt_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
