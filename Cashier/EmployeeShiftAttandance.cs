using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chaisher.Cashier
{
    public partial class EmployeeShiftAttandance : Form
    {
        Classes.ShiftSettingsClass ShiftSettings = new Classes.ShiftSettingsClass();
        public EmployeeShiftAttandance()
        {
            InitializeComponent();
            cmb_Shifts.DataSource = ShiftSettings.SelectAll();
            cmb_Shifts.DisplayMember = "ShiftName";
            cmb_Shifts.ValueMember = "ID";
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_addEmployee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddEmployee employee = new AddEmployee();
            employee.Show(this);
        }

        private void btn_addShift_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Shifts employee = new Shifts();
            employee.Show(this);
        }
    }
}
