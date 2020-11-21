namespace Presentaion_Layer___winforms__UI_
{
    partial class NewCase
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
            this.txtCaseName = new System.Windows.Forms.TextBox();
            this.lblCaseName = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblLawyerFees = new System.Windows.Forms.Label();
            this.lblContractType = new System.Windows.Forms.Label();
            this.txtLawyerFees = new System.Windows.Forms.TextBox();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtContractType = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
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
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCaseName
            // 
            this.txtCaseName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCaseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCaseName.Font = new System.Drawing.Font("Traditional Arabic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCaseName.Location = new System.Drawing.Point(194, 96);
            this.txtCaseName.Name = "txtCaseName";
            this.txtCaseName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCaseName.Size = new System.Drawing.Size(473, 48);
            this.txtCaseName.TabIndex = 0;
            this.txtCaseName.WordWrap = false;
            this.txtCaseName.TextChanged += new System.EventHandler(this.txtCaseName_TextChanged);
            // 
            // lblCaseName
            // 
            this.lblCaseName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCaseName.BackColor = System.Drawing.Color.SeaGreen;
            this.lblCaseName.Font = new System.Drawing.Font("Traditional Arabic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCaseName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCaseName.Location = new System.Drawing.Point(697, 96);
            this.lblCaseName.Name = "lblCaseName";
            this.lblCaseName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCaseName.Size = new System.Drawing.Size(128, 48);
            this.lblCaseName.TabIndex = 1;
            this.lblCaseName.Text = " أسم القضية ";
            this.lblCaseName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCaseName.Click += new System.EventHandler(this.lblCaseName_Click);
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNotes.BackColor = System.Drawing.Color.SeaGreen;
            this.lblNotes.Font = new System.Drawing.Font("Traditional Arabic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblNotes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNotes.Location = new System.Drawing.Point(697, 380);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNotes.Size = new System.Drawing.Size(128, 48);
            this.lblNotes.TabIndex = 2;
            this.lblNotes.Text = "ملاحظات";
            this.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNotes.Click += new System.EventHandler(this.lblNotes_Click);
            // 
            // lblFees
            // 
            this.lblFees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFees.BackColor = System.Drawing.Color.SeaGreen;
            this.lblFees.Font = new System.Drawing.Font("Traditional Arabic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblFees.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFees.Location = new System.Drawing.Point(697, 309);
            this.lblFees.Name = "lblFees";
            this.lblFees.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFees.Size = new System.Drawing.Size(128, 48);
            this.lblFees.TabIndex = 3;
            this.lblFees.Text = "رسوم";
            this.lblFees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFees.Click += new System.EventHandler(this.lblFees_Click);
            // 
            // lblLawyerFees
            // 
            this.lblLawyerFees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLawyerFees.BackColor = System.Drawing.Color.SeaGreen;
            this.lblLawyerFees.Font = new System.Drawing.Font("Traditional Arabic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblLawyerFees.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLawyerFees.Location = new System.Drawing.Point(697, 238);
            this.lblLawyerFees.Name = "lblLawyerFees";
            this.lblLawyerFees.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLawyerFees.Size = new System.Drawing.Size(128, 48);
            this.lblLawyerFees.TabIndex = 4;
            this.lblLawyerFees.Text = "أتعاب المحاماة";
            this.lblLawyerFees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLawyerFees.Click += new System.EventHandler(this.lblLawyerFees_Click);
            // 
            // lblContractType
            // 
            this.lblContractType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContractType.BackColor = System.Drawing.Color.SeaGreen;
            this.lblContractType.Font = new System.Drawing.Font("Traditional Arabic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblContractType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContractType.Location = new System.Drawing.Point(697, 167);
            this.lblContractType.Name = "lblContractType";
            this.lblContractType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblContractType.Size = new System.Drawing.Size(128, 48);
            this.lblContractType.TabIndex = 5;
            this.lblContractType.Text = "نوع التعاقد";
            this.lblContractType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblContractType.Click += new System.EventHandler(this.lblContractType_Click);
            // 
            // txtLawyerFees
            // 
            this.txtLawyerFees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLawyerFees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLawyerFees.Font = new System.Drawing.Font("Traditional Arabic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtLawyerFees.Location = new System.Drawing.Point(194, 238);
            this.txtLawyerFees.Name = "txtLawyerFees";
            this.txtLawyerFees.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLawyerFees.Size = new System.Drawing.Size(473, 48);
            this.txtLawyerFees.TabIndex = 6;
            this.txtLawyerFees.WordWrap = false;
            this.txtLawyerFees.TextChanged += new System.EventHandler(this.txtLawyerFees_TextChanged);
            // 
            // txtFees
            // 
            this.txtFees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFees.Font = new System.Drawing.Font("Traditional Arabic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFees.Location = new System.Drawing.Point(194, 309);
            this.txtFees.Name = "txtFees";
            this.txtFees.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFees.Size = new System.Drawing.Size(473, 48);
            this.txtFees.TabIndex = 7;
            this.txtFees.WordWrap = false;
            this.txtFees.TextChanged += new System.EventHandler(this.txtFees_TextChanged);
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNotes.Font = new System.Drawing.Font("Traditional Arabic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtNotes.Location = new System.Drawing.Point(194, 380);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNotes.Size = new System.Drawing.Size(473, 48);
            this.txtNotes.TabIndex = 8;
            this.txtNotes.WordWrap = false;
            this.txtNotes.TextChanged += new System.EventHandler(this.txtNotes_TextChanged);
            // 
            // txtContractType
            // 
            this.txtContractType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContractType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContractType.Font = new System.Drawing.Font("Traditional Arabic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtContractType.Location = new System.Drawing.Point(194, 167);
            this.txtContractType.Name = "txtContractType";
            this.txtContractType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtContractType.Size = new System.Drawing.Size(473, 48);
            this.txtContractType.TabIndex = 9;
            this.txtContractType.WordWrap = false;
            this.txtContractType.TextChanged += new System.EventHandler(this.txtContractType_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.Azure;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Simplified Arabic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.Location = new System.Drawing.Point(438, 443);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(178, 79);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "فتح قضية";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.menuStrip2.Size = new System.Drawing.Size(947, 36);
            this.menuStrip2.TabIndex = 11;
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
            // NewCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(947, 575);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtContractType);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtFees);
            this.Controls.Add(this.txtLawyerFees);
            this.Controls.Add(this.lblContractType);
            this.Controls.Add(this.lblLawyerFees);
            this.Controls.Add(this.lblFees);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblCaseName);
            this.Controls.Add(this.txtCaseName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewCase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewCase";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NewCase_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCaseName;
        private System.Windows.Forms.Label lblCaseName;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label lblLawyerFees;
        private System.Windows.Forms.Label lblContractType;
        private System.Windows.Forms.TextBox txtLawyerFees;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtContractType;
        private System.Windows.Forms.Button btnSave;
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