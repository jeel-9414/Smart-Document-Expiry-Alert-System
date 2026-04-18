namespace Smart_Dcument_Expiry_Alert_System
{
    partial class ManageDocumentTypesForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageDocumentTypesForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            disptxt = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            txtTypeName = new TextBox();
            txtDiscription = new TextBox();
            ycb = new CheckBox();
            dataGridView1 = new DataGridView();
            savebtn = new Button();
            displaybtn = new Button();
            docnamelbl = new Label();
            descriplbl = new Label();
            actlbl = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // disptxt
            // 
            disptxt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            disptxt.BorderStyle = BorderStyle.FixedSingle;
            disptxt.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            disptxt.Location = new Point(305, 30);
            disptxt.Name = "disptxt";
            disptxt.ReadOnly = true;
            disptxt.Size = new Size(540, 47);
            disptxt.TabIndex = 0;
            disptxt.Text = "Mange Document Types";
            disptxt.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(disptxt);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1111, 117);
            panel1.TabIndex = 1;
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
            // txtTypeName
            // 
            txtTypeName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTypeName.Location = new Point(459, 170);
            txtTypeName.Name = "txtTypeName";
            txtTypeName.Size = new Size(343, 27);
            txtTypeName.TabIndex = 2;
            // 
            // txtDiscription
            // 
            txtDiscription.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDiscription.Location = new Point(459, 228);
            txtDiscription.Multiline = true;
            txtDiscription.Name = "txtDiscription";
            txtDiscription.Size = new Size(480, 137);
            txtDiscription.TabIndex = 3;
            // 
            // ycb
            // 
            ycb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ycb.AutoSize = true;
            ycb.Location = new Point(463, 403);
            ycb.Name = "ycb";
            ycb.Size = new Size(82, 24);
            ycb.TabIndex = 5;
            ycb.Text = "IsActive";
            ycb.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 620);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1111, 261);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // savebtn
            // 
            savebtn.Anchor = AnchorStyles.None;
            savebtn.FlatAppearance.BorderColor = Color.Black;
            savebtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            savebtn.Location = new Point(305, 485);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(141, 40);
            savebtn.TabIndex = 7;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // displaybtn
            // 
            displaybtn.Anchor = AnchorStyles.None;
            displaybtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            displaybtn.Location = new Point(638, 485);
            displaybtn.Name = "displaybtn";
            displaybtn.Size = new Size(139, 40);
            displaybtn.TabIndex = 8;
            displaybtn.Text = "Display";
            displaybtn.UseVisualStyleBackColor = true;
            displaybtn.Click += displaybtn_Click;
            // 
            // docnamelbl
            // 
            docnamelbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            docnamelbl.AutoSize = true;
            docnamelbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            docnamelbl.Location = new Point(283, 172);
            docnamelbl.Name = "docnamelbl";
            docnamelbl.Size = new Size(155, 25);
            docnamelbl.TabIndex = 9;
            docnamelbl.Text = "Document Name";
            // 
            // descriplbl
            // 
            descriplbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            descriplbl.AutoSize = true;
            descriplbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            descriplbl.Location = new Point(283, 255);
            descriplbl.Name = "descriplbl";
            descriplbl.Size = new Size(109, 25);
            descriplbl.TabIndex = 10;
            descriplbl.Text = "Description";
            descriplbl.Click += descriplbl_Click;
            // 
            // actlbl
            // 
            actlbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            actlbl.AutoSize = true;
            actlbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            actlbl.Location = new Point(283, 400);
            actlbl.Name = "actlbl";
            actlbl.Size = new Size(159, 25);
            actlbl.TabIndex = 11;
            actlbl.Text = "Document Active";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // ManageDocumentTypesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(157, 178, 191);
            ClientSize = new Size(1111, 881);
            ControlBox = false;
            Controls.Add(actlbl);
            Controls.Add(descriplbl);
            Controls.Add(docnamelbl);
            Controls.Add(displaybtn);
            Controls.Add(savebtn);
            Controls.Add(dataGridView1);
            Controls.Add(ycb);
            Controls.Add(txtDiscription);
            Controls.Add(txtTypeName);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ManageDocumentTypesForm";
            Text = "ManageDocument TypesForm";
            TopMost = true;
            Load += ManageDocumentTypesForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox disptxt;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox txtTypeName;
        private TextBox txtDiscription;
        private CheckBox ycb;
        private DataGridView dataGridView1;
        private Button savebtn;
        private Button displaybtn;
        private Label docnamelbl;
        private Label descriplbl;
        private Label actlbl;
        private ContextMenuStrip contextMenuStrip1;
    }
}