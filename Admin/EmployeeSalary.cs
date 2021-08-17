using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chaisher.Admin
{
    public partial class EmployeeSalary : Form
    {
        public EmployeeSalary()
        {
            InitializeComponent();
            cmb_employee.DataSource = employee.SelectAllEmployee();
            cmb_employee.DisplayMember = "EmployeeName";
            cmb_employee.ValueMember = "ID";
            cmb_employee.SelectedIndex = -1;
        }
        Classes.EmployeeTimeAttanceClass empin = new Classes.EmployeeTimeAttanceClass();
        Classes.EmployeeClass employee = new Classes.EmployeeClass();
        Classes.LoanClass loan = new Classes.LoanClass();
        private void dt_orderDate_ValueChanged(object sender, EventArgs e)
        {
        List<usp_SelectAllEmployeeByID_Result> emp = employee.SelectAllEmployee(int.Parse(cmb_employee.SelectedValue.ToString()));
            txt_actual.Text = emp[0].workingHours.ToString();
            decimal dayvalue = 0;
            if (emp[0].Isweekly == true)
                dayvalue = ((decimal)emp[0].Salary / 7) /(decimal) emp[0].workingHours;
            else
                dayvalue =( (decimal)emp[0].Salary / 30) / (decimal)emp[0].workingHours;
           txt_cal.Text= empin.TotalWorkingHours(int.Parse(cmb_employee.SelectedValue.ToString()), dt_from.Value.Date, dt_To.Value.Date).ToString();
            if (txt_cal.Text == "")
                txt_cal.Text = "0";
            lbl_total.Text = Math.Round(decimal.Parse(txt_cal.Text)* (decimal)emp[0].Salary / (decimal)emp[0].workingHours, 2).ToString();
            lbl_loan.Text = loan.SelectEmployeeLoan(int.Parse(cmb_employee.SelectedValue.ToString()), dt_from.Value.Date, dt_To.Value.Date,true).ToString();
            if (lbl_loan.Text == "")
                lbl_loan.Text = "0";
            lbl_deduction.Text = loan.SelectEmployeeLoan(int.Parse(cmb_employee.SelectedValue.ToString()), dt_from.Value.Date, dt_To.Value.Date, false).ToString();
            if (lbl_deduction.Text == "")
                lbl_deduction.Text = "0";
            lbl_net.Text = (decimal.Parse(lbl_total.Text)- decimal.Parse(lbl_loan.Text)- decimal.Parse(lbl_deduction.Text)).ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

        }
    }
}
