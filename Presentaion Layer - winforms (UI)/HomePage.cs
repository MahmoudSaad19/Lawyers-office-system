using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentaion_Layer___winforms__UI_
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
        }
        
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
        }

        private void btnCase_Click(object sender, EventArgs e)
        {
            Case caseForm = FormPool.Case;
            caseForm.FormClosed += (s, args) => this.Close();
            caseForm.Show();
            this.Hide();
        }

        private void btnConsultant_Click(object sender, EventArgs e)
        {
            Consultancy consultancy = FormPool.Consultancy;
            consultancy.FormClosed += (s, args) => this.Close();
            consultancy.Show();
            this.Hide();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            ReceiptForm payment = FormPool.ReceiptForm;
            payment.FormClosed += (s, args) => this.Close();
            payment.Show();
            this.Hide();
        }

        private void btnRecieve_Click(object sender, EventArgs e)
        {
            PaymentInfoEditForm editFees = FormPool.PaymentInfo;
            editFees.FormClosed += (s, args) => this.Close();
            editFees.Show();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports reports = FormPool.Reports;
            reports.FormClosed += (s, args) => this.Close();
            reports.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult confirmationMessage = MessageBox.Show("هل تريد الخروج؟","تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (confirmationMessage == DialogResult.Yes)
                this.Close();
            
        }
    }
}
