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

namespace Chaisher
{
    public partial class Notes : Form
    {
        int _id;
        public Notes(int id )
        {
            InitializeComponent();
            _id = id;
            textBox1.Focus();
        }
        Classes.ReqestedORderDetails details = new ReqestedORderDetails();
        private void btn_Login_Click(object sender, EventArgs e)
        {
            List<usp_SelectRequestedORderDetailsById_Result> det =   details.SelectRequestedOrderDetailsById(_id);
            details.UpdateRequestedORderDetails((int)det[0].RequestedID , (int)det[0].ProductID , (decimal)det[0].Qunatity , (decimal)det[0].Price,_id , textBox1.Text );
            DataGridView dg_order = this.Owner.Controls.Find("dg_order", true).First() as DataGridView;
            dg_order.AutoGenerateColumns = false;
            dg_order.DataSource = details.SelectRequestedORderByOrderId((int)det[0].RequestedID);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
