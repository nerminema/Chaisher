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
    public partial class AttendanceReport : Form
    {
        public AttendanceReport()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
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
            Drawer.printedDataTable.Add(ListtoDataTableConverter.ToDataTable(att.SelectAll(dt_from.Value.Date, dt_To.Value.Date)));
            Drawer.header.Add("تقرير الحضور اليومي " + "\n" + "في الفترة من " + dt_from.Value.Date + "إلي" + dt_To.Value.Date);
            //Drawer.columnsWidth.Add("Name", 200); 
            //Drawer.columnsWidth.Add("No", 25);
            //Drawer.columnsWidth.Add("New", 20);
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
        EmployeeTimeAttanceClass att = new EmployeeTimeAttanceClass();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=att.SelectAll(dt_from.Value.Date, dt_To.Value.Date);
        }
    }
}
