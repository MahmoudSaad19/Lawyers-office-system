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
    public partial class SanadSarf : Form
    {
        public SanadSarf()
        {
            InitializeComponent();
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {

            this.TopMost = true;

            this.FormBorderStyle = FormBorderStyle.Fixed3D;

            this.WindowState = FormWindowState.Maximized;
            panel1.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainPage mainPage = FormPool.MainPage;
            mainPage.FormClosed += (s, args) => this.Close();
            mainPage.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }
    }
}
