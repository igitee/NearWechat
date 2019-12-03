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
            this.tb_log = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_vote = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_foiiow = new System.Windows.Forms.Button();
            this.btn_debug = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_debug = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Uuid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_Wxid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_qrcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_scan)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.btn_scan.Location = new System.Drawing.Point(12, 481);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(212, 29);
            this.btn_scan.TabIndex = 3;
            this.btn_scan.Text = "粘贴并识别";
            this.btn_scan.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(525, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 516);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "浏览器";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_log);
            this.groupBox2.Location = new System.Drawing.Point(12, 545);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(838, 204);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "日志";
            // 
            // tb_log
            // 
            this.tb_log.Location = new System.Drawing.Point(6, 22);
            this.tb_log.Multiline = true;
            this.tb_log.Name = "tb_log";
            this.tb_log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_log.Size = new System.Drawing.Size(826, 176);
            this.tb_log.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_vote);
            this.groupBox3.Controls.Add(this.btn_print);
            this.groupBox3.Controls.Add(this.btn_foiiow);
            this.groupBox3.Location = new System.Drawing.Point(235, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 236);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "操作";
            // 
            // btn_vote
            // 
            this.btn_vote.Location = new System.Drawing.Point(11, 54);
            this.btn_vote.Name = "btn_vote";
            this.btn_vote.Size = new System.Drawing.Size(76, 23);
            this.btn_vote.TabIndex = 2;
            this.btn_vote.Text = "投票";
            this.btn_vote.UseVisualStyleBackColor = true;
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(102, 20);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 23);
            this.btn_print.TabIndex = 1;
            this.btn_print.Text = "截图";
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // btn_foiiow
            // 
            this.btn_foiiow.Location = new System.Drawing.Point(11, 20);
            this.btn_foiiow.Name = "btn_foiiow";
            this.btn_foiiow.Size = new System.Drawing.Size(76, 23);
            this.btn_foiiow.TabIndex = 0;
            this.btn_foiiow.Text = "关注";
            this.btn_foiiow.UseVisualStyleBackColor = true;
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
            this.groupBox4.Controls.Add(this.lb_Wxid);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.lb_Uuid);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.tb_debug);
            this.groupBox4.Controls.Add(this.btn_debug);
            this.groupBox4.Location = new System.Drawing.Point(236, 269);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(278, 247);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "调试";
            // 
            // tb_debug
            // 
            this.tb_debug.Location = new System.Drawing.Point(6, 212);
            this.tb_debug.Multiline = true;
            this.tb_debug.Name = "tb_debug";
            this.tb_debug.Size = new System.Drawing.Size(175, 28);
            this.tb_debug.TabIndex = 4;
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
            // lb_Uuid
            // 
            this.lb_Uuid.AutoSize = true;
            this.lb_Uuid.Location = new System.Drawing.Point(56, 30);
            this.lb_Uuid.Name = "lb_Uuid";
            this.lb_Uuid.Size = new System.Drawing.Size(35, 12);
            this.lb_Uuid.TabIndex = 7;
            this.lb_Uuid.Text = "Uuid:";
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
            // lb_Wxid
            // 
            this.lb_Wxid.AutoSize = true;
            this.lb_Wxid.Location = new System.Drawing.Point(56, 59);
            this.lb_Wxid.Name = "lb_Wxid";
            this.lb_Wxid.Size = new System.Drawing.Size(35, 12);
            this.lb_Wxid.TabIndex = 9;
            this.lb_Wxid.Text = "WxId:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 761);
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
            ((System.ComponentModel.ISupportInitialize)(this.pic_qrcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_scan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btn_vote;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_foiiow;
        private System.Windows.Forms.Button btn_debug;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tb_debug;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Wxid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_Uuid;
    }
}

