using Chaisher.Classes;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        Category cat = null;
        private void الفئاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cat == null)
            {
                cat = new Category();
                cat.MdiParent = this;
                cat.FormClosing += Cat_FormClosing;
                cat.Show();
            }
        }

        private void Cat_FormClosing(object sender, FormClosingEventArgs e)
        {
            cat = null;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Count(); i++)
            {
                this.MdiChildren[i].Close();
            }
        }

        private void افقيToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void رأسيToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void متتابعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void الاصنافToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (products == null)
            {
                products = new ProductsList();
                products.MdiParent = this;
                products.FormClosing += Products_FormClosing;
                products.Show();
            }
        }

        private void Products_FormClosing(object sender, FormClosingEventArgs e)
        {
            products = null;
        }

        SalesReport sales = null;
        ProductsList products = null;
        private void تقريرمبيعاتدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sales == null)
            {
                sales = new SalesReport();
                sales.FormClosing += Sales_FormClosing;
                sales.MdiParent = this;
                sales.Show();
            }
        }

        private void Sales_FormClosing(object sender, FormClosingEventArgs e)
        {
            sales = null;
        }
        EmployeeInOut inout = null;
        private void حضوروانصرافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inout == null)
            {
                inout = new EmployeeInOut();
                //inout.MdiParent = this;
                inout.FormClosing += Inout_FormClosing;
                inout.Show(this);
            }

        }
        EmployeeAttendance attendance = null;
        private void حضورواتصرافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (attendance == null)
            {
                attendance = new EmployeeAttendance();
                attendance.MdiParent = this;
                attendance.FormClosing += Attendance_FormClosing;
                attendance.Show();
            }
        }
        private void Inout_FormClosing(object sender, FormClosingEventArgs e)
        {
            inout = null;
        }

        private void Attendance_FormClosing(object sender, FormClosingEventArgs e)
        {
            attendance = null;
        }

        ClientReport salesRpt = null;
        private void تقريرعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (salesRpt == null)
            {
                salesRpt = new ClientReport();
                salesRpt.MdiParent = this;
                salesRpt.FormClosing += SalesRpt_FormClosing;
                salesRpt.Show();
            }
        }

        private void SalesRpt_FormClosing(object sender, FormClosingEventArgs e)
        {
            salesRpt = null;
        }
        Suppliers s = null;
        private void شاشةالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (s == null)
            {
                s = new Suppliers();
                s.MdiParent = this;
                s.FormClosing += S_FormClosing;
                s.Show();
            }
        }

        private void S_FormClosing(object sender, FormClosingEventArgs e)
        {
            s = null;
        }
        SupplierAccount SupplierAccount = null;
        private void حساباتالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
        if(SupplierAccount== null)
        {
                SupplierAccount = new SupplierAccount();
                SupplierAccount.MdiParent = this;
                SupplierAccount.FormClosing += SupplierAccount_FormClosing;
                SupplierAccount.Show();

        }
        }

        private void SupplierAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            //throw new NotImplementedException();
            SupplierAccount = null;
        }

        EmployeeSalary emp = null;
        private void مرتباتToolStripMenuItem_Click(object sender, EventArgs e)
        {if (emp == null)
            {
                emp = new EmployeeSalary();
                emp.MdiParent = this;
                emp.FormClosing += Emp_FormClosing;
                emp.Show();
            }
        }

        private void Emp_FormClosing(object sender, FormClosingEventArgs e)
        {
            // throw new NotImplementedException();
            emp = null;
        }
        UsersForm users = null;
        private void مستخدمينالبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (users == null)
            {
                users = new UsersForm();
                users.MdiParent = this;
                users.FormClosing += Users_FormClosing;
                users.Show();
            }
        }

        private void Users_FormClosing(object sender, FormClosingEventArgs e)
        {
            users = null;
        }

        private void إغلاقالبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Login l = null;
        private void الخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(l== null)
            {
                l = new Login();
                l.Show();
                l.FormClosing += L_FormClosing;
                this.Close();
            }
        }

        private void L_FormClosing(object sender, FormClosingEventArgs e)
        {
            l = null;
        }
        ProductInfo info = null;
        private void مساعدةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (info == null)
            {
                info = new ProductInfo();
                info.MdiParent = this;
                info.FormClosing += Info_FormClosing;
                info.Show();
            }
        }

        private void Info_FormClosing(object sender, FormClosingEventArgs e)
        {
            info = null;
        }

        AttendanceReport attendanceRpt = null;
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (attendanceRpt == null)
            {
                attendanceRpt = new AttendanceReport();
                attendanceRpt.MdiParent = this;
                attendanceRpt.FormClosing += AttendanceRpt_FormClosing;
                attendanceRpt.Show();
            }
        }

        private void AttendanceRpt_FormClosing(object sender, FormClosingEventArgs e)
        {
            attendanceRpt = null;
        }
        EmployeeSalaryReport salaryReport = null;
        private void تقريرمرتباتToolStripMenuItem_Click(object sender, EventArgs e)
        {
        if(salaryReport == null)
        {
                salaryReport = new EmployeeSalaryReport();
                salaryReport.FormClosing += SalaryReport_FormClosing;
                salaryReport.MdiParent = this;
                salaryReport.Show();
            }
        }

        private void SalaryReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            salaryReport = null;
        }
        EmployeesForm empForm = null;
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if(empForm == null)
            {
                empForm = new EmployeesForm();
                empForm.FormClosing += Emp_FormClosing1;
                empForm.MdiParent = this;
                empForm.Show();
            }
        }

        private void Emp_FormClosing1(object sender, FormClosingEventArgs e)
        {
            empForm = null;
        }
        SupplierPayments supplierPay = null;
        private void تصفيةحساباتموردToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (supplierPay == null)
            {
                supplierPay = new Admin.SupplierPayments();
                supplierPay.MdiParent = this.MdiParent;
                supplierPay.FormClosing += SupplierPay_FormClosing;
                supplierPay.Show();
            }
        }

        private void SupplierPay_FormClosing(object sender, FormClosingEventArgs e)
        {
            supplierPay = null;
        }

        private void ترتيبالشاشةToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        PendingOrders salesOrder = null;
        private void حذفطلبToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (salesOrder == null)
            {
                salesOrder = new PendingOrders("");
                salesOrder.MdiParent = this.MdiParent;
                salesOrder.FormClosing += SalesOrder_FormClosing;
                salesOrder.Show();
            }
        }

        private void SalesOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            salesOrder = null;
        }

      
        private void Loan_FormClosing(object sender, FormClosingEventArgs e)
        {
            loan = null;
        }

        private void جزاءاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loan == null)
            {
                loan = new loans(false);
                // loan.MdiParent = this;
                loan.FormClosing += Loan_FormClosing;
                loan.Show();
            }
        }
        loans loan = null;
        private void سلفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loan == null)
            {
                loan = new loans(true);
                //loan.MdiParent = this;
                loan.FormClosing += Loan_FormClosing;
                loan.Show();
            }
        }
        ShiftClass SHIFT = new ShiftClass();
        private void تصفيةالورديةToolStripMenuItem_Click(object sender, EventArgs e)
        {
           List<usp_SelectActiveShift_Result> active =SHIFT.SelectActiveShift();
            if (active.Count != 0)
            {
                EmployeeShift employeeShift = new EmployeeShift((int)active[0].userID, (int)active[0].ID);
                employeeShift.Show();
            }
            else 
            {
                MessageBox.Show("لا توجد وردية مفتوحة");
            }
        }
    }
}
