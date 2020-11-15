using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentaion_Layer___winforms__UI_.View_Models;

namespace Presentaion_Layer___winforms__UI_
{
    public partial class Case : Form
    {
        bool isName;

        #region ctor + Load

        public Case()
        {
            InitializeComponent();
            isName = false;
        }

        private void Case_Load(object sender, EventArgs e)
        {
            ResetUI();
        }

        #endregion

        #region Controls Methods

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage home = FormPool.HomePage;
            home.Show();
            this.Hide();
            ResetUI();
        }

        private void btnOldClient_Click(object sender, EventArgs e)
        {
            ShowAllElements();
            btnNewClient.Hide();
            btnOldClient.Hide();
        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            NewClient newClient = FormPool.NewClient;
            newClient.FormClosed += (s, args) => this.Close();
            newClient.Show();
            this.Hide();
            btnNewClient.Hide();
            btnOldClient.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            grpBoxRadio.Location = new Point(823, 17);
            txtSearch.Location = new Point(288, 29);
            btnSearch.Location = new Point(1049, 34);
            dataGridViewOldClients.DataSource = Client.Data();
            AdjustColumnsWidth();
            dataGridViewOldClients.Show();
        }

        private void dataGridViewOldClients_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            bool dataGridIsValid = dataGridViewOldClients.Rows.Count > 0 && dataGridViewOldClients.Rows[0].Cells.Count > 0 && e.RowIndex > 0 && e.RowIndex <= dataGridViewOldClients.Rows.Count;
            if (dataGridIsValid)
            {
                string ssn = (string)dataGridViewOldClients.Rows[e.RowIndex].Cells[1].Value;
                MessageBox.Show($"لقد أخترت {ssn} ");
                openNewCaseForm();
            }

        }

        #endregion

        #region Helper Methods

        private void ResetUI()
        {
            int width = (this.Width - 900) / 2;
            int height = (this.Height - 100) / 2;
            grpBoxRadio.Location = new Point(width + 508, height + 26);
            txtSearch.Location = new Point(width , height + 33);
            btnSearch.Location = new Point(width + 756, height + 34);
            HideAllElements();
            btnNewClient.Show();
            btnOldClient.Show();
        }

        private void HideAllElements()
        {
            btnSearch.Hide();
            grpBoxRadio.Hide();
            txtSearch.Hide();
            dataGridViewOldClients.Hide();
        }

        private void ShowAllElements()
        {
            btnSearch.Show();
            grpBoxRadio.Show();
            txtSearch.Show();
        }

        private void openNewCaseForm()
        {
            NewCase newCase = FormPool.NewCase;
            newCase.FormClosed += (s, args) => this.Close();
            newCase.Show();
            this.Hide();
            ResetUI();
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

        #endregion
    }
    
}
