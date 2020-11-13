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
    public partial class Case : Form
    {
        public Case()
        {
            InitializeComponent();
        }




        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage home = FormPool.HomePage;
            home.Show();
            this.Hide();
            ResetUI();
        }

        private void ResetUI()
        {
            grpBoxRadio.Location = new Point(708, 226);
            txtSearch.Location = new Point(199, 233);
            btnSearch.Location = new Point(956, 234);
            HideAllElements();
            btnNewClient.Show();
            btnOldClient.Show();
        }

        private void Case_Load(object sender, EventArgs e)
        {
            HideAllElements();
        }

        private void HideAllElements()
        {
            btnSearch.Hide();
            grpBoxRadio.Hide();
            txtSearch.Hide();
            dataGridViewOldClients.Hide();
        }

        private void btnOldClient_Click(object sender, EventArgs e)
        {
            ShowAllElements();            
            openNewCaseForm();
            btnNewClient.Hide();
            btnOldClient.Hide();
        }

        private void ShowAllElements()
        {
            btnSearch.Show();
            grpBoxRadio.Show();
            txtSearch.Show();
        }

        private void openNewCaseForm()
        {
            //throw new NotImplementedException();
        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            
            btnNewClient.Hide();
            btnOldClient.Hide();
            openNewCaseForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            grpBoxRadio.Location = new Point(823, 17);
            txtSearch.Location = new Point(288, 29);
            btnSearch.Location = new Point(1049, 34);
            dataGridViewOldClients.DataSource = Data();
            AdjustColumnsWidth();
            dataGridViewOldClients.Show();
        }

        private List<Client> Data()
        {
            List<Client> clients = new List<Client>()
            {
                new Client(){ Address= "التجمع اللأول", Email="ali.mohamed@gmail.com", Job=" مهندس", Name=" على محمد على ", Notes="حديث التخرج", NumberOfCases = 3, SSN = "١٤٦٧٩٠١٤٦٧٩٠٩٠", Telphone = "٠١٤٦٧٩٠١٤٠"},
                new Client(){ Address= "التجمع اللأول", Email="ali.mohamed@gmail.com", Job=" مهندس", Name=" على محمد على ", Notes="حديث التخرج", NumberOfCases = 3, SSN = "١٤٦٧٩٠١٤٦٧٩٠٩٠", Telphone = "٠١٤٦٧٩٠١٤٠"},
                new Client(){ Address= "التجمع اللأول", Email="ali.mohamed@gmail.com", Job=" مهندس", Name=" على محمد على ", Notes="حديث التخرج", NumberOfCases = 3, SSN = "١٤٦٧٩٠١٤٦٧٩٠٩٠", Telphone = "٠١٤٦٧٩٠١٤٠"},
                new Client(){ Address= "التجمع اللأول", Email="ali.mohamed@gmail.com", Job=" مهندس", Name=" على محمد على ", Notes="حديث التخرج", NumberOfCases = 3, SSN = "١٤٦٧٩٠١٤٦٧٩٠٩٠", Telphone = "٠١٤٦٧٩٠١٤٠"},
                new Client(){ Address= "التجمع اللأول", Email="ali.mohamed@gmail.com", Job=" مهندس", Name=" على محمد على ", Notes="حديث التخرج", NumberOfCases = 3, SSN = "١٤٦٧٩٠١٤٦٧٩٠٩٠", Telphone = "٠١٤٦٧٩٠١٤٠"},
                new Client(){ Address= "التجمع اللأول", Email="ali.mohamed@gmail.com", Job=" مهندس", Name=" على محمد على ", Notes="حديث التخرج", NumberOfCases = 3, SSN = "١٤٦٧٩٠١٤٦٧٩٠٩٠", Telphone = "٠١٤٦٧٩٠١٤٠"},
                new Client(){ Address= "التجمع اللأول", Email="ali.mohamed@gmail.com", Job=" مهندس", Name=" على محمد على ", Notes="حديث التخرج", NumberOfCases = 3, SSN = "١٤٦٧٩٠١٤٦٧٩٠٩٠", Telphone = "٠١٤٦٧٩٠١٤٠"},
                new Client(){ Address= "التجمع اللأول", Email="ali.mohamed@gmail.com", Job=" مهندس", Name=" على محمد على ", Notes="حديث التخرج", NumberOfCases = 3, SSN = "١٤٦٧٩٠١٤٦٧٩٠٩٠", Telphone = "٠١٤٦٧٩٠١٤٠"},
                new Client(){ Address= "الدقى", Email="a@b.com", Job="عامل", Name="عماد", Notes="سنة ", NumberOfCases = 3, SSN = "١٤٦٧٩٠", Telphone = "١٤٦٧٩٠"}
            };
            return clients;
        }

        private void AdjustColumnsWidth()
        {

            int width = 0;
            for (int i = 0; i < dataGridViewOldClients.Columns.Count; i++)
            {
                switch (i)
                {
                    case 1:
                    case 4:
                        width = 245;
                        break;
                    case 0:
                    case 2:
                    case 7:
                        width = 300;
                        break;
                    case 3:
                    case 5:
                        width = 200;
                        break;
                    default:
                        width = 150;
                        break;
                }
                dataGridViewOldClients.Columns[i].Width = width;
            }
        }

        private void dataGridViewOldClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewOldClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            int index = dataGridViewOldClients.Rows.GetNextRow(e.RowIndex, DataGridViewElementStates.Selected);
            //dataGridViewOldClients.SelectedRows.
        }

        private void dataGridViewOldClients_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    public class Client
    {
        
        [DisplayName("الاسم")]
        public string Name { get; set; }
        [DisplayName("رقم المدنية")]
        public string SSN { get; set; }
        [DisplayName("العنوان")]
        public string Address { get; set; }
        [DisplayName("التليفون")]
        public string Telphone { get; set; }
        [DisplayName("الإيميل")]
        public string Email { get; set; }
        [DisplayName("المهنة")]
        public string Job { get; set; }
        
        [DisplayName("عدد القضايا")]
        public int NumberOfCases { get; set; }
        [DisplayName("ملاحظات")]
        public string Notes { get; set; }
        //public static 
    }
}
