namespace GUI_Class.ChildForm
{
    partial class Customers
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
            label8 = new Label();
            txt_KetQuaKH = new TextBox();
            panel1 = new Panel();
            txt_SoThe = new TextBox();
            txt_Mail = new TextBox();
            txt_DiaChi = new TextBox();
            txt_MaKH = new TextBox();
            txt_Ten = new TextBox();
            txt_SDT = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgv_KhachHang = new DataGridView();
            btn_XoaKH = new Button();
            btn_SuaKH = new Button();
            btn_ThemKH = new Button();
            Col_CusID = new DataGridViewTextBoxColumn();
            Col_Fullname = new DataGridViewTextBoxColumn();
            Col_SDT = new DataGridViewTextBoxColumn();
            Col_CaID = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_KhachHang).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(762, 26);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 24;
            label8.Text = "Kết quả :";
            // 
            // txt_KetQuaKH
            // 
            txt_KetQuaKH.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_KetQuaKH.Location = new Point(762, 62);
            txt_KetQuaKH.Multiline = true;
            txt_KetQuaKH.Name = "txt_KetQuaKH";
            txt_KetQuaKH.Size = new Size(300, 122);
            txt_KetQuaKH.TabIndex = 25;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txt_SoThe);
            panel1.Controls.Add(txt_Mail);
            panel1.Controls.Add(txt_DiaChi);
            panel1.Controls.Add(txt_MaKH);
            panel1.Controls.Add(txt_Ten);
            panel1.Controls.Add(txt_SDT);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(22, 390);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 148);
            panel1.TabIndex = 26;
            // 
            // txt_SoThe
            // 
            txt_SoThe.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_SoThe.Location = new Point(80, 99);
            txt_SoThe.Name = "txt_SoThe";
            txt_SoThe.Size = new Size(247, 25);
            txt_SoThe.TabIndex = 17;
            // 
            // txt_Mail
            // 
            txt_Mail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Mail.Location = new Point(457, 60);
            txt_Mail.Name = "txt_Mail";
            txt_Mail.Size = new Size(247, 25);
            txt_Mail.TabIndex = 16;
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_DiaChi.Location = new Point(457, 102);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.Size = new Size(247, 25);
            txt_DiaChi.TabIndex = 15;
            // 
            // txt_MaKH
            // 
            txt_MaKH.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MaKH.Location = new Point(80, 18);
            txt_MaKH.Name = "txt_MaKH";
            txt_MaKH.Size = new Size(247, 25);
            txt_MaKH.TabIndex = 14;
            // 
            // txt_Ten
            // 
            txt_Ten.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Ten.Location = new Point(80, 60);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(247, 25);
            txt_Ten.TabIndex = 13;
            // 
            // txt_SDT
            // 
            txt_SDT.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_SDT.Location = new Point(457, 17);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.Size = new Size(247, 25);
            txt_SDT.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(389, 103);
            label7.Name = "label7";
            label7.Size = new Size(54, 17);
            label7.TabIndex = 11;
            label7.Text = "Địa chỉ :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(389, 60);
            label6.Name = "label6";
            label6.Size = new Size(50, 17);
            label6.TabIndex = 10;
            label6.Text = "Email : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(389, 18);
            label5.Name = "label5";
            label5.Size = new Size(38, 17);
            label5.TabIndex = 9;
            label5.Text = "SĐT :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(11, 59);
            label4.Name = "label4";
            label4.Size = new Size(75, 17);
            label4.TabIndex = 8;
            label4.Text = "Họ và tên : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(11, 102);
            label3.Name = "label3";
            label3.Size = new Size(56, 17);
            label3.TabIndex = 7;
            label3.Text = "Số thẻ : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 192);
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 17);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 6;
            label2.Text = "Mã KH :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 22);
            label1.Name = "label1";
            label1.Size = new Size(196, 25);
            label1.TabIndex = 22;
            label1.Text = "Thông tin khách hàng";
            // 
            // dgv_KhachHang
            // 
            dgv_KhachHang.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_KhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_KhachHang.Columns.AddRange(new DataGridViewColumn[] { Col_CusID, Col_Fullname, Col_SDT, Col_CaID });
            dgv_KhachHang.Location = new Point(22, 62);
            dgv_KhachHang.Name = "dgv_KhachHang";
            dgv_KhachHang.RowHeadersWidth = 51;
            dgv_KhachHang.RowTemplate.Height = 25;
            dgv_KhachHang.Size = new Size(720, 299);
            dgv_KhachHang.TabIndex = 19;
            // 
            // btn_XoaKH
            // 
            btn_XoaKH.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_XoaKH.Location = new Point(762, 311);
            btn_XoaKH.Name = "btn_XoaKH";
            btn_XoaKH.Size = new Size(300, 50);
            btn_XoaKH.TabIndex = 21;
            btn_XoaKH.Text = "Xóa thông tin KH";
            btn_XoaKH.UseVisualStyleBackColor = true;
            // 
            // btn_SuaKH
            // 
            btn_SuaKH.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_SuaKH.Location = new Point(762, 255);
            btn_SuaKH.Name = "btn_SuaKH";
            btn_SuaKH.Size = new Size(300, 50);
            btn_SuaKH.TabIndex = 23;
            btn_SuaKH.Text = "Sửa thông tin KH";
            btn_SuaKH.UseVisualStyleBackColor = true;
            // 
            // btn_ThemKH
            // 
            btn_ThemKH.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ThemKH.Location = new Point(762, 199);
            btn_ThemKH.Name = "btn_ThemKH";
            btn_ThemKH.Size = new Size(300, 50);
            btn_ThemKH.TabIndex = 20;
            btn_ThemKH.Text = "Thêm thông tin KH";
            btn_ThemKH.UseVisualStyleBackColor = true;
            // 
            // Col_CusID
            // 
            Col_CusID.DataPropertyName = "Customer_ID";
            Col_CusID.HeaderText = "Mã KH";
            Col_CusID.MinimumWidth = 6;
            Col_CusID.Name = "Col_CusID";
            Col_CusID.Width = 110;
            // 
            // Col_Fullname
            // 
            Col_Fullname.HeaderText = "Họ và tên";
            Col_Fullname.MinimumWidth = 6;
            Col_Fullname.Name = "Col_Fullname";
            Col_Fullname.Width = 200;
            // 
            // Col_SDT
            // 
            Col_SDT.HeaderText = "Số điện thoại";
            Col_SDT.MinimumWidth = 6;
            Col_SDT.Name = "Col_SDT";
            Col_SDT.Width = 150;
            // 
            // Col_CaID
            // 
            Col_CaID.HeaderText = "Số thẻ";
            Col_CaID.MinimumWidth = 6;
            Col_CaID.Name = "Col_CaID";
            Col_CaID.Width = 150;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 561);
            Controls.Add(label8);
            Controls.Add(txt_KetQuaKH);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(dgv_KhachHang);
            Controls.Add(btn_XoaKH);
            Controls.Add(btn_SuaKH);
            Controls.Add(btn_ThemKH);
            Name = "Customers";
            Text = "Customers";
            Load += Customers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_KhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private TextBox txt_KetQuaKH;
        private Panel panel1;
        private TextBox txt_SoThe;
        private TextBox txt_Mail;
        private TextBox txt_DiaChi;
        private TextBox txt_MaKH;
        private TextBox txt_Ten;
        private TextBox txt_SDT;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgv_KhachHang;
        private Button btn_XoaKH;
        private Button btn_SuaKH;
        private Button btn_ThemKH;
        private DataGridViewTextBoxColumn Col_CusID;
        private DataGridViewTextBoxColumn Col_Fullname;
        private DataGridViewTextBoxColumn Col_SDT;
        private DataGridViewTextBoxColumn Col_CaID;
    }
}