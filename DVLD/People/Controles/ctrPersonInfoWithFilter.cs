using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DVLD_Business_Layer;
using System.Windows.Forms;

namespace DVLD.People.Controles
{
    public partial class ctrPersonInfoWithFilter : UserControl
    {



        // Define a custom event handler delegate with parameters
        public event Action<int> OnPersonSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void PersonSelected(int PersonID)
        {

            Action<int> handler = OnPersonSelected;
            if (handler != null)
            {
                handler(PersonID); // Raise the event with the parameter
            }
        }


        private bool _ShowAddPerson = true;
        public bool ShowAddPerson
        {
            get
            {
                return _ShowAddPerson;
            }

            set
            {
                _ShowAddPerson = value;
                btnAddPerson.Visible = _ShowAddPerson;
            }
        }

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
        }






        public ctrPersonInfoWithFilter()
        {
            InitializeComponent();
        }




        public int PersonID
        {
            get { return ctrPersonInfo1.PersonID; }
        }


        public ClsPerson SelectedPersonInfo
        {
            get { return ctrPersonInfo1.SelectedPersonInfo; }
        }







        public void LoadPersonInfo(int PersonID)
        {
            cbFilterBy.SelectedIndex = 0;
            txFilterValue.Text = PersonID.ToString();
            _FindPerson();
        }




        private void _FindPerson()
        {
            switch (cbFilterBy.Text)
            {
                case "Person ID":
                    ctrPersonInfo1.LoadPersonInfo(int.Parse(txFilterValue.Text));
                    break;
                case "National No":
                    ctrPersonInfo1.LoadPersonInfo(txFilterValue.Text);
                    break;


            }

            if (OnPersonSelected != null && FilterEnabled)
                // Raise the event with a parameter
                OnPersonSelected(ctrPersonInfo1.PersonID);

        }

        private void btnFindPerson_Click(object sender, EventArgs e)
        {


            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FindPerson();



        }


        private void ctrPersonInfoWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            txFilterValue.Focus();
        }

        private void txFilterValue_Validating(object sender, CancelEventArgs e)
        {


            if (string.IsNullOrEmpty(txFilterValue.Text.Trim()))
            {
                e.Cancel = true;

                errorProvider1.SetError(txFilterValue, "This field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txFilterValue, null);
            }

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txFilterValue.Text = "";
            txFilterValue.Focus();
        }

        private void txFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                btnFindPerson.PerformClick();
            }

            //this will allow only digits if person id is selected
            if (cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            frm.DataBack += DataBackEvent;
            frm.ShowDialog();
        }


        private void DataBackEvent(object sender, int PersonID)
        {

            //cbFilterBy.SelectedIndex = 1;
            txFilterValue.Text = PersonID.ToString();
            ctrPersonInfo1.LoadPersonInfo(PersonID);
        }

        public void FilterFocus()
        {
            txFilterValue.Focus();
        }



    }
}
