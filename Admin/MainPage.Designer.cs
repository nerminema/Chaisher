
namespace Chaisher.Admin
{
    partial class MainPage
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.timer_basic = new System.Windows.Forms.Timer(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_BasicInfo = new System.Windows.Forms.Panel();
            this.btn_AddSeller = new System.Windows.Forms.Button();
            this.btn_AddClient = new System.Windows.Forms.Button();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.btn_basicBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_BasicInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1924, 1055);
            this.splitContainer1.SplitterDistance = 301;
            this.splitContainer1.TabIndex = 0;
            // 
            // timer_basic
            // 
            this.timer_basic.Interval = 15;
            this.timer_basic.Tick += new System.EventHandler(this.timer_basic_Tick);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.pnl_BasicInfo);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(301, 1055);
            this.splitContainer2.SplitterDistance = 72;
            this.splitContainer2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Chaisher.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_BasicInfo
            // 
            this.pnl_BasicInfo.Controls.Add(this.btn_AddSeller);
            this.pnl_BasicInfo.Controls.Add(this.btn_AddClient);
            this.pnl_BasicInfo.Controls.Add(this.btn_addProduct);
            this.pnl_BasicInfo.Controls.Add(this.btn_basicBtn);
            this.pnl_BasicInfo.Font = new System.Drawing.Font("Droid Arabic Kufi", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_BasicInfo.Location = new System.Drawing.Point(0, 0);
            this.pnl_BasicInfo.MaximumSize = new System.Drawing.Size(304, 330);
            this.pnl_BasicInfo.MinimumSize = new System.Drawing.Size(304, 57);
            this.pnl_BasicInfo.Name = "pnl_BasicInfo";
            this.pnl_BasicInfo.Size = new System.Drawing.Size(304, 58);
            this.pnl_BasicInfo.TabIndex = 11;
            // 
            // btn_AddSeller
            // 
            this.btn_AddSeller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(22)))), ((int)(((byte)(42)))));
            this.btn_AddSeller.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_AddSeller.FlatAppearance.BorderSize = 0;
            this.btn_AddSeller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddSeller.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F);
            this.btn_AddSeller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_AddSeller.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddSeller.Location = new System.Drawing.Point(0, 110);
            this.btn_AddSeller.Name = "btn_AddSeller";
            this.btn_AddSeller.Size = new System.Drawing.Size(304, 55);
            this.btn_AddSeller.TabIndex = 4;
            this.btn_AddSeller.Text = "إعدادات مطعم";
            this.btn_AddSeller.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddSeller.UseVisualStyleBackColor = false;
            // 
            // btn_AddClient
            // 
            this.btn_AddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(22)))), ((int)(((byte)(42)))));
            this.btn_AddClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AddClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_AddClient.FlatAppearance.BorderSize = 0;
            this.btn_AddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddClient.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F);
            this.btn_AddClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_AddClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddClient.Location = new System.Drawing.Point(0, 55);
            this.btn_AddClient.Name = "btn_AddClient";
            this.btn_AddClient.Size = new System.Drawing.Size(304, 55);
            this.btn_AddClient.TabIndex = 6;
            this.btn_AddClient.Text = "اصناف";
            this.btn_AddClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddClient.UseVisualStyleBackColor = false;
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(22)))), ((int)(((byte)(42)))));
            this.btn_addProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_addProduct.FlatAppearance.BorderSize = 0;
            this.btn_addProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addProduct.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_addProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addProduct.Location = new System.Drawing.Point(0, 0);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(304, 55);
            this.btn_addProduct.TabIndex = 3;
            this.btn_addProduct.Text = "فئات اصناف";
            this.btn_addProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addProduct.UseVisualStyleBackColor = false;
            // 
            // btn_basicBtn
            // 
            this.btn_basicBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_basicBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_basicBtn.FlatAppearance.BorderSize = 0;
            this.btn_basicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_basicBtn.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_basicBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_basicBtn.Image = global::Chaisher.Properties.Resources.Expand_Arrow_20px;
            this.btn_basicBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_basicBtn.Location = new System.Drawing.Point(0, 0);
            this.btn_basicBtn.Name = "btn_basicBtn";
            this.btn_basicBtn.Size = new System.Drawing.Size(304, 55);
            this.btn_basicBtn.TabIndex = 2;
            this.btn_basicBtn.Text = "بيانات أساسية";
            this.btn_basicBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_basicBtn.UseVisualStyleBackColor = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "MainPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_BasicInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Timer timer_basic;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_BasicInfo;
        private System.Windows.Forms.Button btn_AddSeller;
        private System.Windows.Forms.Button btn_AddClient;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.Button btn_basicBtn;
    }
}