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
    public partial class EmployeeShift : Form
    {
        int id, shiftid;
        Classes.ShiftClass shift = new Classes.ShiftClass();

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("هل تريد تصفية الوردية ", "تنبيه" , MessageBoxButtons.OKCancel , MessageBoxIcon.Warning)== DialogResult.OK)
            {
                shift.update(DateTime.Now.TimeOfDay, id, shiftid);
                printDocument1.Print();
                //Application.Exit();
            }
        }
        Classes.UserClass user = new Classes.UserClass();
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Times New Roman", 10);
            float fontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int Offset = 40;

            e.Graphics.DrawLine(new Pen(Color.Black, 3), 20, 5, 300, 5);
            Offset = Offset + 20;
            //string title = "اهلا بك في جزارة عمران";
            graphics.DrawString("إجمالي مبيعات الوردية" +"   "+ lbl_SalesTotal.Text, new Font("Times New Roman", 12),
                                new SolidBrush(Color.Black), startX , Offset - 40);
            Offset = Offset + 20;
            graphics.DrawString("الكاشير " + user.SelectUsers(id)[0].Username, new Font("Times New Roman", 12),
                              new SolidBrush(Color.Black), startX, Offset - 40);
            Offset = Offset + 20;
           //e.Graphics.DrawString("ملاحظات", new Font("Times New Roman", 8, FontStyle.Bold), Brushes.DarkBlue, new Point(10, Offset));
           // e.Graphics.DrawString("الإجمالي", new Font("Times New Roman", 8, FontStyle.Bold), Brushes.DarkBlue, new Point(80, Offset));
           // e.Graphics.DrawString("السعر", new Font("Times New Roman", 8, FontStyle.Bold), Brushes.DarkBlue, new Point(120, Offset));
           // e.Graphics.DrawString("الكمية", new Font("Times New Roman", 8, FontStyle.Bold), Brushes.DarkBlue, new Point(160, Offset));

           // e.Graphics.DrawString("اسم الصنف", new Font("Times New Roman", 8, FontStyle.Bold), Brushes.DarkBlue, new Point(200, Offset));

           // Offset = Offset + 20;
           // e.Graphics.DrawLine(new Pen(Color.Black, 3), 20, Offset, 300, Offset);
           // Offset = Offset + 20;





            //List<usp_SelectRequestedORderByShiftID_Result> orders = shift.SelectORdersByShift(shiftid);
            //for (int i = 0; i < orders.Count; i++)
            //{
            //    e.Graphics.DrawString(orders[i].Notes, new Font("Times New Roman", 8, FontStyle.Bold), Brushes.DarkBlue, new Point(10, Offset));
            //    e.Graphics.DrawString(Math.Round((double)orders[i].Price, 2).ToString("N2"), new Font("Times New Roman", 8, FontStyle.Bold), Brushes.DarkBlue, new Point(120, Offset));
            //    e.Graphics.DrawString(((decimal)orders[i].Qunatity).ToString("N2"), new Font("Times New Roman", 8, FontStyle.Bold), Brushes.DarkBlue, new Point(160, Offset));
            //    e.Graphics.DrawString((Math.Round((double)orders[i].Price, 2) * (double)orders[i].Qunatity).ToString("N2"), new Font("Times New Roman", 8, FontStyle.Bold), Brushes.DarkBlue, new Point(80, Offset));
            //    e.Graphics.DrawString(orders[i].ProductName, new Font("Times New Roman", 8, FontStyle.Bold), Brushes.DarkBlue, new Point(200, Offset));

            //    //graphics.DrawString(+ "\t" +  + "\t" +  + "\t\t\t" + + "\t", new Font("Times New Roman", 10),
            //    //    new SolidBrush(Color.Black), startX,  Offset);
            //    Offset = Offset + 20;
            //}


        }

        private void EmployeeShift_Load(object sender, EventArgs e)
        {

        }

        public EmployeeShift(int userID , int ShiftID )
        {
            InitializeComponent();
            id = userID;
            shiftid = ShiftID;
            dg_order.AutoGenerateColumns = false;
          dg_order.DataSource=  shift.SelectORdersByShift(shiftid);
            try
            {
                lbl_take.Text = ((decimal)shift.SelectAllORdersByShiftTake(shiftid)).ToString("N2");
                if (lbl_take.Text == "")
                    lbl_take.Text = "0";
            }
            catch
            {
                lbl_take.Text = "0";
            }
            try
            {
                lbl_del.Text = ((decimal)shift.SelectAllORdersByShiftDel(shiftid)).ToString("N2");
                if (lbl_del.Text == "")
                    lbl_del.Text = "0";
            }
            catch
            {
                lbl_del.Text = "0";
            }
            try
            {
                lbl_SalesTotal.Text = ((decimal)shift.SelectAllORdersByShift(shiftid)).ToString("N2");
                if (lbl_SalesTotal.Text == "")
                    lbl_SalesTotal.Text = "0";
            }
            catch
            {
                lbl_SalesTotal.Text = "0";
            }
        }
    }
}
