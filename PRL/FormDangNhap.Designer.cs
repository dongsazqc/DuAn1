namespace PRL
{
    partial class FormDangNhap
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
            btn_Thoat = new Button();
            btn_DangNhap = new Button();
            txt_matkhau = new TextBox();
            txt_taikhoan = new TextBox();
            label3 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Thoat
            // 
            btn_Thoat.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            btn_Thoat.Location = new Point(1022, 419);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(116, 39);
            btn_Thoat.TabIndex = 16;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // btn_DangNhap
            // 
            btn_DangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            btn_DangNhap.Location = new Point(755, 420);
            btn_DangNhap.Name = "btn_DangNhap";
            btn_DangNhap.Size = new Size(134, 39);
            btn_DangNhap.TabIndex = 15;
            btn_DangNhap.Text = "Đăng nhập";
            btn_DangNhap.UseVisualStyleBackColor = true;
            btn_DangNhap.Click += btn_DangNhap_Click;
            // 
            // txt_matkhau
            // 
            txt_matkhau.Location = new Point(755, 307);
            txt_matkhau.Name = "txt_matkhau";
            txt_matkhau.PasswordChar = '*';
            txt_matkhau.Size = new Size(383, 27);
            txt_matkhau.TabIndex = 14;
            txt_matkhau.UseSystemPasswordChar = true;
            // 
            // txt_taikhoan
            // 
            txt_taikhoan.Location = new Point(755, 182);
            txt_taikhoan.Name = "txt_taikhoan";
            txt_taikhoan.Size = new Size(383, 27);
            txt_taikhoan.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Cyan;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(591, 178);
            label3.Name = "label3";
            label3.Size = new Size(117, 31);
            label3.TabIndex = 11;
            label3.Text = "Tài khoản";
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(864, 89);
            label2.Name = "label2";
            label2.Size = new Size(135, 32);
            label2.TabIndex = 10;
            label2.Text = "ĐĂNG NHẬP";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(883, 366);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(116, 20);
            linkLabel1.TabIndex = 18;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên mật khẩu?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumSeaGreen;
            label1.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(662, 89);
            label1.Name = "label1";
            label1.Size = new Size(92, 43);
            label1.TabIndex = 19;
            label1.Text = "DTD";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MediumSeaGreen;
            label5.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(1058, 78);
            label5.Name = "label5";
            label5.Size = new Size(130, 43);
            label5.TabIndex = 20;
            label5.Text = "Store";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Cyan;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.Location = new Point(592, 307);
            label6.Name = "label6";
            label6.Size = new Size(116, 31);
            label6.TabIndex = 21;
            label6.Text = "Mật khẩu";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.MediumSeaGreen;
            pictureBox1.Location = new Point(-9, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1834, 759);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1817, 555);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_DangNhap);
            Controls.Add(txt_matkhau);
            Controls.Add(txt_taikhoan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "FormDangNhap";
            Text = "Form2";
            Load += FormDangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_Thoat;
        private Button btn_DangNhap;
        private TextBox txt_matkhau;
        private TextBox txt_taikhoan;
        private Label label3;
        private Label label2;
        private LinkLabel linkLabel1;
        private Label label1;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
    }
}