﻿using System;
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
    public partial class EditClientCase : Form
    {
        public EditClientCase()
        {
            InitializeComponent();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            MainPage mainPage = FormPool.MainPage;
            mainPage.Show();
            this.Hide();
            mainPage.FormClosed += (s, args) => this.Close();
        }
    }
}
