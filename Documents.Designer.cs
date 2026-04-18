namespace Smart_Dcument_Expiry_Alert_System
{
    partial class Documents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Documents));
            panel1 = new Panel();
            attributespanel = new Panel();
            dataGridView1 = new DataGridView();
            dispbtn = new Button();
            savebtn = new Button();
            statuslbl = new Label();
            edatelbl = new Label();
            idatelbl = new Label();
            dnumlbl = new Label();
            doctypeslbl = new Label();
            statuscb = new ComboBox();
            edate = new DateTimePicker();
            idate = new DateTimePicker();
            txtdocnum = new TextBox();
            dtcb = new ComboBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            dataGridView2 = new DataGridView();
            seabtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(157, 178, 191);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(seabtn);
            panel1.Controls.Add(attributespanel);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(dispbtn);
            panel1.Controls.Add(savebtn);
            panel1.Controls.Add(statuslbl);
            panel1.Controls.Add(edatelbl);
            panel1.Controls.Add(idatelbl);
            panel1.Controls.Add(dnumlbl);
            panel1.Controls.Add(doctypeslbl);
            panel1.Controls.Add(statuscb);
            panel1.Controls.Add(edate);
            panel1.Controls.Add(idate);
            panel1.Controls.Add(txtdocnum);
            panel1.Controls.Add(dtcb);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dataGridView2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1773, 918);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // attributespanel
            // 
            attributespanel.Anchor = AnchorStyles.None;
            attributespanel.BorderStyle = BorderStyle.FixedSingle;
            attributespanel.Location = new Point(1070, 125);
            attributespanel.Name = "attributespanel";
            attributespanel.Size = new Size(751, 471);
            attributespanel.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 596);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1771, 174);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // dispbtn
            // 
            dispbtn.Anchor = AnchorStyles.None;
            dispbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dispbtn.Location = new Point(679, 523);
            dispbtn.Name = "dispbtn";
            dispbtn.Size = new Size(114, 42);
            dispbtn.TabIndex = 12;
            dispbtn.Text = "Display";
            dispbtn.UseVisualStyleBackColor = true;
            dispbtn.Click += dispbtn_Click;
            // 
            // savebtn
            // 
            savebtn.Anchor = AnchorStyles.None;
            savebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            savebtn.Location = new Point(240, 523);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(114, 42);
            savebtn.TabIndex = 11;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // statuslbl
            // 
            statuslbl.Anchor = AnchorStyles.None;
            statuslbl.AutoSize = true;
            statuslbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            statuslbl.Location = new Point(302, 451);
            statuslbl.Name = "statuslbl";
            statuslbl.Size = new Size(65, 25);
            statuslbl.TabIndex = 10;
            statuslbl.Text = "Status";
            // 
            // edatelbl
            // 
            edatelbl.Anchor = AnchorStyles.None;
            edatelbl.AutoSize = true;
            edatelbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            edatelbl.Location = new Point(302, 390);
            edatelbl.Name = "edatelbl";
            edatelbl.Size = new Size(111, 25);
            edatelbl.TabIndex = 9;
            edatelbl.Text = "Expiry Date";
            // 
            // idatelbl
            // 
            idatelbl.Anchor = AnchorStyles.None;
            idatelbl.AutoSize = true;
            idatelbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            idatelbl.Location = new Point(302, 315);
            idatelbl.Name = "idatelbl";
            idatelbl.Size = new Size(100, 25);
            idatelbl.TabIndex = 8;
            idatelbl.Text = "Issue Date";
            // 
            // dnumlbl
            // 
            dnumlbl.Anchor = AnchorStyles.None;
            dnumlbl.AutoSize = true;
            dnumlbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            dnumlbl.Location = new Point(302, 247);
            dnumlbl.Name = "dnumlbl";
            dnumlbl.Size = new Size(135, 25);
            dnumlbl.TabIndex = 7;
            dnumlbl.Text = "Document No.";
            // 
            // doctypeslbl
            // 
            doctypeslbl.Anchor = AnchorStyles.None;
            doctypeslbl.AutoSize = true;
            doctypeslbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            doctypeslbl.Location = new Point(302, 182);
            doctypeslbl.Name = "doctypeslbl";
            doctypeslbl.Size = new Size(154, 25);
            doctypeslbl.TabIndex = 6;
            doctypeslbl.Text = "Document Types";
            // 
            // statuscb
            // 
            statuscb.Anchor = AnchorStyles.None;
            statuscb.FormattingEnabled = true;
            statuscb.Items.AddRange(new object[] { "ACTIVE", "EXPIRED", "REVOKED" });
            statuscb.Location = new Point(462, 448);
            statuscb.Name = "statuscb";
            statuscb.Size = new Size(263, 28);
            statuscb.TabIndex = 5;
            statuscb.SelectedIndexChanged += statuscb_SelectedIndexChanged;
            // 
            // edate
            // 
            edate.Anchor = AnchorStyles.None;
            edate.Location = new Point(462, 388);
            edate.Name = "edate";
            edate.Size = new Size(263, 27);
            edate.TabIndex = 4;
            // 
            // idate
            // 
            idate.Anchor = AnchorStyles.None;
            idate.Location = new Point(462, 313);
            idate.Name = "idate";
            idate.Size = new Size(263, 27);
            idate.TabIndex = 3;
            // 
            // txtdocnum
            // 
            txtdocnum.Anchor = AnchorStyles.None;
            txtdocnum.Location = new Point(462, 245);
            txtdocnum.Name = "txtdocnum";
            txtdocnum.Size = new Size(263, 27);
            txtdocnum.TabIndex = 2;
            // 
            // dtcb
            // 
            dtcb.Anchor = AnchorStyles.None;
            dtcb.FormattingEnabled = true;
            dtcb.Location = new Point(462, 179);
            dtcb.Name = "dtcb";
            dtcb.Size = new Size(263, 28);
            dtcb.TabIndex = 1;
            dtcb.SelectedIndexChanged += dtcb_SelectedIndexChanged;
            dtcb.SelectionChangeCommitted += dtcb_SelectionChangeCommitted;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CadetBlue;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(textBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1771, 125);
            panel2.TabIndex = 0;
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
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(223, 44);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(1379, 47);
            textBox1.TabIndex = 0;
            textBox1.Text = "Document Details ";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Bottom;
            dataGridView2.Location = new Point(0, 770);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(1771, 146);
            dataGridView2.TabIndex = 15;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // seabtn
            // 
            seabtn.Anchor = AnchorStyles.None;
            seabtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            seabtn.Location = new Point(462, 523);
            seabtn.Name = "seabtn";
            seabtn.Size = new Size(114, 42);
            seabtn.TabIndex = 16;
            seabtn.Text = "Search";
            seabtn.UseVisualStyleBackColor = true;
            seabtn.Click += seabtn_Click;
            // 
            // Documents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1773, 918);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Documents";
            Text = "Docuemnts";
            Load += Documents_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private ComboBox statuscb;
        private DateTimePicker edate;
        private DateTimePicker idate;
        private TextBox txtdocnum;
        private Label statuslbl;
        private Label edatelbl;
        private Label idatelbl;
        private Label dnumlbl;
        private Button savebtn;
        private DataGridView dataGridView1;
        private Button dispbtn;
        private Label doctypeslbl;
        private ComboBox dtcb;
        private Panel attributespanel;
        private DataGridView dataGridView2;
        private Button seabtn;
    }
}