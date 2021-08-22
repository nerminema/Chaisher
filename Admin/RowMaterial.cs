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
    public partial class RowMaterial : Form
    {
        public RowMaterial()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       Classes.RowMaterialClass  rowMaterial = new Classes.RowMaterialClass();
        private void btn_Login_Click(object sender, EventArgs e)
        {
          //  rowMaterial.Insert(txt_ClientName.Text);

            ComboBox comboBox1 = this.Owner.Controls.Find("comboBox1", true).First() as ComboBox;
            comboBox1.DataSource = rowMaterial.SelectAll();
            comboBox1.DisplayMember = "ProductName";
            comboBox1.ValueMember = "ID";
            comboBox1.SelectedIndex = -1;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
