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
    public partial class SearchForClient : Form
    {
        public SearchForClient()
        {
            InitializeComponent();
        }

        private void lstOfCasesOrConsNames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lstOfClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowClientInfo showClientInfo = FormPool.ShowClientInfo;
            showClientInfo.FormClosed += (s, args) => this.Close();
            showClientInfo.Show();
            this.Hide();



        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstOfClients.DataSource = new List<View_Models.Client>()
            {
                new View_Models.Client(){ Address= "التجمع اللأول", Email="ali.mohamed@gmail.com", Job=" مهندس", Name=" على محمد على ", Notes="حديث التخرج", NumberOfCases = 3, SSN = "١٤٦٧٩٠١٤٦٧٩٠٩٠", Telphone = "٠١٤٦٧٩٠١٤٠"},
                new View_Models.Client(){ Address= "التجمع اللأول", Email="ali.mohamed@gmail.com", Job=" مهندس", Name="  محمد على ", Notes="حديث التخرج", NumberOfCases = 3, SSN = "١٤٦٧٩٠١٤٦٧٩٠٩٠", Telphone = "٠١٤٦٧٩٠١٤٠"}
            };
            lstOfClients.Show();
        }

        private void SearchForClient_Load(object sender, EventArgs e)
        {

        }
    }
}
