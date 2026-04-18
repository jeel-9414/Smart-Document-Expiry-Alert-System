namespace Smart_Dcument_Expiry_Alert_System
{
    partial class Feedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Feedback));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            txtMessage = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            savebtn = new Button();
            dispbtn = new Button();
            ratingcb = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1367, 129);
            panel1.TabIndex = 0;
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
            pictureBox1.Size = new Size(107, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(238, 38);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(1065, 47);
            textBox1.TabIndex = 0;
            textBox1.Text = "Feedback";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMessage
            // 
            txtMessage.Anchor = AnchorStyles.None;
            txtMessage.Location = new Point(637, 262);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(371, 175);
            txtMessage.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(487, 271);
            label2.Name = "label2";
            label2.Size = new Size(94, 28);
            label2.TabIndex = 4;
            label2.Text = "Message";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(424, 489);
            label3.Name = "label3";
            label3.Size = new Size(157, 28);
            label3.TabIndex = 5;
            label3.Text = "Rating Number";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowDrop = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 765);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1367, 168);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // savebtn
            // 
            savebtn.Anchor = AnchorStyles.None;
            savebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            savebtn.Location = new Point(637, 590);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(114, 42);
            savebtn.TabIndex = 12;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // dispbtn
            // 
            dispbtn.Anchor = AnchorStyles.None;
            dispbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dispbtn.Location = new Point(894, 590);
            dispbtn.Name = "dispbtn";
            dispbtn.Size = new Size(114, 42);
            dispbtn.TabIndex = 13;
            dispbtn.Text = "Display";
            dispbtn.UseVisualStyleBackColor = true;
            dispbtn.Click += dispbtn_Click;
            // 
            // ratingcb
            // 
            ratingcb.Anchor = AnchorStyles.None;
            ratingcb.FormattingEnabled = true;
            ratingcb.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            ratingcb.Location = new Point(637, 493);
            ratingcb.Name = "ratingcb";
            ratingcb.Size = new Size(371, 28);
            ratingcb.TabIndex = 14;
            // 
            // Feedback
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(157, 178, 191);
            ClientSize = new Size(1367, 933);
            ControlBox = false;
            Controls.Add(ratingcb);
            Controls.Add(dispbtn);
            Controls.Add(savebtn);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtMessage);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Feedback";
            Text = "Feedback";
            Load += Feedback_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private TextBox txtMessage;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private Button savebtn;
        private Button dispbtn;
        private ComboBox ratingcb;
    }
}