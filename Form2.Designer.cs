
namespace Project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.dataproduct = new System.Windows.Forms.DataGridView();
            this.addbasket = new System.Windows.Forms.Button();
            this.numproduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.เมนToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ประวตการสงซอสนคาToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ออกจากโปรแกรมToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.อปกรณเบเกอรToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ดสนคาในToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataproduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("French Script MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "รายการสินค้า";
            // 
            // dataproduct
            // 
            this.dataproduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataproduct.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataproduct.Location = new System.Drawing.Point(77, 123);
            this.dataproduct.Name = "dataproduct";
            this.dataproduct.RowHeadersWidth = 51;
            this.dataproduct.RowTemplate.Height = 24;
            this.dataproduct.Size = new System.Drawing.Size(453, 375);
            this.dataproduct.TabIndex = 1;
            this.dataproduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataproduct_CellClick);
            // 
            // addbasket
            // 
            this.addbasket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addbasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.addbasket.ForeColor = System.Drawing.Color.Black;
            this.addbasket.Location = new System.Drawing.Point(439, 539);
            this.addbasket.Name = "addbasket";
            this.addbasket.Size = new System.Drawing.Size(190, 46);
            this.addbasket.TabIndex = 5;
            this.addbasket.Text = "เพิ่มสินค้าลงในตะกร้า";
            this.addbasket.UseVisualStyleBackColor = false;
            this.addbasket.Click += new System.EventHandler(this.addbasket_Click);
            // 
            // numproduct
            // 
            this.numproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.numproduct.Location = new System.Drawing.Point(287, 539);
            this.numproduct.Name = "numproduct";
            this.numproduct.Size = new System.Drawing.Size(116, 38);
            this.numproduct.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Forte", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 548);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "จำนวนสินค้า";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(775, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 375);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.เมนToolStripMenuItem,
            this.ประวตการสงซอสนคาToolStripMenuItem,
            this.ดสนคาในToolStripMenuItem,
            this.ออกจากโปรแกรมToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1210, 28);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // เมนToolStripMenuItem
            // 
            this.เมนToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.อปกรณเบเกอรToolStripMenuItem});
            this.เมนToolStripMenuItem.Name = "เมนToolStripMenuItem";
            this.เมนToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.เมนToolStripMenuItem.Text = "ประเภทรายการสินค้า";
            
            // 
            // ประวตการสงซอสนคาToolStripMenuItem
            // 
            this.ประวตการสงซอสนคาToolStripMenuItem.Name = "ประวตการสงซอสนคาToolStripMenuItem";
            this.ประวตการสงซอสนคาToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.ประวตการสงซอสนคาToolStripMenuItem.Text = "ประวัติการสั่งซื้อสินค้า";
            this.ประวตการสงซอสนคาToolStripMenuItem.Click += new System.EventHandler(this.ประวตการสงซอสนคาToolStripMenuItem_Click);
            // 
            // ออกจากโปรแกรมToolStripMenuItem
            // 
            this.ออกจากโปรแกรมToolStripMenuItem.Name = "ออกจากโปรแกรมToolStripMenuItem";
            this.ออกจากโปรแกรมToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.ออกจากโปรแกรมToolStripMenuItem.Text = "ออกจากโปรแกรม";
            this.ออกจากโปรแกรมToolStripMenuItem.Click += new System.EventHandler(this.ออกจากโปรแกรมToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem1.Text = "วัตถุดิบ";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // อปกรณเบเกอรToolStripMenuItem
            // 
            this.อปกรณเบเกอรToolStripMenuItem.Name = "อปกรณเบเกอรToolStripMenuItem";
            this.อปกรณเบเกอรToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.อปกรณเบเกอรToolStripMenuItem.Text = "อุปกรณ์เบเกอรี่";
            this.อปกรณเบเกอรToolStripMenuItem.Click += new System.EventHandler(this.อปกรณเบเกอรToolStripMenuItem_Click);
            // 
            // ดสนคาในToolStripMenuItem
            // 
            this.ดสนคาในToolStripMenuItem.Name = "ดสนคาในToolStripMenuItem";
            this.ดสนคาในToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.ดสนคาในToolStripMenuItem.Text = "ดูสินค้าในตะกร้า";
            this.ดสนคาในToolStripMenuItem.Click += new System.EventHandler(this.ดสนคาในToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1210, 726);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numproduct);
            this.Controls.Add(this.addbasket);
            this.Controls.Add(this.dataproduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ร้านปังหลายรส ขนมเที่ยงคืน";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            
            ((System.ComponentModel.ISupportInitialize)(this.dataproduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataproduct;
        private System.Windows.Forms.Button addbasket;
        private System.Windows.Forms.TextBox numproduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem เมนToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ประวตการสงซอสนคาToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ออกจากโปรแกรมToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem อปกรณเบเกอรToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ดสนคาในToolStripMenuItem;
    }
}