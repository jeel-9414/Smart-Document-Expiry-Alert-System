namespace Smart_Dcument_Expiry_Alert_System
{
    partial class Registration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            disptxt = new TextBox();
            utxt = new TextBox();
            ptxt = new TextBox();
            etxt = new TextBox();
            ctxt = new TextBox();
            regbtn = new Button();
            userlbl = new Label();
            emaillbl = new Label();
            Password = new Label();
            conplbl = new Label();
            loginlbl = new LinkLabel();
            newlbl = new Label();
            SuspendLayout();
            // 
            // disptxt
            // 
            disptxt.Anchor = AnchorStyles.None;
            disptxt.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            disptxt.Location = new Point(334, 32);
            disptxt.Name = "disptxt";
            disptxt.ReadOnly = true;
            disptxt.Size = new Size(687, 43);
            disptxt.TabIndex = 0;
            disptxt.Text = "Registration";
            disptxt.TextAlign = HorizontalAlignment.Center;
            disptxt.TextChanged += textBox1_TextChanged;
            // 
            // utxt
            // 
            utxt.Anchor = AnchorStyles.None;
            utxt.Location = new Point(587, 130);
            utxt.Name = "utxt";
            utxt.Size = new Size(134, 27);
            utxt.TabIndex = 1;
            utxt.TextChanged += textBox2_TextChanged;
            // 
            // ptxt
            // 
            ptxt.Anchor = AnchorStyles.None;
            ptxt.Location = new Point(587, 240);
            ptxt.Name = "ptxt";
            ptxt.PasswordChar = '*';
            ptxt.Size = new Size(134, 27);
            ptxt.TabIndex = 2;
            ptxt.UseSystemPasswordChar = true;
            // 
            // etxt
            // 
            etxt.Anchor = AnchorStyles.None;
            etxt.Location = new Point(587, 186);
            etxt.Name = "etxt";
            etxt.Size = new Size(346, 27);
            etxt.TabIndex = 3;
            // 
            // ctxt
            // 
            ctxt.Anchor = AnchorStyles.None;
            ctxt.Location = new Point(587, 294);
            ctxt.Name = "ctxt";
            ctxt.PasswordChar = '*';
            ctxt.Size = new Size(134, 27);
            ctxt.TabIndex = 4;
            ctxt.UseSystemPasswordChar = true;
            // 
            // regbtn
            // 
            regbtn.Anchor = AnchorStyles.None;
            regbtn.BackColor = Color.Transparent;
            regbtn.FlatAppearance.BorderSize = 0;
            regbtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            regbtn.ForeColor = SystemColors.ActiveCaptionText;
            regbtn.Location = new Point(518, 398);
            regbtn.Name = "regbtn";
            regbtn.Size = new Size(123, 47);
            regbtn.TabIndex = 5;
            regbtn.TabStop = false;
            regbtn.Text = "Register";
            regbtn.UseVisualStyleBackColor = false;
            regbtn.Click += Regbtn_Click;
            // 
            // userlbl
            // 
            userlbl.Anchor = AnchorStyles.None;
            userlbl.AutoSize = true;
            userlbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userlbl.Location = new Point(416, 137);
            userlbl.Name = "userlbl";
            userlbl.Size = new Size(80, 20);
            userlbl.TabIndex = 6;
            userlbl.Text = "Username";
            // 
            // emaillbl
            // 
            emaillbl.Anchor = AnchorStyles.None;
            emaillbl.AutoSize = true;
            emaillbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            emaillbl.Location = new Point(416, 186);
            emaillbl.Name = "emaillbl";
            emaillbl.Size = new Size(47, 20);
            emaillbl.TabIndex = 7;
            emaillbl.Text = "Email";
            // 
            // Password
            // 
            Password.Anchor = AnchorStyles.None;
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Password.Location = new Point(420, 243);
            Password.Name = "Password";
            Password.Size = new Size(76, 20);
            Password.TabIndex = 8;
            Password.Text = "Password";
            // 
            // conplbl
            // 
            conplbl.Anchor = AnchorStyles.None;
            conplbl.AutoSize = true;
            conplbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            conplbl.Location = new Point(416, 301);
            conplbl.Name = "conplbl";
            conplbl.Size = new Size(137, 20);
            conplbl.TabIndex = 9;
            conplbl.Text = "Confirm Password";
            // 
            // loginlbl
            // 
            loginlbl.Anchor = AnchorStyles.None;
            loginlbl.AutoSize = true;
            loginlbl.Location = new Point(623, 470);
            loginlbl.Name = "loginlbl";
            loginlbl.Size = new Size(52, 20);
            loginlbl.TabIndex = 11;
            loginlbl.TabStop = true;
            loginlbl.Text = "Log-in";
            loginlbl.LinkClicked += loginlbl_LinkClicked;
            // 
            // newlbl
            // 
            newlbl.Anchor = AnchorStyles.None;
            newlbl.AutoSize = true;
            newlbl.Location = new Point(439, 470);
            newlbl.Name = "newlbl";
            newlbl.Size = new Size(178, 20);
            newlbl.TabIndex = 10;
            newlbl.Text = "Already have an account?";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(157, 178, 191);
            ClientSize = new Size(1318, 675);
            Controls.Add(disptxt);
            Controls.Add(loginlbl);
            Controls.Add(newlbl);
            Controls.Add(conplbl);
            Controls.Add(Password);
            Controls.Add(emaillbl);
            Controls.Add(userlbl);
            Controls.Add(regbtn);
            Controls.Add(ctxt);
            Controls.Add(etxt);
            Controls.Add(ptxt);
            Controls.Add(utxt);
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox disptxt;
        private TextBox utxt;
        private TextBox ptxt;
        private TextBox etxt;
        private TextBox ctxt;
        private Button regbtn;
        private Label userlbl;
        private Label emaillbl;
        private Label Password;
        private Label conplbl;
        private LinkLabel loginlbl;
        private Label newlbl;
    }
}
