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
    public partial class ShowClientCasesOrConsultation : Form
    {
        #region ctor + Load

        public ShowClientCasesOrConsultation()
        {
            InitializeComponent();
        }

        private void ClientCases_Load(object sender, EventArgs e)
        {


            this.TopMost = true;

            this.FormBorderStyle = FormBorderStyle.None;

            this.WindowState = FormWindowState.Maximized;


        }

        #endregion

        #region Methods ( Controls Events )

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (CaseCheck.Checked)
            {
                lstOfCasesOrConsNames.DataSource = new List<Cases>()
            {
               new Cases(){CaseName="جنائية أ" },
               new Cases(){CaseName="جنائية أ" },
               new Cases(){CaseName="جنائية أ" }
            };
                lstOfCasesOrConsNames.Show();
            }
            else
            {
                lstOfCasesOrConsNames.DataSource = new List<Consultation>()
            {
               new Consultation(){ConsultationName=" استشارة احوال مدنية" },
               new Consultation(){ConsultationName="استشارة احوال شخصية" },
               new Consultation(){ConsultationName="استشارة احوال جنائية" }
            };
                lstOfCasesOrConsNames.Show();
            }


        }

        private void btnHomePage_Click_1(object sender, EventArgs e)
        {
            MainPage mainPage = FormPool.MainPage;
            mainPage.FormClosed += (s, args) => this.Close();
            mainPage.Show();
            this.Hide();
        }

        private void lstOfCasesOrConsNames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CaseCheck.Checked)
            {
                EditClientCase EditClientCase = FormPool.EditClientCase;
                //EditClientCase.FormClosed += (s, args) => this.Close();
                EditClientCase.Show();
                //this.Hide();
            }
            else
            {
                EditClientConsultaion editClientConsultaion = FormPool.EditClientConsultaion;
                //editClientConsultaion.FormClosed += (s, args) => this.Close();
                editClientConsultaion.Show();
                //this.Hide();
            }


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
            Case caseForm = FormPool.Case;
            caseForm.FormClosed += (s, args) => this.Close();
            caseForm.Show();
            this.Hide();
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
