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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_basicBtn_Click(object sender, EventArgs e)
        {
            timer_basic.Start();
        }
        bool basicisCollapsed=true;
        private void timer_basic_Tick(object sender, EventArgs e)
        {
            if (basicisCollapsed)
            {

                btn_basicBtn
                .Image = Chaisher.Properties.Resources.Collapse_Arrow_20px;
                pnl_BasicInfo.Height += 10;
                if (pnl_BasicInfo.Size == pnl_BasicInfo.MaximumSize)
                {
                    timer_basic.Stop();
                    basicisCollapsed = false;
                }
            }
            else
            {
                btn_basicBtn.Image = Chaisher.Properties.Resources.Expand_Arrow_20px;
                pnl_BasicInfo.Height -= 10;
                if (pnl_BasicInfo.Size == pnl_BasicInfo.MinimumSize)
                {
                    timer_basic.Stop();
                    basicisCollapsed = true;
                }
            }
        }
    }
}
