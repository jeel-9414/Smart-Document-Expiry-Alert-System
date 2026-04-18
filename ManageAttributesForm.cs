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
    public partial class ManageAttributesForm : Form
    {
        string connect = "User Id=system;Password=it4;Data Source=localhost:1521;";
        int AttID = 0;
        bool isEdit = false;
        public ManageAttributesForm()
        {
            InitializeComponent();
        }

        public void LoadTypes()
        {
            OracleConnection con = new OracleConnection(connect);

            try
            {
                con.Open();
                string query = "Select Type_Id,Type_Name from Document_Types where Is_Active='Y'";
                OracleCommand cmd = new OracleCommand(query, con);
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                typecb.DataSource = dt;
                typecb.ValueMember = "Type_Id";
                typecb.DisplayMember = "Type_Name";

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        public void Clear()
        {
            fnametxt.Clear();
            typecb.SelectedIndex = 0;
            ftypecb.SelectedIndex = 0;
            AttID = 0;

            reqcb.Checked = true;
            isEdit = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (fnametxt.Text == "" || ftypecb.Text == "")
            {
                MessageBox.Show("All Fields Are Mandatory!");
                return;
            }

            string type;
            if (ftypecb.Text == "Text")
                type = "VARCHAR";
            else if (ftypecb.Text == "Number")
                type = "NUMBER";
            else if (ftypecb.Text == "Date")
                type = "DATE";
            else
                type = "LIST";

            string req = reqcb.Checked ? "Y" : "N";
            string sta = stacb.Checked ? "Y" : "N";

            OracleConnection con = new OracleConnection(connect);
            if (isEdit)
            {
                con.Open();
                string query = $@"Update Document_Attributes set Attribute_Name='{fnametxt.Text}',Data_Type='{type}',IS_ACTIVE='{sta}',Is_Required='{req}' where Attribute_ID={AttID}";

                OracleCommand cmd = new OracleCommand(query, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Document Upadted Successfully!");
                LoadAttributes();

                Clear();
                con.Close();
                dispbtn.PerformClick();
            }
            else
            {
                try
                {
                    con.Open();

                    string chkQuery = $@"Select count(*) from document_attributes where Type_ID={typecb.SelectedValue} and Attribute_Name='{fnametxt.Text.Trim()}'";

                    OracleCommand cmd1 = new OracleCommand(chkQuery, con);
                    OracleDataReader reader = cmd1.ExecuteReader();

                    int count = 0;

                    if (reader.Read())
                    {
                        count = Convert.ToInt32(reader[0]);
                    }
                    reader.Close();

                    if (count > 0)
                    {
                        MessageBox.Show("This field already exists for this document type!");
                        con.Close();
                        return;
                    }

                    string query = $@"Insert Into Document_attributes
                               (Attribute_ID,Type_ID,Attribute_Name,Data_type,IS_ACTIVE,Is_Required)
                               values(ATTR_SEQ.NEXTVAL,{typecb.SelectedValue},'{fnametxt.Text.Trim()}','{type}','{sta}','{req}')";

                    OracleCommand cmd = new OracleCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Fileds Are Saved Successfully!");
                    LoadAttributes();

                    Clear();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }

        public void LoadAttributes()
        {
            OracleConnection con = new OracleConnection(connect);

            try
            {
                con.Open();

                string query = $@"Select Attribute_Id,Type_Id,Attribute_Name,Data_Type,IS_ACTIVE,IS_Required from Document_Attributes";

                OracleCommand cmd = new OracleCommand(query, con);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No documents found!");
                }

                dataGridView1.DataSource = dt;


                dataGridView1.Columns["ATTRIBUTE_ID"].Visible = false;
                dataGridView1.Columns["Type_Id"].Visible = false;

                dataGridView1.Columns["ATTRIBUTE_NAME"].HeaderText = "Field Name";
                dataGridView1.Columns["DATA_TYPE"].HeaderText = "Field Type";
                dataGridView1.Columns["IS_Active"].HeaderText = "Active Status";
                dataGridView1.Columns["IS_REQUIRED"].HeaderText = "Required";

                if (!dataGridView1.Columns.Contains("btnEdit"))
                {
                    DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                    btnEdit.Name = "btnEdit";
                    btnEdit.HeaderText = "Action";
                    btnEdit.Text = "Edit";
                    btnEdit.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(btnEdit);

                    DataGridViewButtonColumn btnDel = new DataGridViewButtonColumn();
                    btnDel.Name = "btnDel";
                    btnDel.HeaderText = "Action";
                    btnDel.Text = "Delete";
                    btnDel.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(btnDel);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void ManageAttributesForm_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            LoadTypes();

        }

        private void dispbtn_Click(object sender, EventArgs e)
        {
            LoadAttributes();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                AttID = Convert.ToInt32(row.Cells["Attribute_ID"].Value);
                typecb.SelectedValue = row.Cells["Type_ID"].Value;
                fnametxt.Text = row.Cells["Attribute_Name"].Value.ToString();
                ftypecb.SelectedValue = row.Cells["Data_Type"].Value.ToString();
                stacb.Checked = row.Cells["Is_Active"].Value.ToString() == "Y";
                reqcb.Checked = row.Cells["IS_Required"].Value.ToString() == "Y";

                isEdit = true;
                dispbtn.PerformClick();
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "btnDel")
            {
                if (MessageBox.Show("Are you sure you Want to Delete The Record?", "Confirm Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    int delID = Convert.ToInt32(row.Cells["Attribute_Id"].Value);

                    OracleConnection con = new OracleConnection(connect);

                    try
                    {
                        con.Open();
                        string query = $@"Update Document_Attributes set IS_Active='N' where Attribute_ID={delID}";
                        OracleCommand cmd = new OracleCommand(query, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Document Deleted Successfully!");
                        LoadAttributes();

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
            }

        }
    }
}
