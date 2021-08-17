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

namespace Chaisher.Cashier
{
    public partial class ProductCount : Form
    {
        Classes.ProductClass product = new Classes.ProductClass();
        int _prod;
        public ProductCount( int productID )
        {
            InitializeComponent();
            List<usp_SelectProductByID_Result> all =product.SelectProductByID(productID);

            _prod = productID;
        }
        bool? _return = null; 
        public ProductCount(bool returnRec , int productID)
        {
            InitializeComponent();
            _return = returnRec;
            _prod = productID;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btn_Result.Text = textBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(textBox1.Text != "" )
            { textBox1.Text += btn.Text; }
            else
            {
                textBox1.Text += btn.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = btn_Result.Text = "";
        }
        Classes.ProductClass prod = new Classes.ProductClass();
        Classes.ReqestedORderDetails details = new ReqestedORderDetails();
        Classes.RequestedOrderClass requested = new Classes.RequestedOrderClass();

        private void button2_Click(object sender, EventArgs e)
        { Label lbl_orderNo = this.Owner.Controls.Find("lbl_orderNo", true).First() as Label;
                    TextBox txt_OrderTotal = this.Owner.Controls.Find("txt_OrderTotal", true).First() as TextBox;
            Label lbl_Total = this.Owner.Controls.Find("lbl_Total", true).First() as Label;
            DataGridView dg_order = this.Owner.Controls.Find("dg_order", true).First() as DataGridView;
                    int id = _prod;
            if (_return == null)
            {
               

                decimal productPRice = (decimal)prod.SelectProductByID(_prod)[0].Price;

                decimal qnty = decimal.Parse(textBox1.Text);
                if (lbl_orderNo.Text == "")
                {

                    lbl_orderNo.Text = requested.InsertRequestedOrder(DateTime.Now.Date, null, DateTime.Now.TimeOfDay, "", null, null).ToString();
                }

                details.InsertRequestedORderDetails(int.Parse(lbl_orderNo.Text), id, qnty, (decimal)prod.SelectProductByID(id)[0].Price, "");

                if (txt_OrderTotal.Text == "")
                    txt_OrderTotal.Text = "0";
                 this.Owner.Text = txt_OrderTotal.Text=lbl_Total.Text  = ((decimal)details.SelectTotalOrder(int.Parse(lbl_orderNo.Text))).ToString("N2");
               
                //(decimal.Parse(lbl_Total.Text) + (decimal)prod.SelectProductByID(id)[0].Price).ToString("N2");
                dg_order.AutoGenerateColumns = false;
                dg_order.DataSource = details.SelectRequestedORderByOrderId(int.Parse(lbl_orderNo.Text));
                this.Close();
            }
            else if (_return == false)
            {


                decimal productPRice = (decimal)prod.SelectProductByID(_prod)[0].Price;

                decimal qnty = decimal.Parse(textBox1.Text);
                if (lbl_orderNo.Text == "")
                {

                    lbl_orderNo.Text = requested.InsertRequestedOrder(DateTime.Now.Date, null, DateTime.Now.TimeOfDay, "", null, null).ToString();
                }
                decimal total = ((decimal)details.SelectTotalOrder(int.Parse(lbl_orderNo.Text)));
                decimal percent = decimal.Parse(textBox1.Text) * total / 100;
                details.InsertRequestedORderDetails(int.Parse(lbl_orderNo.Text), id, qnty, -1 * decimal.Parse(textBox1.Text), "");

                if (txt_OrderTotal.Text == "")
                    txt_OrderTotal.Text = "0";
                this.Owner.Text = lbl_Total.Text = txt_OrderTotal.Text = ((decimal)details.SelectTotalOrder(int.Parse(lbl_orderNo.Text))).ToString("N2");
                //(decimal.Parse(lbl_Total.Text) + (decimal)prod.SelectProductByID(id)[0].Price).ToString("N2");
                dg_order.AutoGenerateColumns = false;
                dg_order.DataSource = details.SelectRequestedORderByOrderId(int.Parse(lbl_orderNo.Text));
                this.Close();

            }
            else if (_return == true)
            {

                decimal productPRice = (decimal)prod.SelectProductByID(_prod)[0].Price;

                decimal qnty = decimal.Parse(textBox1.Text);
                if (lbl_orderNo.Text == "")
                {

                    lbl_orderNo.Text = requested.InsertRequestedOrder(DateTime.Now.Date, null, DateTime.Now.TimeOfDay, "", null, null).ToString();
                }
                decimal total = ((decimal)details.SelectTotalOrder(int.Parse(lbl_orderNo.Text)));
                decimal percent = decimal.Parse(textBox1.Text) * total / 100;
                details.InsertRequestedORderDetails(int.Parse(lbl_orderNo.Text), id, 1, -1 *percent , "");

                if (txt_OrderTotal.Text == "")
                    txt_OrderTotal.Text = "0";
                this.Owner.Text = lbl_Total.Text= txt_OrderTotal.Text = ((decimal)details.SelectTotalOrder(int.Parse(lbl_orderNo.Text))).ToString("N2");
                //(decimal.Parse(lbl_Total.Text) + (decimal)prod.SelectProductByID(id)[0].Price).ToString("N2");
                dg_order.AutoGenerateColumns = false;
                dg_order.DataSource = details.SelectRequestedORderByOrderId(int.Parse(lbl_orderNo.Text));
                this.Close();
            }
        }
    }
    }

