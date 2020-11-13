namespace Presentaion_Layer___winforms__UI_
{
    partial class Case
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnOldClient = new System.Windows.Forms.Button();
            this.btnNewClient = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.radioName = new System.Windows.Forms.RadioButton();
            this.radioSSN = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpBoxRadio = new System.Windows.Forms.GroupBox();
            this.dataGridViewOldClients = new System.Windows.Forms.DataGridView();
            this.grpBoxRadio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOldClients)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 46);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "<--";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnOldClient
            // 
            this.btnOldClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOldClient.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOldClient.Location = new System.Drawing.Point(700, 150);
            this.btnOldClient.MaximumSize = new System.Drawing.Size(400, 200);
            this.btnOldClient.Name = "btnOldClient";
            this.btnOldClient.Size = new System.Drawing.Size(400, 200);
            this.btnOldClient.TabIndex = 5;
            this.btnOldClient.Text = "عميل قديم";
            this.btnOldClient.UseVisualStyleBackColor = true;
            this.btnOldClient.Click += new System.EventHandler(this.btnOldClient_Click);
            // 
            // btnNewClient
            // 
            this.btnNewClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewClient.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewClient.Location = new System.Drawing.Point(100, 150);
            this.btnNewClient.MaximumSize = new System.Drawing.Size(400, 200);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(400, 200);
            this.btnNewClient.TabIndex = 6;
            this.btnNewClient.Text = "عميل جديد";
            this.btnNewClient.UseVisualStyleBackColor = true;
            this.btnNewClient.Click += new System.EventHandler(this.btnNewClient_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(199, 233);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearch.Size = new System.Drawing.Size(488, 37);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radioName
            // 
            this.radioName.AutoSize = true;
            this.radioName.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioName.Location = new System.Drawing.Point(6, 15);
            this.radioName.Name = "radioName";
            this.radioName.Size = new System.Drawing.Size(71, 29);
            this.radioName.TabIndex = 11;
            this.radioName.TabStop = true;
            this.radioName.Text = "بالأسم";
            this.radioName.UseVisualStyleBackColor = true;
            // 
            // radioSSN
            // 
            this.radioSSN.AutoSize = true;
            this.radioSSN.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSSN.Location = new System.Drawing.Point(87, 15);
            this.radioSSN.Name = "radioSSN";
            this.radioSSN.Size = new System.Drawing.Size(116, 29);
            this.radioSSN.TabIndex = 12;
            this.radioSSN.TabStop = true;
            this.radioSSN.Text = "بالرقم المدنى";
            this.radioSSN.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(956, 234);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 36);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "أبحث";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpBoxRadio
            // 
            this.grpBoxRadio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpBoxRadio.Controls.Add(this.radioName);
            this.grpBoxRadio.Controls.Add(this.radioSSN);
            this.grpBoxRadio.Location = new System.Drawing.Point(708, 226);
            this.grpBoxRadio.Name = "grpBoxRadio";
            this.grpBoxRadio.Size = new System.Drawing.Size(211, 53);
            this.grpBoxRadio.TabIndex = 14;
            this.grpBoxRadio.TabStop = false;
            this.grpBoxRadio.Text = "نوع البحث";
            // 
            // dataGridViewOldClients
            // 
            this.dataGridViewOldClients.AllowUserToAddRows = false;
            this.dataGridViewOldClients.AllowUserToDeleteRows = false;
            this.dataGridViewOldClients.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Traditional Arabic", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOldClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOldClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOldClients.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewOldClients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewOldClients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOldClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOldClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Traditional Arabic", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOldClients.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewOldClients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewOldClients.Location = new System.Drawing.Point(0, 116);
            this.dataGridViewOldClients.MultiSelect = false;
            this.dataGridViewOldClients.Name = "dataGridViewOldClients";
            this.dataGridViewOldClients.ReadOnly = true;
            this.dataGridViewOldClients.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewOldClients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOldClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewOldClients.RowHeadersVisible = false;
            this.dataGridViewOldClients.RowHeadersWidth = 60;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewOldClients.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewOldClients.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewOldClients.RowTemplate.Height = 32;
            this.dataGridViewOldClients.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOldClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOldClients.Size = new System.Drawing.Size(1199, 382);
            this.dataGridViewOldClients.TabIndex = 15;
            this.dataGridViewOldClients.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewOldClients_CellMouseDoubleClick);
            // 
            // Case
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 500);
            this.ControlBox = false;
            this.Controls.Add(this.grpBoxRadio);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnNewClient);
            this.Controls.Add(this.btnOldClient);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridViewOldClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Case";
            this.ShowIcon = false;
            this.Text = "Case";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Case_Load);
            this.grpBoxRadio.ResumeLayout(false);
            this.grpBoxRadio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOldClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnOldClient;
        private System.Windows.Forms.Button btnNewClient;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton radioName;
        private System.Windows.Forms.RadioButton radioSSN;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpBoxRadio;
        private System.Windows.Forms.DataGridView dataGridViewOldClients;
    }
}