using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chaisher
{
    public partial class AttendByCode : Form
    {
        public AttendByCode()
        {
            InitializeComponent();
        }
        Classes.EmployeeClass emp = new Classes.EmployeeClass();
        Classes.EmployeeTimeAttanceClass atte = new Classes.EmployeeTimeAttanceClass();
        private void txt_EmployeeID_TextChanged(object sender, EventArgs e)
        {
            if(txt_EmployeeID.Text!="")
            {
               lbl_EmployeeName.Text = emp.SelectAllEmployee(int.Parse(txt_EmployeeID.Text))[0].EmployeeName;
               List<usp_SelectEmployeeAttedance_Result> attEmp = atte.SelectAll(int.Parse(txt_EmployeeID.Text), DateTime.Now.Date, DateTime.Now.Date);
                if (attEmp.Count == 0)
                    txt_att.Text = DateTime.Now.TimeOfDay.ToString();
                // atte.Insert(int.Parse(txt_EmployeeID.Text), DateTime.Now.TimeOfDay, null, null, DateTime.Now, 0);
                else
                {
                    txt_att.Text = attEmp[0].Intime.ToString();
                    txt_leave.Text = attEmp[0].OutTime.ToString();
                    if (txt_leave.Text == "")
                        txt_leave.Text = DateTime.Now.TimeOfDay.ToString();
                 //   atte.Update(int.Parse(txt_EmployeeID.Text), (TimeSpan)attEmp[0].Intime, DateTime.Now.TimeOfDay, (decimal)(DateTime.Now.TimeOfDay - (TimeSpan)attEmp[0].Intime).TotalHours, DateTime.Now, attEmp[0].ID);
                }
            }
        }

        private void txt_EmployeeID_KeyPress(object sender, KeyPressEventArgs e)
        {
           bool IsNumberOrBackSpace = false;
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                IsNumberOrBackSpace = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_EmployeeID.Text != "")
            {
                List<usp_SelectEmployeeAttedance_Result> attEmp = atte.SelectAll(int.Parse(txt_EmployeeID.Text), DateTime.Now.Date, DateTime.Now.Date);
                if (attEmp.Count == 0)
                    atte.Insert(int.Parse(txt_EmployeeID.Text), DateTime.Now.TimeOfDay, null, null, DateTime.Now, 0);
                else
                {
                    atte.Update(int.Parse(txt_EmployeeID.Text), (TimeSpan)attEmp[0].Intime, DateTime.Now.TimeOfDay, (decimal)(DateTime.Now.TimeOfDay - (TimeSpan)attEmp[0].Intime).TotalHours, DateTime.Now, attEmp[0].ID);
                }
              
                using (SpeechSynthesizer synth = new SpeechSynthesizer())
                {

                    // Configure the audio output.   
                    synth.SetOutputToDefaultAudioDevice();

                    // Create a prompt from a string.  
                    Prompt color = new Prompt("thank you No " + txt_EmployeeID.Text);

                    // Speak the contents of the prompt synchronously.  
                    synth.Speak(color);
                }
                txt_EmployeeID.Text = lbl_EmployeeName.Text = txt_att.Text = txt_leave.Text = "";
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
