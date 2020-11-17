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
        public NewCase()
        {
            InitializeComponent();
        }

        private void NewCase_Load(object sender, EventArgs e)
        {

        }

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
    }
}
