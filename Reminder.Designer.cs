
namespace Smart_Dcument_Expiry_Alert_System
{
    partial class Reminder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reminder));
            panel1 = new Panel();
            disptxt = new TextBox();
            pictureBox1 = new PictureBox();
            doccb = new ComboBox();
            daysnum = new NumericUpDown();
            chanelcb = new ComboBox();
            activecb = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            savebtn = new Button();
            dispbtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)daysnum).BeginInit();
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
            panel1.Size = new Size(1356, 117);
            panel1.TabIndex = 3;
            // 
            // disptxt
            // 
            disptxt.Anchor = AnchorStyles.None;
            disptxt.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            disptxt.Location = new Point(322, 34);
            disptxt.Name = "disptxt";
            disptxt.Size = new Size(862, 47);
            disptxt.TabIndex = 2;
            disptxt.Text = "Reminder Dashboard";
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
            // doccb
            // 
            doccb.Anchor = AnchorStyles.None;
            doccb.FormattingEnabled = true;
            doccb.Location = new Point(733, 279);
            doccb.Name = "doccb";
            doccb.Size = new Size(151, 28);
            doccb.TabIndex = 4;
            // 
            // daysnum
            // 
            daysnum.Anchor = AnchorStyles.None;
            daysnum.Location = new Point(734, 353);
            daysnum.Maximum = new decimal(new int[] { 365, 0, 0, 0 });
            daysnum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            daysnum.Name = "daysnum";
            daysnum.Size = new Size(150, 27);
            daysnum.TabIndex = 5;
            daysnum.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // chanelcb
            // 
            chanelcb.Anchor = AnchorStyles.None;
            chanelcb.FormattingEnabled = true;
            chanelcb.Items.AddRange(new object[] { "APP", "EMAIL", "SMS" });
            chanelcb.Location = new Point(733, 435);
            chanelcb.Name = "chanelcb";
            chanelcb.Size = new Size(151, 28);
            chanelcb.TabIndex = 6;
            // 
            // activecb
            // 
            activecb.Anchor = AnchorStyles.None;
            activecb.AutoSize = true;
            activecb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            activecb.Location = new Point(733, 509);
            activecb.Name = "activecb";
            activecb.Size = new Size(107, 29);
            activecb.TabIndex = 7;
            activecb.Text = "Is Active";
            activecb.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(534, 283);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 8;
            label1.Text = "Select Document";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(534, 351);
            label2.Name = "label2";
            label2.Size = new Size(174, 25);
            label2.TabIndex = 9;
            label2.Text = "Days Before Expiry";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.Location = new Point(534, 434);
            label3.Name = "label3";
            label3.Size = new Size(168, 25);
            label3.TabIndex = 10;
            label3.Text = "Reminder Channel";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 743);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1356, 188);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // savebtn
            // 
            savebtn.Anchor = AnchorStyles.None;
            savebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            savebtn.Location = new Point(534, 564);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(112, 39);
            savebtn.TabIndex = 16;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // dispbtn
            // 
            dispbtn.Anchor = AnchorStyles.None;
            dispbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dispbtn.Location = new Point(772, 564);
            dispbtn.Name = "dispbtn";
            dispbtn.Size = new Size(112, 39);
            dispbtn.TabIndex = 17;
            dispbtn.Text = "Display";
            dispbtn.UseVisualStyleBackColor = true;
            dispbtn.Click += dispbtn_Click;
            // 
            // Reminder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(157, 178, 191);
            ClientSize = new Size(1356, 931);
            ControlBox = false;
            Controls.Add(dispbtn);
            Controls.Add(savebtn);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(activecb);
            Controls.Add(chanelcb);
            Controls.Add(daysnum);
            Controls.Add(doccb);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Reminder";
            Text = "Reminder";
            Load += Reminder_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)daysnum).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Panel panel1;
        private TextBox disptxt;
        private PictureBox pictureBox1;
        private ComboBox doccb;
        private NumericUpDown daysnum;
        private ComboBox chanelcb;
        private CheckBox activecb;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private Button savebtn;
        private Button dispbtn;
    }
}