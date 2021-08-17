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
    public partial class EmployeeAttendance : Form
    {
        public EmployeeAttendance()
        {
            InitializeComponent();
            cmb_employee.DataSource = emp.SelectAllEmployee();
            cmb_employee.DisplayMember = "EmployeeName";
            cmb_employee.ValueMember = "ID";
            cmb_employee.SelectedIndex = -1;
        }
        Classes.EmployeeClass emp = new Classes.EmployeeClass();
        Classes.EmployeeTimeAttanceClass atte = new Classes.EmployeeTimeAttanceClass();
        private void button1_Click(object sender, EventArgs e)
        {
            //List<usp_SelectEmployeeAttedance_Result> attEmp = atte.SelectAll(int.Parse(txt_EmployeeID.Text), DateTime.Now.Date, DateTime.Now.Date);
            //if (attEmp.Count == 0)
            //    txt_att.Text = DateTime.Now.TimeOfDay.ToString();
            //// atte.Insert(int.Parse(txt_EmployeeID.Text), DateTime.Now.TimeOfDay, null, null, DateTime.Now, 0);
            //else
            //{
            //    txt_att.Text = attEmp[0].Intime.ToString();
            //    txt_leave.Text = attEmp[0].OutTime.ToString();
            //    if (txt_leave.Text == "")
            //        txt_leave.Text = DateTime.Now.TimeOfDay.ToString();
            //    //   atte.Update(int.Parse(txt_EmployeeID.Text), (TimeSpan)attEmp[0].Intime, DateTime.Now.TimeOfDay, (decimal)(DateTime.Now.TimeOfDay - (TimeSpan)attEmp[0].Intime).TotalHours, DateTime.Now, attEmp[0].ID);
            //}
        }

        private void cmb_employee_SelectedIndexChanged(object sender, EventArgs e)
        {
        try
        {
        
        }
        catch
        {

        }
        }

        private void dt_To_ValueChanged(object sender, EventArgs e)
        {
            List<usp_SelectEmployeeAttedance_Result> attEmp = atte.SelectAll(int.Parse(cmb_employee.SelectedValue.ToString()), dt_To.Value.Date, dt_from.Value.Date);
            dataGridView1.DataSource = attEmp;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            TimeSpan intime = TimeSpan.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            TimeSpan outtime = TimeSpan.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            DateTime date = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells["Column4"].Value.ToString());
            int  id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Column5"].Value.ToString());
            if (e.ColumnIndex ==  2)
            {
                TimeSpan diff = TimeSpan.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()) - TimeSpan.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                double totalsec = Math.Round((diff.TotalSeconds / 60) / 60, 2);
                //txt_cal.Text = totalsec.ToString();
                dataGridView1.Rows[e.RowIndex].Cells[4].Value = totalsec.ToString();
                atte.Update(int.Parse(cmb_employee.SelectedValue.ToString()), intime, outtime, (decimal)totalsec, date, id);
            }
            else if (e.ColumnIndex == 3)
            {
                TimeSpan diff = TimeSpan.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()) - TimeSpan.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                double totalsec =Math.Round( (diff.TotalSeconds / 60) / 60,2);
                //txt_cal.Text = totalsec.ToString();
                dataGridView1.Rows[e.RowIndex].Cells[4].Value = totalsec.ToString();
                atte.Update(int.Parse(cmb_employee.SelectedValue.ToString()), intime, outtime,(decimal) totalsec, date, id);
            }
        }

        private void dt_from_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
