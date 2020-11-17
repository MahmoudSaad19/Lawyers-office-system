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

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if(CaseCheck.Checked)
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
            if(CaseCheck.Checked )
            {
                EditClientCase EditClientCase = FormPool.EditClientCase;
                EditClientCase.FormClosed += (s, args) => this.Close();
                EditClientCase.Show();
                this.Hide();
            }
            else
            {
                EditClientConsultaion editClientConsultaion = FormPool.EditClientConsultaion;
                editClientConsultaion.FormClosed += (s, args) => this.Close();
                editClientConsultaion.Show();
                this.Hide();
            }
           

        }
    }

   
}
