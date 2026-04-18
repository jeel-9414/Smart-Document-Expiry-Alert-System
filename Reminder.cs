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
    public partial class Reminder : Form
    {

        string connect = "User Id=system;Password=it4;Data Source=localhost:1521;";
        bool isEdit = false;
        int id = 0;
        public Reminder()
        {
            InitializeComponent();
        }

        public void LoadDocuments()
        {
            OracleConnection con = new OracleConnection(connect);
            con.Open();

            string query = $@"Select document_id,document_number from documents where user_id={Program.LoggedInUserId} and status='ACTIVE'";

            OracleCommand cmd = new OracleCommand(query, con);
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            doccb.DataSource = dt;
            doccb.ValueMember = "document_id";
            doccb.DisplayMember = "document_number";

            

            con.Close();
        }

        public void Clear()
        {
            doccb.SelectedIndex = 0;
            daysnum.Value = 1;
            chanelcb.SelectedIndex = 0;
            activecb.Checked = true;
            isEdit = false;
            doccb.Enabled = true;
        }

        private void Reminder_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            LoadDocuments();
            //LoadReminders();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(connect);
            string active = activecb.Checked ? "Y" : "N";



            if (isEdit)
            {
                con.Open();
                string query = $@"Update reminder_settings set Reminder_Days_before={daysnum.Value},reminder_channel='{chanelcb.Text}',is_active='{active}' where reminder_id={id}";

                OracleCommand cmd = new OracleCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reminder has been Updated successfully!");
                isEdit = false;
                doccb.Enabled = true;
                Clear();
                LoadReminders();
                con.Close();
            }
            else
            {
                try
                {
                    con.Open();

                    string query1 = $@"Select count(*) from reminder_settings where User_ID={Program.LoggedInUserId} and document_ID={doccb.SelectedValue}";

                    OracleCommand cmd = new OracleCommand(query1, con);
                    OracleDataReader reader = cmd.ExecuteReader();

                    int count = 0;

                    if (reader.Read())
                    {
                        count = Convert.ToInt32(reader[0]);
                    }

                    reader.Close();

                    if (count > 0)
                    {
                        MessageBox.Show("Reminder already exists for this document!");
                        con.Close();
                        return;
                    }

                    string query = $@"Insert into Reminder_settings (Reminder_ID,User_ID,Document_ID,Reminder_Days_Before,Reminder_channel,Is_Active) values(REMINDER_SEQ.NEXTVAL,{Program.LoggedInUserId},{doccb.SelectedValue},{daysnum.Value},'{chanelcb.Text}','{active}')";

                    OracleCommand cmd1 = new OracleCommand(query, con);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Reminder has been configured successfully!");
                    Clear();
                    LoadReminders();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }
        public void LoadReminders()
        {
            OracleConnection con = new OracleConnection(connect);
            con.Open();

            string query = @$"Select r.reminder_id,r.Document_id,
                            d.Document_Number,
                            r.Reminder_Days_Before,
                            r.Reminder_Channel,
                            r.Is_Active
                     from Reminder_Settings r
                     join Documents d
                     on r.Document_Id = d.Document_Id
                     where r.User_Id ={Program.LoggedInUserId}";

            OracleCommand cmd = new OracleCommand(query, con);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No documents found!");
            }

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Reminder_ID"].Visible = false;
            dataGridView1.Columns["Document_ID"].Visible = false;

            if (!dataGridView1.Columns.Contains("btnEdit"))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "btnEdit";
                btn.HeaderText = "Action";
                btn.Text = "Edit";
                btn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btn);

                DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
                btn2.Name = "btnDel";
                btn2.HeaderText = "Action";
                btn2.Text = "Delete";
                btn2.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btn2);
            }
            con.Close();
        }

        private void dispbtn_Click(object sender, EventArgs e)
        {
            LoadReminders();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            OracleConnection con = new OracleConnection(connect);
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                id = Convert.ToInt32(row.Cells["Reminder_ID"].Value);

                doccb.SelectedValue = row.Cells["Document_ID"].Value;
                daysnum.Value = Convert.ToInt32(row.Cells["Reminder_Days_Before"].Value);
                chanelcb.Text = row.Cells["Reminder_Channel"].Value.ToString();

                string active = row.Cells["IS_ACTIVE"].Value.ToString();
                activecb.Checked = (active == "Y");

                isEdit = true;
                doccb.Enabled = false;
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "btnDel")
            {
                if ((MessageBox.Show("Are You Sure You Want To Delete This Document?", "Confirm Delete", MessageBoxButtons.YesNo)) == DialogResult.Yes)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    id = Convert.ToInt32(row.Cells["Reminder_ID"].Value);

                    try
                    {
                        con.Open();

                        string query = $@"Update Reminder_settings Set IS_ACTIVE='N' where Reminder_id={id}";
                        OracleCommand cmd = new OracleCommand(query, con);
                        cmd.ExecuteNonQuery();

                        con.Close();
                        LoadReminders();

                        MessageBox.Show("Deleteed This Reminder Successfully!");
                        dispbtn.PerformClick();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
