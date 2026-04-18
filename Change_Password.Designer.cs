namespace Smart_Dcument_Expiry_Alert_System
{
    partial class Change_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Change_Password));
            panel2 = new Panel();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            currtxt = new TextBox();
            newtxt = new TextBox();
            contxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            changebtn = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.CadetBlue;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(913, 125);
            panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(152, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(715, 47);
            textBox1.TabIndex = 3;
            textBox1.Text = "Change Password";
            textBox1.TextAlign = HorizontalAlignment.Center;
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
            // currtxt
            // 
            currtxt.Anchor = AnchorStyles.None;
            currtxt.Font = new Font("Segoe UI Light", 9F);
            currtxt.Location = new Point(491, 195);
            currtxt.Name = "currtxt";
            currtxt.PasswordChar = '.';
            currtxt.Size = new Size(205, 27);
            currtxt.TabIndex = 2;
            currtxt.UseSystemPasswordChar = true;
            // 
            // newtxt
            // 
            newtxt.Anchor = AnchorStyles.None;
            newtxt.Font = new Font("Segoe UI Light", 9F);
            newtxt.Location = new Point(491, 273);
            newtxt.Name = "newtxt";
            newtxt.PasswordChar = '.';
            newtxt.Size = new Size(205, 27);
            newtxt.TabIndex = 3;
            newtxt.UseSystemPasswordChar = true;
            // 
            // contxt
            // 
            contxt.Anchor = AnchorStyles.None;
            contxt.Font = new Font("Segoe UI Light", 9F);
            contxt.Location = new Point(491, 349);
            contxt.Name = "contxt";
            contxt.PasswordChar = '.';
            contxt.Size = new Size(205, 27);
            contxt.TabIndex = 4;
            contxt.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(297, 197);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 5;
            label1.Text = "Current Password";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(297, 279);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 6;
            label2.Text = "New Password";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.Location = new Point(297, 355);
            label3.Name = "label3";
            label3.Size = new Size(165, 25);
            label3.TabIndex = 7;
            label3.Text = "Confirm Password";
            // 
            // changebtn
            // 
            changebtn.Anchor = AnchorStyles.None;
            changebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            changebtn.Location = new Point(432, 441);
            changebtn.Name = "changebtn";
            changebtn.Size = new Size(111, 42);
            changebtn.TabIndex = 8;
            changebtn.Text = "Change";
            changebtn.UseVisualStyleBackColor = true;
            changebtn.Click += changebtn_Click;
            // 
            // Change_Password
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(157, 178, 191);
            ClientSize = new Size(913, 645);
            ControlBox = false;
            Controls.Add(changebtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(contxt);
            Controls.Add(newtxt);
            Controls.Add(currtxt);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Change_Password";
            Text = "Change_Password";
            Load += Change_Password_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private TextBox currtxt;
        private TextBox newtxt;
        private TextBox contxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button changebtn;
    }
}