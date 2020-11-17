namespace Presentaion_Layer___winforms__UI_
{
    partial class SearchForClient
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
            this.lstOfClients = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SSNCheck = new System.Windows.Forms.RadioButton();
            this.ClientNameCheck = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lstOfClients)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstOfClients
            // 
            this.lstOfClients.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.lstOfClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstOfClients.Location = new System.Drawing.Point(151, 152);
            this.lstOfClients.Name = "lstOfClients";
            this.lstOfClients.Size = new System.Drawing.Size(352, 240);
            this.lstOfClients.TabIndex = 13;
            this.lstOfClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstOfClients_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SSNCheck);
            this.groupBox1.Controls.Add(this.ClientNameCheck);
            this.groupBox1.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Location = new System.Drawing.Point(534, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 65);
            this.groupBox1.TabIndex = 10;
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
            this.textBox1.Location = new System.Drawing.Point(151, 37);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 28);
            this.textBox1.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(98)))), ((int)(((byte)(108)))));
            this.btnSearch.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSearch.Location = new System.Drawing.Point(52, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 31);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SearchForClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(155)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstOfClients);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSearch);
            this.Name = "SearchForClient";
            this.Text = "SearchForClient";
            this.Load += new System.EventHandler(this.SearchForClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstOfClients)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lstOfClients;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton SSNCheck;
        private System.Windows.Forms.RadioButton ClientNameCheck;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
    }
}