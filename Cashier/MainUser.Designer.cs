
namespace Chaisher.Cashier
{
    partial class MainUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dg_order = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_OrderTotal = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbl_Cat = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_cat = new System.Windows.Forms.Panel();
            this.lbl_orderNo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_Product = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_AddQnty = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.roundButton2 = new Chaisher.Classes.RoundButton();
            this.roundButton1 = new Chaisher.Classes.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_order)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tbl_Cat.SuspendLayout();
            this.pnl_cat.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_Product.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            resources.ApplyResources(this.splitContainer2, "splitContainer2");
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dg_order);
            resources.ApplyResources(this.splitContainer2.Panel1, "splitContainer2.Panel1");
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel1);
            // 
            // dg_order
            // 
            this.dg_order.AllowUserToAddRows = false;
            this.dg_order.BackgroundColor = System.Drawing.Color.White;
            this.dg_order.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dg_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_order.ColumnHeadersVisible = false;
            this.dg_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column2,
            this.Column3,
            this.Column1});
            resources.ApplyResources(this.dg_order, "dg_order");
            this.dg_order.Name = "dg_order";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_order.RowsDefaultCellStyle = dataGridViewCellStyle3;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ID";
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Qunatity";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Price";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ProductName";
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.button3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button5, 3, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel4);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.lbl_Total, 1, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // lbl_Total
            // 
            resources.ApplyResources(this.lbl_Total, "lbl_Total");
            this.lbl_Total.Name = "lbl_Total";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.btn_AddQnty, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_sub, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.txt_OrderTotal, 1, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // txt_OrderTotal
            // 
            resources.ApplyResources(this.txt_OrderTotal, "txt_OrderTotal");
            this.txt_OrderTotal.Name = "txt_OrderTotal";
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbl_Cat);
            // 
            // tbl_Cat
            // 
            resources.ApplyResources(this.tbl_Cat, "tbl_Cat");
            this.tbl_Cat.Controls.Add(this.pnl_cat, 0, 0);
            this.tbl_Cat.Controls.Add(this.pnl_Product, 1, 0);
            this.tbl_Cat.Name = "tbl_Cat";
            // 
            // pnl_cat
            // 
            resources.ApplyResources(this.pnl_cat, "pnl_cat");
            this.pnl_cat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.pnl_cat.Controls.Add(this.lbl_orderNo);
            this.pnl_cat.Controls.Add(this.panel1);
            this.pnl_cat.Name = "pnl_cat";
            // 
            // lbl_orderNo
            // 
            resources.ApplyResources(this.lbl_orderNo, "lbl_orderNo");
            this.lbl_orderNo.Name = "lbl_orderNo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.roundButton2);
            this.panel1.Controls.Add(this.roundButton1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // pnl_Product
            // 
            this.pnl_Product.Controls.Add(this.panel2);
            resources.ApplyResources(this.pnl_Product, "pnl_Product");
            this.pnl_Product.Name = "pnl_Product";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Chaisher.Properties.Resources._4243325_users_people_icon;
            resources.ApplyResources(this.button3, "button3");
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Chaisher.Properties.Resources.calc;
            resources.ApplyResources(this.button4, "button4");
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::Chaisher.Properties.Resources.Chaisher1;
            resources.ApplyResources(this.button5, "button5");
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btn_AddQnty
            // 
            this.btn_AddQnty.BackgroundImage = global::Chaisher.Properties.Resources.add1;
            resources.ApplyResources(this.btn_AddQnty, "btn_AddQnty");
            this.btn_AddQnty.FlatAppearance.BorderSize = 0;
            this.btn_AddQnty.Name = "btn_AddQnty";
            this.btn_AddQnty.UseVisualStyleBackColor = true;
            // 
            // btn_sub
            // 
            resources.ApplyResources(this.btn_sub, "btn_sub");
            this.btn_sub.BackgroundImage = global::Chaisher.Properties.Resources.sub;
            this.btn_sub.FlatAppearance.BorderSize = 0;
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.UseVisualStyleBackColor = true;
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(225)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.roundButton2, "roundButton2");
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.ForeColor = System.Drawing.Color.White;
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.UseVisualStyleBackColor = false;
            this.roundButton2.Click += new System.EventHandler(this.roundButton2_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.roundButton1, "roundButton1");
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // MainUser
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainUser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_order)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tbl_Cat.ResumeLayout(false);
            this.pnl_cat.ResumeLayout(false);
            this.pnl_cat.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnl_Product.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_AddQnty;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.DataGridView dg_order;
        private System.Windows.Forms.TextBox txt_OrderTotal;
        private System.Windows.Forms.TableLayoutPanel tbl_Cat;
        private System.Windows.Forms.Panel pnl_cat;
        private System.Windows.Forms.Panel pnl_Product;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_orderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private Classes.RoundButton roundButton2;
        private Classes.RoundButton roundButton1;
        private System.Windows.Forms.Panel panel2;
    }
}