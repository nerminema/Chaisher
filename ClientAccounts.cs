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
    public partial class ClientAccounts : Form
    {
        Classes.RequestedOrderClass order = new Classes.RequestedOrderClass();
        public ClientAccounts()
        {
            InitializeComponent();
            dataGridView1.DataSource = order.SelectRequestedRwem();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        try
        {
                

        }
        catch
        {

        }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex ==0)
            {
            int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Column1"].FormattedValue.ToString());
                Payment p = new Payment(id);
                p.Show(this);
            }
        }
    }
}
