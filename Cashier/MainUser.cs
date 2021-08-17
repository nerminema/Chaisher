using Chaisher.Classes;
using Microsoft.TeamFoundation.Common.Internal;
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
    public partial class MainUser : Form
    {
        Classes.CategoryClass cat = new Classes.CategoryClass();

        Classes.ReqestedORderDetails details = new ReqestedORderDetails();
        Classes.RequestedOrderClass requested = new Classes.RequestedOrderClass();
        public MainUser()
        {
            InitializeComponent();
            try
            {
                dg_order.AutoGenerateColumns = false;
                //dg_order.DataSource = details.SelectRequestedORderByOrderId(int.Parse(lbl_orderNo.Text));
                //txt_OrderTotal.Text = ((decimal)details.SelectTotalOrder(int.Parse(lbl_orderNo.Text))).ToString("N2");
                //lbl_Total.Text = Math.Round(decimal.Parse(txt_OrderTotal.Text), 0).ToString();
                List<usp_SelectAllCategory_Result> all = cat.SelectAllCategory();
                for (int i = 0; i < all.Count; i++)
                {
                    RoundButton btn = new RoundButton();
                    //btn.Dock = DockStyle.Top;
                    btn.Padding = new Padding(5);

                    btn.Text = all[i].CategoryName;
                    btn.Tag = all[i].ID;
                    btn.BackColor = Color.FromArgb(int.Parse(all[i].Color.Trim()));

                    if (all[i].ForeColor != null)
                        btn.ForeColor = Color.FromArgb(int.Parse(all[i].ForeColor));
                    // btn.Size = new Size(150, 70);
                    //btn.Dock = DockStyle.Top;
                    btn.Margin = new Padding(5, 10, 5, 10);
                    btn.TextAlign = ContentAlignment.MiddleCenter;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderColor = Color.LightGray;
                    btn.FlatAppearance.BorderSize = 5;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Location = new Point(0, (i * 105) + 5);
                    btn.Dock = DockStyle.Top;
                    pnl_cat.Controls.Add(btn);

                    btn.Click += Btn_Click;
                }
            }
            catch
            {

            }
        }
        Classes.ProductClass prod = new Classes.ProductClass();
        private void Btn_Click(object sender, EventArgs e)
        {
            pnl_Product.Controls.Clear();
            Button btnCat = (Button)sender;
            List<usp_SelectProductByCatID_Result> allProduct = prod.SelectProductByCatID(int.Parse(btnCat.Tag.ToString()));
          int count =  allProduct.Count;
            int pnl_count = count / 10;
            if (pnl_count == 0)
            {
                Panel p = new Panel();
                p.Width = 200;
                p.Dock = DockStyle.Left;
                //p.Anchor = AnchorStyles.Left;
                p.Location = new Point(0, 0);
                //p.BackColor = Color.Red;

                for (int i = 0; i < allProduct.Count; i++)
                {
                    RoundButton btn = new RoundButton();
                    int productCount = pnl_Product.Controls.Count;
                    int noOfCol = 0;
                    if (productCount > 8)
                        noOfCol = productCount % 8;

                    btn.Dock = DockStyle.Top;
                    btn.Padding = new Padding(5);

                    btn.Text = allProduct[i].ProductName;
                    btn.Tag = allProduct[i].ID;
                    btn.BackColor = btnCat.BackColor;
                    // b.BackColor = Color.FromArgb(int.Parse(pro[i].Color.Trim()));
                    //if (allProduct[i].ForeColor != null)
                    btn.ForeColor = btnCat.ForeColor;
                    //btn.Size = new Size(pnl_cat.Width + (pnl_cat.Width * noOfCol), 100);
                    btn.TextAlign = ContentAlignment.MiddleCenter;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Location = new Point(0, (i * 105) + 5);
                    btn.Dock = DockStyle.Top;
                    p.Controls.Add(btn);
                    btn.Click += Btn_Click1;
                    
                  
                   

                }
               pnl_Product.Controls.Add(p);
            }
            else
            {
               
                int countItem = 0;
                for (int j=0; j< count / 10; j++)
                {
                    Panel p = new Panel();
                    p.Width = 150;
                    p.Dock = DockStyle.Left;
               
                 for (int i = 0; i < 10; i++)
                {
                    RoundButton btn = new RoundButton();
                    int productCount = pnl_Product.Controls.Count;
                    int noOfCol = 0;
                    if (productCount > 8)
                        noOfCol = productCount % 8;

                    btn.Dock = DockStyle.Top;
                    btn.Padding = new Padding(5);

                    btn.Text = allProduct[countItem].ProductName;
                    btn.Tag = allProduct[countItem].ID;
                    btn.BackColor = btnCat.BackColor;
                    // b.BackColor = Color.FromArgb(int.Parse(pro[i].Color.Trim()));
                    //if (allProduct[i].ForeColor != null)
                    btn.ForeColor = btnCat.ForeColor;
                    btn.Size = new Size(pnl_cat.Width + (pnl_cat.Width * noOfCol), 100);
                    btn.TextAlign = ContentAlignment.MiddleCenter;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Location = new Point(0, (i * 105) + 5);
                    btn.Click += Btn_Click1;
                    p.Controls.Add(btn);
                        countItem++;

                }
                    pnl_Product.Controls.Add(p);
                }
                if (count % 10 != 0)
                {
                    Panel p = new Panel();
                    p.Width = 150;
                    p.Dock = DockStyle.Left;
                    for (int i = count - (count % 10); i < count  ; i++)
                    {
                        RoundButton btn = new RoundButton();
                        int productCount = pnl_Product.Controls.Count;
                        int noOfCol = 0;
                        if (productCount > 8)
                            noOfCol = productCount % 8;

                        btn.Dock = DockStyle.Top;
                        btn.Padding = new Padding(5);

                        btn.Text = allProduct[i].ProductName;
                        btn.Tag = allProduct[i].ID;
                        btn.BackColor = btnCat.BackColor;
                        // b.BackColor = Color.FromArgb(int.Parse(pro[i].Color.Trim()));
                        //if (allProduct[i].ForeColor != null)
                        btn.ForeColor = btnCat.ForeColor;
                        btn.Size = new Size(pnl_cat.Width + (pnl_cat.Width * noOfCol), 100);
                        btn.TextAlign = ContentAlignment.MiddleCenter;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderSize = 0;
                        btn.Location = new Point(0, (i * 105) + 5);
                        btn.Click += Btn_Click1;
                        p.Controls.Add(btn);
                        countItem++;

                    }
                    pnl_Product.Controls.Add(p);
                }

            }
        }

        private void Btn_Click1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int ProdID = int.Parse(btn.Tag.ToString());
            ProductCount count = new ProductCount(ProdID );
            count.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = System.Diagnostics.Process.Start("calc.exe");
            p.WaitForInputIdle();
            NativeMethods.SetParent(p.MainWindowHandle, this.Handle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            ProductCount p = new ProductCount( false ,6);
            p.Show(this);
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            ProductCount p = new ProductCount( true ,7);
            p.Show(this);
        }
    }
}
