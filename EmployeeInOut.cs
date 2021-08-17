using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chaisher
{
    public partial class EmployeeInOut : Form
    {
        int id;
        Classes.EmployeeClass employee = new Classes.EmployeeClass();
        public EmployeeInOut()
        {
            InitializeComponent();
            //id = _id;
            cmb_employee.DataSource = employee.SelectAllEmployee();
            cmb_employee.DisplayMember = "EmployeeName";
            cmb_employee.ValueMember = "ID";
            cmb_employee.SelectedIndex = -1;
        }
        Classes.EmployeeTimeAttanceClass empAtt = new Classes.EmployeeTimeAttanceClass();
        private void btn_Login_Click(object sender, EventArgs e)
        {

            empAtt.Insert(int.Parse(cmb_employee.SelectedValue.ToString()) ,dt_inTime.Value.TimeOfDay  , dt_outTime.Value.TimeOfDay  , decimal.Parse(totalsec.ToString()) , dt_orderDate.Value.Date ,1);
            MessageBox.Show("تم تسجيل حضور الموظف");
            txt_cal.Text = "";
            dt_inTime.Value = dt_outTime.Value = dt_orderDate.Value = DateTime.Now;
            cmb_employee.SelectedIndex = -1;
        }
        double totalsec;
        private void dt_outTime_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan diff = dt_outTime.Value.TimeOfDay - dt_inTime.Value.TimeOfDay;
            totalsec = (diff.TotalSeconds/60)/60;
            txt_cal.Text = totalsec.ToString();
        }
    }
}
