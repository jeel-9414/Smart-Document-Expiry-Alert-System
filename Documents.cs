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
    public partial class Documents : Form
    {
        string connect = "User Id=system;Password=it4;Data Source=localhost:1521;";
        int doc_id = 0;
        bool isEdit = false;
        public Documents()
        {
            InitializeComponent();
        }

        private void statuscb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void LoadDocumentTypes()
        {
            OracleConnection con = new OracleConnection(connect);

            try
            {
                con.Open();
                string query = "Select * from Document_Types where IS_Active='Y'";
                OracleCommand cmd = new OracleCommand(query, con);
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dtcb.DataSource = dt;
                dtcb.ValueMember = "Type_Id";
                dtcb.DisplayMember = "Type_NAME";

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
            txtdocnum.Clear();
            statuscb.SelectedIndex = 0;
            idate.Value = DateTime.Now;
            edate.Value = DateTime.Now;
            dtcb.Enabled = true;

            doc_id = 0;
            isEdit = false;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (dtcb.Text == "" || txtdocnum.Text.Trim() == "" || statuscb.Text == "")
            {
                MessageBox.Show("All Feilds Are Mandatory!");
                return;
            }

            if (edate.Value <= idate.Value)
            {
                MessageBox.Show("Expiry Date Is Wrong Inserted!");
                return;
            }
            OracleConnection con = new OracleConnection(connect);
            if (isEdit)
            {
                con.Open();
                string query = $@"Update Documents
                                  set Document_Number = '{txtdocnum.Text}',
                                  Issue_Date = TO_DATE('{idate.Value:dd-MM-yyyy}','DD-MM-YYYY'),
                                  Expiry_Date = TO_DATE('{edate.Value:dd-MM-yyyy}','DD-MM-YYYY'),
                                  Status = '{statuscb.Text}'
                                  where Document_Id = {doc_id}";

                OracleCommand cmd = new OracleCommand(query, con);
                cmd.ExecuteNonQuery();

                foreach (Control ctrl in attributespanel.Controls)
                {
                    if (ctrl.Tag != null)
                    {
                        int attId = Convert.ToInt32(ctrl.Tag);
                        string value = ctrl.Text;

                        string query1 = $@"Update document_attribute_values set attribute_value='{value}' where document_ID={doc_id} and attribute_ID={attId}";

                        OracleCommand cmd2 = new OracleCommand(query1, con);
                        cmd2.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Document Upadted Successfully!");
                Clear();
                con.Close();
                dispbtn.PerformClick();

            }
            else
            {
                try
                {
                    con.Open();
                    foreach (Control ctrl in attributespanel.Controls)
                    {
                        if (ctrl.Tag != null)
                        {
                            if (ctrl.Text.Trim() == "")
                            {
                                MessageBox.Show("Please fill all the fields!");
                                ctrl.Focus();
                                return;
                            }
                        }
                    }
                    string query = $@"Insert into Documents (Document_Id,User_Id,Type_Id,Document_number,issue_date,expiry_date,Status) values (DOC_SEQ.NEXTVAL,{Program.LoggedInUserId},{dtcb.SelectedValue},'{txtdocnum.Text.Trim()}',TO_DATE('{idate.Value:dd-MM-yyyy}','DD-MM-YYYY'),TO_DATE('{edate.Value:dd-MM-yyyy}','DD-MM-YYYY'),'{statuscb.Text}')";


                    OracleCommand cmd = new OracleCommand(query, con);
                    cmd.ExecuteNonQuery();

                    int docId = 0;
                    string query1 = "Select Max(Document_ID) from Documents";
                    OracleCommand cmd1 = new OracleCommand(query1, con);
                    OracleDataReader reader = cmd1.ExecuteReader();

                    if (reader.Read())
                    {
                        docId = Convert.ToInt32(reader[0].ToString());
                    }

                    reader.Close();


                    foreach (Control ctrl in attributespanel.Controls)
                    {
                        if (ctrl.Tag != null)
                        {
                            int attId = Convert.ToInt32(ctrl.Tag);
                            string value = ctrl.Text;

                            string query2 = $@"Insert into Document_Attribute_Values (value_id,document_id,attribute_id,attribute_value) values (VAL_SEQ.NEXTVAL,{docId},{attId},'{value}')";

                            OracleCommand cmd3 = new OracleCommand(query2, con);
                            cmd3.ExecuteNonQuery();
                        }
                    }
                    dispbtn.PerformClick();
                    con.Close();
                    Clear();
                    MessageBox.Show("Document Details Saved!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }

        private void display()
        {
            OracleConnection con = new OracleConnection(connect);

            try
            {
                con.Open();
                string query = $@"Select Document_Id,User_Id,Type_Id,Document_number,issue_date,expiry_date,Status from Documents where User_ID={Program.LoggedInUserId}";
                OracleCommand cmd = new OracleCommand(query, con);
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No documents found!");
                }

                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = dt;

                dataGridView1.Columns["Document_Id"].Visible = false;
                dataGridView1.Columns["User_Id"].Visible = false;
                dataGridView1.Columns["Type_Id"].Visible = false;

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

        private void dispbtn_Click(object sender, EventArgs e)
        {
            display();
        }

        public void attributes_generator()
        {
            attributespanel.Controls.Clear();

            OracleConnection con = new OracleConnection(connect);
            con.Open();

            string query = $@"Select Attribute_ID,Attribute_Name,Data_Type,IS_Required from Document_Attributes where Type_Id={dtcb.SelectedValue} and IS_ACTIVE='Y'";
            OracleCommand cmd = new OracleCommand(query, con);
            OracleDataReader reader = cmd.ExecuteReader();

            int top = 40;

            while (reader.Read())
            {
                Label lbl = new Label();
                lbl.Text = reader["Attribute_Name"].ToString();
                lbl.Left = 20;
                lbl.AutoSize = true;
                lbl.Top = top;
                lbl.Width = 180;

                Control ctrl;

                string DataType = reader["Data_Type"].ToString();

                if (DataType == "VARCHAR")
                {
                    ctrl = new TextBox();
                }
                else if (DataType == "NUMBER")
                {
                    ctrl = new TextBox();
                }
                else if (DataType == "DATE")
                {
                    ctrl = new DateTimePicker();
                }
                else
                {
                    ComboBox cmb = new ComboBox();
                    cmb.Items.Add("Bike");
                    cmb.Items.Add("Bus");
                    cmb.Items.Add("Car");
                    cmb.Items.Add("Truck");

                    ctrl = cmb;
                }

                ctrl.Left = 200;
                ctrl.Top = top;
                ctrl.Width = 180;
                ctrl.Tag = reader["Attribute_Id"];

                attributespanel.Controls.Add(lbl);
                attributespanel.Controls.Add(ctrl);

                top += 45;
            }
            reader.Close();
            con.Close();
        }

        private void Documents_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            LoadDocumentTypes();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                doc_id = Convert.ToInt32(row.Cells["Document_Id"].Value);
                dtcb.SelectedValue = row.Cells["Type_Id"].Value;
                attributes_generator();
                LoadAttributeValues(doc_id);
                txtdocnum.Text = row.Cells["Document_number"].Value.ToString();
                idate.Value = Convert.ToDateTime(row.Cells["Issue_Date"].Value);
                edate.Value = Convert.ToDateTime(row.Cells["Expiry_Date"].Value);
                statuscb.Text = row.Cells["Status"].Value.ToString();

                isEdit = true;
                dtcb.Enabled = false;
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "btnDel")
            {
                if (MessageBox.Show("Are You Sure You Want To Delete This Document?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    int delId = Convert.ToInt32(row.Cells["Document_Id"].Value);

                    OracleConnection con = new OracleConnection(connect);

                    try
                    {
                        con.Open();
                        string query = $@"Update Documents set status='REVOKED' where Document_ID={delId}";
                        OracleCommand cmd = new OracleCommand(query, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Document Deleted Successfully!");
                        con.Close();
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

        private void dtcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            attributes_generator();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        }

        public void LoadAttributes(int id)
        {
            OracleConnection con = new OracleConnection(connect);

            try
            {
                con.Open();

                string query = $@"Select da.Attribute_Name,dav.Attribute_Value from Document_Attribute_Values dav join Document_Attributes da on da.Attribute_ID=dav.Attribute_ID where dav.Document_Id={id}";

                OracleCommand cmd = new OracleCommand(query, con);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView2.DataSource = dt;

                dataGridView2.Columns["Attribute_Name"].HeaderText = "FIELD NAME";
                dataGridView2.Columns["Attribute_Value"].HeaderText = "FIELD VALUE";


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        public void LoadAttributeValues(int id)
        {
            OracleConnection con = new OracleConnection(connect);
            con.Open();

            string query = $@"Select Attribute_Id,Attribute_Value from Document_Attribute_Values where Document_Id={id}";

            OracleCommand cmd = new OracleCommand(query, con);
            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int attId = Convert.ToInt32(reader["Attribute_ID"]);

                foreach (Control ctrl in attributespanel.Controls)
                {
                    if (ctrl.Tag != null)
                    {
                        int cid = Convert.ToInt32(ctrl.Tag);

                        if (cid == attId)
                        {
                            if (ctrl is DateTimePicker)
                            {
                                DateTimePicker dp = (DateTimePicker)ctrl;
                                dp.Value = Convert.ToDateTime(reader["Attribute_Value"]);
                            }
                            else
                            {
                                ctrl.Text = reader["Attribute_Value"].ToString();
                            }
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                LoadAttributes(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Document_Id"].Value));
        }

        private void seabtn_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(connect);

            try
            {
                con.Open();
                string query = $@"Select Document_Id,User_Id,Type_Id,Document_number,issue_date,expiry_date,Status  from documents where Type_id={dtcb.SelectedValue} and user_ID={Program.LoggedInUserId}";

                OracleCommand cmd = new OracleCommand(query, con);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
    }
}
