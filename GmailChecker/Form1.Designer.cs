namespace GmailChecker
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        //private MetroFramework.Forms.MetroForm components = null;

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
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailList = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDomainEmail = new System.Windows.Forms.TextBox();
            this.cbCheckTaiKhoan = new System.Windows.Forms.RadioButton();
            this.ckbDoiNgonNgu = new System.Windows.Forms.RadioButton();
            this.ckbLayThongTinKenh = new System.Windows.Forms.RadioButton();
            this.ckbDoiMatKhau = new System.Windows.Forms.RadioButton();
            this.ckbDoiMailKhoiPhuc = new System.Windows.Forms.RadioButton();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtLogs = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.alltxtDomain = new System.Windows.Forms.TextBox();
            this.allcbLaythongtinkenhYT = new System.Windows.Forms.CheckBox();
            this.allcbDoimatkhau = new System.Windows.Forms.CheckBox();
            this.allcbDoimailkhoiphuctheodomain = new System.Windows.Forms.CheckBox();
            this.allbtnStart = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Danh sách email (email|password|recovery)";
            // 
            // txtEmailList
            // 
            this.txtEmailList.Location = new System.Drawing.Point(44, 119);
            this.txtEmailList.Name = "txtEmailList";
            this.txtEmailList.Size = new System.Drawing.Size(522, 544);
            this.txtEmailList.TabIndex = 39;
            this.txtEmailList.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDomainEmail);
            this.groupBox1.Controls.Add(this.cbCheckTaiKhoan);
            this.groupBox1.Controls.Add(this.ckbDoiNgonNgu);
            this.groupBox1.Controls.Add(this.ckbLayThongTinKenh);
            this.groupBox1.Controls.Add(this.ckbDoiMatKhau);
            this.groupBox1.Controls.Add(this.ckbDoiMailKhoiPhuc);
            this.groupBox1.Location = new System.Drawing.Point(583, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 125);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng single";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(540, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Với chức năng single bạn chỉ có thể lựa chọn 1 trong các chức năng ở nhóm";
            // 
            // txtDomainEmail
            // 
            this.txtDomainEmail.Location = new System.Drawing.Point(307, 23);
            this.txtDomainEmail.Name = "txtDomainEmail";
            this.txtDomainEmail.Size = new System.Drawing.Size(183, 26);
            this.txtDomainEmail.TabIndex = 6;
            this.txtDomainEmail.Text = "outlock.com";
            // 
            // cbCheckTaiKhoan
            // 
            this.cbCheckTaiKhoan.AutoSize = true;
            this.cbCheckTaiKhoan.Checked = true;
            this.cbCheckTaiKhoan.Location = new System.Drawing.Point(572, 66);
            this.cbCheckTaiKhoan.Name = "cbCheckTaiKhoan";
            this.cbCheckTaiKhoan.Size = new System.Drawing.Size(124, 24);
            this.cbCheckTaiKhoan.TabIndex = 5;
            this.cbCheckTaiKhoan.Text = "Check Gmail";
            this.cbCheckTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // ckbDoiNgonNgu
            // 
            this.ckbDoiNgonNgu.AutoSize = true;
            this.ckbDoiNgonNgu.Location = new System.Drawing.Point(370, 66);
            this.ckbDoiNgonNgu.Name = "ckbDoiNgonNgu";
            this.ckbDoiNgonNgu.Size = new System.Drawing.Size(183, 24);
            this.ckbDoiNgonNgu.TabIndex = 5;
            this.ckbDoiNgonNgu.Text = "Đổi ngôn ngữ EN-US";
            this.ckbDoiNgonNgu.UseVisualStyleBackColor = true;
            // 
            // ckbLayThongTinKenh
            // 
            this.ckbLayThongTinKenh.AutoSize = true;
            this.ckbLayThongTinKenh.Location = new System.Drawing.Point(163, 66);
            this.ckbLayThongTinKenh.Name = "ckbLayThongTinKenh";
            this.ckbLayThongTinKenh.Size = new System.Drawing.Size(188, 24);
            this.ckbLayThongTinKenh.TabIndex = 5;
            this.ckbLayThongTinKenh.Text = "Lấy thông tin kênh YT";
            this.ckbLayThongTinKenh.UseVisualStyleBackColor = true;
            // 
            // ckbDoiMatKhau
            // 
            this.ckbDoiMatKhau.AutoSize = true;
            this.ckbDoiMatKhau.Location = new System.Drawing.Point(16, 66);
            this.ckbDoiMatKhau.Name = "ckbDoiMatKhau";
            this.ckbDoiMatKhau.Size = new System.Drawing.Size(128, 24);
            this.ckbDoiMatKhau.TabIndex = 5;
            this.ckbDoiMatKhau.Text = "Đổi mật khẩu";
            this.ckbDoiMatKhau.UseVisualStyleBackColor = true;
            // 
            // ckbDoiMailKhoiPhuc
            // 
            this.ckbDoiMailKhoiPhuc.AutoSize = true;
            this.ckbDoiMailKhoiPhuc.Location = new System.Drawing.Point(16, 27);
            this.ckbDoiMailKhoiPhuc.Name = "ckbDoiMailKhoiPhuc";
            this.ckbDoiMailKhoiPhuc.Size = new System.Drawing.Size(254, 24);
            this.ckbDoiMailKhoiPhuc.TabIndex = 5;
            this.ckbDoiMailKhoiPhuc.Text = "Đổi mail khôi phục theo domain";
            this.ckbDoiMailKhoiPhuc.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(585, 373);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(296, 49);
            this.btnRun.TabIndex = 41;
            this.btnRun.Text = "START SINGLE";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // txtLogs
            // 
            this.txtLogs.Location = new System.Drawing.Point(585, 430);
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.Size = new System.Drawing.Size(716, 233);
            this.txtLogs.TabIndex = 43;
            this.txtLogs.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.alltxtDomain);
            this.groupBox2.Controls.Add(this.allcbLaythongtinkenhYT);
            this.groupBox2.Controls.Add(this.allcbDoimatkhau);
            this.groupBox2.Controls.Add(this.allcbDoimailkhoiphuctheodomain);
            this.groupBox2.Location = new System.Drawing.Point(585, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(716, 138);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng all in one";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(10, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(625, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Với chức năng all in one bạn có thể lựa chọn nhiều options phù hợp với nhu cầu sử" +
    " dụng";
            // 
            // alltxtDomain
            // 
            this.alltxtDomain.Location = new System.Drawing.Point(305, 32);
            this.alltxtDomain.Name = "alltxtDomain";
            this.alltxtDomain.Size = new System.Drawing.Size(183, 26);
            this.alltxtDomain.TabIndex = 6;
            this.alltxtDomain.Text = "outlock.com";
            // 
            // allcbLaythongtinkenhYT
            // 
            this.allcbLaythongtinkenhYT.AutoSize = true;
            this.allcbLaythongtinkenhYT.Location = new System.Drawing.Point(167, 74);
            this.allcbLaythongtinkenhYT.Name = "allcbLaythongtinkenhYT";
            this.allcbLaythongtinkenhYT.Size = new System.Drawing.Size(189, 24);
            this.allcbLaythongtinkenhYT.TabIndex = 0;
            this.allcbLaythongtinkenhYT.Text = "Lấy thông tin kênh YT";
            this.allcbLaythongtinkenhYT.UseVisualStyleBackColor = true;
            // 
            // allcbDoimatkhau
            // 
            this.allcbDoimatkhau.AutoSize = true;
            this.allcbDoimatkhau.Location = new System.Drawing.Point(14, 74);
            this.allcbDoimatkhau.Name = "allcbDoimatkhau";
            this.allcbDoimatkhau.Size = new System.Drawing.Size(129, 24);
            this.allcbDoimatkhau.TabIndex = 0;
            this.allcbDoimatkhau.Text = "Đổi mật khẩu";
            this.allcbDoimatkhau.UseVisualStyleBackColor = true;
            // 
            // allcbDoimailkhoiphuctheodomain
            // 
            this.allcbDoimailkhoiphuctheodomain.AutoSize = true;
            this.allcbDoimailkhoiphuctheodomain.Location = new System.Drawing.Point(14, 34);
            this.allcbDoimailkhoiphuctheodomain.Name = "allcbDoimailkhoiphuctheodomain";
            this.allcbDoimailkhoiphuctheodomain.Size = new System.Drawing.Size(255, 24);
            this.allcbDoimailkhoiphuctheodomain.TabIndex = 0;
            this.allcbDoimailkhoiphuctheodomain.Text = "Đổi mail khôi phục theo domain";
            this.allcbDoimailkhoiphuctheodomain.UseVisualStyleBackColor = true;
            // 
            // allbtnStart
            // 
            this.allbtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allbtnStart.ForeColor = System.Drawing.Color.Maroon;
            this.allbtnStart.Location = new System.Drawing.Point(890, 373);
            this.allbtnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.allbtnStart.Name = "allbtnStart";
            this.allbtnStart.Size = new System.Drawing.Size(296, 49);
            this.allbtnStart.TabIndex = 41;
            this.allbtnStart.Text = "START ALL IN ONE";
            this.allbtnStart.UseVisualStyleBackColor = true;
            this.allbtnStart.Click += new System.EventHandler(this.AllbtnStart_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1466, 880);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtLogs);
            this.Controls.Add(this.allbtnStart);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtEmailList);
            this.Controls.Add(this.label4);
            this.Name = "frmMain";
            this.Text = "GOOGLE CHECKER";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtEmailList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.RichTextBox txtLogs;
        private System.Windows.Forms.RadioButton ckbDoiNgonNgu;
        private System.Windows.Forms.RadioButton ckbLayThongTinKenh;
        private System.Windows.Forms.RadioButton ckbDoiMatKhau;
        private System.Windows.Forms.RadioButton ckbDoiMailKhoiPhuc;
        private System.Windows.Forms.RadioButton cbCheckTaiKhoan;
        private System.Windows.Forms.TextBox txtDomainEmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox alltxtDomain;
        private System.Windows.Forms.CheckBox allcbLaythongtinkenhYT;
        private System.Windows.Forms.CheckBox allcbDoimatkhau;
        private System.Windows.Forms.CheckBox allcbDoimailkhoiphuctheodomain;
        private System.Windows.Forms.Button allbtnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

