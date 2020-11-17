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
    public partial class SanadKabdEntryForm : Form
    {
        public SanadKabdEntryForm()
        {
            InitializeComponent();
        }



        private void CatchReceiptForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;

            this.FormBorderStyle = FormBorderStyle.Fixed3D;

            this.WindowState = FormWindowState.Maximized;
            lstOfCasesOrConsNames.Hide();


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstOfCasesOrConsNames.DataSource = new List<Cases>()
            {
               new Cases(){CaseName="جنائية أ" },
               new Cases(){CaseName="جنائية أ" },
               new Cases(){CaseName="جنائية أ" }
            };
            lstOfCasesOrConsNames.Show();


        }



        private void lstOfCasesOrConsNames_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SanadKabdPaymentEdit paymentInfoEdit = FormPool.paymentInfoEditForm;
            this.Hide();
            paymentInfoEdit.Show();


        }

        private void lstOfCasesOrConsNames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SanadKabdPaymentEdit paymentInfoEdit = FormPool.paymentInfoEditForm;

            paymentInfoEdit.Show();
            this.Hide();
        }

        private void lstOfCasesOrConsNames_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SanadKabdPaymentEdit paymentInfoEdit = FormPool.paymentInfoEditForm;

            paymentInfoEdit.Show();
            this.Hide();
        }
    }
    public class Cases
    {
        [DisplayName(" اسم القضية")]
        public string CaseName { get; set; }
    }
    public class Consultation

    {
        [DisplayName(" اسم الاستشارة")]
        public string ConsultationName { get; set; }
    }

}
