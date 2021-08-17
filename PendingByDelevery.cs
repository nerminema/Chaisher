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
    public partial class PendingByDelevery : Form
    {
        Classes.EmployeeClass employee = new Classes.EmployeeClass();
        public PendingByDelevery()
        {
            InitializeComponent();
            cmb_employee.DataSource = employee.SelectAllEmployee();
            cmb_employee.DisplayMember = "EmployeeName";
            cmb_employee.ValueMember = "ID";
            cmb_employee.SelectedIndex = -1;
        }
        Classes.RequestedOrderClass requested = new Classes.RequestedOrderClass();
        private void button1_Click(object sender, EventArgs e)
        {
            dg_order.AutoGenerateColumns = false;
            dg_order.DataSource=requested.SelectRequestedorder(int.Parse(cmb_employee.SelectedValue.ToString()),dt_orderDate.Value.Date);
           decimal? total  = requested.SelectedTotal(int.Parse(cmb_employee.SelectedValue.ToString()), dt_orderDate.Value.Date);
            lbl_Total.Text = total.ToString();

        }
        Classes.RequestedOrderClass order = new Classes.RequestedOrderClass();
        private void button2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dg_order.Rows.Count; i++)
            {try
                {
                    order.UpdateOrder(int.Parse(dg_order.Rows[i].Cells["Column6"].Value.ToString()), decimal.Parse(dg_order.Rows[i].Cells["Column1"].Value.ToString()), true, "" ,0 , null);
                }
                catch
                { }
            }
            dg_order.DataSource = null;
            lbl_Total.Text = "0";
            cmb_employee.SelectedIndex = -1;
        }
    }
}
