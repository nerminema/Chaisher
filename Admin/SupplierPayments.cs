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

namespace Chaisher.Admin
{
    public partial class SupplierPayments : Form
    {
        Classes.SuppliersClass subs = new Classes.SuppliersClass();
        Classes.POClass POClass = new Classes.POClass();
        public SupplierPayments(int id)
        {
            InitializeComponent();
            comboBox1.DataSource = subs.SelectAll();
            comboBox1.DisplayMember = "SupplierName";
            comboBox1.ValueMember = "ID";
            comboBox1.SelectedIndex = -1;
            comboBox1.SelectedValue = id;
            dt_To.Value = dt_from.Value.Date.AddDays(7);
            dataGridView1.AutoGenerateColumns= true;
            dataGridView1.DataSource = POClass.SelectAllBySub(id, dt_from.Value.Date, dt_To.Value.Date);
            lbl_Total.Text = POClass.SelectTotalAllBySub(id, dt_from.Value.Date, dt_To.Value.Date).ToString();
        }
        public SupplierPayments()
        {
            InitializeComponent(); comboBox1.DataSource = subs.SelectAll();
            comboBox1.DisplayMember = "SupplierName";
            comboBox1.ValueMember = "ID";
            comboBox1.SelectedIndex = -1;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = POClass.SelectAll(false);
            lbl_Total.Text = POClass.SelectSumPO().ToString();
            lbl_Total.Text = POClass.SelectTotalAll(dt_from.Value.Date, dt_To.Value.Date).ToString();
            lbl_paid.Text = POClass.SelectPaidTotalAll(dt_from.Value.Date, dt_To.Value.Date).ToString();
            if (lbl_paid.Text == "")
                lbl_paid.Text = "0";
            lbl_unPaid.Text = POClass.SelectUnPaidTotalAll(dt_from.Value.Date, dt_To.Value.Date).ToString();
            if (lbl_unPaid.Text == "")
                lbl_unPaid.Text = "0";
            if (lbl_Total.Text == "")
                lbl_Total.Text = "0";

        }

        private void dt_To_ValueChanged(object sender, EventArgs e)
        {try
            {
                FilterData();
            }
            catch
            {
                MessageBox.Show("من فضلك اختار مورد");
            }
}

        private void FilterData()
        {
            if (comboBox1.SelectedValue != null)
            {
                int id = int.Parse(comboBox1.SelectedValue.ToString());
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = POClass.SelectAllBySub(id, dt_from.Value.Date, dt_To.Value.Date);
                lbl_Total.Text = POClass.SelectTotalAllBySub(id, dt_from.Value.Date, dt_To.Value.Date).ToString();
                if (lbl_Total.Text == "")
                    lbl_Total.Text = "0";
            }
            else
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = POClass.SelectAllBySub(dt_from.Value.Date, dt_To.Value.Date);
                lbl_Total.Text = POClass.SelectTotalAll(dt_from.Value.Date, dt_To.Value.Date).ToString();
                lbl_paid.Text = POClass.SelectPaidTotalAll(dt_from.Value.Date, dt_To.Value.Date).ToString();
                if (lbl_paid.Text == "")
                    lbl_paid.Text = "0";
                lbl_unPaid.Text = POClass.SelectUnPaidTotalAll(dt_from.Value.Date, dt_To.Value.Date).ToString();
                if (lbl_unPaid.Text == "")
                    lbl_unPaid.Text = "0";
                if (lbl_Total.Text == "")
                    lbl_Total.Text = "0";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(comboBox1.SelectedValue.ToString());
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = POClass.SelectAllBySub(id, dt_from.Value.Date, dt_To.Value.Date);
                lbl_Total.Text = POClass.SelectTotalAllBySub(id, dt_from.Value.Date, dt_To.Value.Date).ToString();
                if (lbl_Total.Text == "")
                    lbl_Total.Text = "0";
            }
            catch
            {

            }
        }

        private void dt_from_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                FilterData();
            }
            catch
            {
                MessageBox.Show("من فضلك اختار مورد");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString());
            DateTime date = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells["Column1"].FormattedValue.ToString());
            decimal PoTotal = decimal.Parse(dataGridView1.Rows[e.RowIndex].Cells["Column2"].FormattedValue.ToString());
            if (e.ColumnIndex ==4)
            {
                POClass.Update(id, int.Parse(comboBox1.SelectedValue.ToString()), date, PoTotal, true);
                int sid = int.Parse(comboBox1.SelectedValue.ToString());
                   dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = POClass.SelectAllBySub(sid, dt_from.Value.Date, dt_To.Value.Date);
                lbl_Total.Text = POClass.SelectTotalAllBySub(id, dt_from.Value.Date, dt_To.Value.Date).ToString();
                if (lbl_Total.Text == "")
                    lbl_Total.Text = "0";
            }
        }
        ExpenceClass expence = new ExpenceClass();
        private void button2_Click(object sender, EventArgs e)
        {
            int sid = int.Parse(comboBox1.SelectedValue.ToString());
            if (lbl_Total.Text!="0")
            {
               
              List<usp_SelectAllPOBySubIDAndDate_Result> pos  = POClass.SelectAllBySub(sid, dt_from.Value.Date, dt_To.Value.Date);
              for(int i=0; i<pos.Count; i++)
              {
                    POClass.Update(pos[i].ID, int.Parse(comboBox1.SelectedValue.ToString()),(DateTime)pos[i].Date, (decimal)pos[i].Total, true);
                  
                }
                expence.InsertExpence(decimal.Parse(lbl_Total.Text ) , "فاتورة توريدات باسم :  " + comboBox1.Text , null , DateTime.Now.Date , null);
                dataGridView1.DataSource = POClass.SelectAllBySub(sid, dt_from.Value.Date, dt_To.Value.Date);
                lbl_Total.Text = POClass.SelectTotalAllBySub(sid, dt_from.Value.Date, dt_To.Value.Date).ToString();
                if (lbl_Total.Text == "")
                    lbl_Total.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.PrintDialog p = new System.Windows.Forms.PrintDialog();
            CPrinting.PrintedDocument PD = new CPrinting.PrintedDocument();
            CPrinting.CPrinting Drawer = new CPrinting.CPrinting();
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Near;
            sf.LineAlignment = StringAlignment.Center;
            PD = new CPrinting.PrintedDocument();
            CPrinting.PrintPreview PP = new CPrinting.PrintPreview(PD);
            Drawer = new CPrinting.CPrinting();
            Drawer.printedDataTable.Add(ListtoDataTableConverter.ToDataTable(POClass.SelectAllBySub(int.Parse(comboBox1.SelectedValue.ToString()), dt_from.Value.Date, dt_To.Value.Date)));
            Drawer.header.Add("تقرير المرتبات " + "\n" + "في الفترة من " + dt_from.Value.Date + "إلي" + dt_To.Value.Date);

            Drawer.PrintDocument.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(40, 40, 100, 100);
            Drawer.PrintDocument.DefaultPageSettings.Landscape = true;
            Drawer.fonts[CPrinting.CPrinting.FontElement.ColumnHeader] = new System.Drawing.Font("Cambria", 10);
            Drawer.fonts[CPrinting.CPrinting.FontElement.Cell] = new System.Drawing.Font("tahoma", 8);
            Drawer.columnsFonts.Add("Name", new System.Drawing.Font("Cambria", 10));

            //Drawer.leftLogoSize = Drawer.rightLogoSize = img.Size;
            //Drawer.leftLogo = img;
            for (int i = 0; i <= Drawer.printedDataTable[0].Columns.IndexOf("Total"); i++)
            {
                Drawer.columnsDirection.Add(Drawer.printedDataTable[0].Columns[i].ColumnName, sf);
                Drawer.columnFormat.Add(Drawer.printedDataTable[0].Columns[i].ColumnName, "  {0}");
            }
            Drawer.columnsDirection.Add("Name", sf);
            Drawer.footer = "";
            Drawer.print();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void SupplierPayments_Load(object sender, EventArgs e)
        {

        }
    }
}
