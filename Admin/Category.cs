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

namespace Chaisher.Admin
{
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }
        CategoryClass cat = new CategoryClass();
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (btn_Login.Tag == null)
            {
                cat.InsertNewCategory(txt_Catname.Text, btn_Color.BackColor.ToArgb().ToString(), btn_Color.ForeColor.ToArgb().ToString());
                dataGridView1.DataSource = cat.SelectAllCategory();
            }
            else 
            {
                cat.UpdateNewCategory(txt_Catname.Text, btn_Color.BackColor.ToArgb().ToString(), int.Parse(btn_Login.Tag.ToString()), btn_Color.ForeColor.ToArgb());
                dataGridView1.DataSource = cat.SelectAllCategory();
            }
            txt_Catname.Text = "";
            btn_Login.Tag = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Column4"].FormattedValue.ToString());
            if(e.ColumnIndex== 0)
            {
              txt_Catname.Text = cat.SelectAllCategoryByID(id)[0].CategoryName;
                btn_Login.Tag = id;
                try
                {
                    btn_Color.BackColor = Color.FromArgb(int.Parse(cat.SelectAllCategoryByID(id)[0].Color));
                    btn_Color.ForeColor = Color.FromArgb(int.Parse(cat.SelectAllCategoryByID(id)[0].ForeColor));
                }
                catch{ }
            }
            else if (e.ColumnIndex ==1)
            {
                cat.DeleteCategory(id);
            }
            dataGridView1.DataSource = cat.SelectAllCategory();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void Category_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cat.SelectAllCategory();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_Catname.Text = "";
            btn_Login.Tag = null;
        }

        private void Category_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                ComboBox cmb_Category = this.Owner.Controls.Find("cmb_Category", true).First() as ComboBox ;
                cmb_Category.DataSource = cat.SelectAllCategory();
                cmb_Category.DisplayMember = "CategoryName";
                cmb_Category.ValueMember = "ID";
                cmb_Category.SelectedIndex = -1;
            }
            catch
            {

            }

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()== DialogResult.OK)
            {
                string str = null;
                str = colorDialog1.Color.Name;
                int argb=colorDialog1.Color.ToArgb();
                btn_Color.BackColor = Color.FromArgb(argb);
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                string str = null;
                str = colorDialog1.Color.Name;
                int argb = colorDialog1.Color.ToArgb();
                btn_Color.ForeColor = Color.FromArgb(argb);
                btn_Color.Text = str;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                string str = null;
                str = colorDialog1.Color.Name;
                int argb = colorDialog1.Color.ToArgb();
                btn_Color.BackColor = Color.FromArgb(argb);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                string str = null;
                str = colorDialog1.Color.Name;
                int argb = colorDialog1.Color.ToArgb();
                btn_Color.ForeColor = Color.FromArgb(argb);
                btn_Color.Text = str;
            }
        }
    }
}
