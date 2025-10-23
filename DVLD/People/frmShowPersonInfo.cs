using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmShowPersonInfo : Form
    {
        public frmShowPersonInfo(int PersonID)
        {
            InitializeComponent();

            ctrPersonInfo1.LoadPersonInfo(PersonID);

        }

        public frmShowPersonInfo(string NationalNo)
        {
            InitializeComponent();

            ctrPersonInfo1.LoadPersonInfo(NationalNo);
         

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
