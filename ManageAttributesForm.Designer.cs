namespace Smart_Dcument_Expiry_Alert_System
{
    partial class ManageAttributesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAttributesForm));
            panel1 = new Panel();
            label5 = new Label();
            stacb = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dispbtn = new Button();
            savebtn = new Button();
            reqcb = new CheckBox();
            ftypecb = new ComboBox();
            fnametxt = new TextBox();
            typecb = new ComboBox();
            panel2 = new Panel();
            disptxt = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(157, 178, 191);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(stacb);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(dispbtn);
            panel1.Controls.Add(savebtn);
            panel1.Controls.Add(reqcb);
            panel1.Controls.Add(ftypecb);
            panel1.Controls.Add(fnametxt);
            panel1.Controls.Add(typecb);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1290, 810);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.Location = new Point(439, 485);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 14;
            label5.Text = "Status";
            // 
            // stacb
            // 
            stacb.Anchor = AnchorStyles.None;
            stacb.AutoSize = true;
            stacb.Checked = true;
            stacb.CheckState = CheckState.Checked;
            stacb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            stacb.Location = new Point(619, 484);
            stacb.Name = "stacb";
            stacb.Size = new Size(107, 29);
            stacb.TabIndex = 13;
            stacb.Text = "Is Active";
            stacb.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.Location = new Point(439, 411);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 12;
            label4.Text = "Required";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.Location = new Point(439, 332);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 11;
            label3.Text = "Field Type";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(439, 250);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 10;
            label2.Text = "Field Name ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(439, 171);
            label1.Name = "label1";
            label1.Size = new Size(154, 25);
            label1.TabIndex = 9;
            label1.Text = "Document Types";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 620);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1288, 188);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dispbtn
            // 
            dispbtn.Anchor = AnchorStyles.None;
            dispbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            dispbtn.Location = new Point(722, 545);
            dispbtn.Name = "dispbtn";
            dispbtn.Size = new Size(115, 37);
            dispbtn.TabIndex = 7;
            dispbtn.Text = "Display";
            dispbtn.UseVisualStyleBackColor = true;
            dispbtn.Click += dispbtn_Click;
            // 
            // savebtn
            // 
            savebtn.Anchor = AnchorStyles.None;
            savebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            savebtn.Location = new Point(403, 545);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(115, 37);
            savebtn.TabIndex = 6;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // reqcb
            // 
            reqcb.Anchor = AnchorStyles.None;
            reqcb.AutoSize = true;
            reqcb.Checked = true;
            reqcb.CheckState = CheckState.Checked;
            reqcb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            reqcb.Location = new Point(619, 410);
            reqcb.Name = "reqcb";
            reqcb.Size = new Size(130, 29);
            reqcb.TabIndex = 5;
            reqcb.Text = "Is Required";
            reqcb.UseVisualStyleBackColor = true;
            // 
            // ftypecb
            // 
            ftypecb.Anchor = AnchorStyles.None;
            ftypecb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            ftypecb.FormattingEnabled = true;
            ftypecb.Items.AddRange(new object[] { "Text", "Number", "Date", "List" });
            ftypecb.Location = new Point(619, 324);
            ftypecb.Name = "ftypecb";
            ftypecb.Size = new Size(207, 33);
            ftypecb.TabIndex = 4;
            // 
            // fnametxt
            // 
            fnametxt.Anchor = AnchorStyles.None;
            fnametxt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            fnametxt.Location = new Point(619, 244);
            fnametxt.Name = "fnametxt";
            fnametxt.Size = new Size(207, 31);
            fnametxt.TabIndex = 3;
            // 
            // typecb
            // 
            typecb.Anchor = AnchorStyles.None;
            typecb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            typecb.FormattingEnabled = true;
            typecb.Location = new Point(619, 163);
            typecb.Name = "typecb";
            typecb.Size = new Size(207, 33);
            typecb.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CadetBlue;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(disptxt);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1288, 125);
            panel2.TabIndex = 2;
            // 
            // disptxt
            // 
            disptxt.Anchor = AnchorStyles.None;
            disptxt.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            disptxt.Location = new Point(217, 39);
            disptxt.Name = "disptxt";
            disptxt.ReadOnly = true;
            disptxt.Size = new Size(906, 47);
            disptxt.TabIndex = 3;
            disptxt.Text = "Manage Document Fields";
            disptxt.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.Wordmark_Logo_for_Smart_Document_System;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // ManageAttributesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1290, 810);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ManageAttributesForm";
            Text = "ManageAttributesForm";
            Load += ManageAttributesForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox disptxt;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Button dispbtn;
        private Button savebtn;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox reqcb;
        private ComboBox ftypecb;
        private TextBox fnametxt;
        private ComboBox typecb;
        private Label label5;
        private CheckBox stacb;
    }
}