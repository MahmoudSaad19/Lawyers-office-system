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
    public partial class SanadKabdPaymentEdit : Form
    {
        public SanadKabdPaymentEdit()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PaymentInfoEditForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;

            this.FormBorderStyle = FormBorderStyle.Fixed3D;

            this.WindowState = FormWindowState.Maximized;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SanadSarf catchReceiptForm = FormPool.ReceiptForm;
            this.Hide();
            catchReceiptForm.Show();
            catchReceiptForm.FormClosed += (s, args) => this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainPage mainPage = FormPool.MainPage;
            mainPage.FormClosed += (s, args) => this.Close();
            this.Hide();
            mainPage.Show();
           

        }
    }
}
