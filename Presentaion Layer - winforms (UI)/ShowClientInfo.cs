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
    public partial class ShowClientInfo : Form
    {
        public ShowClientInfo()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MainPage mainPage = FormPool.MainPage;
            mainPage.FormClosed += (s, args) => this.Close();
            mainPage.Show();
            this.Hide();
        }

        private void ShowClientInfo_Load(object sender, EventArgs e)
        {
            ShowClientInfo clientInfo = FormPool.ShowClientInfo;
            //clientInfo.Width = this.Width / 2;
            //clientInfo.Height = this.Height / 2;
        }
    }
}
