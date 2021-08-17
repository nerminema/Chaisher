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
    public partial class Expences : Form
    {
        public Expences()
        {
            InitializeComponent();
        }
        Classes.ExpenceClass exp = new Classes.ExpenceClass();
        private void btn_Login_Click(object sender, EventArgs e)
        {
            exp.InsertExpence(decimal.Parse(txt_actual.Text) ,txt_exp.Text, null , dt_from.Value.Date, null );
            MessageBox.Show("تم الحفظ");
            txt_exp.Text =txt_actual.Text= "";
        }
    }
}
