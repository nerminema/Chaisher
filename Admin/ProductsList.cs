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
    public partial class ProductsList : Form
    {
        public ProductsList()
        {
            InitializeComponent();
            cmb_Category.DataSource = cat.SelectAllCategory();
            cmb_Category.DisplayMember = "CategoryName";
            cmb_Category.ValueMember = "ID";
            cmb_Category.SelectedIndex = -1;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = product.SelectProduct();
        }
        public ProductsList( string code)
        {
            InitializeComponent();
           cmb_Category.DataSource = cat.SelectAllCategory();
            cmb_Category.DisplayMember = "CategoryName";
            cmb_Category.ValueMember = "ID";
            cmb_Category.SelectedIndex = -1;
            txt_Code.Text = code;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = product.SelectProduct();
        }
        CategoryClass cat = new CategoryClass();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Catname_OnValueChanged(object sender, EventArgs e)
        {
        if(txt_Productname.Text !="")
            dataGridView1.DataSource = product.SearchProduct(txt_Productname.Text);

        }
        ProductClass product = new ProductClass();
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_Code.Text == "")
                txt_Code.Text = "0";
            if (btn_Login.Tag == null)
            {
                product.InsertProductByID(txt_Productname.Text, decimal.Parse(txt_price.Text), ch_IsUnit.Checked, int.Parse(cmb_Category.SelectedValue.ToString()), ch_Notes.Checked, int.Parse(txt_productNo.Text), int.Parse(txt_Code.Text));
            }
            else
            {

                product.UpdateProductByID(txt_Productname.Text, decimal.Parse(txt_price.Text), ch_IsUnit.Checked, int.Parse(cmb_Category.SelectedValue.ToString()), int.Parse(btn_Login.Tag.ToString()), ch_Notes.Checked, int.Parse(txt_productNo.Text), int.Parse(txt_Code.Text));
            }
            Clear();
        }

        private void Clear()
        {
            dataGridView1.DataSource = product.SelectProduct();
            txt_Code.Text = txt_productNo.Text = txt_price.Text = txt_Productname.Text = "";
           ch_Notes.Checked= ch_IsUnit.Checked = false;

            cmb_Category.SelectedIndex = -1;
            btn_Login.Tag = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Column4"].FormattedValue.ToString());
            if (e.ColumnIndex == 8)
            {
                List<usp_SelectProductByID_Result> SelectPRoduct = product.SelectProductByID(id);
                txt_price.Text = SelectPRoduct[0].Price.ToString();
                txt_Productname.Text = SelectPRoduct[0].ProductName.ToString();
                ch_IsUnit.Checked =(bool) SelectPRoduct[0].IsWeightPrice;
                btn_Login.Tag = id;
                txt_Code.Text = SelectPRoduct[0].barcode.ToString() ;
                ch_Notes.Checked =(bool) SelectPRoduct[0].isNoteAllowed;
                txt_productNo.Text = SelectPRoduct[0].OrderNo.ToString();
                cmb_Category.SelectedValue = (int)SelectPRoduct[0].CatID;
            }
            else if (e.ColumnIndex == 9)
            {
                if (MessageBox.Show("هل انت متأكد انك تريد حذف هذا الصنف", "تنبيه", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)== DialogResult.OK)
                {
                    product.DeleteProductByID(id);
                    if(cmb_Category.SelectedIndex== -1)
                    dataGridView1.DataSource = product.SelectProduct();
                    else
                        dataGridView1.DataSource = product.SelectProductByCatID(int.Parse(cmb_Category.SelectedValue.ToString()));
                }
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Category category = new Category();
            category.Show(this);
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = product.SelectProductByCatID(int.Parse(cmb_Category.SelectedValue.ToString()));
            }
            catch
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExcelClass ex = new ExcelClass();
            ex.ExportToExcel(dataGridView1);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                    chk.Value = !(chk.Value == null ? false : (bool)chk.Value); //because chk.Value is initialy null
                    row.Selected = true;
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = product.SelectProduct();
        }
    }
}
