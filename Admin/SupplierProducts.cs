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
    public partial class SupplierProducts : Form
    {
        Classes.RowMaterialClass rowMaterial = new Classes.RowMaterialClass();
        int _id;
        public SupplierProducts(int id)
        {
            InitializeComponent();
            _id = id;

            comboBox1.DataSource = rowMaterial.SelectAll();
            comboBox1.DisplayMember = "ProductName";
            comboBox1.ValueMember = "ID";
            comboBox1.SelectedIndex = -1;
            txt_ClientName.Text = sub.SelectAll(_id)[0].SupplierName;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = suppliersProducts.SelectAllBySub(_id);
        }
        Classes.SuppliersClass sub = new Classes.SuppliersClass();
        Classes.SuppliersProductsProductsClass suppliersProducts = new Classes.SuppliersProductsProductsClass();
        private void btn_Login_Click(object sender, EventArgs e)
        {
        if(btn_Login.Tag == null)
        {
                suppliersProducts.Insert(_id, int.Parse(comboBox1.SelectedValue.ToString()), decimal.Parse(txt_price.Text));
        }
        else 
        {
                suppliersProducts.Update(int.Parse(btn_Login.Tag.ToString()),_id, int.Parse(comboBox1.SelectedValue.ToString()), decimal.Parse(txt_price.Text));
            }
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = suppliersProducts.SelectAllBySub(_id);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString());
            if(e.ColumnIndex==3)
            {
              List<usp_SelectAllSuppliersProductsByID_Result> res=  suppliersProducts.SelectAll(id);
                txt_price.Text = res[0].Price.ToString();
                comboBox1.SelectedValue = (int)res[0].RowMatrialID;
                btn_Login.Tag = res[0].ID;
            }
            else if(e.ColumnIndex==4)
            {
                suppliersProducts.Delete(id);
            }
            dataGridView1.DataSource = suppliersProducts.SelectAllBySub(_id);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RowMaterial rowMaterial = new RowMaterial();
            rowMaterial.Show(this);
        }

        private void SupplierProducts_Load(object sender, EventArgs e)
        {

        }

        private void SupplierProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DataGridView dg = this.Owner.Controls.Find("dataGridView1", true).First() as DataGridView;
                dg.DataSource = suppliersProducts.SelectAllBySub(int.Parse(comboBox1.SelectedValue.ToString()));
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
