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
    public partial class ClientData : Form
    {
        Classes.DistrictClass  district = new Classes.DistrictClass();
        int _id;
        int shiftID;
        public ClientData(int id , int _shiftID)
        {
            InitializeComponent();
            _id = id;
            shiftID = _shiftID;
            cmb_Category.DataSource = district.SelectAll();
            cmb_Category.DisplayMember = "DistrictName";
            cmb_Category.ValueMember = "ID";
            cmb_Category.SelectedIndex = -1;
            txt_Phone.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            District d = new District();
            d.Show(this);
        }
        Classes.ClientsClass Clients = new Classes.ClientsClass();
        private void bunifuMetroTextbox1_Leave(object sender, EventArgs e)
        {
            // check Client data 
          List<usp_SelectAllClientsByPhone_Result> clientByPhone=  Clients.SelectAllClientByPhone(txt_Phone.Text);
          if (clientByPhone.Count>0)
          {
                try
                {
                   
                    txt_ClientName.Text = clientByPhone[0].ClientName;
                    txt_clientAddress.Text = clientByPhone[0].ClientAddress;
                    btn_Login.Text = "تعديل البيانات";
                    btn_Login.Tag = clientByPhone[0].ID;
                    cmb_Category.SelectedValue = (int)clientByPhone[0].DistrictID;
                }
                catch
                {

                }

          }
          else 
          {

          }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
         if(btn_Login.Tag == null)
         {
                Clients.InsertClient(txt_ClientName.Text, txt_Phone.Text, txt_clientAddress.Text , int.Parse(cmb_Category.SelectedValue.ToString()));
                btn_Login.Tag=Clients.SelectMaxClient();
         }
         else 
         {
                Clients.UpdateClient(int.Parse(btn_Login.Tag.ToString()), txt_ClientName.Text, txt_Phone.Text, txt_clientAddress.Text , int.Parse(cmb_Category.SelectedValue.ToString()));
         }
            Label lbl_ClientName = this.Owner.Controls.Find("lbl_ClientName", true).First() as Label;
            TextBox txt_bar = this.Owner.Controls.Find("txt_bar", true).First() as TextBox;
            Button btn_Pre = this.Owner.Controls.Find("btn_Pre", true).First() as Button;
            btn_Pre.Visible = true;
            lbl_ClientName.Text = txt_ClientName.Text;
            lbl_ClientName.Tag = btn_Login.Tag;
            Label lbl_orderNo = this.Owner.Controls.Find("lbl_orderNo", true).First() as Label;
            lbl_orderNo.Text =  requested.InsertRequestedOrder(DateTime.Now.Date, int.Parse(btn_Login.Tag.ToString()), DateTime.Now.TimeOfDay , "",_id, shiftID).ToString();
            txt_clientAddress.Text = txt_ClientName.Text = txt_Phone.Text = "";
            //requested.SelectRequested().Max().ID.ToString();
            txt_bar.Focus();
           this.Hide();
        }
        Classes.RequestedOrderClass requested = new Classes.RequestedOrderClass();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClientData_Load(object sender, EventArgs e)
        {

        }

        private void txt_Phone_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
