using Chaisher.Properties;
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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            Cashier.MainUser main = new Cashier.MainUser();
            main.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSecond.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MMM dd yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");
            lblSecond.Location = new Point(lblTime.Location.X + lblTime.Width - 5, lblSecond.Location.Y);

        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            // Accounting
            timer_basic.Start();
        }

        bool basicisCollapsed = true;
        private void timer_basic_Tick(object sender, EventArgs e)
        {

            if (basicisCollapsed)
            {

                btn_basicBtn
                .Image = Resources.Collapse_Arrow_20px;
                pnl_BasicInfo.Height += 10;
                if (pnl_BasicInfo.Size == pnl_BasicInfo.MaximumSize)
                {
                    timer_basic.Stop();
                    basicisCollapsed = false;
                }
            }
            else
            {
                btn_basicBtn.Image = Resources.Expand_Arrow_20px;
                pnl_BasicInfo.Height -= 10;
                if (pnl_BasicInfo.Size.Height <= pnl_BasicInfo.MinimumSize.Height)
                {
                    timer_basic.Stop();
                    basicisCollapsed = true;
                }
            }
        }

        private void btn_basicBtn_Click(object sender, EventArgs e)
        {
            timer_basic.Start();
        }

        private void btn_Journalminne_Click(object sender, EventArgs e)
        {
            Accounting.ChangeDate change = new Accounting.ChangeDate();
            change.Show();
        }

        private void btn_catgory_Click(object sender, EventArgs e)
        {
            Admin.Category cat = new Admin.Category();
            cat.Show();
        }

        private void timer_Product_Tick(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {

        }
    }
}
