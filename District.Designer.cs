namespace Chaisher
{
    partial class District
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(District));
            this.txt_Productname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Login = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Productname
            // 
            this.txt_Productname.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_Productname.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Productname.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_Productname.BorderThickness = 3;
            this.txt_Productname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Productname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_Productname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Productname.isPassword = false;
            this.txt_Productname.Location = new System.Drawing.Point(12, 12);
            this.txt_Productname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Productname.Name = "txt_Productname";
            this.txt_Productname.Size = new System.Drawing.Size(370, 44);
            this.txt_Productname.TabIndex = 14;
            this.txt_Productname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "اسم الصنف";
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
            this.btn_Login.Location = new System.Drawing.Point(266, 65);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Normalcolor = System.Drawing.Color.White;
            this.btn_Login.OnHovercolor = System.Drawing.Color.White;
            this.btn_Login.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(159)))), ((int)(((byte)(217)))));
            this.btn_Login.selected = true;
            this.btn_Login.Size = new System.Drawing.Size(116, 31);
            this.btn_Login.TabIndex = 15;
            this.btn_Login.Text = "حفظ";
            this.btn_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Login.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btn_Login.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Chaisher.Properties.Resources.if_6___Cross_1815573;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(12, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 31);
            this.button1.TabIndex = 16;
            this.button1.Text = "إلغاء";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // District
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(497, 123);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Productname);
            this.Controls.Add(this.label1);
            this.Name = "District";
            this.Text = "District";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.District_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Productname;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Login;
        private System.Windows.Forms.Button button1;
    }
}