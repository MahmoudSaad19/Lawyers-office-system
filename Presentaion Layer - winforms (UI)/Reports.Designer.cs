namespace Presentaion_Layer___winforms__UI_
{
    partial class Reports
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCreateReport = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.الرئيسيةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.العملاءToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddClient = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowClient = new System.Windows.Forms.ToolStripMenuItem();
            this.Cases = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCase = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowCase = new System.Windows.Forms.ToolStripMenuItem();
            this.الاستشاراتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddConsultaion = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowConsultaion = new System.Windows.Forms.ToolStripMenuItem();
            this.سنداتالقبضToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddSanadKabd = new System.Windows.Forms.ToolStripMenuItem();
            this.عرضسنداتالقبضToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.سنداتالصرفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddSanadSarf = new System.Windows.Forms.ToolStripMenuItem();
            this.عرضسنداتالصرفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EnterReportsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.بياناتالمكتبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(98)))), ((int)(((byte)(108)))));
            this.btnCreateReport.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCreateReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreateReport.Location = new System.Drawing.Point(34, 148);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(132, 41);
            this.btnCreateReport.TabIndex = 3;
            this.btnCreateReport.Text = "انشاء تقرير";
            this.btnCreateReport.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(240, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(736, 441);
            this.dataGridView1.TabIndex = 4;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الرئيسيةToolStripMenuItem,
            this.العملاءToolStripMenuItem,
            this.Cases,
            this.الاستشاراتToolStripMenuItem,
            this.سنداتالقبضToolStripMenuItem,
            this.سنداتالصرفToolStripMenuItem,
            this.EnterReportsMenu,
            this.بياناتالمكتبToolStripMenuItem,
            this.Exit});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip2.Size = new System.Drawing.Size(988, 36);
            this.menuStrip2.TabIndex = 29;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // الرئيسيةToolStripMenuItem
            // 
            this.الرئيسيةToolStripMenuItem.Name = "الرئيسيةToolStripMenuItem";
            this.الرئيسيةToolStripMenuItem.Size = new System.Drawing.Size(90, 32);
            this.الرئيسيةToolStripMenuItem.Text = "الرئيسية";
            this.الرئيسيةToolStripMenuItem.Click += new System.EventHandler(this.الرئيسيةToolStripMenuItem_Click);
            // 
            // العملاءToolStripMenuItem
            // 
            this.العملاءToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddClient,
            this.ShowClient});
            this.العملاءToolStripMenuItem.Name = "العملاءToolStripMenuItem";
            this.العملاءToolStripMenuItem.Size = new System.Drawing.Size(80, 32);
            this.العملاءToolStripMenuItem.Text = "العملاء";
            // 
            // AddClient
            // 
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(190, 32);
            this.AddClient.Text = "اضافة عميل";
            this.AddClient.Click += new System.EventHandler(this.AddClient_Click);
            // 
            // ShowClient
            // 
            this.ShowClient.Name = "ShowClient";
            this.ShowClient.Size = new System.Drawing.Size(190, 32);
            this.ShowClient.Text = "عرض العملاء";
            this.ShowClient.Click += new System.EventHandler(this.ShowClient_Click);
            // 
            // Cases
            // 
            this.Cases.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCase,
            this.ShowCase});
            this.Cases.Name = "Cases";
            this.Cases.Size = new System.Drawing.Size(83, 32);
            this.Cases.Text = "القضايا";
            // 
            // AddCase
            // 
            this.AddCase.Name = "AddCase";
            this.AddCase.Size = new System.Drawing.Size(193, 32);
            this.AddCase.Text = "اضافة قضية";
            this.AddCase.Click += new System.EventHandler(this.AddCase_Click);
            // 
            // ShowCase
            // 
            this.ShowCase.Name = "ShowCase";
            this.ShowCase.Size = new System.Drawing.Size(193, 32);
            this.ShowCase.Text = "عرض القضايا";
            this.ShowCase.Click += new System.EventHandler(this.ShowCase_Click);
            // 
            // الاستشاراتToolStripMenuItem
            // 
            this.الاستشاراتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddConsultaion,
            this.ShowConsultaion});
            this.الاستشاراتToolStripMenuItem.Name = "الاستشاراتToolStripMenuItem";
            this.الاستشاراتToolStripMenuItem.Size = new System.Drawing.Size(116, 32);
            this.الاستشاراتToolStripMenuItem.Text = "الاستشارات";
            // 
            // AddConsultaion
            // 
            this.AddConsultaion.Name = "AddConsultaion";
            this.AddConsultaion.Size = new System.Drawing.Size(226, 32);
            this.AddConsultaion.Text = "اضافة استشارة";
            this.AddConsultaion.Click += new System.EventHandler(this.AddConsultaion_Click);
            // 
            // ShowConsultaion
            // 
            this.ShowConsultaion.Name = "ShowConsultaion";
            this.ShowConsultaion.Size = new System.Drawing.Size(226, 32);
            this.ShowConsultaion.Text = "عرض الاستشارات";
            this.ShowConsultaion.Click += new System.EventHandler(this.ShowConsultaion_Click);
            // 
            // سنداتالقبضToolStripMenuItem
            // 
            this.سنداتالقبضToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddSanadKabd,
            this.عرضسنداتالقبضToolStripMenuItem});
            this.سنداتالقبضToolStripMenuItem.Name = "سنداتالقبضToolStripMenuItem";
            this.سنداتالقبضToolStripMenuItem.Size = new System.Drawing.Size(142, 32);
            this.سنداتالقبضToolStripMenuItem.Text = "سندات القبض";
            // 
            // AddSanadKabd
            // 
            this.AddSanadKabd.Name = "AddSanadKabd";
            this.AddSanadKabd.Size = new System.Drawing.Size(252, 32);
            this.AddSanadKabd.Text = "اضافة سند قبض";
            this.AddSanadKabd.Click += new System.EventHandler(this.AddSanadKabd_Click);
            // 
            // عرضسنداتالقبضToolStripMenuItem
            // 
            this.عرضسنداتالقبضToolStripMenuItem.Name = "عرضسنداتالقبضToolStripMenuItem";
            this.عرضسنداتالقبضToolStripMenuItem.Size = new System.Drawing.Size(252, 32);
            this.عرضسنداتالقبضToolStripMenuItem.Text = "عرض سندات القبض";
            this.عرضسنداتالقبضToolStripMenuItem.Click += new System.EventHandler(this.عرضسنداتالقبضToolStripMenuItem_Click);
            // 
            // سنداتالصرفToolStripMenuItem
            // 
            this.سنداتالصرفToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddSanadSarf,
            this.عرضسنداتالصرفToolStripMenuItem});
            this.سنداتالصرفToolStripMenuItem.Name = "سنداتالصرفToolStripMenuItem";
            this.سنداتالصرفToolStripMenuItem.Size = new System.Drawing.Size(142, 32);
            this.سنداتالصرفToolStripMenuItem.Text = "سندات الصرف";
            // 
            // AddSanadSarf
            // 
            this.AddSanadSarf.Name = "AddSanadSarf";
            this.AddSanadSarf.Size = new System.Drawing.Size(252, 32);
            this.AddSanadSarf.Text = "اضافة سند صرف";
            this.AddSanadSarf.Click += new System.EventHandler(this.AddSanadSarf_Click);
            // 
            // عرضسنداتالصرفToolStripMenuItem
            // 
            this.عرضسنداتالصرفToolStripMenuItem.Name = "عرضسنداتالصرفToolStripMenuItem";
            this.عرضسنداتالصرفToolStripMenuItem.Size = new System.Drawing.Size(252, 32);
            this.عرضسنداتالصرفToolStripMenuItem.Text = "عرض سندات الصرف";
            this.عرضسنداتالصرفToolStripMenuItem.Click += new System.EventHandler(this.عرضسنداتالصرفToolStripMenuItem_Click);
            // 
            // EnterReportsMenu
            // 
            this.EnterReportsMenu.Name = "EnterReportsMenu";
            this.EnterReportsMenu.Size = new System.Drawing.Size(83, 32);
            this.EnterReportsMenu.Text = "التقارير";
            this.EnterReportsMenu.Click += new System.EventHandler(this.EnterReportsMenu_Click);
            // 
            // بياناتالمكتبToolStripMenuItem
            // 
            this.بياناتالمكتبToolStripMenuItem.Name = "بياناتالمكتبToolStripMenuItem";
            this.بياناتالمكتبToolStripMenuItem.Size = new System.Drawing.Size(137, 32);
            this.بياناتالمكتبToolStripMenuItem.Text = "بيانات المكتب";
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(66, 32);
            this.Exit.Text = "خروج";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(155)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(988, 549);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCreateReport);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Reports";
            this.Text = "Reports";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCreateReport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem الرئيسيةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem العملاءToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddClient;
        private System.Windows.Forms.ToolStripMenuItem ShowClient;
        private System.Windows.Forms.ToolStripMenuItem Cases;
        private System.Windows.Forms.ToolStripMenuItem AddCase;
        private System.Windows.Forms.ToolStripMenuItem ShowCase;
        private System.Windows.Forms.ToolStripMenuItem الاستشاراتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddConsultaion;
        private System.Windows.Forms.ToolStripMenuItem ShowConsultaion;
        private System.Windows.Forms.ToolStripMenuItem سنداتالقبضToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddSanadKabd;
        private System.Windows.Forms.ToolStripMenuItem عرضسنداتالقبضToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem سنداتالصرفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddSanadSarf;
        private System.Windows.Forms.ToolStripMenuItem عرضسنداتالصرفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EnterReportsMenu;
        private System.Windows.Forms.ToolStripMenuItem بياناتالمكتبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Exit;
    }
}