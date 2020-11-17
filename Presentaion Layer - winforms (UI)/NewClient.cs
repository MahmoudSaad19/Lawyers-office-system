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
    public partial class NewClient : Form
    {
        public NewClient()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage home = FormPool.HomePage;
            home.Show();
            this.Hide();
        }

        private void btnSaveClient_Click(object sender, EventArgs e)
        {

            if(radOpenCase.Checked)
            {
                
                NewCase newCase = FormPool.NewCase;
                newCase.FormClosed += (s, args) => this.Close();
                this.Hide();
                newCase.Show();
                this.Hide();
            }
            else
            {
                MainPage mainPage = FormPool.MainPage;
                mainPage.Show();
                this.Hide();
                mainPage.FormClosed += (s, args) => this.Close();
            }
           
        }

        private void NewClient_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
        }
    }
}
