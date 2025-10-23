﻿using System;
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
    public partial class frmFindPerson : Form
    {


        public delegate void DataBackEventHandler(object sender, int PersonID);

        public event DataBackEventHandler DataBack;


        public frmFindPerson()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(this, ctrPersonInfoWithFilter1.PersonID);
        }

        private void frmFindPerson_Load(object sender, EventArgs e)
        {
            ctrPersonInfoWithFilter1.ShowAddPerson = false;
        }
    }
}
