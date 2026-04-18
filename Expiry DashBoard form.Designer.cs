namespace Smart_Dcument_Expiry_Alert_System
{
    partial class Expiry_DashBoard_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expiry_DashBoard_form));
            panel1 = new Panel();
            disptxt = new TextBox();
            pictureBox1 = new PictureBox();
            filtercb = new ComboBox();
            loadbtn = new Button();
            dataGridView1 = new DataGridView();
            refreshbtn = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(disptxt);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1329, 117);
            panel1.TabIndex = 2;
            // 
            // disptxt
            // 
            disptxt.Anchor = AnchorStyles.None;
            disptxt.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            disptxt.Location = new Point(282, 34);
            disptxt.Name = "disptxt";
            disptxt.ReadOnly = true;
            disptxt.Size = new Size(857, 47);
            disptxt.TabIndex = 2;
            disptxt.Text = "Expiry Dashboard";
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
            pictureBox1.Size = new Size(107, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // filtercb
            // 
            filtercb.Anchor = AnchorStyles.None;
            filtercb.DropDownStyle = ComboBoxStyle.DropDownList;
            filtercb.FormattingEnabled = true;
            filtercb.Items.AddRange(new object[] { "Expiring in 7 Days", "Expiring in 30 Days", "Already Expired", "All Active Documents" });
            filtercb.Location = new Point(629, 238);
            filtercb.Name = "filtercb";
            filtercb.Size = new Size(250, 28);
            filtercb.TabIndex = 3;
            // 
            // loadbtn
            // 
            loadbtn.Anchor = AnchorStyles.None;
            loadbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loadbtn.Location = new Point(506, 370);
            loadbtn.Name = "loadbtn";
            loadbtn.Size = new Size(112, 39);
            loadbtn.TabIndex = 4;
            loadbtn.Text = "Load";
            loadbtn.UseVisualStyleBackColor = true;
            loadbtn.Click += loadbtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 518);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1329, 188);
            dataGridView1.TabIndex = 5;
            // 
            // refreshbtn
            // 
            refreshbtn.Anchor = AnchorStyles.None;
            refreshbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            refreshbtn.Location = new Point(769, 369);
            refreshbtn.Name = "refreshbtn";
            refreshbtn.Size = new Size(110, 40);
            refreshbtn.TabIndex = 6;
            refreshbtn.Text = "Refresh";
            refreshbtn.UseVisualStyleBackColor = true;
            refreshbtn.Click += refreshbtn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(529, 241);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 7;
            label1.Text = "Filter";
            // 
            // Expiry_DashBoard_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(157, 178, 191);
            ClientSize = new Size(1329, 706);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(refreshbtn);
            Controls.Add(dataGridView1);
            Controls.Add(loadbtn);
            Controls.Add(filtercb);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Expiry_DashBoard_form";
            Text = "Expiry_DashBoard_form";
            Load += Expiry_DashBoard_form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox disptxt;
        private PictureBox pictureBox1;
        private ComboBox filtercb;
        private Button loadbtn;
        private DataGridView dataGridView1;
        private Button refreshbtn;
        private Label label1;
    }
}