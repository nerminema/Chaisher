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
    public partial class loans : Form
    {
        Classes.EmployeeClass employee = new Classes.EmployeeClass();
        bool _isloan;
        public loans(bool isLoan)
        {
            InitializeComponent();
            cmb_employee.DataSource = employee.SelectAllEmployee();
            cmb_employee.DisplayMember = "EmployeeName";
            cmb_employee.ValueMember = "ID";
            cmb_employee.SelectedIndex = -1;
            _isloan = isLoan;
            if (_isloan == false)
                this.Text = "خصومات موظفين";
        }
        Classes.LoanClass loan = new Classes.LoanClass();
        private void btn_Login_Click(object sender, EventArgs e)
        {
            loan.InsertEmployeeLoan(int.Parse(cmb_employee.SelectedValue.ToString()), _isloan ,decimal.Parse( txt_actual.Text ), dt_from.Value.Date);
            MessageBox.Show("تم إضافة السلفة");
            txt_actual.Text = "";
            cmb_employee.SelectedIndex = -1;
            dt_from.Value = DateTime.Now;
        }
    }
}
