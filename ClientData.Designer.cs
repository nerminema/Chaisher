namespace Chaisher
{
    partial class ClientData
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
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ClientName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txt_Phone = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_clientAddress = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(442, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "العنوان ";
            // 
            // cmb_Category
            // 
            this.cmb_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(27, 68);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Category.Size = new System.Drawing.Size(370, 32);
            this.cmb_Category.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "المنطقة ";
            // 
            // txt_ClientName
            // 
            this.txt_ClientName.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_ClientName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ClientName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_ClientName.BorderThickness = 3;
            this.txt_ClientName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_ClientName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_ClientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ClientName.isPassword = false;
            this.txt_ClientName.Location = new System.Drawing.Point(27, 151);
            this.txt_ClientName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ClientName.MaxLength = 32767;
            this.txt_ClientName.Name = "txt_ClientName";
            this.txt_ClientName.Size = new System.Drawing.Size(364, 44);
            this.txt_ClientName.TabIndex = 12;
            this.txt_ClientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "اسم العميل ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.linkLabel1.Location = new System.Drawing.Point(167, 115);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(93, 24);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "اضف المنطقة";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txt_Phone
            // 
            this.txt_Phone.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_Phone.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Phone.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_Phone.BorderThickness = 3;
            this.txt_Phone.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Phone.isPassword = false;
            this.txt_Phone.Location = new System.Drawing.Point(27, 15);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Phone.MaxLength = 32767;
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(370, 44);
            this.txt_Phone.TabIndex = 0;
            this.txt_Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Phone.OnValueChanged += new System.EventHandler(this.txt_Phone_OnValueChanged);
            this.txt_Phone.Leave += new System.EventHandler(this.bunifuMetroTextbox1_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(416, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "رقم التليفون ";
            // 
            // txt_clientAddress
            // 
            this.txt_clientAddress.Location = new System.Drawing.Point(27, 203);
            this.txt_clientAddress.Multiline = true;
            this.txt_clientAddress.Name = "txt_clientAddress";
            this.txt_clientAddress.Size = new System.Drawing.Size(364, 142);
            this.txt_clientAddress.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Chaisher.Properties.Resources.if_6___Cross_1815573;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(27, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 31);
            this.button1.TabIndex = 22;
            this.button1.Text = "إلغاء";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(278, 353);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(113, 31);
            this.btn_Login.TabIndex = 23;
            this.btn_Login.Text = "حفظ";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // ClientData
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(512, 450);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_clientAddress);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_Category);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ClientName);
            this.Controls.Add(this.label1);
            this.Name = "ClientData";
            this.Text = "بيانات العميل ";
            this.Load += new System.EventHandler(this.ClientData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_ClientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_clientAddress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Login;
    }
}