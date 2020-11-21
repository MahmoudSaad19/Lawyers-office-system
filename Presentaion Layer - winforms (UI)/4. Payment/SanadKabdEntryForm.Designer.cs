﻿namespace Presentaion_Layer___winforms__UI_
{
    partial class SanadKabdEntryForm
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SSNCheck = new System.Windows.Forms.RadioButton();
            this.ClientNameCheck = new System.Windows.Forms.RadioButton();
            this.CaseCheck = new System.Windows.Forms.RadioButton();
            this.ConsultationCheck = new System.Windows.Forms.RadioButton();
            this.lstOfCasesOrConsNames = new System.Windows.Forms.DataGridView();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstOfCasesOrConsNames)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(98)))), ((int)(((byte)(108)))));
            this.btnSearch.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSearch.Location = new System.Drawing.Point(158, 111);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 31);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(257, 114);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 28);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(789, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.SSNCheck);
            this.groupBox1.Controls.Add(this.ClientNameCheck);
            this.groupBox1.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Location = new System.Drawing.Point(640, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 65);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بحث باستخدام :";
            // 
            // SSNCheck
            // 
            this.SSNCheck.AutoSize = true;
            this.SSNCheck.Checked = true;
            this.SSNCheck.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSNCheck.ForeColor = System.Drawing.SystemColors.Info;
            this.SSNCheck.Location = new System.Drawing.Point(105, 37);
            this.SSNCheck.Name = "SSNCheck";
            this.SSNCheck.Size = new System.Drawing.Size(103, 35);
            this.SSNCheck.TabIndex = 1;
            this.SSNCheck.TabStop = true;
            this.SSNCheck.Text = "الرقم القومي";
            this.SSNCheck.UseVisualStyleBackColor = true;
            // 
            // ClientNameCheck
            // 
            this.ClientNameCheck.AutoSize = true;
            this.ClientNameCheck.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientNameCheck.Location = new System.Drawing.Point(15, 35);
            this.ClientNameCheck.Name = "ClientNameCheck";
            this.ClientNameCheck.Size = new System.Drawing.Size(68, 35);
            this.ClientNameCheck.TabIndex = 0;
            this.ClientNameCheck.Text = "الاسم";
            this.ClientNameCheck.UseVisualStyleBackColor = true;
            // 
            // CaseCheck
            // 
            this.CaseCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CaseCheck.AutoSize = true;
            this.CaseCheck.Checked = true;
            this.CaseCheck.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaseCheck.ForeColor = System.Drawing.SystemColors.Info;
            this.CaseCheck.Location = new System.Drawing.Point(464, 158);
            this.CaseCheck.Name = "CaseCheck";
            this.CaseCheck.Size = new System.Drawing.Size(64, 35);
            this.CaseCheck.TabIndex = 4;
            this.CaseCheck.TabStop = true;
            this.CaseCheck.Text = "قضية";
            this.CaseCheck.UseVisualStyleBackColor = true;
            // 
            // ConsultationCheck
            // 
            this.ConsultationCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsultationCheck.AutoSize = true;
            this.ConsultationCheck.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultationCheck.ForeColor = System.Drawing.SystemColors.Info;
            this.ConsultationCheck.Location = new System.Drawing.Point(329, 158);
            this.ConsultationCheck.Name = "ConsultationCheck";
            this.ConsultationCheck.Size = new System.Drawing.Size(86, 35);
            this.ConsultationCheck.TabIndex = 5;
            this.ConsultationCheck.Text = "استشارة";
            this.ConsultationCheck.UseVisualStyleBackColor = true;
            // 
            // lstOfCasesOrConsNames
            // 
            this.lstOfCasesOrConsNames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstOfCasesOrConsNames.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.lstOfCasesOrConsNames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstOfCasesOrConsNames.Location = new System.Drawing.Point(193, 221);
            this.lstOfCasesOrConsNames.Name = "lstOfCasesOrConsNames";
            this.lstOfCasesOrConsNames.Size = new System.Drawing.Size(624, 306);
            this.lstOfCasesOrConsNames.TabIndex = 7;
            this.lstOfCasesOrConsNames.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstOfCasesOrConsNames_CellClick);
            this.lstOfCasesOrConsNames.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstOfCasesOrConsNames_CellContentClick);
            this.lstOfCasesOrConsNames.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstOfCasesOrConsNames_CellContentDoubleClick);
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
            this.menuStrip2.Size = new System.Drawing.Size(978, 36);
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
            // SanadKabdEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(155)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(978, 587);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.lstOfCasesOrConsNames);
            this.Controls.Add(this.ConsultationCheck);
            this.Controls.Add(this.CaseCheck);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SanadKabdEntryForm";
            this.Text = "سند قبض";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CatchReceiptForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstOfCasesOrConsNames)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton SSNCheck;
        private System.Windows.Forms.RadioButton ClientNameCheck;
        private System.Windows.Forms.RadioButton CaseCheck;
        private System.Windows.Forms.RadioButton ConsultationCheck;
        private System.Windows.Forms.DataGridView lstOfCasesOrConsNames;
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