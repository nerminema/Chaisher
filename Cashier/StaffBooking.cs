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
    public partial class StaffBooking : Form
    {
        public StaffBooking()
        {
            InitializeComponent();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            Admin.PreviewEmployeeAttendance previewEmployee = new Admin.PreviewEmployeeAttendance();
            previewEmployee.Show(this);
        }

        private void btn_booking_Click(object sender, EventArgs e)
        {
            Cashier.EmployeeShiftAttandance employeeShift = new EmployeeShiftAttandance();
            employeeShift.Show(this);
        }
    }
}
