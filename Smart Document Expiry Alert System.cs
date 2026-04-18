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
    public partial class MainForm : Form
    {
        string connect = "User Id=system;Password=it4;Data Source=localhost:1521;";

        public MainForm()
        {
            InitializeComponent();
        }

        private void documentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documents doc = new Documents();
            doc.MdiParent = this;
            doc.Show();
        }

        private void Smart_Document_Expiry_Alert_System_Load(object sender, EventArgs e)
        {
            Expiry_DashBoard_form f = new Expiry_DashBoard_form();
            f.MdiParent = this;
            f.Show();
        }

        private void reminderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reminder f = new Reminder();
            f.MdiParent = this;
            f.Show();
        }

        private void notificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notification f = new Notification();
            f.MdiParent = this;
            f.Show();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void documentTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageDocumentTypesForm f = new ManageDocumentTypesForm();
            f.MdiParent = this;
            f.Show();
        }

        private void attributesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageAttributesForm f = new ManageAttributesForm();
            f.MdiParent = this;
            f.Show();
        }

        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Feedback f = new Feedback();
            f.MdiParent = this;
            f.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs f = new AboutUs();
            f.MdiParent = this;
            f.Show();
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?",
                                "Logout", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                OracleConnection con=new OracleConnection(connect);
                con.Open();

                string query = $@"update users set remember_me='N' where User_ID={Program.LoggedInUserId}";

                OracleCommand cmd = new OracleCommand(query, con);
                cmd.ExecuteNonQuery();

                con.Close();
                Login f = new Login();
                f.Show();
                this.Close();
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expiry_DashBoard_form f = new Expiry_DashBoard_form();
            f.MdiParent = this;
            f.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Password f = new Change_Password();
            f.MdiParent = this;
            f.Show();
        }
    }
}
