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
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ProductsList products = new ProductsList();
            products.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
      
            Login f = new Login();
            f.Show();
            this.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
        
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            
        }

        private void الفئاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            cat.MdiParent = this;
            cat.Show();
        }

        private void الاصنافToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductsList products = new ProductsList();
            products.MdiParent = this;
            products.Show();
        }

        private void مرتباتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeSalary emp = new EmployeeSalary();
            emp.Show();
        }

        private void الموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void شاشةالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppliers s = new Suppliers();
            s.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void تقريرعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientReport sales = new ClientReport();
            sales.Show();
        }

        private void تقريرمبيعاتدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesReport sales = new SalesReport();
            sales.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void مستخدمينالبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm users = new UsersForm();
            users.Show();
        }

        private void حضورواتصرافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeAttendance attendance = new EmployeeAttendance();
            attendance.Show();
        }

        private void حساباتالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
