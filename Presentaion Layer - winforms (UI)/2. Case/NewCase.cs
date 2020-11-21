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
    public partial class NewCase : Form
    {
        #region ctor + Load
        public NewCase()
        {
            InitializeComponent();
        }

        private void NewCase_Load(object sender, EventArgs e)
        {

        }


        #endregion
        
        #region Methods ( Controls Events )

        private void btnSave_Click(object sender, EventArgs e)
        {

            MainPage mainPage = FormPool.MainPage;
            mainPage.Show();
            this.Hide();
            mainPage.FormClosed += (s, args) => this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage home = FormPool.HomePage;
            home.Show();
            this.Hide();
        }

        private void txtContractType_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFees_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLawyerFees_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCaseName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCaseName_Click(object sender, EventArgs e)
        {

        }

        private void lblNotes_Click(object sender, EventArgs e)
        {

        }

        private void lblFees_Click(object sender, EventArgs e)
        {

        }

        private void lblLawyerFees_Click(object sender, EventArgs e)
        {

        }

        private void lblContractType_Click(object sender, EventArgs e)
        {

        }

        #endregion
        
        #region Menu Strip Events

        private void الرئيسيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPage mainPage = FormPool.MainPage;
            mainPage.Show();
            this.Hide();
            mainPage.FormClosed += (s, args) => this.Close();
        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            NewClient newClient = FormPool.NewClient;
            newClient.Show();
            this.Hide();
            newClient.FormClosed += (s, args) => this.Close();
        }

        private void AddCase_Click(object sender, EventArgs e)
        {

        }

        private void ShowClient_Click(object sender, EventArgs e)
        {
            SearchForClient searchForClient = FormPool.SearchForClient;
            this.Hide();
            searchForClient.Show();
            searchForClient.FormClosed += (s, args) => this.Close();
        }

        private void ShowCase_Click(object sender, EventArgs e)
        {
            ShowClientCasesOrConsultation clientCases = FormPool.clientCases;
            clientCases.FormClosed += (s, args) => this.Close();
            clientCases.Show();
            this.Hide();
        }

        private void AddConsultaion_Click(object sender, EventArgs e)
        {
            Consultancy consultancy = FormPool.Consultancy;
            consultancy.FormClosed += (s, args) => this.Close();
            consultancy.Show();
            this.Hide();
        }

        private void ShowConsultaion_Click(object sender, EventArgs e)
        {
            ShowClientCasesOrConsultation clientCases = FormPool.clientCases;
            clientCases.FormClosed += (s, args) => this.Close();
            clientCases.Show();
            this.Hide();
        }

        private void AddSanadKabd_Click(object sender, EventArgs e)
        {
            SanadKabdEntryForm receiptForm = FormPool.CatchReceiptForm;
            receiptForm.FormClosed += (s, args) => this.Close();
            receiptForm.Show();
            this.Hide();
        }

        private void AddSanadSarf_Click(object sender, EventArgs e)
        {
            SanadSarf receiptForm = FormPool.ReceiptForm;
            receiptForm.FormClosed += (s, args) => this.Close();
            receiptForm.Show();
            this.Hide();
        }

        private void EnterReportsMenu_Click(object sender, EventArgs e)
        {
            Reports reports = FormPool.Reports;
            reports.FormClosed += (s, args) => this.Close();
            reports.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult confirmationMessage = MessageBox.Show("هل تريد الخروج؟", "تنبيه", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (confirmationMessage == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void عرضسنداتالقبضToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SanadKabdPaymentEdit sanadKabdPaymentEdit = FormPool.SanadKabdPaymentEdit;
            sanadKabdPaymentEdit.FormClosed += (s, args) => this.Close();
            sanadKabdPaymentEdit.Show();
            this.Hide();
        }

        private void عرضسنداتالصرفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SanadKabdPaymentEdit sanadKabdPaymentEdit = FormPool.SanadKabdPaymentEdit;
            sanadKabdPaymentEdit.FormClosed += (s, args) => this.Close();
            sanadKabdPaymentEdit.Show();
            this.Hide();
        } 

        #endregion
    }
}
