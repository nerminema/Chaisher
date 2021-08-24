
namespace Chaisher.Cashier
{
    partial class StaffBooking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffBooking));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_booking = new Chaisher.Classes.RoundButton();
            this.btn_hours = new Chaisher.Classes.RoundButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_booking);
            this.panel1.Controls.Add(this.btn_hours);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btn_booking
            // 
            this.btn_booking.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_booking.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_booking, "btn_booking");
            this.btn_booking.ForeColor = System.Drawing.Color.White;
            this.btn_booking.Name = "btn_booking";
            this.btn_booking.UseVisualStyleBackColor = false;
            this.btn_booking.Click += new System.EventHandler(this.btn_booking_Click);
            // 
            // btn_hours
            // 
            this.btn_hours.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_hours.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_hours, "btn_hours");
            this.btn_hours.ForeColor = System.Drawing.Color.White;
            this.btn_hours.Name = "btn_hours";
            this.btn_hours.UseVisualStyleBackColor = false;
            this.btn_hours.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // StaffBooking
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "StaffBooking";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Classes.RoundButton btn_hours;
        private Classes.RoundButton btn_booking;
    }
}