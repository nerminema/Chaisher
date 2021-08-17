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
    public partial class SuppliersByDay : Form
    {
        Classes.SuppliersClass suppliers = new Classes.SuppliersClass();
        public SuppliersByDay()
        {
            InitializeComponent();
            cmb_supplier.DataSource = suppliers.SelectAll();
            cmb_supplier.DisplayMember = "SupplierName";
            cmb_supplier.ValueMember = "ID";
            cmb_supplier.SelectedIndex = -1;
            DayOfWeek day = DateTime.Now.DayOfWeek;
            DatesAndDays(day);
          

        }

        private void DatesAndDays(DayOfWeek day)
        {
            if (day == System.DayOfWeek.Monday)
            {
                txt_mon.BackColor = Color.Green;
                txt_mon.ForeColor = Color.White;
                txt_mon.Text += " " + DateTime.Now.ToShortDateString();
                txt_sun.Text += " " + DateTime.Now.AddDays(-1).ToShortDateString();
                txt_sat.Text += " " + DateTime.Now.AddDays(-2).ToShortDateString();
                txt_tus.Text += " " + DateTime.Now.AddDays(1).ToShortDateString();
                txt_wed.Text += " " + DateTime.Now.AddDays(2).ToShortDateString();
                txt_thur.Text += " " + DateTime.Now.AddDays(3).ToShortDateString();
                txt_fri.Text += " " + DateTime.Now.AddDays(4).ToShortDateString();
                lbl_start.Text = DateTime.Now.AddDays(-2).ToShortDateString();
                lbl_end.Text = DateTime.Now.AddDays(4).ToShortDateString();
            }
            else if (day == System.DayOfWeek.Tuesday)
            {
                txt_tus.BackColor = Color.Green;
                txt_tus.ForeColor = Color.White;
                lbl_start.Text = DateTime.Now.AddDays(-3).ToShortDateString();
                lbl_end.Text = DateTime.Now.AddDays(3).ToShortDateString();
                txt_mon.Text += " " + DateTime.Now.AddDays(-1).ToShortDateString();
                txt_sun.Text += " " + DateTime.Now.AddDays(-2).ToShortDateString();
                txt_sat.Text += " " + DateTime.Now.AddDays(-3).ToShortDateString();
                txt_tus.Text += " " + DateTime.Now.ToShortDateString();
                txt_wed.Text += " " + DateTime.Now.AddDays(1).ToShortDateString();
                txt_thur.Text += " " + DateTime.Now.AddDays(2).ToShortDateString();
                txt_fri.Text += " " + DateTime.Now.AddDays(3).ToShortDateString();

            }
            else if (day == System.DayOfWeek.Wednesday)
            {
                txt_mon.BackColor = Color.Green;
                txt_mon.ForeColor = Color.White;
                lbl_start.Text = DateTime.Now.AddDays(-4).ToShortDateString();
                lbl_end.Text = DateTime.Now.AddDays(2).ToShortDateString();

                txt_mon.Text += " " + DateTime.Now.AddDays(-2).ToShortDateString();
                txt_sun.Text += " " + DateTime.Now.AddDays(-3).ToShortDateString();
                txt_sat.Text += " " + DateTime.Now.AddDays(-4).ToShortDateString();
                txt_tus.Text += " " + DateTime.Now.AddDays(-1).ToShortDateString();
                txt_wed.Text += " " + DateTime.Now.ToShortDateString();
                txt_thur.Text += " " + DateTime.Now.AddDays(1).ToShortDateString();
                txt_fri.Text += " " + DateTime.Now.AddDays(2).ToShortDateString();

            }
            else if (day == System.DayOfWeek.Thursday)
            {
                txt_thur.BackColor = Color.Green;
                txt_thur.ForeColor = Color.White;
                lbl_start.Text = DateTime.Now.AddDays(-5).ToShortDateString();
                lbl_end.Text = DateTime.Now.AddDays(1).ToShortDateString();
                txt_mon.Text += " " + DateTime.Now.AddDays(-3).ToShortDateString();
                txt_sun.Text += " " + DateTime.Now.AddDays(-4).ToShortDateString();
                txt_sat.Text += " " + DateTime.Now.AddDays(-5).ToShortDateString();
                txt_tus.Text += " " + DateTime.Now.AddDays(-2).ToShortDateString();
                txt_wed.Text += " " + DateTime.Now.AddDays(-1).ToShortDateString();
                txt_thur.Text += " " + DateTime.Now.ToShortDateString();
                txt_fri.Text += " " + DateTime.Now.AddDays(1).ToShortDateString();

            }
            else if (day == System.DayOfWeek.Friday)
            {
                txt_fri.BackColor = Color.Green;
                txt_fri.ForeColor = Color.White;
                lbl_start.Text = DateTime.Now.AddDays(-6).ToShortDateString();
                lbl_end.Text = DateTime.Now.ToShortDateString();
                txt_mon.Text += " " + DateTime.Now.AddDays(-4).ToShortDateString();
                txt_sun.Text += " " + DateTime.Now.AddDays(-5).ToShortDateString();
                txt_sat.Text += " " + DateTime.Now.AddDays(-6).ToShortDateString();
                txt_tus.Text += " " + DateTime.Now.AddDays(-3).ToShortDateString();
                txt_wed.Text += " " + DateTime.Now.AddDays(-2).ToShortDateString();
                txt_thur.Text += " " + DateTime.Now.AddDays(-1).ToShortDateString();
                txt_fri.Text += " " + DateTime.Now.ToShortDateString();

            }
            else if (day == System.DayOfWeek.Saturday)
            {
                txt_sat.BackColor = Color.Green;
                txt_sat.ForeColor = Color.White;
                lbl_start.Text = DateTime.Now.ToShortDateString();
                lbl_end.Text = DateTime.Now.AddDays(6).ToShortDateString();
                txt_mon.Text += " " + DateTime.Now.AddDays(2).ToShortDateString();
                txt_sun.Text += " " + DateTime.Now.AddDays(1).ToShortDateString();
                txt_sat.Text += " " + DateTime.Now.ToShortDateString();
                txt_tus.Text += " " + DateTime.Now.AddDays(3).ToShortDateString();
                txt_wed.Text += " " + DateTime.Now.AddDays(4).ToShortDateString();
                txt_thur.Text += " " + DateTime.Now.AddDays(5).ToShortDateString();
                txt_fri.Text += " " + DateTime.Now.AddDays(6).ToShortDateString();

            }
            else if (day == System.DayOfWeek.Sunday)
            {
                txt_sun.BackColor = Color.Green;
                txt_sun.ForeColor = Color.White;
                lbl_start.Text = DateTime.Now.AddDays(-1).ToShortDateString();
                lbl_end.Text = DateTime.Now.AddDays(5).ToShortDateString();
                txt_mon.Text += " " + DateTime.Now.AddDays(1).ToShortDateString();
                txt_sun.Text += " " + DateTime.Now.ToShortDateString();
                txt_sat.Text += " " + DateTime.Now.AddDays(-1).ToShortDateString();
                txt_tus.Text += " " + DateTime.Now.AddDays(2).ToShortDateString();
                txt_wed.Text += " " + DateTime.Now.AddDays(3).ToShortDateString();
                txt_thur.Text += " " + DateTime.Now.AddDays(4).ToShortDateString();
                txt_fri.Text += " " + DateTime.Now.AddDays(5).ToShortDateString();

            }
        }

        private void cmb_supplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
             panel2.Controls.Clear();
                List<usp_SelectPOORder_Result> poDetails = po.SelectBySubAndDate(int.Parse(cmb_supplier.SelectedValue.ToString()), Convert.ToDateTime(lbl_start.Text));
                if (poDetails.Count != 0)
                {
                    lbl_Total.Text = poDetails[0].Total.ToString();
                    btn_Login.Tag = poDetails[0].ID;
                }
                else
                {
                    po.Insert(int.Parse(cmb_supplier.SelectedValue.ToString()), DateTime.Parse(lbl_start.Text), 0, false);
                     poDetails = po.SelectBySubAndDate(int.Parse(cmb_supplier.SelectedValue.ToString()), Convert.ToDateTime(lbl_start.Text));
                    if (poDetails.Count != 0)
                    {
                        lbl_Total.Text = poDetails[0].Total.ToString();
                        btn_Login.Tag = poDetails[0].ID;
                    }
                }
                List<usp_selectSupplierProduct_Result> data = suppliers.SelectAllSid(int.Parse(cmb_supplier.SelectedValue.ToString()));
             
             for (int i = 0; i < data.Count; i++)
                {
                    GroupBox p = new GroupBox();
                    p.Dock = DockStyle.Right;
                    p.Size = new Size(170, 353);
                    p.Tag = data[i].ID;
                    p.Text = data[i].ProductName;
                    p.Name = "pnl_" + i.ToString();
                    panel2.Controls.Add(p);
                    Label l = new Label();
                    l.Text = "الكمية";
                    l.Location = new Point(-30, 30);
                    p.Controls.Add(l);
                    Label l2 = new Label();
                    l2.Text = "السعر";
                    l2.Location = new Point(50, 30);
                    p.Controls.Add(l2);
                    //p.BorderStyle
                    for (int j=0; j<8;j++)
                    {
                       
                        TextBox txt = new TextBox();
                        // txt.Dock = DockStyle.Top;
                        txt.Name = "txt_p_i_" + i.ToString() +"_j_"+ j.ToString();
                        txt.Leave += Txt_TextChanged;
                        txt.Location = new Point(3,60+(30*j)); 
                       txt.Margin = new Padding(5);
                        txt.Tag = data[i].Price;
                       txt.Size = new Size(80, 27);
                      
                        if(j== 7)
                        {
                            txt.BackColor = Color.Orange;
                            txt.ForeColor = Color.White;
                            //txt.Enabled = false;
                            txt.Name = "txt_p_i_" + i.ToString() + "_j_"+ j.ToString()+"count";
                            List<usp_SelectTotalqntyandPrice_Result> totals = details.SelectAllByPOID(int.Parse(p.Tag.ToString()), DateTime.Parse(lbl_start.Text), DateTime.Parse(lbl_end.Text));
                            txt.Text = totals[0].qnty.ToString();
                            //totalPrice.Text = totals[0].price_.ToString();
                        }
                        //if (j == 8)
                        //{
                        //    txt.BackColor = Color.Green;
                        //    txt.ForeColor = Color.White;
                        //   // txt.Enabled = false;
                        //    txt.Name = "txt_p_i_" + i.ToString() + "_j_"+ j.ToString() + "total";
                        //}
                        List<usp_SelectAllPODetailsByPOID_Result> all = details.SelectAllByPOID(int.Parse(btn_Login.Tag.ToString()), data[i].ID, DateTime.Parse(lbl_start.Text).AddDays(j));

                        if (all.Count != 0)
                        {
                            txt.Text = all[0].qnty.ToString();
                        }
                       
                        p.Controls.Add(txt);
                    }

                    for (int j = 0; j < 8; j++)
                    {
                        TextBox txt = new TextBox();
                        // txt.Dock = DockStyle.Top;
                       
                        txt.Name = "txt_price_p_i_" + i.ToString() + "_j_" + j.ToString();
                       // txt.Leave += Txt_TextChanged;
                        txt.Location = new Point(86, 60 + (30 * j));
                        txt.Margin = new Padding(5);
                        txt.Tag = data[i].Price;
                        txt.Size = new Size(80, 27);
                        List<usp_SelectAllPODetailsByPOID_Result> all = details.SelectAllByPOID(int.Parse(btn_Login.Tag.ToString()), data[i].ID, DateTime.Parse(lbl_start.Text).AddDays(j));
                        if (j == 7)
                        {
                            txt.BackColor = Color.Green;
                            txt.ForeColor = Color.White;
                            //txt.Enabled = false;
                            txt.Name = "txt_p_i_" + i.ToString() + "_j_" + j.ToString() + "total";
                            List<usp_SelectTotalqntyandPrice_Result> totals = details.SelectAllByPOID(int.Parse(p.Tag.ToString()), DateTime.Parse(lbl_start.Text), DateTime.Parse(lbl_end.Text));
                            txt.Text = totals[0].price_.ToString();
                            //totalPrice.Text = totals[0].price_.ToString();
                        }
                        if (all.Count != 0)
                        {
                            txt.Text = all[0].price.ToString();
                        }
                        p.Controls.Add(txt);
                    }
                }
            
            
            }
            catch
            { }
        }
        
        private void Txt_TextChanged(object sender, EventArgs e)
        { 
        
        TextBox txt = (TextBox)sender;
        
            if (txt.Text != "")
            {
                decimal price = decimal.Parse(txt.Tag.ToString());
                string[] name = txt.Name.Split('_');
                int day =int.Parse( name[5]);
                GroupBox p = panel2.Controls.Find("pnl_" + name[3], true).First() as GroupBox;
                int index = txt.Name.LastIndexOf('_');
                int start = txt.Name.IndexOf('_');
                DateTime startDate = DateTime.Parse(lbl_start.Text);
                string priceName = "txt_price" + txt.Name.Substring(start);
                TextBox txtPrice = p.Controls.Find(priceName, true).First() as TextBox;
                TextBox totalcount = p.Controls.Find(txt.Name.Substring(0, index + 1) + "7" + "count", true).First() as TextBox;
                TextBox totalPrice = p.Controls.Find(txt.Name.Substring(0, index + 1) + "7" + "total", true).First() as TextBox;
            
               //if (totalcount.Text == "")
                //{
                //    if (txtPrice.Text == "")
                //    {
                //        totalcount.Text = txt.Text;
                //        totalPrice.Text = (decimal.Parse(txt.Text) * price).ToString("N2");
                //    }
                //    else
                //    {
                //        totalcount.Text = txt.Text;
                //        totalPrice.Text = (decimal.Parse(txt.Text) * decimal.Parse(txtPrice.Text)).ToString("N2");

                //    }
                //    //decimal.Parse(totalcount.Text) + decimal.Parse(txt.Text)
                //}
                //else
                //{
                //    if (txtPrice.Text == "")
                //    {
                //        totalcount.Text = (decimal.Parse(totalcount.Text) + decimal.Parse(txt.Text)).ToString();
                //        decimal total = decimal.Parse(totalcount.Text);
                //        totalPrice.Text = (total * price).ToString("N2");
                //    }
                //    else
                //    if (txtPrice.Text != "")
                //    {
                //        totalcount.Text = (decimal.Parse(totalcount.Text) + decimal.Parse(txt.Text)).ToString();
                //        decimal total = decimal.Parse(totalcount.Text);
                //        totalPrice.Text = (total * decimal.Parse(txtPrice.Text)).ToString("N2");
                //    }

                //}
                if (txtPrice.Text != "")
                {
                    List<usp_SelectAllPODetailsByPOID_Result> all = details.SelectAllByPOID(int.Parse(btn_Login.Tag.ToString()), int.Parse(p.Tag.ToString()), DateTime.Parse(lbl_start.Text).AddDays(day));

                    if (all.Count == 0)
                    {

                        details.Insert(int.Parse(btn_Login.Tag.ToString()), int.Parse(p.Tag.ToString()), decimal.Parse(txt.Text), decimal.Parse(txtPrice.Text), startDate.AddDays(day));
                      //  po.UpdateTotal(int.Parse(btn_Login.Tag.ToString()), decimal.Parse(txtPrice.Text) * decimal.Parse(txt.Text));
                    }
                    else 
                    {
                       // po.SubTotal(int.Parse(btn_Login.Tag.ToString()), ((decimal)all[0].price *(decimal) all[0].qnty));
                        details.Delete(all[0].ID);
                        details.Insert(int.Parse(btn_Login.Tag.ToString()), int.Parse(p.Tag.ToString()), decimal.Parse(txt.Text), decimal.Parse(txtPrice.Text), startDate.AddDays(day));
                       // po.UpdateTotal(int.Parse(btn_Login.Tag.ToString()), decimal.Parse(txtPrice.Text) * decimal.Parse(txt.Text));

                    }
                }
               else if (txtPrice.Text == "")
                {
                    details.Insert(int.Parse(btn_Login.Tag.ToString()), int.Parse(p.Tag.ToString()), decimal.Parse(txt.Text), price, startDate.AddDays(day));
                    //po.UpdateTotal(int.Parse(btn_Login.Tag.ToString()), price * decimal.Parse(txt.Text));

                }
                List<usp_SelectPOORder_Result> poDetails = po.SelectBySubAndDate(int.Parse(cmb_supplier.SelectedValue.ToString()), Convert.ToDateTime(lbl_start.Text));

                lbl_Total.Text = poDetails[0].Total.ToString();
                List<usp_SelectTotalqntyandPrice_Result> totals = details.SelectAllByPOID(int.Parse(p.Tag.ToString()), DateTime.Parse(lbl_start.Text), DateTime.Parse(lbl_end.Text));
                totalcount.Text = totals[0].qnty.ToString();
                totalPrice.Text = totals[0].price_.ToString();

            }
            // throw new NotImplementedException();
        }
        Classes.POClass po = new Classes.POClass();
        Classes.PODetailsClass details = new Classes.PODetailsClass();

        private void btn_Login_Click(object sender, EventArgs e)
        {
           // int? poID = po.Insert(int.Parse(cmb_supplier.SelectedValue.ToString()), dt_orderDate.Value.Date, decimal.Parse(lbl_total.Text), false);

        }
    }
}
