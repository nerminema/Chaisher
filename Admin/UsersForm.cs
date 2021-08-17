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
    public partial class UsersForm : Form
    {
        Classes.UserClass users = new Classes.UserClass();
        public UsersForm()
        {
            InitializeComponent();
          dataGridView1.DataSource=  users.SelectUsers();

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            int prev = 0;
            try
            {
                if (btn_Login.Tag == null)
                {

                    if (checkBox1.Checked)
                        prev = 1;
                    users.InsertNewUser(txt_user.Text, txt_pass.Text, prev);
                }
                else
                {
                    if (checkBox1.Checked)
                        prev = 1;
                    users.UpdateNewUser(txt_user.Text, txt_pass.Text, prev, int.Parse(btn_Login.Tag.ToString()));
                }
                Clear();
            }
            catch
            {
                MessageBox.Show("اسم المستخدم موجود مسبقا");
            }
        }

        private void Clear()
        {
            dataGridView1.DataSource = users.SelectUsers();
            txt_user.Text = txt_pass.Text = "";
            btn_Login.Tag = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Column4"].FormattedValue.ToString());
            if(e.ColumnIndex== 0)
            {
              List<usp_SelectNewUserByID_Result> SelectUserByID=  users.SelectUsers(id);
                txt_user.Text = SelectUserByID[0].Username;
                txt_pass.Text = SelectUserByID[0].PAssword;
                int pre=(int )SelectUserByID[0].prevId;
                if (pre == 1)
                    checkBox1.Checked = true;
                btn_Login.Tag = id;

            }
            else if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("متاكد انك عايز تحذف المستخدم ده ؟", "رسالة تأكيد", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    users.DeleteUser(id);
                    dataGridView1.DataSource = users.SelectUsers();
                }
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
