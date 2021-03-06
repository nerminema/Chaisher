using Chaisher.Cashier;
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

namespace Chaisher
{
    public partial class Login : Form
    {
        int uid;
        public Login(int? id = null  )
        {
            InitializeComponent();
            if (id!= null)
            {
                btn_Login.Text = "تغيير كلمة السر ";
                btn_Login.Tag = id;
              txt_user.Text=  user.SelectUsers((int)id)[0].Username;
                txt_user.Focus();
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        Classes.UserClass user = new Classes.UserClass();
       
        ShiftClass shift = new ShiftClass();
        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_Login.Text == "تغيير كلمة السر ")
                {
                    int prev = 0;
                    user.UpdateNewUser(txt_user.Text, txt_pass.Text, prev, int.Parse(btn_Login.Tag.ToString()));
                    this.Hide();
                }
                else
                {
                    int id = (int)user.CheckLogin(txt_user.Text, txt_pass.Text);
                    if (id != 0)
                    {
                        int pre = (int)user.SelectUsers(id)[0].prevId;
                        if (pre == 1)
                        {
                            Start adminMain = new Start();

                            

                            adminMain.Show();
                            this.Hide();
                        }
                        else
                        {

                         int   _id = id;
                            int? _shiftid = shift.Select(_id);
                            if (_shiftid == null)
                            {
                                shift.InsertShift(DateTime.Now.TimeOfDay, null, _id);
                                _shiftid = shift.Select(_id);
                                int shiftID = (int)_shiftid;
                                Cashier.CashFlow f = new Cashier.CashFlow(shiftID, _id);


                                f.Show();
                                this.Hide();
                            }
                            else
                            {
                                Cashier.MainUser user = new MainUser(_id);
                                user.Show();
                                this.Hide();
                            }
                         
                        }
                    }
                    else
                    {
                        MessageBox.Show("اسم مستخدم او كلمة سر غير متطابقة");
                    }
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
