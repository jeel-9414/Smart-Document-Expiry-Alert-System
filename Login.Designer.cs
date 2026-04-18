namespace Smart_Dcument_Expiry_Alert_System
{
    partial class Login
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
            displogin = new TextBox();
            remcb = new CheckBox();
            reglbl = new LinkLabel();
            newlbl = new Label();
            logbtn = new Button();
            passlbl = new Label();
            ulbl = new Label();
            ptxt = new TextBox();
            utxt = new TextBox();
            SuspendLayout();
            // 
            // displogin
            // 
            displogin.Anchor = AnchorStyles.None;
            displogin.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            displogin.Location = new Point(145, 73);
            displogin.Name = "displogin";
            displogin.ReadOnly = true;
            displogin.Size = new Size(618, 43);
            displogin.TabIndex = 20;
            displogin.Text = "Log-In";
            displogin.TextAlign = HorizontalAlignment.Center;
            // 
            // remcb
            // 
            remcb.Anchor = AnchorStyles.None;
            remcb.AutoSize = true;
            remcb.Location = new Point(377, 333);
            remcb.Name = "remcb";
            remcb.Size = new Size(129, 24);
            remcb.TabIndex = 28;
            remcb.Text = "Remember Me";
            remcb.UseVisualStyleBackColor = true;
            // 
            // reglbl
            // 
            reglbl.Anchor = AnchorStyles.None;
            reglbl.AutoSize = true;
            reglbl.Location = new Point(489, 436);
            reglbl.Name = "reglbl";
            reglbl.Size = new Size(89, 20);
            reglbl.TabIndex = 27;
            reglbl.TabStop = true;
            reglbl.Text = "Registration";
            // 
            // newlbl
            // 
            newlbl.Anchor = AnchorStyles.None;
            newlbl.AutoSize = true;
            newlbl.Location = new Point(322, 436);
            newlbl.Name = "newlbl";
            newlbl.Size = new Size(163, 20);
            newlbl.TabIndex = 26;
            newlbl.Text = "Don’t have an account?";
            // 
            // logbtn
            // 
            logbtn.Anchor = AnchorStyles.None;
            logbtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logbtn.Location = new Point(377, 373);
            logbtn.Name = "logbtn";
            logbtn.Size = new Size(119, 44);
            logbtn.TabIndex = 25;
            logbtn.Text = "Log-in";
            logbtn.UseVisualStyleBackColor = true;
            logbtn.Click += logbtn_Click;
            // 
            // passlbl
            // 
            passlbl.Anchor = AnchorStyles.None;
            passlbl.AutoSize = true;
            passlbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            passlbl.Location = new Point(273, 276);
            passlbl.Name = "passlbl";
            passlbl.Size = new Size(76, 20);
            passlbl.TabIndex = 24;
            passlbl.Text = "Password";
            // 
            // ulbl
            // 
            ulbl.Anchor = AnchorStyles.None;
            ulbl.AutoSize = true;
            ulbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ulbl.Location = new Point(273, 193);
            ulbl.Name = "ulbl";
            ulbl.Size = new Size(80, 20);
            ulbl.TabIndex = 23;
            ulbl.Text = "Username";
            // 
            // ptxt
            // 
            ptxt.Anchor = AnchorStyles.None;
            ptxt.Location = new Point(377, 269);
            ptxt.Name = "ptxt";
            ptxt.PasswordChar = '*';
            ptxt.Size = new Size(229, 27);
            ptxt.TabIndex = 22;
            ptxt.UseSystemPasswordChar = true;
            // 
            // utxt
            // 
            utxt.Anchor = AnchorStyles.None;
            utxt.Location = new Point(377, 193);
            utxt.Name = "utxt";
            utxt.Size = new Size(229, 27);
            utxt.TabIndex = 21;
            utxt.TextChanged += utxt_TextChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(157, 178, 191);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(899, 625);
            Controls.Add(displogin);
            Controls.Add(remcb);
            Controls.Add(reglbl);
            Controls.Add(newlbl);
            Controls.Add(logbtn);
            Controls.Add(passlbl);
            Controls.Add(ulbl);
            Controls.Add(ptxt);
            Controls.Add(utxt);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox displogin;
        private CheckBox remcb;
        private LinkLabel reglbl;
        private Label newlbl;
        private Button logbtn;
        private Label passlbl;
        private Label ulbl;
        private TextBox ptxt;
        private TextBox utxt;
    }
}