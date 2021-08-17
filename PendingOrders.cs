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
    public partial class PendingOrders : Form
    {
        bool? _isPending;
        public PendingOrders(  bool isPending )
        {
            InitializeComponent();
            _isPending = isPending;
            if (_isPending == false)
            {                 linkLabel2.Text = "إستعراض الطلبات الديليفري";
                this.Text = "طلبات الدليفري";
            }
            cmb_employee.DataSource = employee.SelectAllEmployee();
            cmb_employee.DisplayMember = "EmployeeName";
            cmb_employee.ValueMember = "ID";
            cmb_employee.SelectedIndex = -1;
        }
        public PendingOrders(string isPending)
        {
            InitializeComponent();
            _isPending = null;
            
                linkLabel2.Text = "استعراض الطلبات";
                this.Text = "حذف الطلب";
           
            cmb_employee.DataSource = employee.SelectAllEmployee();
            cmb_employee.DisplayMember = "EmployeeName";
            cmb_employee.ValueMember = "ID";
            cmb_employee.SelectedIndex = -1;
        }
        Classes.EmployeeClass employee = new Classes.EmployeeClass();
        private void btn_Login_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmployeeName emp = new EmployeeName();
            emp.Show(this);
        }

        private void txt_client_Leave(object sender, EventArgs e)
        {

        }
        Classes.RequestedOrderClass order = new Classes.RequestedOrderClass();
        Classes.ReqestedORderDetails details = new Classes.ReqestedORderDetails();
        Classes.ClientsClass Clients = new Classes.ClientsClass();
        private void txt_orderNo_Leave(object sender, EventArgs e)
        {
            if (txt_orderNo.Text != "")
            {

                List<usp_SelectRequestedOrderByID_Result> req = order.SelectRequestedOrderByID(int.Parse(txt_orderNo.Text));

                if (req.Count > 0)
                {
                    if (req[0].ClientID != null)
                    {
                        txt_client.Text = Clients.SelectAllClients((int)req[0].ClientID)[0].ClientName;
                        lbl_Total.Text =((decimal) req[0].Total).ToString("N2");
                        dt_orderDate.Value = (DateTime)req[0].OrderDate;
                        DateTime val = DateTime.Now.Add((TimeSpan)req[0].OrderTime);
                        txt_Notes.Text = req[0].Notes;
                        dt_orderTime.Value = val;
                        dg_order.AutoGenerateColumns = false;
                        dg_order.DataSource = null;
                        dg_order.DataSource = details.SelectRequestedORderByOrderId(int.Parse(txt_orderNo.Text));
                        if (_isPending == false)
                        {
                            ch_Isdelevery.Checked = true;
                            cmb_employee.SelectedValue = (int)req[0].EmployeeID;
                            txt_rem.Text = req[0].Rem.ToString();
                            txt_DelFees.Text = expence.SelectExpenceByOrderID(int.Parse(txt_orderNo.Text))[0].ExpenceAmount.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("لا يوجد طلب  قيد الانتظار بهذا الرقم ");
                    }
                }
                else
                {
                    MessageBox.Show("لا يوجد طلب بهذا الرقم ");
                }
            }
        }

        private void txt_rem_Leave(object sender, EventArgs e)
        {
            lbl_Total.Text = ((decimal)req[0].Total + decimal.Parse(txt_DelFees.Text) + decimal.Parse(txt_rem.Text)).ToString();
        }
        Classes.ExpenceClass expence = new Classes.ExpenceClass();
        private void btn_Login_Click_1(object sender, EventArgs e)
        {
            if (_isPending == true)
            {
                if (cmb_employee.SelectedValue != null)
                {
                    //expence.InsertExpence(decimal.Parse(txt_DelFees.Text), "مصاريف توصيل", int.Parse(cmb_employee.SelectedValue.ToString()), DateTime.Now, int.Parse(txt_orderNo.Text));
                    order.SetDelevery(int.Parse(txt_orderNo.Text), decimal.Parse(txt_rem.Text), int.Parse(cmb_employee.SelectedValue.ToString()));
                    print(); Clear();
                }
                else
                {
                    if (MessageBox.Show("سوف يتم تسليم هذا الطلب من المحل", "تنويه", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        order.UpdateOrder(int.Parse(txt_orderNo.Text), decimal.Parse(lbl_Total.Text) - decimal.Parse(txt_rem.Text), true, txt_Notes.Text , 0 , int.Parse(txt_client.Tag.ToString()));
                        print();
                        Clear();
                    }
                }
            }
            else if (_isPending == false)
            {
                order.UpdateOrder(int.Parse(txt_orderNo.Text), decimal.Parse(lbl_Total.Text) - decimal.Parse(txt_rem.Text), true, txt_Notes.Text, 0, int.Parse(txt_client.Tag.ToString()));
              //  print();
                Clear();
            }
            else
            {
                if (txt_orderNo.Text != "")
                {
                    if (MessageBox.Show("هل انت متاكد انك تريد الحذف", "تنوبيه", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)

                    {
                        expence.InsertExpence(decimal.Parse(lbl_Total.Text), "مرتجعات" , null , DateTime.Now ,int.Parse( txt_orderNo.Text));
                        order.DeleteRequestOrder(int.Parse(txt_orderNo.Text));

                        Clear();
                    }
                }
            }
           
        }

        private void Clear()
        {
            
            txt_client.Text = txt_Notes.Text = txt_orderNo.Text = "";
            txt_DelFees.Text = txt_rem.Text = "0";
            ch_Isdelevery.Checked = false;
            label5.Visible = cmb_employee.Visible = false;
            dg_order.DataSource = null;
        }

        PrintDocument pdoc;
        public void print()
        {
            PrintDialog pd = new PrintDialog();
            pdoc = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            Font font = new Font("Courier New", 15);


            PaperSize psize = new PaperSize("Custom", 100, 200);
            //ps.DefaultPageSettings.PaperSize = psize;

            pd.Document = pdoc;
            pd.Document.DefaultPageSettings.PaperSize = psize;
            //pdoc.DefaultPageSettings.PaperSize.Height =320;
            pdoc.DefaultPageSettings.PaperSize.Height = 820;

            pdoc.DefaultPageSettings.PaperSize.Width = 520;

            pdoc.PrintPage += new PrintPageEventHandler(pdoc_PrintPage);

            pdoc.Print();



        }
        string source = "";
        void pdoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Times New Roman", 10);
            float fontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int Offset = 40;

            e.Graphics.DrawLine(new Pen(Color.Black, 3), 20, 5, 300, 5);
            Offset = Offset + 20;
            string title = "اهلا بك في جزارة عمران";
            graphics.DrawString("اهلا بك في جزارة عمران", new Font("Times New Roman", 12),
                                new SolidBrush(Color.Black), startX + title.Length + 100, Offset - 40);
            graphics.DrawString("رقم الطلب :" + txt_orderNo.Text.ToString(),
 new Font("Times New Roman", 12),
 new SolidBrush(Color.Black), startX + title.Length + 140, Offset - 20);
            //Offset = Offset + 20;


            Image img = Image.FromFile("logo.jpg");
            graphics.DrawImage(img, new Point(startX, startY));
            Offset = Offset + 20;
            Offset = Offset + 20;
            e.Graphics.DrawLine(new Pen(Color.Black, 3), 20, Offset, 300, Offset);



            title = "رقم الطلب :";

            if (txt_client.Text != "عميل محل")
            {
                int id = int.Parse(txt_client.Tag.ToString());
                List<usp_SelectAllClientsByID_Result> clientData = Clients.SelectAllClients(id);
                graphics.DrawString("اسم العميل: " + clientData[0].ClientName, new Font("Times New Roman", 12),
                               new SolidBrush(Color.Black), startX + title.Length + 110, Offset);
                Offset = Offset + 20;
                try
                {
                    string str = clientData[0].ClientAddress;
                    int start = 0;
                    int end = 30;
                    string part3 = ""; string part4 = "";
                    string part2 = "";
                    string part1 = "";
                    if (str.Length < 30)
                        part1 = str.Substring(0, str.Length);
                    else
                        part1 = str.Substring(0, end);
                    if (str.Length > 30 && str.Length > 70)
                    {
                        part2 = str.Substring(30, 40);
                    }
                    else
                        part2 = str.Substring(30, str.Length - 40); ;
                    if (str.Length > 70 && str.Length > 110)
                        part3 = str.Substring(70, 40);
                    else
                        part3 = str.Substring(60, str.Length - 70);
                    if (str.Length > 110)
                        part4 = str.Substring(90, str.Length - 110);

                    //string part4 = str.Substring((3 * str.Length / 4), str.Length);
                    graphics.DrawString("عنوان العميل " + part1, new Font("Times New Roman", 12, FontStyle.Bold),
                                new SolidBrush(Color.Black), startX, startY + Offset);
                    Offset = Offset + 20;
                    graphics.DrawString(part2, new Font("Times New Roman", 12, FontStyle.Bold),
                               new SolidBrush(Color.Black), startX, startY + Offset);
                    Offset = Offset + 20;
                    if (part3 != "")
                        graphics.DrawString(part3, new Font("Times New Roman", 12, FontStyle.Bold),
                                 new SolidBrush(Color.Black), startX, startY + Offset);
                    Offset = Offset + 20;
                    if (part4 != "")
                        graphics.DrawString(part4, new Font("Times New Roman", 12, FontStyle.Bold),
                       new SolidBrush(Color.Black), startX, startY + Offset);
                    Offset = Offset + 20;
                }
                catch (Exception ex)
                {
                }

                graphics.DrawString(" : تليفون العميل " + clientData[0].ClientPhone, new Font("Times New Roman", 12),
                            new SolidBrush(Color.Black), startX + title.Length + 70, Offset);
                Offset = Offset + 20;
            }
            //String Source = this.source;
            //// Header 
            e.Graphics.DrawLine(new Pen(Color.Black, 3), 20, Offset + 60, 300, Offset + 60);
            Offset = Offset + 70;
            e.Graphics.DrawString("ملاحظات", new Font("Times New Roman", 8, FontStyle.Bold), Brushes.DarkBlue, new Point(10, Offset));
            e.Graphics.DrawString("الإجمالي", new Font("Times New Roman", 8, FontStyle.Bold), Brushes.DarkBlue, new Point(80, Offset));
            e.Graphics.DrawString("السعر", new Font("Times New Roman", 8, FontStyle.Bold), Brushes.DarkBlue, new Point(120, Offset));
            e.Graphics.DrawString("الكمية", new Font("Times New Roman", 8, FontStyle.Bold), Brushes.DarkBlue, new Point(160, Offset));

            e.Graphics.DrawString("اسم الصنف", new Font("Times New Roman", 8, FontStyle.Bold), Brushes.DarkBlue, new Point(200, Offset));
            e.Graphics.DrawString("م", new Font("Times New Roman", 8, FontStyle.Bold), Brushes.DarkBlue, new Point(262, Offset));
            Offset = Offset + 20;
            e.Graphics.DrawLine(new Pen(Color.Black, 3), 20, Offset, 300, Offset);
            Offset = Offset + 20;





            List<usp_SelectRequestedORderByORderID_Result> orders = details.SelectRequestedORderByOrderId(int.Parse(txt_orderNo.Text));
            for (int i = 0; i < orders.Count; i++)
            {
                e.Graphics.DrawString(orders[i].Notes, new Font("Times New Roman", 8, FontStyle.Bold), Brushes.DarkBlue, new Point(10, Offset));
                e.Graphics.DrawString(Math.Round((double)orders[i].Price, 2).ToString(), new Font("Times New Roman", 8, FontStyle.Bold), Brushes.DarkBlue, new Point(120, Offset));
                e.Graphics.DrawString(orders[i].Qunatity.ToString(), new Font("Times New Roman", 8, FontStyle.Bold), Brushes.DarkBlue, new Point(160, Offset));
                e.Graphics.DrawString((Math.Round((double)orders[i].Price, 2) * (double)orders[i].Qunatity).ToString(), new Font("Times New Roman", 8, FontStyle.Bold), Brushes.DarkBlue, new Point(80, Offset));
                e.Graphics.DrawString(orders[i].ProductName, new Font("Times New Roman", 8, FontStyle.Bold), Brushes.DarkBlue, new Point(200, Offset));
                e.Graphics.DrawString((i + 1).ToString(), new Font("Times New Roman", 8, FontStyle.Bold), Brushes.DarkBlue, new Point(260, Offset));
                //graphics.DrawString(+ "\t" +  + "\t" +  + "\t\t\t" + + "\t", new Font("Times New Roman", 10),
                //    new SolidBrush(Color.Black), startX,  Offset);
                Offset = Offset + 20;
            }



            decimal totalVal = decimal.Parse(this.lbl_Total.Text);

            String Grosstotal = totalVal.ToString("N2") + "\t" + " المبلغ المطلوب  ";

            //Offset = Offset + 20;
            e.Graphics.DrawLine(new Pen(Color.Black, 3), 20, Offset, 300, Offset);
            //e.Graphics.DrawLine(new Pen(Color.Blue, 3), 60, Offset, 200, Offset);
            Offset = Offset + 20;

            graphics.DrawString(Grosstotal, new Font("Times New Roman", 12, FontStyle.Bold),
                     new SolidBrush(Color.Black), 10, Offset);
            Offset = Offset + 20;
            try
            {
                if (txt_Notes.Text != "")
                {
                    for (int i = 0; i < (txt_Notes.Text.Length / 50) + 1; i++)
                    {
                        if (i == 0)
                        {
                            string str = txt_Notes.Text.Substring(0, i + 1 * 50);
                            graphics.DrawString("ملاحظات : " + str, new Font("Times New Roman", 10),
                                            new SolidBrush(Color.Black), startX, startY + Offset);
                            Offset = Offset + 20;
                        }
                        else
                        {
                            try
                            {
                                string str = txt_Notes.Text.Substring(i * 50, i + 1 * 50);
                                graphics.DrawString("         " + str, new Font("Times New Roman", 10),
                                                new SolidBrush(Color.Black), startX, startY + Offset);
                                Offset = Offset + 20;
                            }
                            catch
                            {
                                //graphics.DrawString("ملاحظات : " + txt_Notes.Text.Substring(i * 50, txt_Notes.Text.Length-1), new Font("Times New Roman", 10),
                                //                    new SolidBrush(Color.Black), startX, startY + Offset);
                                //Offset = Offset + 20;
                            }
                        }
                    }
                }
            }
            catch { }
            //String DrawnBy = user.SelectUsers(_id)[0].Username;
            //graphics.DrawString("كاشير - " + DrawnBy, new Font("Times New Roman", 10),
            //         new SolidBrush(Color.Black), startX, startY + Offset);

        }
        UserClass user = new UserClass();
        RequestedOrderClass requested = new RequestedOrderClass();
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OrdersNos nos = new OrdersNos(_isPending);
            nos.Show(this);
        }

        private void dg_order_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                try
                {
                    int id = int.Parse(dg_order.Rows[e.RowIndex].Cells["Column4"].FormattedValue.ToString());

                    List<usp_SelectRequestedORderDetailsById_Result> record = details.SelectRequestedOrderDetailsById(id);
                    decimal price = (decimal)record[0].Price;

                    decimal qnty = (decimal.Parse(dg_order.Rows[e.RowIndex].Cells[2].FormattedValue.ToString()));
                    lbl_Total.Text = (decimal.Parse(lbl_Total.Text) - price + (price * qnty)).ToString();
                    details.UpdateRequestedORderDetails(int.Parse(txt_orderNo.Text), (int)record[0].ProductID, qnty, qnty * price, id, "");
                    dg_order.AutoGenerateColumns = false;
                    dg_order.DataSource = null;
                    dg_order.DataSource = details.SelectRequestedORderByOrderId(int.Parse(txt_orderNo.Text));
                }
                catch
                { }
            }
        }
        List<usp_SelectRequestedOrderByID_Result> req = null;
        private void txt_orderNo_TextChanged(object sender, EventArgs e)
        {
        if (txt_orderNo.Text !="")
            {
              req=  order.SelectRequestedOrderByID(int.Parse(txt_orderNo.Text));

                if (req.Count > 0)
                {
                    if (req[0].ClientID != null && (_isPending == true|| _isPending== false))
                    {
                        txt_client.Tag = (int)req[0].ClientID;
                        txt_client.Text = Clients.SelectAllClients((int)req[0].ClientID)[0].ClientName;
                        lbl_Total.Text = req[0].Total.ToString();
                        dt_orderDate.Value = (DateTime)req[0].OrderDate;
                        DateTime val = DateTime.Now.Add((TimeSpan)req[0].OrderTime);

                        dt_orderTime.Value = val;
                        dg_order.AutoGenerateColumns = false;
                        dg_order.DataSource = null;
                        dg_order.DataSource = details.SelectRequestedORderByOrderId(int.Parse(txt_orderNo.Text));
                        if (_isPending == false)
                        {
                            ch_Isdelevery.Checked = true;
                            cmb_employee.SelectedValue = (int)req[0].EmployeeID;
                            txt_rem.Text = req[0].Rem.ToString();
                            txt_DelFees.Text = expence.SelectExpenceByOrderID(int.Parse(txt_orderNo.Text))[0].ExpenceAmount.ToString();
                        }
                    }
                    else if(_isPending == null)
                    {
                        if (req[0].ClientID != null)
                        {
                            txt_client.Tag = (int)req[0].ClientID;
                            txt_client.Text = Clients.SelectAllClients((int)req[0].ClientID)[0].ClientName;
                        }
                            lbl_Total.Text = req[0].Total.ToString();
                            dt_orderDate.Value = (DateTime)req[0].OrderDate;
                            DateTime val = DateTime.Now.Add((TimeSpan)req[0].OrderTime);

                            dt_orderTime.Value = val;
                            dg_order.AutoGenerateColumns = false;
                            dg_order.DataSource = null;
                            dg_order.DataSource = details.SelectRequestedORderByOrderId(int.Parse(txt_orderNo.Text));
                            if (_isPending == false)
                            {
                                ch_Isdelevery.Checked = true;
                                cmb_employee.SelectedValue = (int)req[0].EmployeeID;
                                txt_rem.Text = req[0].Rem.ToString();
                                txt_DelFees.Text = expence.SelectExpenceByOrderID(int.Parse(txt_orderNo.Text))[0].ExpenceAmount.ToString();
                            }
                        }
                    else
                    {
                    if(_isPending != null)
                        MessageBox.Show("لا يوجد طلب  قيد الانتظار بهذا الرقم ");
                    }
                }
                else
                {
                    MessageBox.Show("لا يوجد طلب بهذا الرقم ");
                }
            }
        }

        private void txt_DelFees_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbl_Total.Text = ((decimal)req[0].Total + decimal.Parse(txt_DelFees.Text) + decimal.Parse(txt_rem.Text)).ToString();
            }
            catch
            {
                lbl_Total.Text = "0";
            }
        }

        private void txt_rem_TextChanged(object sender, EventArgs e)
        {

        }

        private void ch_Isdelevery_CheckedChanged(object sender, EventArgs e)
        {
            if(ch_Isdelevery.Checked )
            {
                label5.Visible = cmb_employee.Visible = true;
            }
            else 
            {
                label5.Visible = cmb_employee.Visible = false;
            
        }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        
        }
        ProductClass prod = new ProductClass();
        private void txt_bar_TextChanged(object sender, EventArgs e)
        {
            if (txt_bar.Text != "")
            {
                try
                {
                    int l = txt_bar.TextLength;
                    if (l == 13)
                        {
                        int code = int.Parse(txt_bar.Text.Substring(1, 6));
                        List<usp_selectProductByCode_Result> prodByCode = prod.SelectProduct(code);
                        int id = prodByCode[0].ID;
                     
                        string price = txt_bar.Text.Substring(7);
                        int index = price.Length - 1;
                        string dec = price.Substring(index);
                        string total = price.Substring(0, 3);
                        string rem = price.Substring(3);
                        total = total + '.' + rem.Substring(0, 2);
                        double totalval = double.Parse(total);
                        double productPRice = double.Parse(prodByCode[0].Price.ToString());

                        decimal qnty = (decimal)Math.Round(totalval / productPRice, 3);
                        List<usp_SelectRequestedORderDetailsByOrderId_Result> det=details.SelectRequestedORderDetailsByOrderId(int.Parse(txt_orderNo.Text));
                        for (int i = 0; i<det.Count; i++)
                        {
                        if(det[i].ProductID == id)
                        {
                                details.UpdateRequestedORderDetails(int.Parse(txt_orderNo.Text), id, qnty, (decimal)prod.SelectProductByID(id)[0].Price,det[i].ID, txt_Notes.Text );
                            }
                        }
                       

                        if (lbl_Total.Text == "")
                            lbl_Total.Text = "0";
                        lbl_Total.Text = (decimal.Parse(lbl_Total.Text) + (decimal)prod.SelectProductByID(id)[0].Price).ToString();
                        dg_order.AutoGenerateColumns = false;
                        dg_order.DataSource = details.SelectRequestedORderByOrderId(int.Parse(txt_orderNo.Text));
                        txt_bar.Text = "";
                    }
                }
                catch { }
            }
        }

        private void PendingOrders_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 46)
            {
                Int32 selectedRowCount =
            dg_order.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 0)
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();

                    for (int i = 0; i < selectedRowCount; i++)
                    {
                        int index =dg_order.SelectedRows[i].Index;
                        decimal price = decimal.Parse(dg_order.Rows[index].Cells["Column3"].FormattedValue.ToString());
                        expence.InsertExpence(decimal.Parse(lbl_Total.Text), "مرتجعات", null, DateTime.Now, int.Parse(txt_orderNo.Text));
                        int id = int.Parse(dg_order.Rows[index].Cells["Column4"].FormattedValue.ToString());
                        details.DeleteOrderDetails(id);
                        dg_order.AutoGenerateColumns = false;
                        dg_order.DataSource = details.SelectRequestedORderByOrderId(int.Parse(txt_orderNo.Text));
                        
                        
                    }
                    if (dg_order.Rows.Count==0)

                    {
                        order.DeleteRequestOrder(int.Parse(txt_orderNo.Text));

                        Clear();
                    }

                }
                else 
                {
                    MessageBox.Show("إختار الطلبات المطلوب حذفها");
                }
            }
        }
    }
}
