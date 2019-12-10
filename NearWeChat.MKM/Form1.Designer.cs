using System;

namespace NearWeChat.MKM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_getqrcode = new System.Windows.Forms.Button();
            this.pic_qrcode = new System.Windows.Forms.PictureBox();
            this.pic_scan = new System.Windows.Forms.PictureBox();
            this.btn_scan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_heart = new System.Windows.Forms.TextBox();
            this.tb_log = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_InitUser = new System.Windows.Forms.Button();
            this.btn_heart = new System.Windows.Forms.Button();
            this.btn_verify = new System.Windows.Forms.Button();
            this.btn_confirmget = new System.Windows.Forms.Button();
            this.btn_confim = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_twcLogin = new System.Windows.Forms.Button();
            this.btn_loginout = new System.Windows.Forms.Button();
            this.btn_NewInit = new System.Windows.Forms.Button();
            this.btn_get62 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_foiiow = new System.Windows.Forms.Button();
            this.btn_Sync = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_debug = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lb_appid = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_native = new System.Windows.Forms.Button();
            this.lb_ConfirmUrl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_Wxid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_Uuid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_debug = new System.Windows.Forms.TextBox();
            this.btn_liulan = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_62 = new System.Windows.Forms.TextBox();
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.btn_browser = new System.Windows.Forms.Button();
            this.tb_APPID = new System.Windows.Forms.TextBox();
            this.btn_getfriendlist = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_towxid = new System.Windows.Forms.TextBox();
            this.btn_sendtext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_qrcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_scan)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_getqrcode
            // 
            this.btn_getqrcode.Location = new System.Drawing.Point(12, 218);
            this.btn_getqrcode.Name = "btn_getqrcode";
            this.btn_getqrcode.Size = new System.Drawing.Size(212, 29);
            this.btn_getqrcode.TabIndex = 0;
            this.btn_getqrcode.Text = "扫码登录";
            this.btn_getqrcode.UseVisualStyleBackColor = true;
            this.btn_getqrcode.Click += new System.EventHandler(this.Btn_getqrcode_Click);
            // 
            // pic_qrcode
            // 
            this.pic_qrcode.Image = ((System.Drawing.Image)(resources.GetObject("pic_qrcode.Image")));
            this.pic_qrcode.Location = new System.Drawing.Point(12, 12);
            this.pic_qrcode.Name = "pic_qrcode";
            this.pic_qrcode.Size = new System.Drawing.Size(212, 200);
            this.pic_qrcode.TabIndex = 1;
            this.pic_qrcode.TabStop = false;
            // 
            // pic_scan
            // 
            this.pic_scan.Image = ((System.Drawing.Image)(resources.GetObject("pic_scan.Image")));
            this.pic_scan.Location = new System.Drawing.Point(12, 269);
            this.pic_scan.Name = "pic_scan";
            this.pic_scan.Size = new System.Drawing.Size(212, 200);
            this.pic_scan.TabIndex = 2;
            this.pic_scan.TabStop = false;
            // 
            // btn_scan
            // 
            this.btn_scan.Location = new System.Drawing.Point(12, 510);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(212, 29);
            this.btn_scan.TabIndex = 3;
            this.btn_scan.Text = "粘贴并识别";
            this.btn_scan.UseVisualStyleBackColor = true;
            this.btn_scan.Click += new System.EventHandler(this.Btn_scan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(855, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 731);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "浏览器";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_heart);
            this.groupBox2.Controls.Add(this.tb_log);
            this.groupBox2.Location = new System.Drawing.Point(12, 545);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(837, 265);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "日志";
            // 
            // tb_heart
            // 
            this.tb_heart.Location = new System.Drawing.Point(702, 20);
            this.tb_heart.Multiline = true;
            this.tb_heart.Name = "tb_heart";
            this.tb_heart.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_heart.Size = new System.Drawing.Size(135, 237);
            this.tb_heart.TabIndex = 1;
            // 
            // tb_log
            // 
            this.tb_log.Location = new System.Drawing.Point(6, 22);
            this.tb_log.Multiline = true;
            this.tb_log.Name = "tb_log";
            this.tb_log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_log.Size = new System.Drawing.Size(679, 237);
            this.tb_log.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tabControl1);
            this.groupBox3.Location = new System.Drawing.Point(532, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 528);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "操作";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(11, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(300, 502);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_InitUser);
            this.tabPage1.Controls.Add(this.btn_heart);
            this.tabPage1.Controls.Add(this.btn_verify);
            this.tabPage1.Controls.Add(this.btn_confirmget);
            this.tabPage1.Controls.Add(this.btn_confim);
            this.tabPage1.Controls.Add(this.btn_login);
            this.tabPage1.Controls.Add(this.btn_twcLogin);
            this.tabPage1.Controls.Add(this.btn_loginout);
            this.tabPage1.Controls.Add(this.btn_NewInit);
            this.tabPage1.Controls.Add(this.btn_get62);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(292, 476);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Login";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_InitUser
            // 
            this.btn_InitUser.Location = new System.Drawing.Point(164, 65);
            this.btn_InitUser.Name = "btn_InitUser";
            this.btn_InitUser.Size = new System.Drawing.Size(111, 26);
            this.btn_InitUser.TabIndex = 13;
            this.btn_InitUser.Text = "初始化好友信息";
            this.btn_InitUser.UseVisualStyleBackColor = true;
            this.btn_InitUser.Click += new System.EventHandler(this.Btn_InitUser_Click);
            // 
            // btn_heart
            // 
            this.btn_heart.Location = new System.Drawing.Point(20, 305);
            this.btn_heart.Name = "btn_heart";
            this.btn_heart.Size = new System.Drawing.Size(111, 26);
            this.btn_heart.TabIndex = 12;
            this.btn_heart.Text = "心 跳";
            this.btn_heart.UseVisualStyleBackColor = true;
            this.btn_heart.Click += new System.EventHandler(this.Btn_heart_Click);
            // 
            // btn_verify
            // 
            this.btn_verify.Location = new System.Drawing.Point(20, 107);
            this.btn_verify.Name = "btn_verify";
            this.btn_verify.Size = new System.Drawing.Size(111, 27);
            this.btn_verify.TabIndex = 11;
            this.btn_verify.Text = "验证通过";
            this.btn_verify.UseVisualStyleBackColor = true;
            this.btn_verify.Click += new System.EventHandler(this.Btn_verify_Click);
            // 
            // btn_confirmget
            // 
            this.btn_confirmget.Location = new System.Drawing.Point(20, 205);
            this.btn_confirmget.Name = "btn_confirmget";
            this.btn_confirmget.Size = new System.Drawing.Size(111, 26);
            this.btn_confirmget.TabIndex = 5;
            this.btn_confirmget.Text = "获取登录授权";
            this.btn_confirmget.UseVisualStyleBackColor = true;
            // 
            // btn_confim
            // 
            this.btn_confim.Location = new System.Drawing.Point(20, 154);
            this.btn_confim.Name = "btn_confim";
            this.btn_confim.Size = new System.Drawing.Size(111, 26);
            this.btn_confim.TabIndex = 4;
            this.btn_confim.Text = "确认登录";
            this.btn_confim.UseVisualStyleBackColor = true;
            this.btn_confim.Click += new System.EventHandler(this.Btn_confim_Click);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(20, 64);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(111, 27);
            this.btn_login.TabIndex = 10;
            this.btn_login.Text = "62登录";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // btn_twcLogin
            // 
            this.btn_twcLogin.Location = new System.Drawing.Point(20, 257);
            this.btn_twcLogin.Name = "btn_twcLogin";
            this.btn_twcLogin.Size = new System.Drawing.Size(111, 26);
            this.btn_twcLogin.TabIndex = 3;
            this.btn_twcLogin.Text = "二次登录";
            this.btn_twcLogin.UseVisualStyleBackColor = true;
            this.btn_twcLogin.Click += new System.EventHandler(this.Btn_twcLogin_Click);
            // 
            // btn_loginout
            // 
            this.btn_loginout.Location = new System.Drawing.Point(20, 358);
            this.btn_loginout.Name = "btn_loginout";
            this.btn_loginout.Size = new System.Drawing.Size(111, 26);
            this.btn_loginout.TabIndex = 2;
            this.btn_loginout.Text = "退出登录";
            this.btn_loginout.UseVisualStyleBackColor = true;
            this.btn_loginout.Click += new System.EventHandler(this.Btn_loginout_Click);
            // 
            // btn_NewInit
            // 
            this.btn_NewInit.Location = new System.Drawing.Point(164, 20);
            this.btn_NewInit.Name = "btn_NewInit";
            this.btn_NewInit.Size = new System.Drawing.Size(111, 26);
            this.btn_NewInit.TabIndex = 1;
            this.btn_NewInit.Text = "初始化用户信息";
            this.btn_NewInit.UseVisualStyleBackColor = true;
            this.btn_NewInit.Click += new System.EventHandler(this.Btn_NewInit_Click);
            // 
            // btn_get62
            // 
            this.btn_get62.Location = new System.Drawing.Point(20, 20);
            this.btn_get62.Name = "btn_get62";
            this.btn_get62.Size = new System.Drawing.Size(111, 26);
            this.btn_get62.TabIndex = 0;
            this.btn_get62.Text = "提取62数据";
            this.btn_get62.UseVisualStyleBackColor = true;
            this.btn_get62.Click += new System.EventHandler(this.Btn_get62_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tb_APPID);
            this.tabPage2.Controls.Add(this.btn_foiiow);
            this.tabPage2.Controls.Add(this.btn_Sync);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(292, 476);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Common";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_foiiow
            // 
            this.btn_foiiow.Location = new System.Drawing.Point(197, 89);
            this.btn_foiiow.Name = "btn_foiiow";
            this.btn_foiiow.Size = new System.Drawing.Size(76, 23);
            this.btn_foiiow.TabIndex = 0;
            this.btn_foiiow.Text = "关注";
            this.btn_foiiow.UseVisualStyleBackColor = true;
            this.btn_foiiow.Click += new System.EventHandler(this.Btn_foiiow_Click);
            // 
            // btn_Sync
            // 
            this.btn_Sync.Location = new System.Drawing.Point(16, 39);
            this.btn_Sync.Name = "btn_Sync";
            this.btn_Sync.Size = new System.Drawing.Size(76, 23);
            this.btn_Sync.TabIndex = 2;
            this.btn_Sync.Text = "同步微信消息";
            this.btn_Sync.UseVisualStyleBackColor = true;
            this.btn_Sync.Click += new System.EventHandler(this.Btn_Sync_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_getfriendlist);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(292, 476);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Friend";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_sendtext);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(292, 476);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Message";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_debug
            // 
            this.btn_debug.Location = new System.Drawing.Point(196, 211);
            this.btn_debug.Name = "btn_debug";
            this.btn_debug.Size = new System.Drawing.Size(76, 29);
            this.btn_debug.TabIndex = 3;
            this.btn_debug.Text = "Debug";
            this.btn_debug.UseVisualStyleBackColor = true;
            this.btn_debug.Click += new System.EventHandler(this.Btn_debug_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tb_towxid);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.lb_appid);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btn_native);
            this.groupBox4.Controls.Add(this.lb_ConfirmUrl);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.lb_Wxid);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.lb_Uuid);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.tb_debug);
            this.groupBox4.Controls.Add(this.btn_debug);
            this.groupBox4.Location = new System.Drawing.Point(236, 269);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(278, 270);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "调试";
            // 
            // lb_appid
            // 
            this.lb_appid.AutoSize = true;
            this.lb_appid.Location = new System.Drawing.Point(64, 124);
            this.lb_appid.Name = "lb_appid";
            this.lb_appid.Size = new System.Drawing.Size(47, 12);
            this.lb_appid.TabIndex = 15;
            this.lb_appid.Text = "APPID：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "APPID：";
            // 
            // btn_native
            // 
            this.btn_native.Location = new System.Drawing.Point(192, 81);
            this.btn_native.Name = "btn_native";
            this.btn_native.Size = new System.Drawing.Size(76, 29);
            this.btn_native.TabIndex = 13;
            this.btn_native.Text = "浏 览";
            this.btn_native.UseVisualStyleBackColor = true;
            this.btn_native.Click += new System.EventHandler(this.Btn_native_Click);
            // 
            // lb_ConfirmUrl
            // 
            this.lb_ConfirmUrl.AutoSize = true;
            this.lb_ConfirmUrl.Location = new System.Drawing.Point(94, 89);
            this.lb_ConfirmUrl.Name = "lb_ConfirmUrl";
            this.lb_ConfirmUrl.Size = new System.Drawing.Size(65, 12);
            this.lb_ConfirmUrl.TabIndex = 11;
            this.lb_ConfirmUrl.Text = "ConfirmUrl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "ConfirmUrl：";
            // 
            // lb_Wxid
            // 
            this.lb_Wxid.AutoSize = true;
            this.lb_Wxid.Location = new System.Drawing.Point(56, 59);
            this.lb_Wxid.Name = "lb_Wxid";
            this.lb_Wxid.Size = new System.Drawing.Size(35, 12);
            this.lb_Wxid.TabIndex = 9;
            this.lb_Wxid.Text = "WxId:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "WxId:";
            // 
            // lb_Uuid
            // 
            this.lb_Uuid.AutoSize = true;
            this.lb_Uuid.Location = new System.Drawing.Point(56, 30);
            this.lb_Uuid.Name = "lb_Uuid";
            this.lb_Uuid.Size = new System.Drawing.Size(35, 12);
            this.lb_Uuid.TabIndex = 7;
            this.lb_Uuid.Text = "Uuid:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "UuId:";
            // 
            // tb_debug
            // 
            this.tb_debug.Location = new System.Drawing.Point(6, 212);
            this.tb_debug.Multiline = true;
            this.tb_debug.Name = "tb_debug";
            this.tb_debug.Size = new System.Drawing.Size(175, 28);
            this.tb_debug.TabIndex = 4;
            // 
            // btn_liulan
            // 
            this.btn_liulan.Location = new System.Drawing.Point(12, 476);
            this.btn_liulan.Name = "btn_liulan";
            this.btn_liulan.Size = new System.Drawing.Size(212, 29);
            this.btn_liulan.TabIndex = 8;
            this.btn_liulan.Text = "识别二维码";
            this.btn_liulan.UseVisualStyleBackColor = true;
            this.btn_liulan.Click += new System.EventHandler(this.Btn_liulan_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.tb_62);
            this.groupBox5.Controls.Add(this.tb_pwd);
            this.groupBox5.Controls.Add(this.tb_username);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(242, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(272, 221);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "登陆";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "62：";
            // 
            // tb_62
            // 
            this.tb_62.Location = new System.Drawing.Point(52, 88);
            this.tb_62.Multiline = true;
            this.tb_62.Name = "tb_62";
            this.tb_62.Size = new System.Drawing.Size(210, 112);
            this.tb_62.TabIndex = 12;
            this.tb_62.Text = resources.GetString("tb_62.Text");
            // 
            // tb_pwd
            // 
            this.tb_pwd.Location = new System.Drawing.Point(52, 54);
            this.tb_pwd.Multiline = true;
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.Size = new System.Drawing.Size(210, 28);
            this.tb_pwd.TabIndex = 11;
            this.tb_pwd.Text = "13054134167c";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(52, 20);
            this.tb_username.Multiline = true;
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(210, 28);
            this.tb_username.TabIndex = 10;
            this.tb_username.Text = "demon2019ww";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "密码：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "账号：";
            // 
            // tb_url
            // 
            this.tb_url.Location = new System.Drawing.Point(855, 31);
            this.tb_url.Multiline = true;
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(392, 28);
            this.tb_url.TabIndex = 12;
            // 
            // btn_browser
            // 
            this.btn_browser.Location = new System.Drawing.Point(1253, 30);
            this.btn_browser.Name = "btn_browser";
            this.btn_browser.Size = new System.Drawing.Size(76, 29);
            this.btn_browser.TabIndex = 12;
            this.btn_browser.Text = "浏 览";
            this.btn_browser.UseVisualStyleBackColor = true;
            this.btn_browser.Click += new System.EventHandler(this.Btn_browser_Click);
            // 
            // tb_APPID
            // 
            this.tb_APPID.Location = new System.Drawing.Point(16, 84);
            this.tb_APPID.Multiline = true;
            this.tb_APPID.Name = "tb_APPID";
            this.tb_APPID.Size = new System.Drawing.Size(175, 28);
            this.tb_APPID.TabIndex = 16;
            // 
            // btn_getfriendlist
            // 
            this.btn_getfriendlist.Location = new System.Drawing.Point(18, 33);
            this.btn_getfriendlist.Name = "btn_getfriendlist";
            this.btn_getfriendlist.Size = new System.Drawing.Size(110, 29);
            this.btn_getfriendlist.TabIndex = 16;
            this.btn_getfriendlist.Text = "获取好友联系人";
            this.btn_getfriendlist.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "To_WxId:";
            // 
            // tb_towxid
            // 
            this.tb_towxid.Location = new System.Drawing.Point(70, 154);
            this.tb_towxid.Multiline = true;
            this.tb_towxid.Name = "tb_towxid";
            this.tb_towxid.Size = new System.Drawing.Size(175, 28);
            this.tb_towxid.TabIndex = 17;
            // 
            // btn_sendtext
            // 
            this.btn_sendtext.Location = new System.Drawing.Point(30, 47);
            this.btn_sendtext.Name = "btn_sendtext";
            this.btn_sendtext.Size = new System.Drawing.Size(120, 29);
            this.btn_sendtext.TabIndex = 18;
            this.btn_sendtext.Text = "发送文本消息";
            this.btn_sendtext.UseVisualStyleBackColor = true;
            this.btn_sendtext.Click += new System.EventHandler(this.Btn_sendtext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 822);
            this.Controls.Add(this.btn_browser);
            this.Controls.Add(this.tb_url);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btn_liulan);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_scan);
            this.Controls.Add(this.pic_scan);
            this.Controls.Add(this.pic_qrcode);
            this.Controls.Add(this.btn_getqrcode);
            this.Name = "Form1";
            this.Text = "MKM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_qrcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_scan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion

        private System.Windows.Forms.Button btn_getqrcode;
        private System.Windows.Forms.PictureBox pic_qrcode;
        private System.Windows.Forms.PictureBox pic_scan;
        private System.Windows.Forms.Button btn_scan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_log;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Sync;
        private System.Windows.Forms.Button btn_foiiow;
        private System.Windows.Forms.Button btn_debug;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tb_debug;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Wxid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_Uuid;
        private System.Windows.Forms.Button btn_liulan;
        private System.Windows.Forms.TextBox tb_heart;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_62;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_get62;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Button btn_NewInit;
        private System.Windows.Forms.Button btn_loginout;
        private System.Windows.Forms.Button btn_twcLogin;
        private System.Windows.Forms.Button btn_confirmget;
        private System.Windows.Forms.Button btn_confim;
        private System.Windows.Forms.Label lb_ConfirmUrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.Button btn_browser;
        private System.Windows.Forms.Button btn_verify;
        private System.Windows.Forms.Button btn_native;
        private System.Windows.Forms.Button btn_heart;
        private System.Windows.Forms.Button btn_InitUser;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lb_appid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_APPID;
        private System.Windows.Forms.Button btn_getfriendlist;
        private System.Windows.Forms.TextBox tb_towxid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_sendtext;
    }
}

