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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            this.TopMost = true;

            this.FormBorderStyle = FormBorderStyle.Fixed3D;

            this.WindowState = FormWindowState.Maximized;
             
            //QuickReportsPanel.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            QuickReportsPanel.Show();
        }

       

        private void btnAddCase_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            NewClient newClient = FormPool.NewClient;
            this.Hide();
            newClient.Show();
            newClient.FormClosed += (s, args) => this.Close();

        }

        private void btnAddCase_Click_1(object sender, EventArgs e)
        {
            Case caseForm = FormPool.Case;
            caseForm.FormClosed += (s, args) => this.Close();
            caseForm.Show();
            this.Hide();
        }

        private void btnAddConsultation_Click(object sender, EventArgs e)
        {
            Consultancy consultancy = FormPool.Consultancy;
            consultancy.FormClosed += (s, args) => this.Close();
            consultancy.Show();
            this.Hide();
        }

        private void btnOpenReportsPage_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
         
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void التقاريرToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EnterReportsMenu_Click(object sender, EventArgs e)
        {
            Reports reports = FormPool.Reports;
            reports.FormClosed += (s, args) => this.Close();
            reports.Show();
            this.Hide();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            DialogResult confirmationMessage = MessageBox.Show("هل تريد الخروج؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationMessage == DialogResult.Yes)
            {
                this.Close();
            }
            else
                this.Show();
        }

        private void اضافةعميلToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            NewClient newClient = FormPool.NewClient;
            this.Hide();
            newClient.Show();
            newClient.FormClosed += (s, args) => this.Close();
        }

        private void ShowClient_Click(object sender, EventArgs e)
        {

            SearchForClient searchForClient = FormPool.SearchForClient;
            this.Hide();
            searchForClient.Show();
            searchForClient.FormClosed += (s, args) => this.Close();


        }

        private void AddCase_Click(object sender, EventArgs e)
        {
            Case caseForm = FormPool.Case;
            caseForm.FormClosed += (s, args) => this.Close();
            caseForm.Show();
            this.Hide();
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

        private void ShowConsultaion_Click(object sender, EventArgs e)
        {
            ShowClientCasesOrConsultation clientCases = FormPool.clientCases;
            clientCases.FormClosed += (s, args) => this.Close();
            clientCases.Show();
            this.Hide();
        }
    }
}
