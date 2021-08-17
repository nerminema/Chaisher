using Chaisher.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chaisher
{
    public partial class Payment : Form
    {
        int? _orderid;
        Classes.RequestedOrderClass order = new Classes.RequestedOrderClass();
        public Payment(  )
        {
            InitializeComponent();
        
            List<usp_SelectRequested_Result> req = order.SelectRequested();
            for (int i = 0; i < req.Count; i++)
            {
                comboBox1.Items.Add(req[i].ID);
            }
            comboBox2.DataSource =  c.SelectAllClients();
            comboBox2.DisplayMember = "ClientName";
            comboBox2.ValueMember = "ID";
            comboBox2.SelectedIndex = -1;


        }
        public Payment(int orderid )
        {
            InitializeComponent();
            _orderid = orderid;
            List<usp_SelectRequested_Result> req = order.SelectRequested();
            for (int i = 0; i < req.Count; i++)
            {
                comboBox1.Items.Add(req[i].ID);
            }
            comboBox1.Text = orderid.ToString();
            comboBox2.DataSource = c.SelectAllClients();
            comboBox2.DisplayMember = "ClientName";
            comboBox2.ValueMember = "ID";
           


        }
        CPrinting.PrintedDocument PD = new CPrinting.PrintedDocument();
        Classes.ReqestedORderDetails details = new ReqestedORderDetails();
        private void button1_Click(object sender, EventArgs e)
        {
        try{ 
                order.UpdateOrder(int.Parse(comboBox1.Text), decimal.Parse(txt_Paid.Text), true, "", -1 * decimal.Parse(txt_Rem.Text), int.Parse(comboBox2.SelectedValue.ToString()));
                if (txt_Rem.Text != "0")
                    MessageBox.Show("تم إضافة المديونية");
                else
                    MessageBox.Show("تم تصفية المديونية");
                DataGridView dataGridView1 = this.Owner.Controls.Find("dataGridView1", true).First() as DataGridView;
                dataGridView1.DataSource = order.SelectRequestedRwem();
                this.Close();

            }
            catch
            {

            }
        }
        PrintDocument pdoc;
        public void print()
        {
            PrintDialog pd = new PrintDialog();
            pdoc = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            Font font = new Font("Times New Roman", 15);


            PaperSize psize = new PaperSize("Custom", 100, 200);
            //ps.DefaultPageSettings.PaperSize = psize;

            pd.Document = pdoc;
            pd.Document.DefaultPageSettings.PaperSize = psize;
            //pdoc.DefaultPageSettings.PaperSize.Height =320;
            pdoc.DefaultPageSettings.PaperSize.Height = 820;

            pdoc.DefaultPageSettings.PaperSize.Width = 520;

         //   pdoc.PrintPage += new PrintPageEventHandler(pdoc_PrintPage);


            PrintPreviewDialog pp = new PrintPreviewDialog();
            pp.Document = pdoc;
            //;
            
                pdoc.Print();
            


        }
        string source ="";
        UserClass user = new UserClass();
        RequestedOrderClass requested = new RequestedOrderClass();
 //       void pdoc_PrintPage(object sender, PrintPageEventArgs e)
 //       {
 //           Graphics graphics = e.Graphics;
 //           Font font = new Font("Times New Roman", 10);
 //           float fontHeight = font.GetHeight();
 //           int startX = 50;
 //           int startY = 55;
 //           int Offset = 40;
 //           Image img = Image.FromFile("logo.jpg");
            
 //           graphics.DrawImage(img, new Point(startX, startY));
 //           Offset = Offset + 20;
 //           Offset = Offset + 20;
 //           string title = "اهلا بك في جزارة عمران";
 //           //graphics.DrawString("اهلا بك في جزارة عمران", new Font("Times New Roman", 12),
 //           //                    new SolidBrush(Color.Black), startX+ title.Length, startY + Offset);
           
 //           e.Graphics.DrawString(title, new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(180, Offset));
 //           Offset = Offset + 20;
 //           title = "رقم الطلب :" + _orderid.ToString();
 //           e.Graphics.DrawString(title, new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(180, Offset));

 //           //graphics.DrawString("رقم الطلب :" + _orderid.ToString(),
 //           //         new Font("Times New Roman", 12),

 //           //         new SolidBrush(Color.Black), startX+title.Length, startY + Offset);
 //           Offset = Offset + 20;
 //           //String Source = this.source;
 //           //// Header 
 //           e.Graphics.DrawLine(new Pen(Color.Black, 3), 20, Offset+60, 300, Offset+60);
 //           Offset = Offset + 70;
 //           e.Graphics.DrawString("ملاحظات", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(10, Offset));
 //           e.Graphics.DrawString("السعر", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(80, Offset));
 //           e.Graphics.DrawString("الكمية", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(120, Offset));
 //           e.Graphics.DrawString("اسم الصنف", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(180, Offset));
 //            Offset = Offset + 20;
 //           e.Graphics.DrawLine(new Pen(Color.Black, 3), 20, Offset , 300, Offset);
 //Offset = Offset + 20;
         


          

 //           List<usp_SelectRequestedORderByORderID_Result> orders = details.SelectRequestedORderByOrderId(_orderid);
 //           for (int i = 0; i < orders.Count; i++)
 //           {
 //               e.Graphics.DrawString(orders[i].Notes , new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(10, Offset));
 //               e.Graphics.DrawString(Math.Round((double)orders[i].Price, 2).ToString(), new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(80, Offset));
 //               e.Graphics.DrawString(orders[i].Qunatity.ToString(), new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(120, Offset));
 //               e.Graphics.DrawString(orders[i].ProductName, new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(180, Offset));

 //               //graphics.DrawString(+ "\t" +  + "\t" +  + "\t\t\t" + + "\t", new Font("Times New Roman", 10),
 //               //    new SolidBrush(Color.Black), startX,  Offset);
 //               Offset = Offset + 20;
 //           }




 //           String Grosstotal =  this.txt_Total.Text + "\t\t" + " المبلغ المطلوب  " ;

 //           //Offset = Offset + 20;
 //           e.Graphics.DrawLine(new Pen(Color.Black, 3), 20, Offset, 300, Offset);
 //           //e.Graphics.DrawLine(new Pen(Color.Blue, 3), 60, Offset, 200, Offset);
 //           Offset = Offset + 20;
 //           e.Graphics.DrawString(Grosstotal, new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(10, Offset));

           
 //           Offset = Offset + 20;
 //           e.Graphics.DrawString(txt_Paid.Text + "\t\t" + "المبلغ المدفوع  ", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(10, Offset));


           
 //           Offset = Offset + 20;
 //           e.Graphics.DrawString(txt_Rem.Text + "\t\t" + "المبلغ المتبقي  ", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(10, Offset));


        
 //           Offset = Offset + 20;
 //           string cashierName = user.SelectUsers((int)requested.SelectRequestedOrderByID(_orderid)[0].UserID)[0].Username;
 //           e.Graphics.DrawString(cashierName + "\t\t" + "الكاشير  ", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(10, Offset));



 //           Offset = Offset + 20;

 //           //String DrawnBy = this.drawnBy;
 //           //graphics.DrawString("Conductor - " + DrawnBy, new Font("Times New Roman", 10),
 //           //         new SolidBrush(Color.Black), startX, startY + Offset);

 //       }
        private void txt_Paid_Leave(object sender, EventArgs e)
        {
        if(txt_Paid.Text!="")
            txt_Rem.Text = (- decimal.Parse(txt_Total.Text) + decimal.Parse(txt_Paid.Text)).ToString();
        }

        private void txt_Paid_TextChanged(object sender, EventArgs e)
        {
            if (txt_Paid.Text != "")
                txt_Rem.Text = (-decimal.Parse(txt_Total.Text) + decimal.Parse(txt_Paid.Text)).ToString();

        }
        ClientsClass c = new ClientsClass();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int orderId = int.Parse(comboBox1.Text);
                List<usp_SelectRequestedOrderByID_Result> details = order.SelectRequestedOrderByID(orderId);
                if (details[0].ClientID != null)
                    comboBox2.SelectedValue = (int)details[0].ClientID;
                if (_orderid == null)
                    // txt_clientName.Text =c.SelectAllClients((int) details[0].ClientID)[0].ClientName;
                    txt_Total.Text = details[0].Total.ToString();
                else
                {
                    txt_Total.Text = ((decimal)details[0].Total + (decimal)details[0].Rem).ToString();
                    
                    txt_Rem.Text = details[0].Rem.ToString();
                    txt_Paid.Text = details[0].Total.ToString();
                }

            }
            catch
            {

            }
        }
    }
}
