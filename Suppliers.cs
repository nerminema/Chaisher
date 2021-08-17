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
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
           comboBox1.DataSource= sub.SelectAll();
            comboBox1.DisplayMember = "SupplierName";
            comboBox1.ValueMember = "ID";
            comboBox1.SelectedIndex = -1;
        }
        int _id;
        public Suppliers(int id )
        {
            InitializeComponent();
            comboBox1.DataSource = sub.SelectAll();
            comboBox1.DisplayMember = "SupplierName";
            comboBox1.ValueMember = "ID";
            comboBox1.SelectedIndex = -1;
            _id = id;
        }
        Classes.SuppliersClass sub = new Classes.SuppliersClass();
        Classes.SuppliersProductsProductsClass suppliersProducts = new Classes.SuppliersProductsProductsClass();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = suppliersProducts.SelectAllBySub(int.Parse(comboBox1.SelectedValue.ToString()));
            }
            catch
            { }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin.SupplierProducts sub = new Admin.SupplierProducts(int.Parse(comboBox1.SelectedValue.ToString()));
            sub.Show(this);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Classes.POClass po = new Classes.POClass();
        Classes.PODetailsClass details = new Classes.PODetailsClass();
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(btn_Login.Tag == null)
            {
              int? poID =  po.Insert(int.Parse(comboBox1.SelectedValue.ToString()), dt_orderDate.Value.Date ,decimal.Parse(lbl_total.Text) , false );
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    try
                    {
                        int spID = int.Parse(dataGridView1.Rows[i].Cells["ID"].FormattedValue.ToString());
                        decimal qnty = decimal.Parse(dataGridView1.Rows[i].Cells["Column3"].FormattedValue.ToString());
                        details.Insert((int)poID, spID, qnty ,0 , dt_orderDate.Value);
                    }
                    catch
                    { }
                }
            }
            else 
            {
                po.Update(_id,int.Parse(comboBox1.SelectedValue.ToString()), dt_orderDate.Value.Date, decimal.Parse(lbl_total.Text), false);
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    int spID = int.Parse(dataGridView1.Rows[i].Cells["ID"].FormattedValue.ToString());
                    decimal qnty = decimal.Parse(dataGridView1.Rows[i].Cells["Column3"].FormattedValue.ToString());
                    //details.Update((int)poID, spID, qnty);
                }
            }
            MessageBox.Show("تم حفظ فاتورة التوريدات");
            comboBox1.SelectedValue = -1;
            dataGridView1.DataSource = null;
            dt_orderDate.Value = DateTime.Now;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 3)
            {
                decimal price = decimal.Parse(dataGridView1.Rows[e.RowIndex].Cells["Column2"].FormattedValue.ToString());
                decimal qnty = decimal.Parse(dataGridView1.Rows[e.RowIndex].Cells["Column3"].FormattedValue.ToString());
                lbl_total.Text = (decimal.Parse(lbl_total.Text) + (price * qnty)).ToString();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SupplierAccount account = new SupplierAccount(int.Parse(comboBox1.SelectedValue.ToString()));
            account.Show();
        }
    }
}
