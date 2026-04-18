using Oracle.ManagedDataAccess.Client;
using System.Drawing;

namespace Smart_Dcument_Expiry_Alert_System
{
    public partial class Registration : Form
    {
        string connect = "User Id=system; Password=it4; Data Source=localhost:1521;";
        public Registration()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void Regbtn_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(connect);
            string username = utxt.Text;
            string email = etxt.Text.ToLower();
            string password = ptxt.Text;
            string confirmPassword = ctxt.Text;

            if (username == "" || email == "" || password == "")
            {
                MessageBox.Show("All Feilds Are Mandatory!");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Password is not Matching!");
                return;
            }

            try
            {
                con.Open();
                string checkquery = $@"Select * from users Where username='{username}'";
                OracleCommand cmd = new OracleCommand(checkquery, con);

                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Username Already Exist!");
                    reader.Close();
                    con.Close();
                    return;
                }
                reader.Close();
                string query = $@"Insert into Users(user_id,username,email,password) values (USER_SEQ.NEXTVAL,'{username}','{email}','{password}')";
                OracleCommand cmd2 = new OracleCommand(query, con);
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Registration Succesfully!");
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void loginlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
