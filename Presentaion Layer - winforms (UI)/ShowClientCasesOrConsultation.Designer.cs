namespace Presentaion_Layer___winforms__UI_
{
    partial class ShowClientCasesOrConsultation
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
            this.btnHomePage = new System.Windows.Forms.Button();
            this.ConsultationCheck = new System.Windows.Forms.RadioButton();
            this.CaseCheck = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SSNCheck = new System.Windows.Forms.RadioButton();
            this.ClientNameCheck = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstOfCasesOrConsNames = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstOfCasesOrConsNames)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHomePage
            // 
            this.btnHomePage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnHomePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(98)))), ((int)(((byte)(108)))));
            this.btnHomePage.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomePage.ForeColor = System.Drawing.SystemColors.Info;
            this.btnHomePage.Location = new System.Drawing.Point(732, 28);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(124, 45);
            this.btnHomePage.TabIndex = 26;
            this.btnHomePage.Text = "الصفحةالرئيسية";
            this.btnHomePage.UseVisualStyleBackColor = false;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click_1);
            // 
            // ConsultationCheck
            // 
            this.ConsultationCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsultationCheck.AutoSize = true;
            this.ConsultationCheck.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultationCheck.ForeColor = System.Drawing.SystemColors.Info;
            this.ConsultationCheck.Location = new System.Drawing.Point(208, 72);
            this.ConsultationCheck.Name = "ConsultationCheck";
            this.ConsultationCheck.Size = new System.Drawing.Size(86, 35);
            this.ConsultationCheck.TabIndex = 25;
            this.ConsultationCheck.Text = "استشارة";
            this.ConsultationCheck.UseVisualStyleBackColor = true;
            // 
            // CaseCheck
            // 
            this.CaseCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CaseCheck.AutoSize = true;
            this.CaseCheck.Checked = true;
            this.CaseCheck.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaseCheck.ForeColor = System.Drawing.SystemColors.Info;
            this.CaseCheck.Location = new System.Drawing.Point(343, 72);
            this.CaseCheck.Name = "CaseCheck";
            this.CaseCheck.Size = new System.Drawing.Size(64, 35);
            this.CaseCheck.TabIndex = 24;
            this.CaseCheck.TabStop = true;
            this.CaseCheck.Text = "قضية";
            this.CaseCheck.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.SSNCheck);
            this.groupBox1.Controls.Add(this.ClientNameCheck);
            this.groupBox1.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Location = new System.Drawing.Point(502, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 65);
            this.groupBox1.TabIndex = 23;
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
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(136, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 28);
            this.textBox1.TabIndex = 22;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(98)))), ((int)(((byte)(108)))));
            this.btnSearch.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSearch.Location = new System.Drawing.Point(37, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 31);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // lstOfCasesOrConsNames
            // 
            this.lstOfCasesOrConsNames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lstOfCasesOrConsNames.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.lstOfCasesOrConsNames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstOfCasesOrConsNames.Location = new System.Drawing.Point(93, 113);
            this.lstOfCasesOrConsNames.Name = "lstOfCasesOrConsNames";
            this.lstOfCasesOrConsNames.Size = new System.Drawing.Size(681, 284);
            this.lstOfCasesOrConsNames.TabIndex = 27;
            this.lstOfCasesOrConsNames.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstOfCasesOrConsNames_CellContentClick);
            // 
            // ShowClientCases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(155)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(873, 512);
            this.Controls.Add(this.lstOfCasesOrConsNames);
            this.Controls.Add(this.btnHomePage);
            this.Controls.Add(this.ConsultationCheck);
            this.Controls.Add(this.CaseCheck);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSearch);
            this.Name = "ShowClientCases";
            this.Text = "ClientCases";
            this.Load += new System.EventHandler(this.ClientCases_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstOfCasesOrConsNames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.RadioButton ConsultationCheck;
        private System.Windows.Forms.RadioButton CaseCheck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton SSNCheck;
        private System.Windows.Forms.RadioButton ClientNameCheck;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView lstOfCasesOrConsNames;
    }
}