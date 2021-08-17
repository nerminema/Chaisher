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
namespace Chaisher
{
    public partial class OrdersNos : Form
    {
        RequestedOrderClass order = new RequestedOrderClass();
        public OrdersNos(bool? isPending)
        {
            InitializeComponent();
            if (isPending == true)
            {
                listBox1.DataSource = order.SelectOrderWaitting();
            }
            else if (isPending == false)
            {
                listBox1.DataSource = order.SelectOrderDele();
            }
            else
            {
               List<usp_SelectRequested_Result> req = order.SelectRequested();
                for (int i=0; i< req.Count;i++)
                {
                    listBox1.Items.Add(req[i].ID);
                }
            }
                
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        { try
            {
                TextBox txt_orderNo = this.Owner.Controls.Find("txt_orderNo", true).First() as TextBox;
                txt_orderNo.Text = listBox1.SelectedItem.ToString();

                TextBox txt_bar = this.Owner.Controls.Find("txt_bar", true).First() as TextBox;
                txt_bar.Focus();
                this.Close();
            }
            catch
            { }
        }
    }
}
