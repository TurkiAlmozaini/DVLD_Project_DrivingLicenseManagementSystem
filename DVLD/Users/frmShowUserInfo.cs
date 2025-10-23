using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmShowUserInfo : Form
    {
        public frmShowUserInfo(int UserId)
        {
            InitializeComponent();

            ctrUserInfo1.LoadUserInfo(UserId);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
