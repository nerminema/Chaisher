namespace Chaisher
{
    partial class EmployeeInOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeInOut));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_employee = new System.Windows.Forms.ComboBox();
            this.dt_inTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_outTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_orderDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Login = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_Login);
            this.panel1.Controls.Add(this.txt_cal);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dt_orderDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dt_outTime);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dt_inTime);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmb_employee);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 268);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الموظف";
            // 
            // cmb_employee
            // 
            this.cmb_employee.FormattingEnabled = true;
            this.cmb_employee.Location = new System.Drawing.Point(9, 6);
            this.cmb_employee.Name = "cmb_employee";
            this.cmb_employee.Size = new System.Drawing.Size(300, 35);
            this.cmb_employee.TabIndex = 11;
            // 
            // dt_inTime
            // 
            this.dt_inTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_inTime.Location = new System.Drawing.Point(9, 47);
            this.dt_inTime.Name = "dt_inTime";
            this.dt_inTime.Size = new System.Drawing.Size(300, 35);
            this.dt_inTime.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "حضور";
            // 
            // dt_outTime
            // 
            this.dt_outTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_outTime.Location = new System.Drawing.Point(9, 88);
            this.dt_outTime.Name = "dt_outTime";
            this.dt_outTime.Size = new System.Drawing.Size(300, 35);
            this.dt_outTime.TabIndex = 15;
            this.dt_outTime.ValueChanged += new System.EventHandler(this.dt_outTime_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 27);
            this.label2.TabIndex = 14;
            this.label2.Text = "انصراف";
            // 
            // dt_orderDate
            // 
            this.dt_orderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_orderDate.Location = new System.Drawing.Point(9, 128);
            this.dt_orderDate.Name = "dt_orderDate";
            this.dt_orderDate.Size = new System.Drawing.Size(300, 35);
            this.dt_orderDate.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 27);
            this.label3.TabIndex = 16;
            this.label3.Text = "التاريخ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 27);
            this.label5.TabIndex = 18;
            this.label5.Text = "عدد الساعات";
            // 
            // txt_cal
            // 
            this.txt_cal.Location = new System.Drawing.Point(9, 169);
            this.txt_cal.Name = "txt_cal";
            this.txt_cal.Size = new System.Drawing.Size(300, 35);
            this.txt_cal.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Chaisher.Properties.Resources.if_6___Cross_1815573;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(14, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 31);
            this.button1.TabIndex = 36;
            this.button1.Text = "إلغاء";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_Login
            // 
            this.btn_Login.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.btn_Login.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Login.BorderRadius = 7;
            this.btn_Login.ButtonText = "حفظ";
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(209)))), ((int)(((byte)(54)))));
            this.btn_Login.Font = new System.Drawing.Font("Amin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(209)))), ((int)(((byte)(54)))));
            this.btn_Login.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Login.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Login.Iconimage")));
            this.btn_Login.Iconimage_right = null;
            this.btn_Login.Iconimage_right_Selected = null;
            this.btn_Login.Iconimage_Selected = null;
            this.btn_Login.IconMarginLeft = 0;
            this.btn_Login.IconMarginRight = 0;
            this.btn_Login.IconRightVisible = false;
            this.btn_Login.IconRightZoom = 0D;
            this.btn_Login.IconVisible = false;
            this.btn_Login.IconZoom = 90D;
            this.btn_Login.IsTab = true;
            this.btn_Login.Location = new System.Drawing.Point(193, 223);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Normalcolor = System.Drawing.Color.White;
            this.btn_Login.OnHovercolor = System.Drawing.Color.White;
            this.btn_Login.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(159)))), ((int)(((byte)(217)))));
            this.btn_Login.selected = true;
            this.btn_Login.Size = new System.Drawing.Size(116, 31);
            this.btn_Login.TabIndex = 35;
            this.btn_Login.Text = "حفظ";
            this.btn_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Login.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btn_Login.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // EmployeeInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 268);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeInOut";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "حضور و انصراف الموظفين";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_employee;
        private System.Windows.Forms.DateTimePicker dt_outTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_inTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dt_orderDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Login;
    }
}