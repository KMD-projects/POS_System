using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String StudentId = txtStudentId.Text;
            String StudentName = txtStudentName.Text;
            String Gender;
            if (rdoMale.Checked)
            {
                Gender = "Male";
            } else if (rdoFemale.Checked)
            {
                Gender = "Female";
            } else
            {
                Gender = "";
            }

            int Age = Convert.ToInt32(txtAge.Text);
            String Phone = txtPhone.Text;
            String Address = txtAddress.Text;

            // save data to db here
           
        }

        //private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
