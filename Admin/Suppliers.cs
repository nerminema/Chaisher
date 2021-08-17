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
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
        }
        Classes.SuppliersClass suppliers = new Classes.SuppliersClass();
        private void Suppliers_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource=suppliers.SelectAll();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (btn_Login.Tag == null)
            {
                suppliers.Insert(txt_ClientName.Text, txt_Phone.Text, txt_Address.Text);
            }
            else
            {
                suppliers.Update(int.Parse(btn_Login.Tag.ToString()),txt_ClientName.Text, txt_Phone.Text, txt_Address.Text);
            }
            dataGridView1.DataSource = suppliers.SelectAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id =int.Parse( dataGridView1.Rows[e.RowIndex].Cells["Column4"].FormattedValue.ToString());
            if(e.ColumnIndex == 0)
            {
                SupplierProducts sub = new SupplierProducts(id);
                sub.Show();
            }
        }
    }
}
