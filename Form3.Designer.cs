
namespace Project
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bot1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tell = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(195, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "สมัครสมาชิก";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(85, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ชื่อ-สกุล";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(165, 115);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(137, 22);
            this.name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(85, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "ชื่อผู้ใช้";
            // 
            // userl
            // 
            this.userl.Location = new System.Drawing.Point(165, 176);
            this.userl.Name = "userl";
            this.userl.Size = new System.Drawing.Size(137, 22);
            this.userl.TabIndex = 4;
            this.userl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userl_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(85, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "รหัสผ่าน ";
            // 
            // passl
            // 
            this.passl.Location = new System.Drawing.Point(165, 204);
            this.passl.MaxLength = 10;
            this.passl.Name = "passl";
            this.passl.Size = new System.Drawing.Size(137, 22);
            this.passl.TabIndex = 50;
            this.passl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passl_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Forte", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(57, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "สร้างบัญชีผู้ใช้";
            // 
            // bot1
            // 
            this.bot1.Location = new System.Drawing.Point(158, 247);
            this.bot1.Name = "bot1";
            this.bot1.Size = new System.Drawing.Size(144, 41);
            this.bot1.TabIndex = 8;
            this.bot1.Text = "ยืนยัน";
            this.bot1.UseVisualStyleBackColor = true;
            this.bot1.Click += new System.EventHandler(this.bot1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(85, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "เบอร์โทร";
            // 
            // tell
            // 
            this.tell.Location = new System.Drawing.Point(165, 146);
            this.tell.MaxLength = 10;
            this.tell.Name = "tell";
            this.tell.Size = new System.Drawing.Size(137, 22);
            this.tell.TabIndex = 10;
            this.tell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tell_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "เข้าสู่ระบบ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(308, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 17);
            this.label7.TabIndex = 51;
            this.label7.Text = " (เป็นอักขระภาษาอังกฤษหรือตัวเลขเท่านั้น)";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(599, 394);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tell);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bot1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "สมัครสมาชิก";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bot1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tell;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
    }
}