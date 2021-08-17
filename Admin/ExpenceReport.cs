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
    public partial class ExpenceReport : Form
    {
        public ExpenceReport()
        {
            InitializeComponent();
        }
        Classes.ExpenceClass ex = new Classes.ExpenceClass();
        private void button1_Click(object sender, EventArgs e)
        {
           dg_del.DataSource= ex.SelectDElExpence(dt_from.Value.Date, dt_To.Value.Date);
            dg_other.DataSource = ex.SelectExpence(dt_from.Value.Date, dt_To.Value.Date);
            txt_del.Text = ex.totaldelex(dt_from.Value.Date, dt_To.Value.Date).ToString();
            txt_total.Text = ex.Totalex(dt_from.Value.Date, dt_To.Value.Date).ToString();
        }
    }
}
