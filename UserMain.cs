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
    public partial class UserMain : Form
    {
        ProductClass prod = new ProductClass();
        UserClass user = new UserClass();
        ShiftClass shift = new ShiftClass();
        int _id;
        int shiftID;
        public UserMain(int id)
        {
            InitializeComponent();
            _id = id;
            int? _shiftid = shift.Select(_id);
            if (_shiftid == null)
            {
                shift.InsertShift(DateTime.Now.TimeOfDay, null, _id);
                _shiftid = shift.Select(_id);
            }
            shiftID = (int)_shiftid;
            lbl_Chashier.Text = user.SelectUsers(id)[0].Username;
            List<usp_SelectProduct_Result> pro = prod.SelectProduct();
            int x = 0;
            int y = 0;
            for (int i = 0; i < pro.Count; i++)
            {
                if (i == 0)
                {
                    y += 10;
                }
                if (i % 10 == 0 && i != 0)
                {
                    x = 0;
                    y += 75;
                }
                Button b = new Button();
                try
                {
                    b.BackColor = Color.FromArgb(int.Parse(pro[i].Color.Trim()));
                    b.ForeColor = Color.FromArgb(int.Parse(pro[i].ForeColor));
                }
                catch
                { }
                b.Size = new Size(70, 70);
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.Text = pro[i].ProductName;
                b.Tag = pro[i].ID.ToString();
                //PointLoc(x, b);
                b.Font = new Font(lbl_ClientName.Font.FontFamily, 10);
                b.Click += B_Click;
                b.Location = new Point(x, y);
                x += 75;

                pnl_Product.Controls.Add(b);

            }

        }
        Classes.ReqestedORderDetails details = new ReqestedORderDetails();
        Classes.RequestedOrderClass requested = new Classes.RequestedOrderClass();
        public string Notes = "";
        private void B_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;


            int id = int.Parse(b.Tag.ToString());
            if (lbl_orderNo.Text == "")
            {
                lbl_ClientName.Text = "عميل محل";
                lbl_orderNo.Text = requested.InsertRequestedOrder(DateTime.Now.Date, null, DateTime.Now.TimeOfDay, txt_Notes.Text, _id, shiftID).ToString();
            }


            details.InsertRequestedORderDetails(int.Parse(lbl_orderNo.Text), id, 1, (decimal)prod.SelectProductByID(id)[0].Price, lbl_notes.Text);

            if (lbl_Total.Text == "")
                lbl_Total.Text = "0";
            lbl_Total.Text = (decimal.Parse(lbl_Total.Text) + (decimal)prod.SelectProductByID(id)[0].Price).ToString("N2");
            dg_order.AutoGenerateColumns = false;
            dg_order.DataSource = details.SelectRequestedORderByOrderId(int.Parse(lbl_orderNo.Text));
            bool? isNotes = prod.SelectProductByID(id)[0].isNoteAllowed;
            if (isNotes == true)
            {
                if (dg_order.Rows.Count > 0)
                {
                    Notes no = new Notes(int.Parse(dg_order.Rows[dg_order.Rows.Count - 1].Cells["Column4"].FormattedValue.ToString()));
                    no.Show(this);
                }
            }
            txt_bar.Focus();
        }

        ProductInfo product = null;
        private void مساعدةToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (product == null)
            {
                product = new ProductInfo();
                //  product.MdiParent = this;
                product.FormClosing += Product_FormClosing;
                product.Show();

            }
        }

        private void Product_FormClosing(object sender, FormClosingEventArgs e)
        {
            product = null;
        }

        private void إغلاقالبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Login l = null;
        private void الخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (l == null)
            {
                l = new Login();

                l.FormClosing += L_FormClosing;

                l.Show();
                this.Close();
            }
        }

        private void L_FormClosing(object sender, FormClosingEventArgs e)
        {
            l = null;
        }

        private void افقيToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void رأسيToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void متتابعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        ClientData client = null;
        private void ديليفريToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (client == null)
            {
                client = new ClientData(_id, shiftID);
                //client.MdiParent = this;
                client.FormClosing += Client_FormClosing;
                client.Show(this);
            }
            else
            {
                client.Show();
            }
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            client = null;
        }
        PendingOrders pending = null;
        private void طلباتمعلقةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pending == null)
            {
                pending = new PendingOrders(true);
                //pending.MdiParent = this;
                pending.FormClosing += Pending_FormClosing;
                pending.Show(this);
            }

        }

        private void Pending_FormClosing(object sender, FormClosingEventArgs e)
        {
            pending = null;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (pending == null)
            {
                pending = new PendingOrders(false);
                // pending.MdiParent = this;
                pending.FormClosing += Pending_FormClosing;
                pending.Show(this);
            }
        }
        EmployeeInOut inout = null;
        private void حضوروانصرافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pending == null)
            {
                inout = new EmployeeInOut();
                //inout.MdiParent = this;
                inout.FormClosing += Inout_FormClosing;
                inout.Show(this);
            }

        }

        private void Inout_FormClosing(object sender, FormClosingEventArgs e)
        {
            pending = null;
        }
        AttendByCode att = null;
        private void مرتباتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (att == null)
            {
                att = new AttendByCode();
                // att.MdiParent = this;
                att.FormClosing += Att_FormClosing;
                att.Show(this);
            }

        }

        private void Att_FormClosing(object sender, FormClosingEventArgs e)
        {
            att = null;
        }


        Suppliers sub = null;
        private void شاشةالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Sub_FormClosing(object sender, FormClosingEventArgs e)
        {
            sub = null;
        }

        private void الموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (sub == null)
            //{
            //    sub = new Suppliers();
            //    //sub.MdiParent = this;
            //    sub.FormClosing += Sub_FormClosing;
            //    sub.Show();
            //}
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            print();
            if (lbl_ClientName.Tag != null)
                requested.UpdateOrder(int.Parse(lbl_orderNo.Text), decimal.Parse(lbl_Total.Text), true, txt_Notes.Text, 0, int.Parse(lbl_ClientName.Tag.ToString()));
            else
                requested.UpdateOrder(int.Parse(lbl_orderNo.Text), decimal.Parse(lbl_Total.Text), true, txt_Notes.Text, 0, null);
            dg_order.DataSource = null;
            lbl_Total.Text = lbl_ClientName.Text = lbl_orderNo.Text = "";
            lbl_Total.Text = "0";
            btn_Pre.Visible = false;
            txt_bar.Focus();
            txt_Notes.Text = "";
        }

        private void btn_Pre_Click(object sender, EventArgs e)
        {
            requested.UpdateOrder(int.Parse(lbl_orderNo.Text), decimal.Parse(lbl_Total.Text), false, txt_Notes.Text, 0, int.Parse(lbl_ClientName.Tag.ToString()));
            print();
            dg_order.DataSource = null;
            lbl_Total.Text = lbl_ClientName.Text = lbl_orderNo.Text = "";
            btn_Pre.Visible = false;

        }
        PrintDocument pdoc;
        public void print()
        {
            PrintDialog pd = new PrintDialog();
            pdoc = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            Font font = new Font("Courier New", 15);


            PaperSize psize = new PaperSize("Custom", 100, 200);
            ps.DefaultPageSettings.PaperSize = psize;

            pd.Document = pdoc;
            pd.Document.DefaultPageSettings.PaperSize = psize;
            //pdoc.DefaultPageSettings.PaperSize.Height =320;
            pdoc.DefaultPageSettings.PaperSize.Height = 820;

            pdoc.DefaultPageSettings.PaperSize.Width = 520;

            pdoc.PrintPage += new PrintPageEventHandler(pdoc_PrintPage);
            printPreviewDialog1.Document = pdoc;
            //pdoc.Print();
            printPreviewDialog1.ShowDialog();


        }
        string source = "";
        ClientsClass c = new ClientsClass();
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
            graphics.DrawString("رقم الطلب :" + lbl_orderNo.Text.ToString(),
 new Font("Times New Roman", 12),
 new SolidBrush(Color.Black), startX + title.Length + 140, Offset - 20);
            Offset = Offset + 20;
            graphics.DrawString("التاريخ :" + DateTime.Now.ToShortDateString(),
 new Font("Times New Roman", 12),
 new SolidBrush(Color.Black), startX + title.Length + 140, Offset - 20);
            Offset = Offset + 20;
            graphics.DrawString("الساعة  :"+ DateTime.Now.TimeOfDay.ToString().Substring(0, DateTime.Now.TimeOfDay.ToString().LastIndexOf('.')),
 new Font("Times New Roman", 12),
 new SolidBrush(Color.Black), startX + title.Length + 140, Offset - 20);
            //Offset = Offset + 20;


            Image img = Image.FromFile("logo.jpg");
            graphics.DrawImage(img, new Point(startX, startY));
            Offset = Offset + 20;
            Offset = Offset + 20;
            e.Graphics.DrawLine(new Pen(Color.Black, 3), 20, Offset, 300, Offset);
            



            title = "رقم الطلب :";

            if (lbl_ClientName.Text != "عميل محل")
            {
                int id = int.Parse(lbl_ClientName.Tag.ToString());
                List<usp_SelectAllClientsByID_Result> clientData = c.SelectAllClients(id);
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
                    e.Graphics.DrawLine(new Pen(Color.Black, 3), 20, Offset + 60, 300, Offset + 60);
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





            List<usp_SelectRequestedORderByORderID_Result> orders = details.SelectRequestedORderByOrderId(int.Parse(lbl_orderNo.Text));
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
            String DrawnBy = user.SelectUsers(_id)[0].Username;
            graphics.DrawString("كاشير - " + DrawnBy, new Font("Times New Roman", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);

        }

        private void pnl_Product_Paint(object sender, PaintEventArgs e)
        {

        }

        private void طلباتمجمعةمععاملدليفريToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PendingByDelevery byDelevery = new PendingByDelevery();
            byDelevery.Show();
        }

        private void txt_bar_TextChanged(object sender, EventArgs e)
        {
            if (txt_bar.Text.Contains(' '))
                txt_bar.Text = txt_bar.Text.Trim();
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
                        if (lbl_orderNo.Text == "")
                        {
                            lbl_ClientName.Text = "عميل محل";
                            lbl_orderNo.Text = requested.InsertRequestedOrder(DateTime.Now.Date, null, DateTime.Now.TimeOfDay, txt_Notes.Text, _id, shiftID).ToString();
                        }

                        details.InsertRequestedORderDetails(int.Parse(lbl_orderNo.Text), id, qnty, (decimal)prod.SelectProductByID(id)[0].Price, lbl_notes.Text);

                        if (lbl_Total.Text == "")
                            lbl_Total.Text = "0";
                        lbl_Total.Text = ((decimal)details.SelectTotalOrder(int.Parse(lbl_orderNo.Text))).ToString("N2");
                        //(decimal.Parse(lbl_Total.Text) + (decimal)prod.SelectProductByID(id)[0].Price).ToString("N2");
                        dg_order.AutoGenerateColumns = false;
                        dg_order.DataSource = details.SelectRequestedORderByOrderId(int.Parse(lbl_orderNo.Text));
                        txt_bar.Text = "";
                    }
                }
                catch { }
            }

        }

        private void dg_order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dg_order_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 || e.ColumnIndex == 4)
            {
                try
                {
                    int id = int.Parse(dg_order.Rows[e.RowIndex].Cells["Column4"].FormattedValue.ToString());

                    List<usp_SelectRequestedORderDetailsById_Result> record = details.SelectRequestedOrderDetailsById(id);
                    //decimal price = (decimal)record[0].Price;
                    //if (price == 0)
                    decimal price = decimal.Parse(dg_order.Rows[e.RowIndex].Cells["Column3"].FormattedValue.ToString());
                    decimal qnty = (decimal.Parse(dg_order.Rows[e.RowIndex].Cells["Column2"].FormattedValue.ToString()));
                    //lbl_Total.Text = (decimal.Parse(lbl_Total.Text) - price + (price * qnty)).ToString();
                    string notes = dg_order.Rows[e.RowIndex].Cells["Column5"].FormattedValue.ToString();
                    details.UpdateRequestedORderDetails(int.Parse(lbl_orderNo.Text), (int)record[0].ProductID, qnty, price, id, notes);
                    lbl_Total.Text = ((decimal)details.SelectTotalOrder(int.Parse(lbl_orderNo.Text))).ToString("N2");
                    dg_order.AutoGenerateColumns = false;
                    dg_order.DataSource = null;
                    dg_order.DataSource = details.SelectRequestedORderByOrderId(int.Parse(lbl_orderNo.Text));
                    dg_order.Rows[e.RowIndex].Cells["Column6"].Value = (price * qnty).ToString();
                    btn_Enter.Focus();
                }
                catch
                {
                    MessageBox.Show("قم بإدخال الارقام فقط");
                }
            }
        }

        private void UserMain_Load(object sender, EventArgs e)
        {
            txt_bar.Focus();
        }

        private void تصفيةالورديةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 
            EmployeeShift employeeShift = new EmployeeShift(_id, shiftID);
            employeeShift.Show();
        }

        private void dg_order_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {

                decimal price = decimal.Parse(dg_order.Rows[e.RowIndex].Cells["Column3"].FormattedValue.ToString());
                decimal qnty = (decimal.Parse(dg_order.Rows[e.RowIndex].Cells[2].FormattedValue.ToString()));

                int id = int.Parse(dg_order.Rows[e.RowIndex].Cells["Column4"].FormattedValue.ToString());
                details.DeleteOrderDetails(id);
                dg_order.DataSource = details.SelectRequestedORderByOrderId(int.Parse(lbl_orderNo.Text));
                if (dg_order.Rows.Count == 0)
                {
                    lbl_Total.Text = "";
                    if (MessageBox.Show("هل تريد بدأ طلب جديد", "تنبيه", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        requested.DeleteRequestOrder(int.Parse(lbl_orderNo.Text));
                        lbl_orderNo.Text = "";
                        lbl_ClientName.Text = "";

                    }
                }
                //dg_order.Rows[e.RowIndex].Cells["Column6"].Value = (price * qnty).ToString();
            }
        }

        private void dg_order_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void تصفيةالورديةToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
        ClientsClass clientsClass = new ClientsClass();
        private void UserMain_KeyDown(object sender, KeyEventArgs e)

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
                        int index = dg_order.SelectedRows[i].Index;
                        decimal price = decimal.Parse(dg_order.Rows[index].Cells["Column3"].FormattedValue.ToString());
                        //expence.InsertExpence(decimal.Parse(lbl_Total.Text), "مرتجعات", null, DateTime.Now, int.Parse(txt_orderNo.Text));
                        int id = int.Parse(dg_order.Rows[index].Cells["Column4"].FormattedValue.ToString());
                        details.DeleteOrderDetails(id);
                        dg_order.AutoGenerateColumns = false;
                        dg_order.DataSource = details.SelectRequestedORderByOrderId(int.Parse(lbl_orderNo.Text));
                        if (dg_order.Rows.Count == 0)
                        {
                            lbl_Total.Text = "0";
                        }
                        //update toatl

                    }
                    if (dg_order.Rows.Count == 0)

                    {
                        
                        //requested.DeleteRequestOrder(int.Parse(lbl_orderNo.Text));


                    }
                    if(dg_order.Rows.Count>0)
                    dg_order.Rows[0].Selected = true;
                    //List<usp_SelectRequestedOrderByID_Result> req = requested.SelectRequestedOrderByID(int.Parse(lbl_orderNo.Text));
                    //if (req[0].ClientID != null)
                    //{
                    //    lbl_ClientName.Tag = (int)req[0].ClientID;
                    //    lbl_ClientName.Text = clientsClass.SelectAllClients((int)req[0].ClientID)[0].ClientName;
                    //}
                    string total = details.SelectTotalOrder(int.Parse(lbl_orderNo.Text)).ToString();
                    if(total!="")
                    lbl_Total.Text = total.Split('.')[0]+"."+ total.Split('.')[1].Substring(0,2);
                }
                else
                {

                 

dg_order.Rows[0].Selected = true;
                }
            }
            else if (e.KeyValue == 32)
            {
                //if(txt_bar.Text)
                print();
                
                if (lbl_ClientName.Tag != null)
                    requested.UpdateOrder(int.Parse(lbl_orderNo.Text), decimal.Parse(lbl_Total.Text), true, txt_Notes.Text, 0, int.Parse(lbl_ClientName.Tag.ToString()));
                else
                    requested.UpdateOrder(int.Parse(lbl_orderNo.Text), decimal.Parse(lbl_Total.Text), true, txt_Notes.Text, 0, null);
                dg_order.DataSource = null;
                lbl_Total.Text = lbl_ClientName.Text = lbl_orderNo.Text = "";
                lbl_Total.Text = "0";
                btn_Pre.Visible = false;
                txt_bar.Text = string.Empty;
                txt_Notes.Text = "";
                txt_bar.Focus();
              
            }
            else if (e.KeyValue == 123)
            {
                // pending order 
                if (dg_order.Rows.Count != 0)
                {
                    if (lbl_ClientName.Tag != null)
                        requested.UpdateOrder(int.Parse(lbl_orderNo.Text), decimal.Parse(lbl_Total.Text), true, txt_Notes.Text, 0, int.Parse(lbl_ClientName.Tag.ToString()));
                    else
                        requested.UpdateOrder(int.Parse(lbl_orderNo.Text), decimal.Parse(lbl_Total.Text), true, txt_Notes.Text, 0, null);
                    label3.Text = lbl_orderNo.Text;
                    dg_order.DataSource = null;
                    lbl_Total.Text = lbl_ClientName.Text = lbl_orderNo.Text = "";
                    lbl_Total.Text = "0";
                    btn_Pre.Visible = false;
                    txt_bar.Focus();
                    txt_Notes.Text = "";
                }
            }
            else if (e.KeyValue == 122)
            {
                if (dg_order.Rows.Count == 0)
                {
                    lbl_orderNo.Text = label3.Text;
                    List<usp_SelectRequestedOrderByID_Result> req = requested.SelectRequestedOrderByID(int.Parse(label3.Text));
                    if (req[0].ClientID != null)
                    {
                        lbl_ClientName.Tag = (int)req[0].ClientID;
                        lbl_ClientName.Text = clientsClass.SelectAllClients((int)req[0].ClientID)[0].ClientName;
                    }
                    lbl_Total.Text = req[0].Total.ToString();
                    //dt_orderDate.Value = (DateTime)req[0].OrderDate;
                    DateTime val = DateTime.Now.Add((TimeSpan)req[0].OrderTime);
                    txt_Notes.Text = req[0].Notes;
                    //dt_orderTime.Value = val;
                    dg_order.AutoGenerateColumns = false;
                    dg_order.DataSource = null;
                    dg_order.DataSource = details.SelectRequestedORderByOrderId(int.Parse(lbl_orderNo.Text));

                }

            }
        }

        private void إضافةمديونيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payment accounts = new Payment();
            accounts.Show();
        }

        private void متابعةمديونيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientAccounts accounts = new ClientAccounts();
            accounts.Show();
        }

        private void حساباتموردToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuppliersByDay suppliers = new SuppliersByDay();
            suppliers.Show();
        }
    }
}
