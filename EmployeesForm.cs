using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chaisher.Classes;
namespace Chaisher
{
    public partial class EmployeesForm : Form
    {
        EmployeeClass employee = new EmployeeClass(); 

    
        public EmployeesForm()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = employee.SelectAllEmployee();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(btn_Login.Tag== null)
            {
                employee.InsertEmployee(txt_Employee.Text , ch_delevery.Checked , decimal.Parse(txt_Salary.Text), ch_weeklySalary.Checked , decimal.Parse(txt_houringWorking.Text), ch_manager.Checked , ch_attandance.Checked);
            }
            else 
            {
                employee.UpdateEmployee(txt_Employee.Text, ch_delevery.Checked, decimal.Parse(txt_Salary.Text), ch_weeklySalary.Checked, decimal.Parse(txt_houringWorking.Text), int.Parse(btn_Login.Tag.ToString()), ch_manager.Checked, ch_attandance.Checked);
            }
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = employee.SelectAllEmployee();
            txt_Employee.Text = txt_houringWorking.Text = txt_Salary.Text = "";
            ch_delevery.Checked = ch_weeklySalary.Checked = false;
            btn_Login.Tag = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Column6"].FormattedValue.ToString());
            if(e.ColumnIndex ==8)
            {
                // select fro edit 
                List<usp_SelectAllEmployeeByID_Result> empList =employee.SelectAllEmployee(id);
                txt_Employee.Text = empList[0].EmployeeName;
                txt_houringWorking.Text = empList[0].workingHours.ToString();
                txt_Salary.Text = empList[0].Salary.ToString();
                ch_delevery.Checked =(bool) empList[0].IsDelevery;
                ch_weeklySalary.Checked = (bool)empList[0].Isweekly;
                btn_Login.Tag = id;
                ch_manager.Checked = (bool)empList[0].IsManager;
                ch_attandance.Checked = (bool)empList[0].IsAttendance;
            }
            else if (e.ColumnIndex == 9)
            {
                // delete 
                if (MessageBox.Show("متاكد انك عايز تمسح الموظف ده ", "تاكيد حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    employee.DeleteEmployee(id);
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = employee.SelectAllEmployee();
                }
            }
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {

        }

        private void EmployeesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                ComboBox cmb_employee = this.Owner.Controls.Find("cmb_employee", true).First() as ComboBox;
                cmb_employee.DataSource = employee.SelectAllEmployee();
                cmb_employee.DisplayMember = "EmployeeName";
                cmb_employee.ValueMember = "ID";
                cmb_employee.SelectedIndex = -1;
            }
            catch
            { }
        }

        private void txt_houringWorking_KeyPress(object sender, KeyPressEventArgs e)
        {
          bool  IsNumberOrBackSpace = false;
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                IsNumberOrBackSpace = true;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
