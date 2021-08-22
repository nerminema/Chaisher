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

namespace Chaisher.Cashier
{
    public partial class CashFlow : Form
    {
        int _shiftID;
        int _userID;
        public CashFlow(int shiftId , int userID)
        {
            InitializeComponent();
            _shiftID = shiftId;
            _userID = userID;
        }
        UserClass user = new UserClass();
        ShiftClass shift = new ShiftClass();
        private void CashFlow_KeyDown(object sender, KeyEventArgs e)
        {
            

        }

        private void CashFlow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {

            }
        }

        Classes.RequestedOrderClass requested = new Classes.RequestedOrderClass();
        Classes.ReqestedORderDetails details = new ReqestedORderDetails();
        private void button1_Click(object sender, EventArgs e)
        {
            string orderID  =requested.InsertRequestedOrder(DateTime.Now.Date, null, DateTime.Now.TimeOfDay, "", _userID, _shiftID).ToString();
            details.InsertRequestedORderDetails(int.Parse(orderID), _userID, 1, decimal.Parse( textBox1.Text),"Start balance");
            Cashier.MainUser user = new MainUser(_userID);
            user.Show();
            this.Hide();

        }
    }
}
