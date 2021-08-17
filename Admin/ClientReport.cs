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
    public partial class ClientReport : Form
    {
        Classes.DistrictClass district = new Classes.DistrictClass();
        public ClientReport()
        {
            InitializeComponent();
            cmb_Category.DataSource = district.SelectAll();
            cmb_Category.DisplayMember = "DistrictName";
            cmb_Category.ValueMember = "ID";
            cmb_Category.SelectedIndex = -1;
            dataGridView1.AutoGenerateColumns = false;
           dataGridView1.DataSource= clients.SelectAllClients();
        }
        Classes.ClientsClass clients = new Classes.ClientsClass();
        private void button1_Click(object sender, EventArgs e)
        {
            if(cmb_Category.SelectedIndex !=-1)
            {
                dataGridView1.DataSource = clients.SelectAllClientsByDistrict(int.Parse(cmb_Category.SelectedValue.ToString()));
            }
        }
        System.Windows.Forms.PrintDialog p = new System.Windows.Forms.PrintDialog();
        CPrinting.PrintedDocument PD = new CPrinting.PrintedDocument();
        private void button2_Click(object sender, EventArgs e)
        {
            CPrinting.CPrinting Drawer = new CPrinting.CPrinting();
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Near;
            sf.LineAlignment = StringAlignment.Center;
            PD = new CPrinting.PrintedDocument();
            CPrinting.PrintPreview PP = new CPrinting.PrintPreview(PD);
            Drawer = new CPrinting.CPrinting();
            if(cmb_Category.SelectedIndex!= -1)
                Drawer.printedDataTable.Add(ListtoDataTableConverter.ToDataTable(clients.SelectAllClientsByDistrict(int.Parse(cmb_Category.SelectedValue.ToString()))));
            else 
            Drawer.printedDataTable.Add(ListtoDataTableConverter.ToDataTable(clients.SelectAllClients()));
            Drawer.header.Add("تقرير العملاء " + "\n" );
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
            
            Drawer.columnsDirection.Add("Name", sf);
            Drawer.footer = "";
            Drawer.print();
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Category.SelectedIndex != -1)
                {
                    dataGridView1.DataSource = clients.SelectAllClientsByDistrict(int.Parse(cmb_Category.SelectedValue.ToString()));
                }
            }
            catch
            { }

            }
    }
}
