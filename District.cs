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
    public partial class District : Form
    {
        public District()
        {
            InitializeComponent();
        }
        Classes.DistrictClass district = new Classes.DistrictClass();
        private void btn_Login_Click(object sender, EventArgs e)
        {
        if(txt_Productname.Text !="")
        {
                district.InsertDistrict(txt_Productname.Text);
        }
        }

        private void District_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                ComboBox cmb_Category = this.Owner.Controls.Find("cmb_Category", true).First() as ComboBox;
                cmb_Category.DataSource = district.SelectAll();
                cmb_Category.DisplayMember = "DistrictName";
                cmb_Category.ValueMember = "ID";
                cmb_Category.SelectedIndex = -1;
            }
            catch
            {

            }
        }
    }
}
