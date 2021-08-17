namespace Chaisher
{
    partial class Expences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expences));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_actual = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Login = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dt_from = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_exp = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_exp);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_actual);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_Login);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dt_from);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 287);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(736, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 27);
            this.label6.TabIndex = 45;
            this.label6.Text = "المبلغ ";
            // 
            // txt_actual
            // 
            this.txt_actual.Location = new System.Drawing.Point(298, 78);
            this.txt_actual.Name = "txt_actual";
            this.txt_actual.Size = new System.Drawing.Size(300, 35);
            this.txt_actual.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Chaisher.Properties.Resources.if_6___Cross_1815573;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(22, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 31);
            this.button1.TabIndex = 43;
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
            this.btn_Login.Location = new System.Drawing.Point(201, 219);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Normalcolor = System.Drawing.Color.White;
            this.btn_Login.OnHovercolor = System.Drawing.Color.White;
            this.btn_Login.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(159)))), ((int)(((byte)(217)))));
            this.btn_Login.selected = true;
            this.btn_Login.Size = new System.Drawing.Size(116, 31);
            this.btn_Login.TabIndex = 42;
            this.btn_Login.Text = "حفظ";
            this.btn_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Login.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btn_Login.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // dt_from
            // 
            this.dt_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_from.Location = new System.Drawing.Point(298, 36);
            this.dt_from.Name = "dt_from";
            this.dt_from.Size = new System.Drawing.Size(300, 35);
            this.dt_from.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(735, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 27);
            this.label2.TabIndex = 40;
            this.label2.Text = "التاريخ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(678, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 27);
            this.label1.TabIndex = 47;
            this.label1.Text = "بيان المصروفات";
            // 
            // txt_exp
            // 
            this.txt_exp.Location = new System.Drawing.Point(12, 119);
            this.txt_exp.Multiline = true;
            this.txt_exp.Name = "txt_exp";
            this.txt_exp.Size = new System.Drawing.Size(586, 77);
            this.txt_exp.TabIndex = 46;
            // 
            // Expences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 287);
            this.Controls.Add(this.panel1);
            this.Name = "Expences";
            this.Text = "المصروفات";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_actual;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Login;
        private System.Windows.Forms.DateTimePicker dt_from;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_exp;
    }
}