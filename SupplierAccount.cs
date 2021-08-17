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
    public partial class SupplierAccount : Form
    {
        Classes.SuppliersClass subs = new Classes.SuppliersClass();
        Classes.POClass POClass = new Classes.POClass();
        public SupplierAccount(int sub)
        {
            InitializeComponent();
            comboBox1.DataSource = subs.SelectAll();
            comboBox1.DisplayMember = "SupplierName";
            comboBox1.ValueMember = "ID";
            comboBox1.SelectedIndex = -1;
            comboBox1.SelectedValue = sub;

        }
        public SupplierAccount()
        {
            InitializeComponent();
            comboBox1.DataSource = subs.SelectAll();
            comboBox1.DisplayMember = "SupplierName";
            comboBox1.ValueMember = "ID";
            comboBox1.SelectedIndex = -1;
           

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try

            {
                dataGridView1.AutoGenerateColumns = false;
                   dataGridView1.DataSource= POClass.SelectAllBySub(int.Parse(comboBox1.SelectedValue.ToString()));
            }
            catch
            {

            }
        }
       Admin.SupplierPayments supplierPay = null;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(supplierPay == null)
            {
                if (comboBox1.SelectedValue != null)
                {
                    supplierPay = new Admin.SupplierPayments(int.Parse(comboBox1.SelectedValue.ToString()));
                    supplierPay.MdiParent = this.MdiParent;

                    supplierPay.Show();
                }
                else 
                {
                    supplierPay = new Admin.SupplierPayments();
                    supplierPay.MdiParent = this.MdiParent;

                    supplierPay.Show();
                }
            }

        }
    }
}
