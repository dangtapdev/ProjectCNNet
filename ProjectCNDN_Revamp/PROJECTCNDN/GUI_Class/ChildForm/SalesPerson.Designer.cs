namespace GUI_Class.ChildForm
{
    partial class SalesPerson
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
            txt_KQ = new TextBox();
            panel1 = new Panel();
            txt_SDT = new TextBox();
            txt_DiaChi = new TextBox();
            txt_Luong = new TextBox();
            txt_MaNV = new TextBox();
            txt_Ten = new TextBox();
            txt_Mail = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgv_NV = new DataGridView();
            btn_XoaNV = new Button();
            btn_SuaNV = new Button();
            btn_ThemNV = new Button();
            Col_CusID = new DataGridViewTextBoxColumn();
            Col_Fullname = new DataGridViewTextBoxColumn();
            Col_SDT = new DataGridViewTextBoxColumn();
            Col_CaID = new DataGridViewTextBoxColumn();
            Info_Address = new DataGridViewTextBoxColumn();
            Salary = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_NV).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(824, 36);
            label8.Name = "label8";
            label8.Size = new Size(85, 25);
            label8.TabIndex = 32;
            label8.Text = "Kết quả :";
            // 
            // txt_KQ
            // 
            txt_KQ.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_KQ.Location = new Point(824, 84);
            txt_KQ.Margin = new Padding(3, 4, 3, 4);
            txt_KQ.Multiline = true;
            txt_KQ.Name = "txt_KQ";
            txt_KQ.Size = new Size(342, 161);
            txt_KQ.TabIndex = 33;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txt_SDT);
            panel1.Controls.Add(txt_DiaChi);
            panel1.Controls.Add(txt_Luong);
            panel1.Controls.Add(txt_MaNV);
            panel1.Controls.Add(txt_Ten);
            panel1.Controls.Add(txt_Mail);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(25, 520);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(764, 197);
            panel1.TabIndex = 34;
            // 
            // txt_SDT
            // 
            txt_SDT.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_SDT.Location = new Point(91, 132);
            txt_SDT.Margin = new Padding(3, 4, 3, 4);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.Size = new Size(282, 29);
            txt_SDT.TabIndex = 17;
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_DiaChi.Location = new Point(464, 80);
            txt_DiaChi.Margin = new Padding(3, 4, 3, 4);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.Size = new Size(282, 29);
            txt_DiaChi.TabIndex = 16;
            // 
            // txt_Luong
            // 
            txt_Luong.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Luong.Location = new Point(464, 136);
            txt_Luong.Margin = new Padding(3, 4, 3, 4);
            txt_Luong.Name = "txt_Luong";
            txt_Luong.Size = new Size(282, 29);
            txt_Luong.TabIndex = 15;
            // 
            // txt_MaNV
            // 
            txt_MaNV.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MaNV.Location = new Point(91, 24);
            txt_MaNV.Margin = new Padding(3, 4, 3, 4);
            txt_MaNV.Name = "txt_MaNV";
            txt_MaNV.Size = new Size(282, 29);
            txt_MaNV.TabIndex = 14;
            // 
            // txt_Ten
            // 
            txt_Ten.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Ten.Location = new Point(91, 80);
            txt_Ten.Margin = new Padding(3, 4, 3, 4);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(282, 29);
            txt_Ten.TabIndex = 13;
            // 
            // txt_Mail
            // 
            txt_Mail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Mail.Location = new Point(464, 23);
            txt_Mail.Margin = new Padding(3, 4, 3, 4);
            txt_Mail.Name = "txt_Mail";
            txt_Mail.Size = new Size(282, 29);
            txt_Mail.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(386, 137);
            label7.Name = "label7";
            label7.Size = new Size(72, 23);
            label7.TabIndex = 11;
            label7.Text = "Lương : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(386, 80);
            label6.Name = "label6";
            label6.Size = new Size(71, 23);
            label6.TabIndex = 10;
            label6.Text = "Địa chỉ :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(386, 24);
            label5.Name = "label5";
            label5.Size = new Size(65, 23);
            label5.TabIndex = 9;
            label5.Text = "Email : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 79);
            label4.Name = "label4";
            label4.Size = new Size(98, 23);
            label4.TabIndex = 8;
            label4.Text = "Họ và tên : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 136);
            label3.Name = "label3";
            label3.Size = new Size(49, 23);
            label3.TabIndex = 7;
            label3.Text = "SĐT :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 192);
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 23);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 6;
            label2.Text = "Mã NV :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 29);
            label1.Name = "label1";
            label1.Size = new Size(231, 32);
            label1.TabIndex = 30;
            label1.Text = "Thông tin nhân viên";
            // 
            // dgv_NV
            // 
            dgv_NV.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_NV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_NV.Columns.AddRange(new DataGridViewColumn[] { Col_CusID, Col_Fullname, Col_SDT, Col_CaID, Info_Address, Salary });
            dgv_NV.Location = new Point(25, 83);
            dgv_NV.Margin = new Padding(3, 4, 3, 4);
            dgv_NV.Name = "dgv_NV";
            dgv_NV.RowHeadersWidth = 51;
            dgv_NV.RowTemplate.Height = 25;
            dgv_NV.Size = new Size(765, 409);
            dgv_NV.TabIndex = 27;
            // 
            // btn_XoaNV
            // 
            btn_XoaNV.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_XoaNV.Location = new Point(824, 404);
            btn_XoaNV.Margin = new Padding(3, 4, 3, 4);
            btn_XoaNV.Name = "btn_XoaNV";
            btn_XoaNV.Size = new Size(343, 67);
            btn_XoaNV.TabIndex = 29;
            btn_XoaNV.Text = "Xóa thông tin NV";
            btn_XoaNV.UseVisualStyleBackColor = true;
            // 
            // btn_SuaNV
            // 
            btn_SuaNV.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_SuaNV.Location = new Point(824, 329);
            btn_SuaNV.Margin = new Padding(3, 4, 3, 4);
            btn_SuaNV.Name = "btn_SuaNV";
            btn_SuaNV.Size = new Size(343, 67);
            btn_SuaNV.TabIndex = 31;
            btn_SuaNV.Text = "Sửa thông tin NV";
            btn_SuaNV.UseVisualStyleBackColor = true;
            // 
            // btn_ThemNV
            // 
            btn_ThemNV.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ThemNV.Location = new Point(824, 255);
            btn_ThemNV.Margin = new Padding(3, 4, 3, 4);
            btn_ThemNV.Name = "btn_ThemNV";
            btn_ThemNV.Size = new Size(343, 67);
            btn_ThemNV.TabIndex = 28;
            btn_ThemNV.Text = "Thêm NV mới";
            btn_ThemNV.UseVisualStyleBackColor = true;
            // 
            // Col_CusID
            // 
            Col_CusID.DataPropertyName = "SalesPerson_ID";
            Col_CusID.HeaderText = "Mã NV";
            Col_CusID.MinimumWidth = 6;
            Col_CusID.Name = "Col_CusID";
            Col_CusID.Width = 110;
            // 
            // Col_Fullname
            // 
            Col_Fullname.DataPropertyName = "FullName";
            Col_Fullname.HeaderText = "Họ và tên";
            Col_Fullname.MinimumWidth = 6;
            Col_Fullname.Name = "Col_Fullname";
            Col_Fullname.Width = 200;
            // 
            // Col_SDT
            // 
            Col_SDT.DataPropertyName = "ContactNumber";
            Col_SDT.HeaderText = "Số điện thoại";
            Col_SDT.MinimumWidth = 6;
            Col_SDT.Name = "Col_SDT";
            Col_SDT.Width = 150;
            // 
            // Col_CaID
            // 
            Col_CaID.DataPropertyName = "Email";
            Col_CaID.HeaderText = "Email ";
            Col_CaID.MinimumWidth = 6;
            Col_CaID.Name = "Col_CaID";
            Col_CaID.Width = 150;
            // 
            // Info_Address
            // 
            Info_Address.DataPropertyName = "Info_Address";
            Info_Address.HeaderText = "Địa chỉ";
            Info_Address.MinimumWidth = 6;
            Info_Address.Name = "Info_Address";
            Info_Address.Width = 125;
            // 
            // Salary
            // 
            Salary.DataPropertyName = "Salary";
            Salary.HeaderText = "Lương";
            Salary.MinimumWidth = 6;
            Salary.Name = "Salary";
            Salary.Width = 125;
            // 
            // SalesPerson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 748);
            Controls.Add(label8);
            Controls.Add(txt_KQ);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(dgv_NV);
            Controls.Add(btn_XoaNV);
            Controls.Add(btn_SuaNV);
            Controls.Add(btn_ThemNV);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SalesPerson";
            Text = "SalesPerson";
            Load += SalesPerson_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_NV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private TextBox txt_KQ;
        private Panel panel1;
        private TextBox txt_SDT;
        private TextBox txt_DiaChi;
        private TextBox txt_Luong;
        private TextBox txt_MaNV;
        private TextBox txt_Ten;
        private TextBox txt_Mail;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgv_NV;
        private Button btn_XoaNV;
        private Button btn_SuaNV;
        private Button btn_ThemNV;
        private DataGridViewTextBoxColumn Col_CusID;
        private DataGridViewTextBoxColumn Col_Fullname;
        private DataGridViewTextBoxColumn Col_SDT;
        private DataGridViewTextBoxColumn Col_CaID;
        private DataGridViewTextBoxColumn Info_Address;
        private DataGridViewTextBoxColumn Salary;
    }
}