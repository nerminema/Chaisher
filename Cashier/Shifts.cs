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
    public partial class Shifts : Form
    {
        public Shifts()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ShiftSettings.SelectAll();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dt_Out_ValueChanged(object sender, EventArgs e)
        {
            double xx = (dt_Out.Value.TimeOfDay - dt_In.Value.TimeOfDay).TotalMinutes / 60;
            double duration = Math.Round(xx, 1);
            txt_Hours.Text =duration.ToString();
        }
        Classes.ShiftSettingsClass ShiftSettings = new Classes.ShiftSettingsClass();
        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_ShiftName.Text != "" && txt_ShiftName.Tag == null)
            {
                ShiftSettings.Insert(txt_ShiftName.Text, dt_In.Value.TimeOfDay, dt_Out.Value.TimeOfDay);
            }
            else if (txt_ShiftName.Tag!= null)
            {
                ShiftSettings.Update(txt_ShiftName.Text, dt_In.Value.TimeOfDay, dt_Out.Value.TimeOfDay ,int.Parse(txt_ShiftName.Tag.ToString()) );
            }
            txt_ShiftName.Text = txt_Hours.Text = "";
            txt_ShiftName.Tag = "";
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ShiftSettings.SelectAll();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_ShiftName.Text = txt_Hours.Text = "";
            txt_ShiftName.Tag = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            if(e.ColumnIndex ==0 )
            {
                List<usp_SelectAllShiftSettingsByID_Result> all=ShiftSettings.SelectAll(ID);
                txt_ShiftName.Text = all[0].ShiftName;
                txt_ShiftName.Tag = all[0].ID;
                TimeSpan span = (TimeSpan)all[0].ShiftStart;
                TimeSpan espan = (TimeSpan)all[0].ShiftEnd;
                dt_In.Value =new DateTime(2021,08,24 , span.Hours , span.Minutes , span.Seconds); 
                dt_Out.Value=new DateTime(2021,08,24 , espan.Hours , espan.Minutes , espan.Seconds);
            }
            else if(e.ColumnIndex ==1)
            {

            }
        }

        private void Shifts_FormClosing(object sender, FormClosingEventArgs e)
        {
            ComboBox cmb_Shifts = this.Owner.Controls.Find("cmb_Shifts", true).First() as ComboBox ;
            cmb_Shifts.DataSource =ShiftSettings.SelectAll();
            cmb_Shifts.DisplayMember = "ShiftName";
            cmb_Shifts.ValueMember = "ID";
        }
    }
}
