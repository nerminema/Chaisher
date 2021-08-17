namespace Chaisher
{
    partial class SuppliersByDay
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbl_end = new System.Windows.Forms.Label();
            this.lbl_start = new System.Windows.Forms.Label();
            this.cmb_supplier = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.txt_fri = new System.Windows.Forms.TextBox();
            this.txt_sat = new System.Windows.Forms.TextBox();
            this.txt_sun = new System.Windows.Forms.TextBox();
            this.txt_mon = new System.Windows.Forms.TextBox();
            this.txt_tus = new System.Windows.Forms.TextBox();
            this.txt_wed = new System.Windows.Forms.TextBox();
            this.txt_thur = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_Login);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_end);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_start);
            this.splitContainer1.Panel1.Controls.Add(this.cmb_supplier);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 93;
            this.splitContainer1.TabIndex = 0;
            // 
            // lbl_end
            // 
            this.lbl_end.AutoSize = true;
            this.lbl_end.Font = new System.Drawing.Font("Calibri", 12F);
            this.lbl_end.Location = new System.Drawing.Point(183, 47);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(49, 19);
            this.lbl_end.TabIndex = 2;
            this.lbl_end.Text = "label4";
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.Font = new System.Drawing.Font("Calibri", 12F);
            this.lbl_start.Location = new System.Drawing.Point(584, 47);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(49, 19);
            this.lbl_start.TabIndex = 2;
            this.lbl_start.Text = "label4";
            // 
            // cmb_supplier
            // 
            this.cmb_supplier.FormattingEnabled = true;
            this.cmb_supplier.Location = new System.Drawing.Point(383, 10);
            this.cmb_supplier.Name = "cmb_supplier";
            this.cmb_supplier.Size = new System.Drawing.Size(246, 21);
            this.cmb_supplier.TabIndex = 1;
            this.cmb_supplier.SelectedIndexChanged += new System.EventHandler(this.cmb_supplier_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F);
            this.label3.Location = new System.Drawing.Point(298, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "نهاية الإسبوع";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.label2.Location = new System.Drawing.Point(709, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "بداية الإسبوع";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F);
            this.label1.Location = new System.Drawing.Point(722, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "إختار مورد";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Font = new System.Drawing.Font("Calibri", 12F);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 353);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbl_Total);
            this.panel1.Controls.Add(this.txt_fri);
            this.panel1.Controls.Add(this.txt_sat);
            this.panel1.Controls.Add(this.txt_sun);
            this.panel1.Controls.Add(this.txt_mon);
            this.panel1.Controls.Add(this.txt_tus);
            this.panel1.Controls.Add(this.txt_wed);
            this.panel1.Controls.Add(this.txt_thur);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Calibri", 12F);
            this.panel1.Location = new System.Drawing.Point(629, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 353);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "إجمالي الفاتورة";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(80, 313);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(17, 19);
            this.lbl_Total.TabIndex = 3;
            this.lbl_Total.Text = "0";
            // 
            // txt_fri
            // 
            this.txt_fri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_fri.Location = new System.Drawing.Point(7, 240);
            this.txt_fri.Name = "txt_fri";
            this.txt_fri.Size = new System.Drawing.Size(164, 27);
            this.txt_fri.TabIndex = 2;
            this.txt_fri.Text = "الجمعة";
            this.txt_fri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_sat
            // 
            this.txt_sat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sat.Location = new System.Drawing.Point(6, 60);
            this.txt_sat.Name = "txt_sat";
            this.txt_sat.Size = new System.Drawing.Size(164, 27);
            this.txt_sat.TabIndex = 0;
            this.txt_sat.Text = "السبت";
            this.txt_sat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_sun
            // 
            this.txt_sun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sun.Location = new System.Drawing.Point(6, 90);
            this.txt_sun.Name = "txt_sun";
            this.txt_sun.Size = new System.Drawing.Size(164, 27);
            this.txt_sun.TabIndex = 1;
            this.txt_sun.Text = "الأحد";
            this.txt_sun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_mon
            // 
            this.txt_mon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_mon.Location = new System.Drawing.Point(6, 120);
            this.txt_mon.Name = "txt_mon";
            this.txt_mon.Size = new System.Drawing.Size(164, 27);
            this.txt_mon.TabIndex = 2;
            this.txt_mon.Text = "الأثنين";
            this.txt_mon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_tus
            // 
            this.txt_tus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tus.Location = new System.Drawing.Point(7, 150);
            this.txt_tus.Name = "txt_tus";
            this.txt_tus.Size = new System.Drawing.Size(164, 27);
            this.txt_tus.TabIndex = 2;
            this.txt_tus.Text = "الثلاثاء";
            this.txt_tus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_wed
            // 
            this.txt_wed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_wed.Location = new System.Drawing.Point(7, 180);
            this.txt_wed.Name = "txt_wed";
            this.txt_wed.Size = new System.Drawing.Size(164, 27);
            this.txt_wed.TabIndex = 2;
            this.txt_wed.Text = "الأربعاء";
            this.txt_wed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_thur
            // 
            this.txt_thur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_thur.Location = new System.Drawing.Point(7, 210);
            this.txt_thur.Name = "txt_thur";
            this.txt_thur.Size = new System.Drawing.Size(164, 27);
            this.txt_thur.TabIndex = 2;
            this.txt_thur.Text = "الخميس";
            this.txt_thur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Black;
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Image = global::Chaisher.Properties.Resources.if_save_1730911;
            this.btn_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Login.Location = new System.Drawing.Point(3, 47);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(118, 43);
            this.btn_Login.TabIndex = 9;
            this.btn_Login.Text = "حفظ";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Visible = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // SuppliersByDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SuppliersByDay";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "حسابات موردين";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_sun;
        private System.Windows.Forms.TextBox txt_sat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_fri;
        private System.Windows.Forms.TextBox txt_thur;
        private System.Windows.Forms.TextBox txt_wed;
        private System.Windows.Forms.TextBox txt_tus;
        private System.Windows.Forms.TextBox txt_mon;
        private System.Windows.Forms.ComboBox cmb_supplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_end;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Button btn_Login;
    }
}