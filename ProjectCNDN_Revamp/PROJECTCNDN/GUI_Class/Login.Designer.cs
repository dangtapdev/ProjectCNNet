namespace GUI_Class
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            btn_Login = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txt_MatKhau = new TextBox();
            txt_TaiKhoan = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btn_Login);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txt_MatKhau);
            panel1.Controls.Add(txt_TaiKhoan);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 535);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(46, 25);
            label4.Name = "label4";
            label4.Size = new Size(281, 28);
            label4.TabIndex = 4;
            label4.Text = "Phần mềm quản lý cửa hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(103, 207);
            label3.Name = "label3";
            label3.Size = new Size(134, 32);
            label3.TabIndex = 3;
            label3.Text = "Đăng nhập";
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.FromArgb(255, 128, 0);
            btn_Login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Login.ForeColor = Color.White;
            btn_Login.Location = new Point(46, 423);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(234, 45);
            btn_Login.TabIndex = 2;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(47, 340);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 0;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(46, 269);
            label1.Name = "label1";
            label1.Size = new Size(103, 28);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(95, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.BackColor = Color.White;
            txt_MatKhau.BorderStyle = BorderStyle.FixedSingle;
            txt_MatKhau.Location = new Point(47, 371);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.PasswordChar = '*';
            txt_MatKhau.Size = new Size(234, 27);
            txt_MatKhau.TabIndex = 1;
            // 
            // txt_TaiKhoan
            // 
            txt_TaiKhoan.BackColor = Color.White;
            txt_TaiKhoan.BorderStyle = BorderStyle.FixedSingle;
            txt_TaiKhoan.ForeColor = Color.Black;
            txt_TaiKhoan.Location = new Point(46, 300);
            txt_TaiKhoan.Name = "txt_TaiKhoan";
            txt_TaiKhoan.Size = new Size(234, 27);
            txt_TaiKhoan.TabIndex = 0;
            // 
            // Login
            // 
            AcceptButton = btn_Login;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(341, 535);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += Login_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txt_MatKhau;
        private TextBox txt_TaiKhoan;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btn_Login;
        private Label label3;
        private Label label4;
    }
}