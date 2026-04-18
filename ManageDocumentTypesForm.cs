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
    public partial class ManageDocumentTypesForm : Form
    {
        string connect = "User Id=system;Password=it4;Data Source=localhost:1521;";
        int id = 0;
        bool isEdit = false;
        public ManageDocumentTypesForm()
        {
            InitializeComponent();
        }

        private void descriplbl_Click(object sender, EventArgs e)
        {

        }

        private void ManageDocumentTypesForm_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            ycb.Checked = true;
        }



        public void LoadDocumentTypes()
        {
            OracleConnection con = new OracleConnection(connect);
            con.Open();
            string Query = "Select * from Document_Types";
            OracleCommand cmd = new OracleCommand(Query, con);
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No documents found!");
            }

            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = dt;

            dataGridView1.Columns["Type_ID"].Visible= false;
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

        public void Clear()
        {
            txtTypeName.Clear();
            txtDiscription.Clear();
            ycb.Checked = true;

            id = 0;
            isEdit = false;
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            if (txtTypeName.Text.Trim() == "" || txtDiscription.Text.Trim() == "")
            {
                MessageBox.Show("All Feilds Are Mandatory!");
                return;
            }

            OracleConnection con = new OracleConnection(connect);

            try
            {
                con.Open();


                if (isEdit)
                {
                    string active = ycb.Checked ? "Y" : "N";
                    string query1 = $@"Update Document_Types 
                                       set TYPE_NAME='{txtTypeName.Text.Trim()}',
                                       DESCRIPTION='{txtDiscription.Text.Trim()}',
                                       IS_ACTIVE='{active}' 
                                       where TYPE_ID={id}";

                    OracleCommand cmd1 = new OracleCommand(query1, con);
                    cmd1.ExecuteNonQuery();
                    LoadDocumentTypes();

                    MessageBox.Show("Document Upadted Successfully!");

                    displaybtn.PerformClick();

                    Clear();
                }
                else
                {

                    string active = ycb.Checked ? "Y" : "N";
                    string query = $@"Insert Into Document_Types values (DOCTYPE_SEQ.NEXTVAL,'{txtTypeName.Text.Trim()}','{txtDiscription.Text.Trim()}','{active}')";
                    OracleCommand command = con.CreateCommand();
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                    LoadDocumentTypes();

                    MessageBox.Show("Document Type Saved Successfully.");
                }
                con.Close();

                Clear();

                isEdit = false;
                id = 0;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }


        }


        private void displaybtn_Click(object sender, EventArgs e)
        {
            LoadDocumentTypes();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                id = Convert.ToInt32(row.Cells["Type_Id"].Value);
                txtTypeName.Text = row.Cells["TYPE_NAME"].Value.ToString();

                txtDiscription.Text = row.Cells["DESCRIPTION"].Value.ToString();

                string active = row.Cells["IS_ACTIVE"].Value.ToString();
                ycb.Checked = (active == "Y");
                isEdit = true;
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "btnDel")
            {
                if ((MessageBox.Show("Are You Sure You Want To Delete This Document?", "Confirm Delete", MessageBoxButtons.YesNo)) == DialogResult.Yes)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    id = Convert.ToInt32(row.Cells["Type_Id"].Value);

                    OracleConnection con = new OracleConnection(connect);
                    try
                    {
                        con.Open();

                        string query = $@"Update Document_Types Set IS_ACTIVE='N' where Type_ID={id}";
                        OracleCommand cmd = new OracleCommand(query, con);
                        cmd.ExecuteNonQuery();

                        con.Close();
                        LoadDocumentTypes();

                        MessageBox.Show("Document Type Deactivated Successfully!");
                        displaybtn.PerformClick();
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
