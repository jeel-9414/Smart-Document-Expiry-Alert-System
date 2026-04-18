namespace Smart_Dcument_Expiry_Alert_System
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            manageToolStripMenuItem = new ToolStripMenuItem();
            documentTypesToolStripMenuItem = new ToolStripMenuItem();
            attributesToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            documentsToolStripMenuItem = new ToolStripMenuItem();
            reminderToolStripMenuItem = new ToolStripMenuItem();
            notificationToolStripMenuItem = new ToolStripMenuItem();
            feedbackToolStripMenuItem = new ToolStripMenuItem();
            aboutUsToolStripMenuItem = new ToolStripMenuItem();
            logToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.AliceBlue;
            menuStrip1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, manageToolStripMenuItem, documentsToolStripMenuItem, reminderToolStripMenuItem, notificationToolStripMenuItem, feedbackToolStripMenuItem, aboutUsToolStripMenuItem, logToolStripMenuItem });
            menuStrip1.Location = new Point(15, 15);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 5, 10, 5);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(979, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(118, 30);
            dashboardToolStripMenuItem.Text = "Dashboard";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // manageToolStripMenuItem
            // 
            manageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { documentTypesToolStripMenuItem, attributesToolStripMenuItem, changePasswordToolStripMenuItem });
            manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            manageToolStripMenuItem.Size = new Size(95, 30);
            manageToolStripMenuItem.Text = "Manage";
            manageToolStripMenuItem.Click += manageToolStripMenuItem_Click;
            // 
            // documentTypesToolStripMenuItem
            // 
            documentTypesToolStripMenuItem.Name = "documentTypesToolStripMenuItem";
            documentTypesToolStripMenuItem.Size = new Size(247, 30);
            documentTypesToolStripMenuItem.Text = "Document Types";
            documentTypesToolStripMenuItem.Click += documentTypesToolStripMenuItem_Click;
            // 
            // attributesToolStripMenuItem
            // 
            attributesToolStripMenuItem.Name = "attributesToolStripMenuItem";
            attributesToolStripMenuItem.Size = new Size(247, 30);
            attributesToolStripMenuItem.Text = "Document  Fields";
            attributesToolStripMenuItem.Click += attributesToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(247, 30);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // documentsToolStripMenuItem
            // 
            documentsToolStripMenuItem.Name = "documentsToolStripMenuItem";
            documentsToolStripMenuItem.Size = new Size(122, 30);
            documentsToolStripMenuItem.Text = "Documents";
            documentsToolStripMenuItem.Click += documentsToolStripMenuItem_Click;
            // 
            // reminderToolStripMenuItem
            // 
            reminderToolStripMenuItem.Name = "reminderToolStripMenuItem";
            reminderToolStripMenuItem.Size = new Size(108, 30);
            reminderToolStripMenuItem.Text = "Reminder";
            reminderToolStripMenuItem.Click += reminderToolStripMenuItem_Click;
            // 
            // notificationToolStripMenuItem
            // 
            notificationToolStripMenuItem.Name = "notificationToolStripMenuItem";
            notificationToolStripMenuItem.Size = new Size(128, 30);
            notificationToolStripMenuItem.Text = "Notification";
            notificationToolStripMenuItem.Click += notificationToolStripMenuItem_Click;
            // 
            // feedbackToolStripMenuItem
            // 
            feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            feedbackToolStripMenuItem.Size = new Size(106, 30);
            feedbackToolStripMenuItem.Text = "Feedback";
            feedbackToolStripMenuItem.Click += feedbackToolStripMenuItem_Click;
            // 
            // aboutUsToolStripMenuItem
            // 
            aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            aboutUsToolStripMenuItem.Size = new Size(105, 30);
            aboutUsToolStripMenuItem.Text = "About Us";
            aboutUsToolStripMenuItem.Click += aboutUsToolStripMenuItem_Click;
            // 
            // logToolStripMenuItem
            // 
            logToolStripMenuItem.Name = "logToolStripMenuItem";
            logToolStripMenuItem.Size = new Size(86, 30);
            logToolStripMenuItem.Text = "Logout";
            logToolStripMenuItem.Click += logToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1009, 756);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlText;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Padding = new Padding(15);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Smart Document Expiry Alert System";
            Load += Smart_Document_Expiry_Alert_System_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem documentsToolStripMenuItem;
        private ToolStripMenuItem reminderToolStripMenuItem;
        private ToolStripMenuItem notificationToolStripMenuItem;
        private ToolStripMenuItem manageToolStripMenuItem;
        private ToolStripMenuItem feedbackToolStripMenuItem;
        private ToolStripMenuItem aboutUsToolStripMenuItem;
        private ToolStripMenuItem logToolStripMenuItem;
        private ToolStripMenuItem documentTypesToolStripMenuItem;
        private ToolStripMenuItem attributesToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}