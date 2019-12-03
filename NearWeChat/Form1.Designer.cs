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
            this.btn_login_account_IOS = new System.Windows.Forms.Button();
            this.btn_login_web = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_friend_list = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_add_friend = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_login_Ipad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.用户名 = new System.Windows.Forms.Label();
            this.tb_userpwd = new System.Windows.Forms.TextBox();
            this.tb_usernmae = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_login_mac = new System.Windows.Forms.Button();
            this.btn_login_account_Android = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_qrcode_web)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // img_qrcode_web
            // 
            this.img_qrcode_web.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.img_qrcode_web.Location = new System.Drawing.Point(12, 12);
            this.img_qrcode_web.Name = "img_qrcode_web";
            this.img_qrcode_web.Size = new System.Drawing.Size(277, 241);
            this.img_qrcode_web.TabIndex = 0;
            this.img_qrcode_web.TabStop = false;
            // 
            // tb_log
            // 
            this.tb_log.Location = new System.Drawing.Point(12, 566);
            this.tb_log.Multiline = true;
            this.tb_log.Name = "tb_log";
            this.tb_log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_log.Size = new System.Drawing.Size(1138, 231);
            this.tb_log.TabIndex = 1;
            // 
            // btn_login_pc
            // 
            this.btn_login_pc.Location = new System.Drawing.Point(896, 198);
            this.btn_login_pc.Name = "btn_login_pc";
            this.btn_login_pc.Size = new System.Drawing.Size(228, 34);
            this.btn_login_pc.TabIndex = 2;
            this.btn_login_pc.Text = "Windows-PC二维码登录";
            this.btn_login_pc.UseVisualStyleBackColor = true;
            // 
            // tb_62
            // 
            this.tb_62.Location = new System.Drawing.Point(368, 12);
            this.tb_62.Multiline = true;
            this.tb_62.Name = "tb_62";
            this.tb_62.Size = new System.Drawing.Size(235, 155);
            this.tb_62.TabIndex = 3;
            // 
            // btn_login_62
            // 
            this.btn_login_62.Location = new System.Drawing.Point(896, 108);
            this.btn_login_62.Name = "btn_login_62";
            this.btn_login_62.Size = new System.Drawing.Size(228, 34);
            this.btn_login_62.TabIndex = 4;
            this.btn_login_62.Text = "62数据登录";
            this.btn_login_62.UseVisualStyleBackColor = true;
            // 
            // btn_login_account_IOS
            // 
            this.btn_login_account_IOS.Location = new System.Drawing.Point(896, 158);
            this.btn_login_account_IOS.Name = "btn_login_account_IOS";
            this.btn_login_account_IOS.Size = new System.Drawing.Size(228, 34);
            this.btn_login_account_IOS.TabIndex = 9;
            this.btn_login_account_IOS.Text = "IOS-账户登录";
            this.btn_login_account_IOS.UseVisualStyleBackColor = true;
            // 
            // btn_login_web
            // 
            this.btn_login_web.Location = new System.Drawing.Point(896, 16);
            this.btn_login_web.Name = "btn_login_web";
            this.btn_login_web.Size = new System.Drawing.Size(228, 34);
            this.btn_login_web.TabIndex = 13;
            this.btn_login_web.Text = "Web-二维码登录";
            this.btn_login_web.UseVisualStyleBackColor = true;
            this.btn_login_web.Click += new System.EventHandler(this.Btn_login_web_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tabControl1);
            this.groupBox3.Location = new System.Drawing.Point(12, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1138, 278);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "操 作";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(6, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1126, 243);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_friend_list);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1118, 217);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "信息操作";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_friend_list
            // 
            this.btn_friend_list.Location = new System.Drawing.Point(15, 20);
            this.btn_friend_list.Name = "btn_friend_list";
            this.btn_friend_list.Size = new System.Drawing.Size(75, 23);
            this.btn_friend_list.TabIndex = 0;
            this.btn_friend_list.Text = "好友列表";
            this.btn_friend_list.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_add_friend);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1118, 217);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "好友操作";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_add_friend
            // 
            this.btn_add_friend.Location = new System.Drawing.Point(20, 15);
            this.btn_add_friend.Name = "btn_add_friend";
            this.btn_add_friend.Size = new System.Drawing.Size(75, 23);
            this.btn_add_friend.TabIndex = 0;
            this.btn_add_friend.Text = "添加好友";
            this.btn_add_friend.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1118, 217);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "支付操作";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1118, 217);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "功能操作";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_login_Ipad
            // 
            this.btn_login_Ipad.Location = new System.Drawing.Point(639, 16);
            this.btn_login_Ipad.Name = "btn_login_Ipad";
            this.btn_login_Ipad.Size = new System.Drawing.Size(228, 34);
            this.btn_login_Ipad.TabIndex = 15;
            this.btn_login_Ipad.Text = "Ipad-账户登录-二维码";
            this.btn_login_Ipad.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "密  码";
            // 
            // 用户名
            // 
            this.用户名.AutoSize = true;
            this.用户名.Location = new System.Drawing.Point(321, 189);
            this.用户名.Name = "用户名";
            this.用户名.Size = new System.Drawing.Size(41, 12);
            this.用户名.TabIndex = 7;
            this.用户名.Text = "用户名";
            // 
            // tb_userpwd
            // 
            this.tb_userpwd.Location = new System.Drawing.Point(368, 219);
            this.tb_userpwd.Multiline = true;
            this.tb_userpwd.Name = "tb_userpwd";
            this.tb_userpwd.Size = new System.Drawing.Size(235, 34);
            this.tb_userpwd.TabIndex = 6;
            // 
            // tb_usernmae
            // 
            this.tb_usernmae.Location = new System.Drawing.Point(368, 179);
            this.tb_usernmae.Multiline = true;
            this.tb_usernmae.Name = "tb_usernmae";
            this.tb_usernmae.Size = new System.Drawing.Size(235, 34);
            this.tb_usernmae.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "62数据";
            // 
            // btn_login_mac
            // 
            this.btn_login_mac.Location = new System.Drawing.Point(896, 68);
            this.btn_login_mac.Name = "btn_login_mac";
            this.btn_login_mac.Size = new System.Drawing.Size(228, 34);
            this.btn_login_mac.TabIndex = 17;
            this.btn_login_mac.Text = "Mac-PC二维码登录";
            this.btn_login_mac.UseVisualStyleBackColor = true;
            // 
            // btn_login_account_Android
            // 
            this.btn_login_account_Android.Location = new System.Drawing.Point(896, 236);
            this.btn_login_account_Android.Name = "btn_login_account_Android";
            this.btn_login_account_Android.Size = new System.Drawing.Size(228, 34);
            this.btn_login_account_Android.TabIndex = 18;
            this.btn_login_account_Android.Text = "Android-账户登录";
            this.btn_login_account_Android.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 809);
            this.Controls.Add(this.btn_login_account_Android);
            this.Controls.Add(this.btn_login_mac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_userpwd);
            this.Controls.Add(this.tb_usernmae);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.用户名);
            this.Controls.Add(this.btn_login_Ipad);
            this.Controls.Add(this.tb_log);
            this.Controls.Add(this.btn_login_account_IOS);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_login_web);
            this.Controls.Add(this.btn_login_62);
            this.Controls.Add(this.tb_62);
            this.Controls.Add(this.btn_login_pc);
            this.Controls.Add(this.img_qrcode_web);
            this.Name = "Form1";
            this.Text = "NearWeChat";
            ((System.ComponentModel.ISupportInitialize)(this.img_qrcode_web)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_qrcode_web;
        private System.Windows.Forms.TextBox tb_log;
        private System.Windows.Forms.Button btn_login_pc;
        private System.Windows.Forms.TextBox tb_62;
        private System.Windows.Forms.Button btn_login_62;
        private System.Windows.Forms.Button btn_login_account_IOS;
        private System.Windows.Forms.Button btn_login_web;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_login_Ipad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label 用户名;
        private System.Windows.Forms.TextBox tb_userpwd;
        private System.Windows.Forms.TextBox tb_usernmae;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_login_mac;
        private System.Windows.Forms.Button btn_login_account_Android;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_friend_list;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_add_friend;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}

