namespace NearWeChat
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.img_qrcode_web = new System.Windows.Forms.PictureBox();
            this.tb_log = new System.Windows.Forms.TextBox();
            this.btn_login_pc = new System.Windows.Forms.Button();
            this.tb_62 = new System.Windows.Forms.TextBox();
            this.btn_login_62 = new System.Windows.Forms.Button();
            this.tb_usernmae = new System.Windows.Forms.TextBox();
            this.tb_userpwd = new System.Windows.Forms.TextBox();
            this.用户名 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login_account = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_login_web = new System.Windows.Forms.Button();
            this.image_qrcode_pc = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_qrcode_web)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_qrcode_pc)).BeginInit();
            this.SuspendLayout();
            // 
            // img_qrcode_web
            // 
            this.img_qrcode_web.Location = new System.Drawing.Point(12, 12);
            this.img_qrcode_web.Name = "img_qrcode_web";
            this.img_qrcode_web.Size = new System.Drawing.Size(223, 192);
            this.img_qrcode_web.TabIndex = 0;
            this.img_qrcode_web.TabStop = false;
            // 
            // tb_log
            // 
            this.tb_log.Location = new System.Drawing.Point(9, 20);
            this.tb_log.Multiline = true;
            this.tb_log.Name = "tb_log";
            this.tb_log.Size = new System.Drawing.Size(276, 379);
            this.tb_log.TabIndex = 1;
            // 
            // btn_login_pc
            // 
            this.btn_login_pc.Location = new System.Drawing.Point(249, 210);
            this.btn_login_pc.Name = "btn_login_pc";
            this.btn_login_pc.Size = new System.Drawing.Size(118, 34);
            this.btn_login_pc.TabIndex = 2;
            this.btn_login_pc.Text = "PC二维码登录";
            this.btn_login_pc.UseVisualStyleBackColor = true;
            this.btn_login_pc.Click += new System.EventHandler(this.btn_qrcode_login_Click);
            // 
            // tb_62
            // 
            this.tb_62.Location = new System.Drawing.Point(485, 12);
            this.tb_62.Multiline = true;
            this.tb_62.Name = "tb_62";
            this.tb_62.Size = new System.Drawing.Size(349, 192);
            this.tb_62.TabIndex = 3;
            // 
            // btn_login_62
            // 
            this.btn_login_62.Location = new System.Drawing.Point(485, 210);
            this.btn_login_62.Name = "btn_login_62";
            this.btn_login_62.Size = new System.Drawing.Size(81, 34);
            this.btn_login_62.TabIndex = 4;
            this.btn_login_62.Text = "62登录";
            this.btn_login_62.UseVisualStyleBackColor = true;
            // 
            // tb_usernmae
            // 
            this.tb_usernmae.Location = new System.Drawing.Point(57, 44);
            this.tb_usernmae.Multiline = true;
            this.tb_usernmae.Name = "tb_usernmae";
            this.tb_usernmae.Size = new System.Drawing.Size(198, 34);
            this.tb_usernmae.TabIndex = 5;
            // 
            // tb_userpwd
            // 
            this.tb_userpwd.Location = new System.Drawing.Point(57, 117);
            this.tb_userpwd.Multiline = true;
            this.tb_userpwd.Name = "tb_userpwd";
            this.tb_userpwd.Size = new System.Drawing.Size(198, 34);
            this.tb_userpwd.TabIndex = 6;
            // 
            // 用户名
            // 
            this.用户名.AutoSize = true;
            this.用户名.Location = new System.Drawing.Point(10, 52);
            this.用户名.Name = "用户名";
            this.用户名.Size = new System.Drawing.Size(41, 12);
            this.用户名.TabIndex = 7;
            this.用户名.Text = "用户名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "密  码";
            // 
            // btn_login_account
            // 
            this.btn_login_account.Location = new System.Drawing.Point(175, 168);
            this.btn_login_account.Name = "btn_login_account";
            this.btn_login_account.Size = new System.Drawing.Size(68, 34);
            this.btn_login_account.TabIndex = 9;
            this.btn_login_account.Text = "账户登录";
            this.btn_login_account.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_usernmae);
            this.groupBox1.Controls.Add(this.tb_userpwd);
            this.groupBox1.Controls.Add(this.btn_login_account);
            this.groupBox1.Controls.Add(this.用户名);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(852, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 226);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "账号密码";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_log);
            this.groupBox2.Location = new System.Drawing.Point(852, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 405);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loger";
            // 
            // btn_login_web
            // 
            this.btn_login_web.Location = new System.Drawing.Point(12, 210);
            this.btn_login_web.Name = "btn_login_web";
            this.btn_login_web.Size = new System.Drawing.Size(118, 34);
            this.btn_login_web.TabIndex = 13;
            this.btn_login_web.Text = "Web二维码登录";
            this.btn_login_web.UseVisualStyleBackColor = true;
            this.btn_login_web.Click += new System.EventHandler(this.Btn_login_web_Click);
            // 
            // image_qrcode_pc
            // 
            this.image_qrcode_pc.Location = new System.Drawing.Point(249, 12);
            this.image_qrcode_pc.Name = "image_qrcode_pc";
            this.image_qrcode_pc.Size = new System.Drawing.Size(223, 192);
            this.image_qrcode_pc.TabIndex = 12;
            this.image_qrcode_pc.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(812, 405);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "操 作";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 702);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_login_web);
            this.Controls.Add(this.image_qrcode_pc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_login_62);
            this.Controls.Add(this.tb_62);
            this.Controls.Add(this.btn_login_pc);
            this.Controls.Add(this.img_qrcode_web);
            this.Name = "Form1";
            this.Text = "NearWeChat";
            ((System.ComponentModel.ISupportInitialize)(this.img_qrcode_web)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_qrcode_pc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_qrcode_web;
        private System.Windows.Forms.TextBox tb_log;
        private System.Windows.Forms.Button btn_login_pc;
        private System.Windows.Forms.TextBox tb_62;
        private System.Windows.Forms.Button btn_login_62;
        private System.Windows.Forms.TextBox tb_usernmae;
        private System.Windows.Forms.TextBox tb_userpwd;
        private System.Windows.Forms.Label 用户名;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login_account;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_login_web;
        private System.Windows.Forms.PictureBox image_qrcode_pc;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

