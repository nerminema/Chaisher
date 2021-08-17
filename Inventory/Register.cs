using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chaisher.Inventory
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            Admin.ProductsList product = new Admin.ProductsList(textBox1.Text);
            product.Show(this);
        }
    }
}
