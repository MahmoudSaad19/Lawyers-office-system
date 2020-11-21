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
        #region ctor + Load
        public ShowClientInfo()
        {
            InitializeComponent();
        }

        private void ShowClientInfo_Load(object sender, EventArgs e)
        {
            ShowClientInfo clientInfo = FormPool.ShowClientInfo;
        }

        #endregion
    }
}
