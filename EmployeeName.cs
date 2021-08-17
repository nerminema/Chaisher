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
    public partial class EmployeeName : Form
    {
        public EmployeeName()
        {
            InitializeComponent();
        }
        Classes.EmployeeClass emp = new Classes.EmployeeClass();
        private void btn_Login_Click(object sender, EventArgs e)
        {
            emp.InsertEmployee(txt_Employee.Text, true, 0, true, 0, false, false);
            this.Close();
        }

        private void EmployeeName_FormClosing(object sender, FormClosingEventArgs e)
        {
           
                try
                {
                    ComboBox cmb_employee = this.Owner.Controls.Find("cmb_employee", true).First() as ComboBox;
                    cmb_employee.DataSource = emp.SelectAllEmployee();
                    cmb_employee.DisplayMember = "EmployeeName";
                    cmb_employee.ValueMember = "ID";
                    cmb_employee.SelectedIndex = -1;
                }
                catch
                { }
            
        }
    }
}
